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
        }
    }

    /// <summary>
    /// 登陆按钮响应
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void loginBtn_Click(object sender, EventArgs e)
    {
        // 用户名及密码获取
        string sName = userName.Text.Trim();
        string passWord = userPwd.Text.Trim();
        string scenicId = string.Empty;

        // 实例化对象，便于基本数据的访问
        AdminServices Lg = new AdminServices();

        // 验证码判断
        if (Session["CheckCode"].ToString() == validCode.Text.Trim())
        {
            scenicId = Lg.CheckLogin(sName, passWord);
            // 密码校验
            if (!string.IsNullOrEmpty(scenicId))
            {
                Session["userName"] = sName;
                Session["ScenicId"] = scenicId;
                Session["userLimit"] = Lg.GetUserMode(sName);
                Session["userId"] = Lg.GetUserID(sName);

                // 自动登录
                if (autoLoging.Checked)
                {
                    HttpCookie userNamece = new HttpCookie("userName");
                    HttpCookie userPwdce = new HttpCookie("userPwd");
                    userNamece.Value = sName;
                    userNamece.Expires = DateTime.Now.AddDays(7);
                    userPwdce.Value = passWord;
                    userPwdce.Expires = DateTime.Now.AddDays(7);

                    Response.AppendCookie(userNamece);
                    Response.AppendCookie(userPwdce);

                }
                else
                {
                    HttpCookie userNamece = new HttpCookie("userName");
                    HttpCookie userPwdce = new HttpCookie("userPwd");
                    userNamece.Value = sName;
                    userPwdce.Value = passWord;

                    Response.AppendCookie(userNamece);
                    Response.AppendCookie(userPwdce);
                }
                // 强制修改密码
                if (passWord.Equals("11111111"))
                {
                    // 执行js响应
                    string url = @"<script language=javascript>
                                        alert('您的密码已被初始化，需要重置！');
                                        window.location.href='PwdChange.aspx';
                                   </script>";
                    Response.Write(url);
                }
                else
                {
                    Response.Redirect("HomePage.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('密码错误！')</script>");
                validCode.Text = string.Empty;
            }
        }
        else
        {
            Response.Write("<script>alert('验证码错误！')</script>");
            validCode.Text = string.Empty;
        }
    }
}
