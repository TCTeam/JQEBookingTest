using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using JQEBookingTest.Model;
using JQEBookingTest.Model.TableModel;
using JQEBookingTest.Web;
using JQEBookingTest.DataAccess.Tables;

public partial class Home : System.Web.UI.Page
{
    /// <summary>
    /// 以下字段主要是“订单查询”选项所需关键字
    /// </summary>
    
    // 日期类型选择
    private string qTime = string.Empty;
    
    // 起始结束日期
    private string textStartData = string.Empty;
    private string textEndData = string.Empty;

    /// <summary>
    /// 初始化数据
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        // 选取选项选定
        DefaultData.showFields = new List<OrderTableFields>();
        DefaultData.showFields.Add(OrderTableFields.OTOrderComfirmNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderSerialNo);
        DefaultData.showFields.Add(OrderTableFields.OTOrderState);
        DefaultData.showFields.Add(OrderTableFields.OTTicketName);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPhone);
        DefaultData.showFields.Add(OrderTableFields.OTOrderCreateTime);
        DefaultData.showFields.Add(OrderTableFields.OTTravelTime);
        DefaultData.showFields.Add(OrderTableFields.OTTicketNumber);
        DefaultData.showFields.Add(OrderTableFields.OTTicketPrice);
        DefaultData.showFields.Add(OrderTableFields.OTTicketType);
        DefaultData.showFields.Add(OrderTableFields.OTRemark);

        // 查询条件
        DefaultData.whereFields = new List<OrderTableWhereFields>();
        DefaultData.whereFields.Add(new OrderTableWhereFields(OrderTableFields.OTOrderName, "tctest"));

        // 生成符合条件的个体条数
        int temp = new OrderTableAccess().GetCount(DefaultData.whereFields);
        if (temp % 4 != 0)// 10为每页的个数
        {
            DefaultData.listCount = temp / 4 + 1;
        }
        else 
        {            
            DefaultData.listCount = temp / 4;
        }
        //DefaultData.listCount = 

        // 动态生成连接
        for (int i = 1; i <= DefaultData.listCount; i++)
        {
            LinkButton link = new LinkButton();
            link.Text = i.ToString();
            link.Attributes.Add("id", "textview");
            link.Attributes.Add("class", "_textview");
            link.Attributes.Add("href", "javascript:void(0)");
            placeHolder.Controls.Add(link);
        }

    }

    /// <summary>
    /// “查询”事件相应
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void buttonDoQuery_Click(object sender, EventArgs e)
    {
        //textStartData = Request.Form["textStartData"];
        //Response.Write(textStartData);
        
    }

    protected void buttonExcelOut_Click(object sender, EventArgs e)
    {

    }
}