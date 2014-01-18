//-----------------------------------------------------------------------
// <copyright company="同程网" file="chcekMode.cs">
//    作者：asp.net全体组员
//    功能：登陆后台
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MakeCheckCode MK = new MakeCheckCode();
            Session["CheckCode"] = MK.DrawImage();
        }
    }
}