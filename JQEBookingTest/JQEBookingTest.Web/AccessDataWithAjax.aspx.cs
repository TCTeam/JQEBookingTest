//-----------------------------------------------------------------------
// <copyright company="同程网" file="AccessDataWithAjax.cs">
//    作者：asp.net全体组员
//    功能：异步查询接口
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
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
        DefaultData.showFields.Add(OrderTableFields.OTOrderSerialNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderComfirmNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderState);
        DefaultData.showFields.Add(OrderTableFields.OTTicketName);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPhone);
        DefaultData.showFields.Add(OrderTableFields.OTOrderCreateTime);
        DefaultData.showFields.Add(OrderTableFields.OTTravelTime);
        DefaultData.showFields.Add(OrderTableFields.OTTicketNumber);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPrice);
        //DefaultData.showFields.Add(OrderTableFields.OTTicketType);
        DefaultData.whereFields = new List<OrderTableWhereFields>();
        DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTScenicId, 3320));
        DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderState, 1));
        DefaultData.listCount = new OrderTableAccess().GetCount(DefaultData.whereFields) / 10;
        StringBuilder stringbuilder = new StringBuilder();

        // 索引转换为int，由于是在页面中定好的值，所以没有判读是否可以转换
        pageIndex = Convert.ToInt32(index);

        // 获取结果集 
        DefaultData.list = new ShowSplitData().GetServerTableList(DefaultData.showFields, DefaultData.whereFields, null, pageCount, pageIndex);

        // 嵌入tbody标签中的table内容
        foreach (var item in DefaultData.list)
        {
            // 添加内容并嵌入表格内容标签
            stringbuilder.Append("<tr><td>");
            stringbuilder.AppendFormat("{0}</td><td>", item.OTOrderComfirmNo);
            stringbuilder.AppendFormat("{0}</td><td>", item.OTOrderSerialNo);
            stringbuilder.AppendFormat("{0}</td><td>", item.OTOrderState);
            stringbuilder.AppendFormat("{0}</td><td>", item.OTTicketName);
            stringbuilder.AppendFormat("{0}</td><td>", item.OTTicketPhone);
            stringbuilder.AppendFormat("{0}</td><td>", item.OTOrderCreateTime);
            stringbuilder.AppendFormat("{0}</td><td>", item.OTTravelTime);
            stringbuilder.AppendFormat("{0}</td><td>", item.OTTicketNumber);
            stringbuilder.AppendFormat("{0}</td><td>", item.OTTicketPrice);
            stringbuilder.AppendFormat((Convert.ToInt32(item.OTTicketPrice) * Convert.ToInt32(item.OTTicketNumber)).ToString() + "</td><td>");
            //stringbuilder.AppendFormat("{0}</td><td>", item.OTTicketType);
            stringbuilder.AppendFormat("<input type='button' class='ChooseTicketNum' value='确认' data={0}/></td><td>", item.OTOrderSerialNo);
            stringbuilder.AppendFormat("<input type='button' class='CancelReConfirm' value='未购票' data={0}", item.OTOrderSerialNo + "'/>" + "</td></tr>");
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
    /// 根据条件查询订单
    /// </summary>
    /// <param name="index"></param>
    /// <param name="req"></param>
    /// <returns></returns>
    public string OrderConfirmQuery(string index, HttpRequest req)
    {
        DefaultData.showFields = new List<OrderTableFields>();
        DefaultData.showFields.Add(OrderTableFields.OTOrderSerialNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderComfirmNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderState);
        DefaultData.showFields.Add(OrderTableFields.OTTicketName);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPhone);
        DefaultData.showFields.Add(OrderTableFields.OTOrderCreateTime);
        DefaultData.showFields.Add(OrderTableFields.OTTravelTime);
        DefaultData.showFields.Add(OrderTableFields.OTTicketNumber);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPrice);
        //DefaultData.showFields.Add(OrderTableFields.OTTicketType);
        DefaultData.whereFields = new List<OrderTableWhereFields>();
        DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTScenicId, 3320));
        DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderState, 1));

        if (req["dateStart"].Trim() != "" && req["dateEnd"].Trim() != "")
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
        if (req["otOrderSerialNo"].Trim() != "")
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderSerialNo, req["otOrderSerialNo"].Trim()));
        }
        if (req["orderConfirmNum"].Trim() != "")
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderComfirmNo, req["orderConfirmNum"].Trim()));
        }
        if (req["orderName"].Trim() != "")
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderName, req["orderName"].Trim()));
        }
        if (req["ticketPhone"].Trim() != "")
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTicketPhone, req["ticketPhone"].Trim()));
        }
        if (req["ticketSort"].Trim() != "")
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

        // 获取结果集 
        DefaultData.list = new ShowSplitData().GetServerTableList(DefaultData.showFields, DefaultData.whereFields, null, pageCount, pageIndex);

        // 嵌入tbody标签中的table内容
        foreach (var item in DefaultData.list)
        {
            // 添加内容并嵌入表格内容标签
            stringbuilder.Append("<tr><td>");
            stringbuilder.Append(item.OTOrderComfirmNo + "</td><td>");
            stringbuilder.Append(item.OTOrderSerialNo + "</td><td>");
            stringbuilder.Append(item.OTOrderState + "</td><td>");
            stringbuilder.Append(item.OTTicketName + "</td><td>");
            stringbuilder.Append(item.OTTicketPhone + "</td><td>");
            stringbuilder.Append(item.OTOrderCreateTime + "</td><td>");
            stringbuilder.Append(item.OTTravelTime + "</td><td>");
            stringbuilder.Append(item.OTTicketNumber + "</td><td>");
            stringbuilder.Append(item.OTTicketPrice + "</td><td>");
            stringbuilder.Append((Convert.ToInt32(item.OTTicketPrice) * Convert.ToInt32(item.OTTicketNumber)).ToString() + "</td><td>");
            //stringbuilder.Append(item.OTTicketType + "</td><td>");
            stringbuilder.Append("<input type='button' class='ChooseTicketNum' value='确认' data='" + item.OTOrderSerialNo + "'/>" + "</td><td>");
            stringbuilder.Append("<input type='button' class='CancelReConfirm' value='未购票' data='" + item.OTOrderSerialNo + "'/>" + "</td></tr>");
        }
        //
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("<tr><td class='linkpage' colspan='13'>");
        }
        for (int i = 1; i <= DefaultData.listCount; i++)
        {
            stringbuilder.Append("<a class='ListPage'>" + i + "</a>");
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
        DefaultData.showFields.Add(OrderTableFields.OTOrderSerialNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderComfirmNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderState);
        DefaultData.showFields.Add(OrderTableFields.OTTicketName);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPhone);
        DefaultData.showFields.Add(OrderTableFields.OTOrderCreateTime);
        DefaultData.showFields.Add(OrderTableFields.OTTravelTime);
        DefaultData.showFields.Add(OrderTableFields.OTTicketNumber);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPrice);
        //DefaultData.showFields.Add(OrderTableFields.OTTicketType);
        DefaultData.showFields.Add(OrderTableFields.OTPayWay);
        DefaultData.showFields.Add(OrderTableFields.OTRemark);

        // 初始化条件
        DefaultData.whereFields = new List<OrderTableWhereFields>();


        // 初始化排序条件
        DefaultData.order = new List<OrderTableOrderFields>();
        // 默认排序
        //DefaultData.order.Add(new OrderTableOrderFields(OrderTableFields.OTTicketType));

        // url取值，空值不附加条件
        if (req["orderComfirmNo"] != null && req["orderComfirmNo"].Trim() != "")
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderComfirmNo, req["orderComfirmNo"].Trim()));
        }
        if (!string.IsNullOrEmpty(req["takeTicketTime"]))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderCreateTime, req["takeTicketTime"].Trim()));
        }
        if (req["orderNo"] != null && req["orderNo"].Trim() != "")
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTId, req["orderNo"].Trim()));
        }
        if (req["identityId"] != null && req["identityId"].Trim() != "")
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTIdentityCard, req["identityId"].Trim()));
        }
        if (req["takeTicketName"] != null && req["takeTicketName"].Trim() != "")
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTicketName, req["takeTicketName"].Trim()));
        }
        if (req["takeTicketPhone"] != null && req["takeTicketPhone"].Trim() != "")
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

        if (req["payType"] != null && req["payType"].Trim() != "")
        {
            //todo
        }
        DefaultData.listCount = new OrderTableAccess().GetCount(DefaultData.whereFields) / pageCount;
        StringBuilder stringbuilder = new StringBuilder();
        // 索引转换为int，由于是在页面中定好的值，所以没有判读是否可以转换
        pageIndex = Convert.ToInt32(index);

        // 获取结果集 
        DefaultData.list = new ShowSplitData().GetServerTableList(DefaultData.showFields, DefaultData.whereFields, null, pageCount, pageIndex);

        // 嵌入tbody标签中的table内容
        foreach (var item in DefaultData.list)
        {
            // 添加内容并嵌入表格内容标签
            stringbuilder.Append("<tr><td>");
            stringbuilder.Append(item.OTOrderComfirmNo + "</td><td>");
            stringbuilder.Append(item.OTOrderSerialNo + "</td><td>");
            stringbuilder.Append(item.OTOrderState + "</td><td>");
            stringbuilder.Append(item.OTTicketName + "</td><td>");
            stringbuilder.Append(item.OTTicketPhone + "</td><td>");
            stringbuilder.Append(item.OTOrderCreateTime + "</td><td>");
            stringbuilder.Append(item.OTTravelTime + "</td><td>");
            stringbuilder.Append(item.OTTicketNumber + "</td><td>");
            stringbuilder.Append(item.OTTicketPrice + "</td><td>");
            stringbuilder.Append((Convert.ToInt32(item.OTTicketPrice) * Convert.ToInt32(item.OTTicketNumber)).ToString() + "</td><td>");
            stringbuilder.Append(item.OTPayWay + "</td><td>");
            //stringbuilder.Append(item.OTTicketType + "</td><td>");
            stringbuilder.Append(item.OTRemark + "</td></tr>");
        }

        //
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("<tr><td class='linkpage' colspan='13'>");
        }
        for (int i = 1; i <= DefaultData.listCount; i++)
        {
            stringbuilder.Append("<a class='item2ListPage' style='cursor:pointer;'>" + i + "</a>");
        }
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("</td></tr>");
        }
        return stringbuilder.ToString();
    }

    public string OrderOrderStatistical(string index, HttpRequest req)
    {

        DefaultData.showFields = new List<OrderTableFields>();
        DefaultData.showFields.Add(OrderTableFields.OTOrderSerialNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderComfirmNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderState);
        DefaultData.showFields.Add(OrderTableFields.OTTicketName);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPhone);
        DefaultData.showFields.Add(OrderTableFields.OTOrderCreateTime);
        DefaultData.showFields.Add(OrderTableFields.OTTravelTime);
        DefaultData.showFields.Add(OrderTableFields.OTTicketNumber);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPrice);
        //DefaultData.showFields.Add(OrderTableFields.OTTicketType);

        DefaultData.whereFields = new List<OrderTableWhereFields>();

        if (!string.IsNullOrEmpty(req["payType"]))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTPayWay, req["payType"]));
        }
        if (!string.IsNullOrEmpty(req["conStion"]))
        {
            if (req["dateStart1"] != null && req["dateStart1"].Trim() != "" && req["dateEnd1"] != null && req["dateEnd1"].Trim() != "")
            {

                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderCreateTime, req["dateStart1"].Trim(), QueryCondition.GreaterThanAndEqual));
                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderCreateTime, req["dateEnd1"].Trim(), QueryCondition.LessThanAndEqual));

            }
            else if (req["dateStart2"] != null && req["dateStart2"].Trim() != "" && req["dateEnd2"] != null && req["dateEnd2"].Trim() != "")
            {

                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTravelTime, req["dateStart2"].Trim(), QueryCondition.GreaterThanAndEqual));
                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTravelTime, req["dateEnd2"].Trim(), QueryCondition.LessThanAndEqual));

            }
        }

        StringBuilder sb = new StringBuilder();

        DefaultData.listCount = new OrderTableAccess().GetCount(DefaultData.whereFields) / pageCount;
        StringBuilder stringbuilder = new StringBuilder();

        // 索引转换为int，由于是在页面中定好的值，所以没有判读是否可以转换
        pageIndex = Convert.ToInt32(index);

        // 获取结果集 
        DefaultData.list = new ShowSplitData().GetServerTableList(DefaultData.showFields, DefaultData.whereFields, null, pageCount, pageIndex);

        // 嵌入tbody标签中的table内容
        foreach (var item in DefaultData.list)
        {
            // 添加内容并嵌入表格内容标签
            stringbuilder.Append("<tr><td>");
            stringbuilder.Append(item.OTOrderComfirmNo + "</td><td>");
            stringbuilder.Append(item.OTOrderSerialNo + "</td><td>");
            stringbuilder.Append(item.OTOrderState + "</td><td>");
            stringbuilder.Append(item.OTTicketName + "</td><td>");
            stringbuilder.Append(item.OTTicketPhone + "</td><td>");
            stringbuilder.Append(item.OTOrderCreateTime + "</td><td>");
            stringbuilder.Append(item.OTTravelTime + "</td><td>");
            stringbuilder.Append(item.OTTicketNumber + "</td><td>");
            //stringbuilder.Append(item.OTTicketType + "</td></tr>");
        }

        //
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("<tr><td class='linkpage' colspan='13'>");
        }
        for (int i = 1; i <= DefaultData.listCount; i++)
        {
            stringbuilder.Append("<a class='item4ListPage' style='cursor:pointer;' >" + i + "</a>");
        }
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("</td></tr>");
        }
        return stringbuilder.ToString();
    }

}