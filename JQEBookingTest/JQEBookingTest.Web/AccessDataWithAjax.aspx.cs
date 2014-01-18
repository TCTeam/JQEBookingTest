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

public partial class AccessDataWithDataBase : System.Web.UI.Page
{
    // 每页显示表格大小
    private const int pageCount = 4;

    // 当前页面
    private int pageIndex = 1;

    /// <summary>
    /// 配合AJAX来异步查询数据库中的内容
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        StringBuilder stringbuilder = new StringBuilder();

        // 添加显示标签
        stringbuilder.Append("<tbody id='showview'>");
        

        // 获取url索引
        string index = Request["index"];

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
            stringbuilder.Append(item.OTOrderSerialNo+"</td><td>");
            stringbuilder.Append(item.OTOrderState + "</td><td>");
            stringbuilder.Append(item.OTTicketName + "</td><td>");
            stringbuilder.Append(item.OTTicketPhone + "</td><td>");
            stringbuilder.Append(item.OTOrderCreateTime + "</td><td>");
            stringbuilder.Append(item.OTTravelTime + "</td><td>");
            stringbuilder.Append(item.OTTicketNumber + "</td><td>");
            stringbuilder.Append(item.OTTicketPrice + "</td><td>");
            stringbuilder.Append((Convert.ToInt32(item.OTTicketPrice) * Convert.ToInt32(item.OTTicketNumber)).ToString()+"</td><td>");
            stringbuilder.Append(item.OTTicketType + "</td><td>");
            stringbuilder.Append(item.OTRemark + "</td></tr>");
        }

        // 添加尾标签
        stringbuilder.Append("</tbody>");
        
            
        // 返回数据
        Response.Write(stringbuilder.ToString());


    }

    
}