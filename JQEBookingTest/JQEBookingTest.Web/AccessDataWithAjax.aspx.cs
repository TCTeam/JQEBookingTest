using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using JQEBookingTest.Web;
using JQEBookingTest.Model;
using JQEBookingTest.Model.TableModel;
using JQEBookingTest.DataAccess.Tables;
using JQEBookingTest.Business.TableBusiness;
using JQEBookingTest.IBusiness.TableBusiness;
using JQEBookingTest.Injector;
using JQEBookingTest.Model.Enum;

public partial class AccessDataWithDataBase : System.Web.UI.Page
{
    // 每页显示表格大小
    private const int pageCount = 10;

    // 当前页面
    private int pageIndex = 1;

    // 页面的操作属性
    private string pageType = string.Empty;

    /// <summary>
    /// 配合AJAX来异步查询数据库中的内容
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        string type = Request["type"];
        string index = Request["index"];
        string otOrderSerialNo = Request["otOrderSerialNo"];
        string realTicketNum = Request["realTicketNum"];
        string SearialNo = Request["SearialNo"];
        // 返回数据
        switch (type)
        {
            case "OrderQuery":
                Response.Write(OrderQuery(index, Request));
                break;
            case "OrderConfirmInit":
                Response.Write(OrderConfirmInit(index));
                break;
            case "OrderStatistical":
                Response.Write(OrderOrderStatistical(index, Request));
                break;
            case "OrderConfirmOk":
                Response.Write(OrderConfirmOk(otOrderSerialNo, realTicketNum));
                break;
            case "CancelReConfirm":
                Response.Write(CancelReConfirm(otOrderSerialNo));
                break;
            case "OrderConfirmQuery":
                Response.Write(OrderConfirmQuery(index, Request));
                break;
            case "CommentsQuery":
                Response.Write(CommentsQuery(index));
                break;
            case　"GetRemark":
                Response.Write(GetRemarkFromDataBase(Request["SearialNo"]));
                break;
            case "AddRemark":
                Response.Write(AddRemark(Request["SearialNo"],Request["text"]));
                break;
        }

    }


    /// <summary>
    /// 订单确认初始化页面--“订单确认选项”
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public string OrderConfirmInit(string index)
    {
        DefaultData.showFields = new List<OrderTableFields>();
        DefaultData.showFields1 = new List<TicketTypeFields>();
        DefaultData.showFields.Add(OrderTableFields.OTOrderSerialNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderComfirmNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderState);
        DefaultData.showFields.Add(OrderTableFields.OTTicketName);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPhone);
        DefaultData.showFields.Add(OrderTableFields.OTOrderCreateTime);
        DefaultData.showFields.Add(OrderTableFields.OTTravelTime);
        DefaultData.showFields.Add(OrderTableFields.OTTicketNumber);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPrice);
        DefaultData.showFields1.Add(TicketTypeFields.TTTypeName);
        DefaultData.whereFields = new List<OrderTableWhereFields>();
        DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTScenicId, 3320));
        DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderState, 1));
        DefaultData.listCount = new OrderTableAccess().GetCount(DefaultData.whereFields) / 10;
        StringBuilder stringbuilder = new StringBuilder();

        // 索引转换为int，由于是在页面中定好的值，所以没有判读是否可以转换
        pageIndex = Convert.ToInt32(index);
        string mainTableName = "OrderTable";
        string joinTableName = "TicketType";
        string joinCondition = "OrderTable.OTTicketTypeId=TicketType.TTTypeId";
        // 获取结果集 
        DefaultData.datatable = new ShowSplitData().GetServerTableExtend(DefaultData.showFields, DefaultData.showFields1, DefaultData.whereFields, null, pageCount, pageIndex, mainTableName, joinTableName, joinCondition);

        // 嵌入tbody标签中的table内容
        foreach (DataRow item in DefaultData.datatable.Rows)
        {
            // 添加内容并嵌入表格内容标签
            stringbuilder.Append("<tr><td>");
            stringbuilder.AppendFormat("{0}</td><td>", item["OTOrderComfirmNo"]);//将Append修改为AppendFormat
            stringbuilder.AppendFormat("{0}</td><td>", item["OTOrderSerialNo"]);
            stringbuilder.AppendFormat("{0}</td><td>", (OrderStatus)Convert.ToInt32(item["OTOrderState"]));
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketName"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketPhone"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTOrderCreateTime"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTravelTime"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketNumber"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketPrice"]);
            stringbuilder.AppendFormat("{0}</td><td>", (Convert.ToInt32(item["OTTicketPrice"]) * Convert.ToInt32(item["OTTicketNumber"])).ToString());
            stringbuilder.AppendFormat("{0}</td><td>", item["TTTypeName"]);
            stringbuilder.AppendFormat("<input type='button' class='ChooseTicketNum' value='确认' data='{0}{1}{2}", item["OTOrderSerialNo"], "'/>", "</td><td>");
            stringbuilder.AppendFormat("<input type='button' class='CancelReConfirm' value='未购票' data='{0}{1}{2}", item["OTOrderSerialNo"], "'/>", "</td></tr>");
        }
        //
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("<tr><td class='linkpage' colspan='13'>");
        }
        for (int i = 1; i <= DefaultData.listCount; i++)
        {
            stringbuilder.Append("<a class='item3ListPage' style='cursor:pointer;'>" + i + "</a>");
        }
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("</td></tr>");
        }
        return stringbuilder.ToString();
    }

    /// <summary>
    /// 订单确认执行订单确认操作
    /// </summary>
    /// <param name="otOrderSerialNo"></param>
    /// <param name="realTicketNum"></param>
    /// <returns></returns>
    public string OrderConfirmOk(string otOrderSerialNo, string realTicketNum)
    {
        List<OrderTableFieldValuePair> updateFields = new List<OrderTableFieldValuePair>();
        updateFields.Add(new OrderTableFieldValuePair(OrderTableFields.OTOrderState, 3));
        updateFields.Add(new OrderTableFieldValuePair(OrderTableFields.OTHaveTicketNumber, realTicketNum));
        List<OrderTableWhereFields> where = new List<OrderTableWhereFields>();
        where.Add(new OrderTableWhereFields(OrderTableFields.OTOrderSerialNo, otOrderSerialNo));
        where.Add(new OrderTableWhereFields(OrderTableFields.OTOrderState, 1));
        bool ret = DependencyInjector.GetInstance<IOrderTableServices>().Update(updateFields, where);
        if (ret)
        {
            return "true";
        }
        else
        {
            return "false";
        }
    }

    /// <summary>
    /// 订单确认为未购票操作
    /// </summary>
    /// <param name="otOrderSerialNo"></param>
    /// <returns></returns>
    public string CancelReConfirm(string otOrderSerialNo)
    {
        List<OrderTableFieldValuePair> updateFields = new List<OrderTableFieldValuePair>();
        updateFields.Add(new OrderTableFieldValuePair(OrderTableFields.OTOrderState, 0));
        List<OrderTableWhereFields> where = new List<OrderTableWhereFields>();
        where.Add(new OrderTableWhereFields(OrderTableFields.OTOrderSerialNo, otOrderSerialNo));
        where.Add(new OrderTableWhereFields(OrderTableFields.OTOrderState, 1));
        bool ret = DependencyInjector.GetInstance<IOrderTableServices>().Update(updateFields, where);
        if (ret)
        {
            return "true";
        }
        else
        {
            return "false";
        }
    }

    /// <summary>
    /// 更具输入条件返回备注
    /// </summary>
    /// <param name="otOrderSerialNo"></param>
    /// <returns></returns>
    public string GetRemarkFromDataBase(string otOrderSerialNo) 
    {
        List<OrderTableWhereFields> where = new List<OrderTableWhereFields>();
        where.Add(new OrderTableWhereFields(OrderTableFields.OTOrderSerialNo, otOrderSerialNo));
        List<OrderTableFields> fields = new List<OrderTableFields>();
        fields.Add(OrderTableFields.OTRemark);
        DataTable dt = DependencyInjector.GetInstance<IOrderTableServices>().GetOrderTableTable(fields, where, null);
        if (dt!=null&&dt.Rows.Count > 0)
        {
            return Convert.ToString(dt.Rows[0]["OTRemark"]);
        }
        return string.Empty;
    }

    /// <summary>
    /// 更改备注
    /// </summary>
    /// <param name="otOrderSerialNo"></param>
    /// <returns></returns>
    public string AddRemark(string otOrderSerialNo,string text)
    {
        List<OrderTableFieldValuePair> updateFields = new List<OrderTableFieldValuePair>();
        updateFields.Add(new OrderTableFieldValuePair(OrderTableFields.OTRemark, text));
        List<OrderTableWhereFields> where = new List<OrderTableWhereFields>();
        where.Add(new OrderTableWhereFields(OrderTableFields.OTOrderSerialNo, otOrderSerialNo));
        where.Add(new OrderTableWhereFields(OrderTableFields.OTOrderState, 1));
        bool ret = DependencyInjector.GetInstance<IOrderTableServices>().Update(updateFields, where);
        if (ret)
        {
            return "true";
        }
        else
        {
            return "false";
        }
    }
    /// <summary>
    /// 根据条件查询订单
    /// </summary>
    /// <param name="index"></param>
    /// <param name="req"></param>
    /// <returns></returns>
    public string OrderConfirmQuery(string index, HttpRequest req)
    {
        DefaultData.showFields = new List<OrderTableFields>();
        DefaultData.showFields1 = new List<TicketTypeFields>();
        DefaultData.showFields.Add(OrderTableFields.OTOrderSerialNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderComfirmNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderState);
        DefaultData.showFields.Add(OrderTableFields.OTTicketName);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPhone);
        DefaultData.showFields.Add(OrderTableFields.OTOrderCreateTime);
        DefaultData.showFields.Add(OrderTableFields.OTTravelTime);
        DefaultData.showFields.Add(OrderTableFields.OTTicketNumber);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPrice);
        DefaultData.showFields1.Add(TicketTypeFields.TTTypeName);
        DefaultData.whereFields = new List<OrderTableWhereFields>();
        DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTScenicId, 3320));
        DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderState, 1));
        // 初始化排序条件
        DefaultData.order = new List<OrderTableOrderFields>();
        if (!string.IsNullOrEmpty(req["dateStart"].Trim()) && !string.IsNullOrEmpty(req["dateEnd"].Trim()))
        {
            if (req["chooseDate"].Trim() == "buyTime")
            {
                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderCreateTime, req["dateStart"].Trim(), QueryCondition.GreaterThanAndEqual));
                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderCreateTime, req["dateEnd"].Trim(), QueryCondition.LessThanAndEqual));
            }
            else
            {
                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTravelTime, req["dateStart"].Trim(), QueryCondition.GreaterThanAndEqual));
                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTravelTime, req["dateEnd"].Trim(), QueryCondition.LessThanAndEqual));
            }

        }
        if (!string.IsNullOrEmpty(req["otOrderSerialNo"].Trim()))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderSerialNo, req["otOrderSerialNo"].Trim()));
        }
        if (!string.IsNullOrEmpty(req["orderConfirmNum"].Trim()))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderComfirmNo, req["orderConfirmNum"].Trim()));
        }
        if (!string.IsNullOrEmpty(req["orderName"].Trim()))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderName, req["orderName"].Trim()));
        }
        if (!string.IsNullOrEmpty(req["ticketPhone"].Trim()))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTicketPhone, req["ticketPhone"].Trim()));
        }
        if (!string.IsNullOrEmpty(req["ticketSort"].Trim()))
        {
            //DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTicketPhone, req["ticketPhone"].Trim()));
        }
        if (req["payType"].Trim().Equals("viewPay"))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTPayWay, 0));
        }
        if (req["payType"].Trim().Equals("onlinePay"))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTPayWay, 1));
        }
        DefaultData.listCount = new OrderTableAccess().GetCount(DefaultData.whereFields) / 10;
        StringBuilder stringbuilder = new StringBuilder();
        // 索引转换为int，由于是在页面中定好的值，所以没有判读是否可以转换
        pageIndex = Convert.ToInt32(index);
        string mainTableName = "OrderTable";
        string joinTableName = "TicketType";
        string joinCondition = "OrderTable.OTTicketTypeId=TicketType.TTTypeId";
        // 获取结果集 
        DefaultData.datatable = new ShowSplitData().GetServerTableExtend(DefaultData.showFields, DefaultData.showFields1, DefaultData.whereFields, null, pageCount, pageIndex, mainTableName, joinTableName, joinCondition);

        // 嵌入tbody标签中的table内容
        foreach (DataRow item in DefaultData.datatable.Rows)
        {
            // 添加内容并嵌入表格内容标签
            stringbuilder.Append("<tr><td>");
            stringbuilder.AppendFormat("{0}</td><td>", item["OTOrderComfirmNo"]);//将Append修改为AppendFormat
            stringbuilder.AppendFormat("{0}</td><td>", item["OTOrderSerialNo"]);
            stringbuilder.AppendFormat("{0}</td><td>", (OrderStatus)Convert.ToInt32(item["OTOrderState"]));
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketName"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketPhone"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTOrderCreateTime"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTravelTime"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketNumber"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketPrice"]);
            stringbuilder.AppendFormat("{0}</td><td>", (Convert.ToInt32(item["OTTicketPrice"]) * Convert.ToInt32(item["OTTicketNumber"])).ToString());
            stringbuilder.AppendFormat("{0}</td><td>", item["TTTypeName"]);
            stringbuilder.AppendFormat("<input type='button' class='ChooseTicketNum' value='确认' data='{0}{1}{2}", item["OTOrderSerialNo"], "'/>", "</td><td>");
            stringbuilder.AppendFormat("<input type='button' class='CancelReConfirm' value='未购票' data='{0}{1}{2}", item["OTOrderSerialNo"], "'/>", "</td></tr>");
        }
        //
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("<tr><td class='linkpage' colspan='13'>");
        }
        for (int i = 1; i <= DefaultData.listCount; i++)
        {
            stringbuilder.AppendFormat("<a class='ListPage'>{0}{1}", i, "</a>");
        }
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("</td></tr>");
        }
        return stringbuilder.ToString();
    }

    /// <summary>
    /// 根据条件查询
    /// </summary>
    /// <param name="index"></param>
    /// <param name="req"></param>
    /// <returns></returns>
    public string OrderQuery(string index, HttpRequest req)
    {
        DefaultData.showFields = new List<OrderTableFields>();
        DefaultData.showFields1 = new List<TicketTypeFields>();
        DefaultData.showFields.Add(OrderTableFields.OTOrderSerialNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderComfirmNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderState);
        DefaultData.showFields.Add(OrderTableFields.OTTicketName);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPhone);
        DefaultData.showFields.Add(OrderTableFields.OTOrderCreateTime);
        DefaultData.showFields.Add(OrderTableFields.OTTravelTime);
        DefaultData.showFields.Add(OrderTableFields.OTTicketNumber);
        DefaultData.showFields.Add(OrderTableFields.OTHaveTicketNumber);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPrice);
        DefaultData.showFields1.Add(TicketTypeFields.TTTypeName);
        DefaultData.showFields.Add(OrderTableFields.OTPayWay);

        // 初始化条件
        DefaultData.whereFields = new List<OrderTableWhereFields>();
        DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTScenicId, 3320));

        // 初始化排序条件
        DefaultData.order = new List<OrderTableOrderFields>();

        // url取值
        if (!string.IsNullOrEmpty(req["orderComfirmNo"]) && !string.IsNullOrEmpty(req["orderComfirmNo"].Trim()))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderComfirmNo, req["orderComfirmNo"].Trim()));
        }
        if (!string.IsNullOrEmpty(req["takeTicketTime"]))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderCreateTime, req["takeTicketTime"].Trim()));
        }
        if (!string.IsNullOrEmpty(req["orderNo"]) && !string.IsNullOrEmpty(req["orderNo"].Trim()))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTId, req["orderNo"].Trim()));
        }
        if (!string.IsNullOrEmpty(req["identityId"]) && !string.IsNullOrEmpty(req["identityId"].Trim()))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTIdentityCard, req["identityId"].Trim()));
        }
        if (!string.IsNullOrEmpty(req["takeTicketName"]) && !string.IsNullOrEmpty(req["takeTicketName"].Trim()))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTicketName, req["takeTicketName"].Trim()));
        }
        if (!string.IsNullOrEmpty(req["takeTicketPhone"]) && !string.IsNullOrEmpty(req["takeTicketPhone"].Trim()))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTicketPhone, req["takeTicketPhone"].Trim()));
        }
        // 排序条件
        if (!string.IsNullOrEmpty(req["ticketSort"]) && !string.IsNullOrEmpty(req["sortType"]))
        {
            if (req["ticketSort"].Equals("drawTicketName"))
            {
                if (req["sortType"].Equals("up"))
                {
                    DefaultData.order.Add(new OrderTableOrderFields(OrderTableFields.OTTicketName, OrderType.Asc));
                }
                else if (req["sortType"].Equals("down"))
                {
                    DefaultData.order.Add(new OrderTableOrderFields(OrderTableFields.OTTicketName, OrderType.Desc));
                }
            }
            if (req["ticketSort"].Equals("drawTicketTime"))
            {
                if (req["sortType"].Equals("up"))
                {
                    DefaultData.order.Add(new OrderTableOrderFields(OrderTableFields.OTTravelTime, OrderType.Asc));
                }
                else if (req["sortType"].Equals("down"))
                {
                    DefaultData.order.Add(new OrderTableOrderFields(OrderTableFields.OTTravelTime, OrderType.Desc));
                }
            }
            if (req["ticketSort"].Equals("buyTime"))
            {
                if (req["sortType"].Equals("up"))
                {
                    DefaultData.order.Add(new OrderTableOrderFields(OrderTableFields.OTOrderCreateTime, OrderType.Asc));
                }
                else if (req["sortType"].Equals("down"))
                {
                    DefaultData.order.Add(new OrderTableOrderFields(OrderTableFields.OTOrderCreateTime, OrderType.Desc));
                }
            }
        }
        if (!string.IsNullOrEmpty(req["payType"]) && !string.IsNullOrEmpty(req["payType"].Trim()))
        {
            if (req["payType"].Trim().Equals("viewPay"))
            {
                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTPayWay, 0));
            }
            if (req["payType"].Trim().Equals("onlinePay"))
            {
                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTPayWay, 1));
            }
        }
        DefaultData.listCount = new OrderTableAccess().GetCount(DefaultData.whereFields) / pageCount;
        StringBuilder stringbuilder = new StringBuilder();
        // 索引转换为int，由于是在页面中定好的值，所以没有判读是否可以转换
        pageIndex = Convert.ToInt32(index);
        string mainTableName = "OrderTable";
        string joinTableName = "TicketType";
        string joinCondition = "OrderTable.OTTicketTypeId=TicketType.TTTypeId";
        // 获取结果集 
        DefaultData.datatable = new ShowSplitData().GetServerTableExtend(DefaultData.showFields, DefaultData.showFields1, DefaultData.whereFields, DefaultData.order, pageCount, pageIndex, mainTableName, joinTableName, joinCondition);

        // 嵌入tbody标签中的table内容
        foreach (DataRow item in DefaultData.datatable.Rows)
        {
            // 添加内容并嵌入表格内容标签
            stringbuilder.Append("<tr><td>");
            stringbuilder.AppendFormat("{0}</td><td>", item["OTOrderComfirmNo"]);//将Append修改为AppendFormat
            stringbuilder.AppendFormat("{0}</td><td>", item["OTOrderSerialNo"]);
            stringbuilder.AppendFormat("{0}</td><td>", (OrderStatus)Convert.ToInt32(item["OTOrderState"]));
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketName"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketPhone"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTOrderCreateTime"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTravelTime"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketNumber"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTHaveTicketNumber"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketPrice"]);
            stringbuilder.AppendFormat("{0}</td><td>", (Convert.ToInt32(item["OTTicketPrice"]) * Convert.ToInt32(item["OTTicketNumber"])).ToString());
            stringbuilder.AppendFormat("{0}</td><td>", (PayWay)Convert.ToInt32(item["OTPayWay"]));
            stringbuilder.AppendFormat("{0}</td><td>", item["TTTypeName"]);
            stringbuilder.AppendFormat("<input type='button' value='查看' class='RemarkView' data={0}/></td></tr>", item["OTOrderSerialNo"]);
        }

        //
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("<tr><td class='linkpage' colspan='14'>");
        }
        for (int i = 1; i <= DefaultData.listCount; i++)
        {
            stringbuilder.AppendFormat("<a class='item2ListPage' style='cursor:pointer;'>{0}{1}", i, "</a>");
        }
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("</td></tr>");
        }
        return stringbuilder.ToString();
    }
    /// <summary>
    /// 订单统计查询
    /// </summary>
    /// <param name="index">页面索引</param>
    /// <param name="req">请求参数</param>
    /// <returns></returns>
    public string OrderOrderStatistical(string index, HttpRequest req)
    {
        string startTime = string.Empty;
        string endTime = string.Empty;
        string payType = string.Empty;


        DefaultData.showFields = new List<OrderTableFields>();
        DefaultData.showFields1 = new List<TicketTypeFields>();
        DefaultData.showFields.Add(OrderTableFields.OTOrderSerialNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderComfirmNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderState);
        DefaultData.showFields.Add(OrderTableFields.OTTicketName);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPhone);
        DefaultData.showFields.Add(OrderTableFields.OTOrderCreateTime);
        DefaultData.showFields.Add(OrderTableFields.OTTravelTime);
        DefaultData.showFields.Add(OrderTableFields.OTTicketNumber);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPrice);
        DefaultData.showFields1.Add(TicketTypeFields.TTTypeName);

        DefaultData.whereFields = new List<OrderTableWhereFields>();
        DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTScenicId, 3320));
        if (req["payType"] != null)
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTPayWay, req["payType"]));
        }
        if (!string.IsNullOrEmpty(req["conStion"]))
        {
            if (!string.IsNullOrEmpty(req["dateStart1"]) && !string.IsNullOrEmpty(req["dateEnd1"]))
            {
                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderCreateTime, req["dateStart1"].Trim(), QueryCondition.GreaterThanAndEqual));
                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderCreateTime, req["dateEnd1"].Trim(), QueryCondition.LessThanAndEqual));
            }
            if (!string.IsNullOrEmpty(req["dateStart2"].Trim()) && !string.IsNullOrEmpty(req["dateEnd2"].Trim()))
            {

                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTravelTime, req["dateStart2"].Trim(), QueryCondition.GreaterThanAndEqual));
                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTravelTime, req["dateEnd2"].Trim(), QueryCondition.LessThanAndEqual));

            }
        }
        DefaultData.listCount = new OrderTableAccess().GetCount(DefaultData.whereFields) / pageCount;
        StringBuilder stringbuilder = new StringBuilder();

        // 索引转换为int，由于是在页面中定好的值，所以没有判读是否可以转换
        pageIndex = Convert.ToInt32(index);

        string mainTableName = "OrderTable";
        string joinTableName = "TicketType";
        string joinCondition = "OrderTable.OTTicketTypeId=TicketType.TTTypeId";
        // 获取结果集 
        DefaultData.datatable = new ShowSplitData().GetServerTableExtend(DefaultData.showFields, DefaultData.showFields1, DefaultData.whereFields, null, pageCount, pageIndex, mainTableName, joinTableName, joinCondition);

        // 嵌入tbody标签中的table内容
        foreach (DataRow item in DefaultData.datatable.Rows)
        {
            // 添加内容并嵌入表格内容标签
            stringbuilder.Append("<tr><td>");
            stringbuilder.AppendFormat("{0}</td><td>", item["OTOrderComfirmNo"]);//将Append修改为AppendFormat
            stringbuilder.AppendFormat("{0}</td><td>", item["OTOrderSerialNo"]);
            stringbuilder.AppendFormat("{0}</td><td>", (OrderStatus)Convert.ToInt32(item["OTOrderState"]));
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketName"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketPhone"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTOrderCreateTime"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTravelTime"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketNumber"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["TTTypeName"]);
        }

        //
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("<tr><td class='linkpage' colspan='13'>");
        }
        for (int i = 1; i <= DefaultData.listCount; i++)
        {
            stringbuilder.AppendFormat("<a class='item4ListPage' style='cursor:pointer;' >{0}{1}", i, "</a>");
        }
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("</td></tr>");
        }
        return stringbuilder.ToString();
    }

    /// <summary>
    /// 点评管理页面
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public string CommentsQuery(string index)
    {
        StringBuilder stringbuilder = new StringBuilder();

        // 索引转换为int，由于是在页面中定好的值，所以没有判读是否可以转换
        pageIndex = Convert.ToInt32(index);
        // 获取结果集 
        DefaultData.datatable = DependencyInjector.GetInstance<ICommentsServices>().GetCommentsExtend();

        // 嵌入tbody标签中的table内容
        foreach (DataRow item in DefaultData.datatable.Rows)
        {
            // 添加内容并嵌入表格内容标签
            stringbuilder.Append("<tr><td>");
            stringbuilder.Append("<input type='checkbox'/></td><td>");
            stringbuilder.AppendFormat("{0}</td><td>", item["COrderSerialNo"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTOrderName"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["CCommentsContent"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["CCommentsTime"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["CCommentsReply"]);
            stringbuilder.AppendFormat("{0}</td><td>", (CommentsState)Convert.ToInt32(item["CCommentsState"]));

            //stringbuilder.AppendFormat("<input type='button' class='ChooseTicketNum' value='查看' data='{0}{1}{2}", item["COrderSerialNo"], "'/>", "</td><td>");
            //stringbuilder.AppendFormat("<input type='button' class='CancelReConfirm' value='回复' data='{0}{1}{2}", item["COrderSerialNo"], "'/>", "</td></tr>");
        }
        //
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("<tr><td class='linkpage' colspan='7'>");
        }
        for (int i = 1; i <= DefaultData.listCount; i++)
        {
            stringbuilder.Append("<a class='item3ListPage' style='cursor:pointer;'>" + i + "</a>");
        }
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("</td></tr>");
        }
        return stringbuilder.ToString();
    }
}







