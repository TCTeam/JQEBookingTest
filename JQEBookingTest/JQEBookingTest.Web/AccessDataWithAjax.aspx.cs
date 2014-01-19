//-----------------------------------------------------------------------
// <copyright company="同程网" file="AccessDataWithAjax.cs">
//    作者：asp.net全体组员
//    功能：前台Ajax请求api
//-----------------------------------------------------------------------
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
    private int scenicId = 3320;

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
        if (Int32.TryParse(Request["index"], out pageIndex) == false)
        {
            pageIndex = 1;
        };
        string otOrderSerialNo = Request["otOrderSerialNo"];
        string realTicketNum = Request["realTicketNum"];
        // 返回数据
        switch (type)
        {
            case "OrderQuery":
                Response.Write(OrderQuery(pageIndex, Request));
                break;
            case "OrderConfirmInit":
                Response.Write(OrderConfirmQuery(pageIndex, Request));
                break;
            case "OrderStatistical":
                Response.Write(OrderOrderStatistical(pageIndex, Request));
                break;
            case "OrderConfirmOk":
                Response.Write(OrderConfirmOk(otOrderSerialNo, realTicketNum));
                break;
            case "CancelReConfirm":
                Response.Write(CancelReConfirm(otOrderSerialNo));
                break;
            case "OrderConfirmQuery":
                Response.Write(OrderConfirmQuery(pageIndex, Request));
                break;
            case "CommentsQuery":
                Response.Write(CommentsQuery(pageIndex,Request));
                break;
            case "CommentsReply":
                Response.Write(CommentsReply(Request));
                break;
            case "GetRemark":
                Response.Write(GetRemark(Request["otOrderSerialNo"]));
                break;
            case "UpdataRemark":
                Response.Write(UpdataRemark(Request["otOrderSerialNo"], Request["text"]));
                break;
            case "ChangePwd":
                Response.Write(ChangePwd(Convert.ToString(Session["userName"]),Request["passwd"]));
                break;
            default:
                break;
        }

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
        return (ret ? "true" : "false");
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
        return (ret ? "true" : "false");
    }

    /// <summary>
    /// 根据条件查询订单
    /// </summary>
    /// <param name="index"></param>
    /// <param name="req"></param>
    /// <returns></returns>
    public string OrderConfirmQuery(int pageIndex, HttpRequest req)
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
        if (!string.IsNullOrEmpty(req["dateStart"]) && !string.IsNullOrEmpty(req["dateEnd"]))
        {
            if (req["chooseDate"] == "buyTime")
            {
                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderCreateTime, req["dateStart"], QueryCondition.GreaterThanAndEqual));
                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderCreateTime, req["dateEnd"], QueryCondition.LessThanAndEqual));
            }
            else
            {
                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTravelTime, req["dateStart"], QueryCondition.GreaterThanAndEqual));
                DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTravelTime, req["dateEnd"], QueryCondition.LessThanAndEqual));
            }

        }
        if (!string.IsNullOrEmpty(req["otOrderSerialNo"]))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderSerialNo, req["otOrderSerialNo"]));
        }
        if (!string.IsNullOrEmpty(req["orderConfirmNum"]))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderComfirmNo, req["orderConfirmNum"]));
        }
        if (!string.IsNullOrEmpty(req["orderName"]))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTicketName, req["orderName"]));
        }
        if (!string.IsNullOrEmpty(req["ticketPhone"]))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTicketPhone, req["ticketPhone"]));
        }
        if (!string.IsNullOrEmpty(req["ticketSort"]))
        {
            if (req["ticketSort"].Equals("drawTicketName"))
            {
                DefaultData.order.Add(new OrderTableOrderFields(OrderTableFields.OTTicketName, OrderType.Asc));
            }
            if (req["ticketSort"].Equals("drawTicketTime"))
            {
                DefaultData.order.Add(new OrderTableOrderFields(OrderTableFields.OTTravelTime, OrderType.Asc));
            }
            if (req["ticketSort"].Equals("buyTime"))
            {
                DefaultData.order.Add(new OrderTableOrderFields(OrderTableFields.OTOrderCreateTime, OrderType.Asc));
            }
        }
        if (!string.IsNullOrEmpty(req["payType"]) && req["payType"].Equals("viewPay"))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTPayWay, 0));
        }
        if (!string.IsNullOrEmpty(req["payType"]) && req["payType"].Equals("onlinePay"))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTPayWay, 1));
        }
        DefaultData.listCount = new OrderTableAccess().GetCount(DefaultData.whereFields) / 10;
        StringBuilder stringbuilder = new StringBuilder();
        // 获取结果集 
        DefaultData.datatable = new ShowSplitData().GetServerTableExtend(DefaultData.showFields, DefaultData.showFields1, DefaultData.whereFields, null, pageCount, pageIndex);

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
            stringbuilder.AppendFormat("{0}</td><td>", ((DateTime)item["OTTravelTime"]).ToShortDateString());
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
            stringbuilder.Append("<tr><td class='linkPage' colspan='13'>");
        }
        for (int i = 1; i <= DefaultData.listCount; i++)
        {
            if (i == pageIndex)
            {
                stringbuilder.Append("<a class='item3ListPage active' style='cursor:pointer;'>" + i + "</a>");
            }
            else
            {
                stringbuilder.Append("<a class='item3ListPage' style='cursor:pointer;'>" + i + "</a>");
            }
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
    public string OrderQuery(int pageIndex, HttpRequest req)
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
        DefaultData.showFields.Add(OrderTableFields.OTRemark);

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
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTTravelTime, req["takeTicketTime"].Trim()));
        }
        if (!string.IsNullOrEmpty(req["orderNo"]) && !string.IsNullOrEmpty(req["orderNo"].Trim()))
        {
            DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderSerialNo, req["orderNo"].Trim()));
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
        // 获取结果集 
        DefaultData.datatable = new ShowSplitData().GetServerTableExtend(DefaultData.showFields, DefaultData.showFields1, DefaultData.whereFields, DefaultData.order, pageCount, pageIndex);

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
            stringbuilder.AppendFormat("{0}</td><td>", ((DateTime)item["OTTravelTime"]).ToShortDateString());
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketNumber"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTHaveTicketNumber"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketPrice"]);
            stringbuilder.AppendFormat("{0}</td><td>", (Convert.ToInt32(item["OTTicketPrice"]) * Convert.ToInt32(item["OTHaveTicketNumber"])).ToString());
            stringbuilder.AppendFormat("{0}</td><td>", item["TTTypeName"]);
            stringbuilder.AppendFormat("{0}</td><td>", (PayWay)Convert.ToInt32(item["OTPayWay"]));
            stringbuilder.AppendFormat("<input class='sbutton' value='查看' type='button' data='{0}'/></td></tr>", item["OTOrderSerialNo"]);
        }
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("<tr><td class='linkPage' colspan='14'>");
        }
        for (int i = 1; i <= DefaultData.listCount; i++)
        {
            if (pageIndex == i)
            {
                stringbuilder.AppendFormat("<a class='item2ListPage active' style='cursor:pointer;'>{0}{1}", i, "</a>");
            }
            else
            {
                stringbuilder.AppendFormat("<a class='item2ListPage' style='cursor:pointer;'>{0}{1}", i, "</a>");
            }
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
    public string OrderOrderStatistical(int pageIndex, HttpRequest req)
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
        DefaultData.showFields.Add(OrderTableFields.OTHaveTicketNumber);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPrice);
        DefaultData.showFields1.Add(TicketTypeFields.TTTypeName);
        
        // 条件
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
        // 获取结果集 
        DefaultData.datatable = new ShowSplitData().GetServerTableExtend(DefaultData.showFields, DefaultData.showFields1, DefaultData.whereFields, null, pageCount, pageIndex);

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
            stringbuilder.AppendFormat("{0}</td><td>", ((DateTime)item["OTTravelTime"]).ToShortDateString());
            stringbuilder.AppendFormat("{0}</td><td>", item["OTTicketNumber"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTHaveTicketNumber"]);
            stringbuilder.AppendFormat("{0}</td>", item["TTTypeName"]);
        }
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("<tr><td class='linkPage' colspan='13'>");
        }
        for (int i = 1; i <= DefaultData.listCount; i++)
        {
            if (i == pageIndex)
            {
                stringbuilder.Append("<a class='item4ListPage active' style='cursor:pointer;'>" + i + "</a>");
            }
            else
            {
                stringbuilder.Append("<a class='item4ListPage' style='cursor:pointer;'>" + i + "</a>");
            }
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
    public string CommentsQuery(int pageIndex, HttpRequest req)
    {
        List<CommentsWhereFields> whereFields = new List<CommentsWhereFields>();
        string queryTime = req["QueryTime"];
        string startTime = string.Empty;
        string endTime = string.Empty;
        if (!string.IsNullOrEmpty(queryTime) || !string.IsNullOrEmpty(req["CustomQuery"]))
        {
            if (!string.IsNullOrEmpty(req["StartDate"]) && !string.IsNullOrEmpty(req["EndDate"]))
            {
                startTime = req["StartDate"];
                endTime = req["EndDate"];
                switch (req["Evaluate"])
                {
                    case "all":
                        break;
                    case "good":
                        whereFields.Add(new CommentsWhereFields(CommentsFields.CCommentsType, 1));
                        break;
                    case "middle":
                        whereFields.Add(new CommentsWhereFields(CommentsFields.CCommentsType, 2));
                        break;
                    case "bad":
                        whereFields.Add(new CommentsWhereFields(CommentsFields.CCommentsType, 3));
                        break;
                    default:
                        break;
                }
            }
            if ("Ultimo".Equals(queryTime))
            {
                startTime = DateTime.Now.AddMonths(-1).AddDays(1 - DateTime.Now.Day).ToShortDateString();
                endTime = DateTime.Now.AddDays(-DateTime.Now.Day).ToShortDateString();
            }
            if ("Month".Equals(queryTime))
            {
                startTime = DateTime.Now.ToString("yyyy-MM-01");
                endTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(1).AddDays(-1).ToShortDateString();
            }
            whereFields.Add(new CommentsWhereFields(CommentsFields.CCommentsTime, startTime, QueryCondition.GreaterThanAndEqual));
            whereFields.Add(new CommentsWhereFields(CommentsFields.CCommentsTime, endTime, QueryCondition.LessThanAndEqual));
        }
        DefaultData.listCount = new CommentsAccess().GetCommentsCount(whereFields, scenicId) / pageCount;
        StringBuilder stringbuilder = new StringBuilder();
        // 获取结果集 
        DefaultData.datatable = DependencyInjector.GetInstance<ICommentsServices>().GetCommentsExtend(whereFields, scenicId, pageCount, pageIndex);

        // 嵌入tbody标签中的table内容
        foreach (DataRow item in DefaultData.datatable.Rows)
        {
            // 添加内容并嵌入表格内容标签
            stringbuilder.Append("<tr><td>");
            stringbuilder.AppendFormat("{0}</td><td>", item["COrderSerialNo"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["OTOrderName"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["CCommentsContent"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["CCommentsTime"]);
            stringbuilder.AppendFormat("{0}</td><td>", item["CCommentsReply"]);
            stringbuilder.AppendFormat("{0}</td><td>", (CommentsState)Convert.ToInt32(item["CCommentsState"]));
            stringbuilder.AppendFormat("<input type='button' class='CommentsReply' value='回复' data='{0}'/></td>", item["COrderSerialNo"]);
        }

        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("<tr><td class='linkPage' colspan='7'>");
        }
        for (int i = 1; i <= DefaultData.listCount; i++)
        {
            if (i == pageIndex)
            {
                stringbuilder.Append("<a class='item6ListPage active' style='cursor:pointer;'>" + i + "</a>");
            }
            else
            {
                stringbuilder.Append("<a class='item6ListPage' style='cursor:pointer;'>" + i + "</a>");
            }
        }
        if (DefaultData.listCount > 0)
        {
            stringbuilder.Append("</td></tr>");
        }
        return stringbuilder.ToString();
    }

    /// <summary>
    /// 点评回复
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    public string CommentsReply(HttpRequest req)
    {
        List<CommentsFieldValuePair> updateFields = new List<CommentsFieldValuePair>();
        updateFields.Add(new CommentsFieldValuePair(CommentsFields.CCommentsReply, req["commentsReply"]));
        updateFields.Add(new CommentsFieldValuePair(CommentsFields.CCommentsState, 1));
        List<CommentsWhereFields> where = new List<CommentsWhereFields>();
        where.Add(new CommentsWhereFields(CommentsFields.COrderSerialNo, req["orderSerialNo"]));
        bool ret = DependencyInjector.GetInstance<ICommentsServices>().Update(updateFields, where);
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
    /// 获得流水号备注
    /// </summary>
    /// <param name="otOrderSerialNo"></param>
    /// <returns></returns>
    public string GetRemark(string otOrderSerialNo)
    {
        List<OrderTableFields> showfields = new List<OrderTableFields>();
        showfields.Add(OrderTableFields.OTRemark);
        List<OrderTableWhereFields> where = new List<OrderTableWhereFields>();
        where.Add(new OrderTableWhereFields(OrderTableFields.OTOrderSerialNo, otOrderSerialNo));
        DataTable dt = DependencyInjector.GetInstance<IOrderTableServices>().GetOrderTableTable(showfields, where, null);
        string result = string.Empty;
        if (dt != null && dt.Rows.Count > 0)
        {
            result = Convert.ToString(dt.Rows[0]["OTRemark"]);
        }
        return result;
    }

    /// <summary>
    /// 更改流水号备注
    /// </summary>
    /// <param name="otOrderSerialNo"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public string UpdataRemark(string otOrderSerialNo, string value)
    {
        // 条件处理
        List<OrderTableFieldValuePair> updateFields = new List<OrderTableFieldValuePair>();
        updateFields.Add(new OrderTableFieldValuePair(OrderTableFields.OTRemark, value));
        List<OrderTableWhereFields> where = new List<OrderTableWhereFields>();
        where.Add(new OrderTableWhereFields(OrderTableFields.OTOrderSerialNo, otOrderSerialNo));
        bool ret = DependencyInjector.GetInstance<IOrderTableServices>().Update(updateFields, where);

        // 结果返回
        return (ret ? "true" : "false");
    }

    /// <summary>
    /// 修改密码
    /// </summary>
    /// <param name="userName"></param>
    /// <param name="pwd"></param>
    /// <returns></returns>
    public string ChangePwd(string userName, string pwd)
    {
        // 调用底层方法
        bool result = new AdminServices().ChangePwd(userName, pwd);
        return (result ? "true" : "false");
    }
}