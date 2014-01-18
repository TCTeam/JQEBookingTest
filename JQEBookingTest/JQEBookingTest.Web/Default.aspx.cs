//-----------------------------------------------------------------------
// <copyright company="同程网" file="BasePage.cs">
//    作者：asp.net全体组员
//    功能：登陆页面
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
using JQEBookingTest.Model.TableModel;
using JQEBookingTest.Model.Enum;

public partial class Default2 : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Ran check = new Ran();
        if (Request.Cookies["userName"] != null)
        {
            userName.Text = Request.Cookies["userName"].Value;
            userPwd.Attributes.Add("value", check.RandomNum(8));
        }
    }

    protected void loginBtn_Click(object sender, EventArgs e)
    {
        // 用户名及密码获取
        string name = userName.Text.Trim();
        string password = userPwd.Text.Trim();
        AdminServices Lg = new AdminServices();

        // 检查Cookie之中是否拥有有效的登陆记录
        if (Request.Cookies["userName"] == null)
        {
            if (Lg.CheckLogin(name, password) != null)
            {
                if (Session["CheckCode"].ToString() == validCode.Text.Trim())
                {
                    if (autoLoging.Checked)
                    {
                        Session.Add("userName", name);
                        Session.Add("AId", Lg.GetUserID(name));
                        Session.Add("UserLimit", Lg.GetUserMode(name));

                        Response.Cookies["userName"].Value = name;
                        Response.Cookies["userPwd"].Value = password;
                        Response.Cookies["userName"].Expires = DateTime.Now.AddDays(7);
                        Response.Cookies["userPwd"].Expires = DateTime.Now.AddDays(7);

                        Response.Redirect("~/HomePage.aspx");
                    }
                    else
                    {
                        Session.Add("userName", name);
                        Session.Add("AId", Lg.GetUserID(name));
                        Session.Add("UserLimit", Lg.GetUserMode(name));

                        Response.Redirect("~/HomePage.aspx");

                    }
                }
                else
                {
                    Response.Write("<script>alert('验证码有误请重新输入！')</script>");
                    //this.Page.RegisterStartupScript("", "<script>alert('验证码有误请重新输入！')</script>");//此方法在form执行完后执行

                    validCode.Text = string.Empty;
                }
            }
            else
            {
                Response.Write("<script>alert('用户或密码错误！')</script>");
                //this.Page.RegisterStartupScript("","<script>alert('用户或密码错误！')</script>");//此方法在form执行完后执行

                validCode.Text = string.Empty;
            }
        }
        else
        {
            if (Session["CheckCode"].ToString() == validCode.Text.Trim())
            {
                //////////////更改：修正密码记住之后就会出现密码错误提示
                if (Lg.CheckLogin(Request.Cookies["userName"].Value.ToString(),Lg.GetUserPassWD(Lg.GetUserID(Request.Cookies["userName"].Value))) != null)
                {
                    Session.Add("userName", name);
                    Session.Add("AId", Lg.GetUserID(name));
                    Session.Add("UserLimit", Lg.GetUserMode(name));

                    Response.Redirect("~/HomePage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('用户或密码错误！')</script>");
                    validCode.Text = string.Empty;
                }
            }
            else
            {
                Response.Write("<script>alert('验证码错误！')</script>");
            }
        }
    }
}
