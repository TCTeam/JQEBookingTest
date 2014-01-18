//-----------------------------------------------------------------------
// <copyright company="同程网" file="Change.cs">
//    作者：asp.net全体组员
//    功能：修改密码
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JQEBookingTest.Business.TableBusiness;
using JQEBookingTest.IBusiness.TableBusiness;
using JQEBookingTest.Injector;
using JQEBookingTest.Model.Enum;
using JQEBookingTest.Model.TableModel;

public partial class Change : System.Web.UI.Page
{
    // 用户身份
    string username = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        username = Request["username"];
        userPwd.TextMode = TextBoxMode.Password;
        userPwdCheck.TextMode = TextBoxMode.Password;
    }
    protected void nextBtn_Click(object sender, EventArgs e)
    {

        AdminServices chge = new AdminServices();
        bool change = chge.ChangePwd(username,userPwd.Text);
        if (change == true)
        {
            Response.Write("<script>alert('修改成功')location.href='~/Default.aspx'</script>");
        }
        else
        {
            Response.Write("<script>alert('修改失败')</script>");
            userPwd.Text = string.Empty;
            userPwdCheck.Text = string.Empty;
        }
    }
}