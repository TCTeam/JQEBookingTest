using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


/// <summary>
///BasePage 的摘要说明
/// </summary>
public class BasePage : System.Web.UI.Page
{
	public BasePage()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    /// <summary>
    /// 检查用户是否有登陆状态
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void CheckLogState(object sender ,EventArgs e)
    {
        if (Request.Cookies["userName"] != null)
        { 
            
        }
    }

    //public void 
}