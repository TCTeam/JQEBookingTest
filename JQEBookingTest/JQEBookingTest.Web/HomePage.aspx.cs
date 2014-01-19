using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Text;
using JQEBookingTest.Model;
using JQEBookingTest.Model.TableModel;
using JQEBookingTest.Web;
using JQEBookingTest.DataAccess.Tables;
using JQEBookingTest.Injector;
using JQEBookingTest.IBusiness.TableBusiness;
using JQEBookingTest.Model.Enum;
using JQEBookingTest.Business.TableBusiness;

public partial class HomePage : BasePage
{
    // 用户信息
    private string scenicId = string.Empty;
    private string userName = string.Empty;
    private string userLimit = string.Empty;
    private string userId = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        // 手动验证码失效
        Session["CheckCode"] = string.Empty;

        HttpCookie cookie = Request.Cookies["userName"];
        
        if (Request.Cookies["userName"] != null)
        {
            userName = Request.Cookies["userName"].Value;
            userId = new AdminServices().GetUserID(userName);
            scenicId = new AdminServices().CheckLogin(userName,Request.Cookies["userPwd"].Value );
            userLimit = (new AdminServices().GetUserMode(userName));

            // 保存用户信息
            Session.Add("userName", Request.Cookies["userName"].Value);
            Session.Add("ScenicId", scenicId);
            Session.Add("userLimit", userLimit);
            Session.Add("AId", userId);

            // 页面添加选项
            LinkButton user = new LinkButton();
            user.Text = (string)Session["userName"];
            user.Attributes.Add("href", "PwdChange.aspx");
            Place.Controls.Add(user);
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
        // 用户权限判断
        if (userLimit == "1")
        {
            DataOut.Visible = false;
        }
    }

