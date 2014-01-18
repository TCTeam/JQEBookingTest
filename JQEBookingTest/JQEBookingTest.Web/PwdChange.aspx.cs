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
    protected void Page_Load(object sender, EventArgs e)
    {
        // 判断是否为修改密码选项
        if (!string.IsNullOrEmpty(Request["type"])&&Request["type"].Equals("ChangePwd"))
        {
            string id = Convert.ToString(Session["AId"]);
            List<AdminFieldValuePair> fields = new List<AdminFieldValuePair>();
            fields.Add(new AdminFieldValuePair(AdminFields.APassword,Request["password"]));
            List<AdminWhereFields> where = new List<AdminWhereFields>();
            where.Add(new AdminWhereFields(AdminFields.AId,id));
            DependencyInjector.GetInstance<IAdminServices>().Update(fields, where);
        }
    }
}