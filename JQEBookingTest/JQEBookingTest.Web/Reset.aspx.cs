using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JQEBookingTest.Model.TableModel;
using JQEBookingTest.IBusiness.TableBusiness;
using JQEBookingTest.Injector;
using JQEBookingTest.Business.TableBusiness;

public partial class Reset : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        resetBtn.Enabled = false;
    }
    protected void nextBtn_Click(object sender, EventArgs e)
    {
        AdminServices Lg = new AdminServices();
        if (Lg.CheckReset(userName.Text, phoNum.Text))
        {
            Response.Write("<script>alert('验证成功')</script>");
            resetBtn.Enabled = true;
        }
        else
        {
            Response.Write("<script>alert('验证失败')</script>");
            userName.Text = string.Empty;
            phoNum.Text = string.Empty;
        }
    }
    protected void resetBtn_Click(object sender, EventArgs e)
    {
        AdminServices Lg = new AdminServices();
        if (Lg.ResetPwd(userName.Text)==true)
        {
            Response.Redirect("~/Default.aspx");
        }
        else
        {
            Response.Write("<script>alert('重置失败')</script>");
        }
    }
}