    /// <summary>
    /// 导出excel按钮点击事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ButtonOrderBackExcel_Click(object sender, EventArgs e)
    {
        #region
        List<OrderTableFields> orderTableFields = new List<OrderTableFields>();
        List<TicketTypeFields> ticketTypeFields = new List<TicketTypeFields>();
        ticketTypeFields.Add(TicketTypeFields.TTTypeName);
        orderTableFields.Add(OrderTableFields.OTOrderSerialNo);
        orderTableFields.Add(OrderTableFields.OTOrderComfirmNo);
        orderTableFields.Add(OrderTableFields.OTTicketName);
        orderTableFields.Add(OrderTableFields.OTTicketPhone);
        orderTableFields.Add(OrderTableFields.OTTicketNumber);
        orderTableFields.Add(OrderTableFields.OTTicketPrice);
        orderTableFields.Add(OrderTableFields.OTOrderCreateTime);
        orderTableFields.Add(OrderTableFields.OTTravelTime);
        orderTableFields.Add(OrderTableFields.OTOrderState);
        orderTableFields.Add(OrderTableFields.OTIdentityCard);
        List<OrderTableWhereFields> where = new List<OrderTableWhereFields>();
        where.Add(new OrderTableWhereFields(OrderTableFields.OTScenicId, scenicId));
        // 支付方式
        switch (Item5payType.Value)
        {
            case "viewPay":
                where.Add(new OrderTableWhereFields(OrderTableFields.OTPayWay, 0));
                break;
            case "onlinePay":
                where.Add(new OrderTableWhereFields(OrderTableFields.OTPayWay, 1));
                break;
            case "noPlace":
                break;
            default: break;
        }
        if (Item5TextCreateTimeStart.Value.Trim() != "" && Item5TextCreateTimeEnd.Value.Trim() != "")
        {
            where.Add(new OrderTableWhereFields(OrderTableFields.OTOrderCreateTime, Item5TextCreateTimeStart.Value.Trim(), QueryCondition.GreaterThanAndEqual));
            where.Add(new OrderTableWhereFields(OrderTableFields.OTOrderCreateTime, Item5TextCreateTimeEnd.Value.Trim(), QueryCondition.LessThan));
        }
        if (Item5TextTravelTimeStart.Value.Trim() != "" && Item5TextTravelTimeEnd.Value.Trim() != "")
        {
            where.Add(new OrderTableWhereFields(OrderTableFields.OTTravelTime, Item5TextTravelTimeStart.Value.Trim(), QueryCondition.GreaterThanAndEqual));
            where.Add(new OrderTableWhereFields(OrderTableFields.OTTravelTime, Item5TextTravelTimeEnd.Value.Trim(), QueryCondition.LessThan));
        }
        switch (Item5ticketState.Value)
        {
            case "all":
                break;
            case "alreadyCheck":
                where.Add(new OrderTableWhereFields(OrderTableFields.OTOrderState, 2));
                break;
            case "NoShow":
                where.Add(new OrderTableWhereFields(OrderTableFields.OTOrderState, 0));
                break;
            case "viewSure":
                where.Add(new OrderTableWhereFields(OrderTableFields.OTOrderState, 3));
                break;
        }
        DataBaseType dbType = DataBaseType.Read;

        // 结果
        DataTable table = DependencyInjector.GetInstance<IOrderTableServices>().GetOrderTableExtend(dbType, orderTableFields, ticketTypeFields, where, null, 100, 1);
        if (table != null && table.Rows.Count >= 1)
        {
            table.Columns["OTOrderSerialNo"].ColumnName = "订单号";
            table.Columns["OTOrderComfirmNo"].ColumnName = "订单确认号";
            table.Columns["OTTicketName"].ColumnName = "取票人";
            table.Columns["OTTicketPhone"].ColumnName = "取票人手机";
            table.Columns["OTTicketNumber"].ColumnName = "票数";
            table.Columns["OTOrderCreateTime"].ColumnName = "下单时间";
            table.Columns["OTTravelTime"].ColumnName = "旅游时间";
            table.Columns["TTTypeName"].ColumnName = "门票类型";
            table.Columns["OTIdentityCard"].ColumnName = "身份证号";
            table.Columns.Add("总价", Type.GetType("System.Double"));
            table.Columns.Add("订单状态", Type.GetType("System.String"));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                double price = Convert.ToDouble(table.Rows[i]["OTTicketPrice"]);
                double number = Convert.ToDouble(table.Rows[i]["票数"]);
                double countprice = price * number;
                table.Rows[i]["总价"] = countprice;
                table.Rows[i]["身份证号"] = "’" + table.Rows[i]["身份证号"];
                switch (Convert.ToInt32(table.Rows[i]["OTOrderState"]))
                {
                    case 0:
                        table.Rows[i]["订单状态"] = "NoShow";
                        break;
                    case 1:
                        table.Rows[i]["订单状态"] = "新订单";
                        break;
                    case 2:
                        table.Rows[i]["订单状态"] = "已核单";
                        break;
                    case 3:
                        table.Rows[i]["门票类型"] = "景区确认";
                        break;
                }
            }
            table.Columns.Remove("OTTicketPrice");
            table.Columns.Remove("OTOrderState");
            table.Columns["总价"].SetOrdinal(5);
            table.Columns["订单状态"].SetOrdinal(9);
            OrderExcelBack(table, DateTime.Now.ToString("yyyyMMddmmss"));
        }
        #endregion
    }
    /// <summary>
    /// Excel表格导出
    /// </summary>
    /// <param name="dataTable">要导出的数据源</param>
    /// <param name="fileName">导出文件的文件名</param>
    public void OrderExcelBack(DataTable dataTable, string fileName)
    {
        GridView gvExport = new GridView();
        //当前对话
        HttpContext curContext = HttpContext.Current;
        //IO用于导出并返回excel文件
        StringWriter strWriter = new StringWriter();
        HtmlTextWriter htmlWriter = new HtmlTextWriter(strWriter);
        if (dataTable != null)
        {
            curContext.Response.AddHeader("content-disposition", "attachment;filename=" + System.Web.HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8) + ".xls");
            curContext.Response.ContentType = "application/vnd.ms-excel";// "application/x-xls";
            curContext.Response.ContentEncoding = System.Text.Encoding.UTF8;
            curContext.Response.Charset = "GB2312";
            //为了解决dataTable中可能进行了分页的情况,需要重新定义一个无分页的GridView
            gvExport.DataSource = dataTable.DefaultView;
            gvExport.AllowPaging = false;
            gvExport.DataBind();
            //下载到客户端
            gvExport.RenderControl(htmlWriter);
            curContext.Response.Write(strWriter.ToString());
            curContext.Response.End();
        }
    }

    public void LogoutClick(object sender, EventArgs e)
    {
        // Cookie手动过期
        if (Request.Cookies["userName"] != null)
        {
            // session清除
            Session["userName"] = null;
            Session["userId"] = null;
            Session["ScenicId"] = null;
            Session["userLimit"] = null;
            
            // cookie清除
            HttpCookie aCookie;
            string cookieName;
            int limit = Request.Cookies.Count;
            for (int i = 0; i < limit; i++)
            {
                cookieName = Request.Cookies[i].Name;
                aCookie = new HttpCookie(cookieName);
                aCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(aCookie);
            }

        }
       
        Response.Redirect("Default.aspx");
    }
}