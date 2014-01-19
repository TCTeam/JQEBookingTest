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
        
    }
}