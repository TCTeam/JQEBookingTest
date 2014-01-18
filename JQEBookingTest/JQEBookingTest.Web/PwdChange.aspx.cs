//-----------------------------------------------------------------------
// <copyright company="同程网" file="PwdChange.cs">
//    作者：asp.net全体组员
//    功能：修改密码
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JQEBookingTest.Model.TableModel;
using JQEBookingTest.Injector;
using JQEBookingTest.IBusiness.TableBusiness;

public partial class PwdChange : System.Web.UI.Page
{
    // 标识符，验证页面是否为第一次加载
    static int flag = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        // 判断是否为修改密码选项
        if (flag!=0)
        {
            string pwd = Request["userPwd"];
            string id = Convert.ToString(Session["AId"]);
            List<AdminFieldValuePair> fields = new List<AdminFieldValuePair>();
            fields.Add(new AdminFieldValuePair(AdminFields.APassword,pwd));
            List<AdminWhereFields> where = new List<AdminWhereFields>();
            where.Add(new AdminWhereFields(AdminFields.AId,id));
            bool result = DependencyInjector.GetInstance<IAdminServices>().Update(fields, where);
            if (result)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Write("<script>alert('修改失败')</script>");
            }
        }
        flag++;
    }
}