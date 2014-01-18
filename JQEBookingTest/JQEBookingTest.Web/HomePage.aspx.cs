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
    // id号
    private string scenicId = string.Empty;
    private string userName = string.Empty;
    private string userLimit = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        // 判断Cookie记录，确定用户已经登陆
        if (Request.Cookies["userName"] != null)
        {
            userName = Request.Cookies["userName"].Value;
            scenicId = new AdminServices().GetUserID(userName);
            userLimit = (new AdminServices().GetUserMode(userName));

            if (Session["userName"] == null)
            {
                // 保存用户信息
                Session.Add("userName", userName);
                Session.Add("ScenicId", scenicId);
                Session.Add("UserLimit",userLimit);
                // 页面添加选项
                LinkButton user = new LinkButton();
                user.Text = (string)Session["userName"];
                user.Attributes.Add("href", "Change.aspx");
                Place.Controls.Add(user);
            }
            else
            {
                // 页面添加选项
                LinkButton user = new LinkButton();
                user.Text = (string)Session["userName"];
                user.Attributes.Add("href", "Change.aspx");
                Place.Controls.Add(user);
            }
        }
        else
        {
            // 检查Cookie确定用户已经拥有合适身份浏览过网页
            if (Session["userName"] != null)
            {
                userName = (string)Session["userName"];
                scenicId = (string)Session["ScenicId"];
                userLimit = (string)Session["UserLimit"];

                // 页面添加选项
                LinkButton user = new LinkButton();
                user.Text = (string)Session["userName"];
                user.Attributes.Add("href", "Change.aspx");
                Place.Controls.Add(user);

                
            }
            else
            {
                // 返回登录页面
                Response.Redirect("Default.aspx");
            }
        }
        SetLimit(userLimit);
    }

    private void SetLimit(string limit)
    {
        if (limit == "1")
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
        List<OrderTableFields> fields = new List<OrderTableFields>();
        fields.Add(OrderTableFields.OTOrderSerialNo);
        fields.Add(OrderTableFields.OTOrderComfirmNo);
        fields.Add(OrderTableFields.OTTicketName);
        fields.Add(OrderTableFields.OTTicketPhone);
        fields.Add(OrderTableFields.OTTicketNumber);
        fields.Add(OrderTableFields.OTTicketPrice);
        //fields.Add(OrderTableFields.OTTicketType);
        fields.Add(OrderTableFields.OTOrderCreateTime);
        fields.Add(OrderTableFields.OTTravelTime);
        fields.Add(OrderTableFields.OTOrderState);
        fields.Add(OrderTableFields.OTIdentityCard);
        List<OrderTableWhereFields> where = new List<OrderTableWhereFields>();
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
        else
        {
            where.Add(new OrderTableWhereFields(OrderTableFields.OTOrderCreateTime, DateTime.Today, QueryCondition.GreaterThanAndEqual));
            where.Add(new OrderTableWhereFields(OrderTableFields.OTOrderCreateTime, DateTime.Today.AddDays(1), QueryCondition.LessThan));
        }
        if (Item5TextTravelTimeStart.Value.Trim() != "" && Item5TextTravelTimeEnd.Value.Trim() != "")
        {
            where.Add(new OrderTableWhereFields(OrderTableFields.OTTravelTime, Item5TextCreateTimeStart.Value.Trim(), QueryCondition.GreaterThanAndEqual));
            where.Add(new OrderTableWhereFields(OrderTableFields.OTTravelTime, Item5TextCreateTimeEnd.Value.Trim(), QueryCondition.LessThan));
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

        DataTable table = DependencyInjector.GetInstance<IOrderTableServices>().GetOrderTableTable(fields, where, null);
        if (table != null && table.Rows.Count >= 1)
        {
            table.Columns["OTOrderSerialNo"].ColumnName = "订单号";
            table.Columns["OTOrderComfirmNo"].ColumnName = "订单确认号";
            table.Columns["OTTicketName"].ColumnName = "取票人";
            table.Columns["OTTicketPhone"].ColumnName = "取票人手机";
            table.Columns["OTTicketNumber"].ColumnName = "票数";
            table.Columns["OTOrderCreateTime"].ColumnName = "下单时间";
            table.Columns["OTTravelTime"].ColumnName = "旅游时间";
            table.Columns["OTTicketType"].ColumnName = "门票类型";
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
}