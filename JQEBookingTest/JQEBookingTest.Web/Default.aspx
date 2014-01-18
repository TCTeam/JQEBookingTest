<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/Login.css" rel="stylesheet" type="text/css" />
    <title>同程网eBooking</title>
</head>

<body>
    <div id="logo">
       	<a href="http://www.17u.cn/" target="_blank">
        	<img src="images/logo.gif" alt="同程网" title="同程网"/>
        </a>
    </div>
	<div id="content">
    	<h1>用户登录</h1>
        <div id="login_box">
        	<div id="errInfo"></div>
          <form ID="login_form" method="post" runat="server">
          	<div class="uname">
                <asp:Label ID="lbName" runat="server" Text="用户名:"></asp:Label><br />
                <asp:TextBox ID="userName" runat="server" CssClass="ninput" Font-Size="18px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="userNameCheck" runat="server" 
                    ControlToValidate="userName" CssClass="ninput" ErrorMessage="用户名不能为空" Font-Size="13px" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
			<div id="nameInfo"></div>
            <div class="password">
				<asp:Label ID="lbPwd" runat="server" Text="密  码:"></asp:Label> <br />
                <asp:TextBox ID="userPwd" CssClass="pinput" runat="server" TextMode="Password" 
                    Font-Size="18px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="userPwdCheck" runat="server" 
                    ControlToValidate="userPwd" ErrorMessage="请输入密码" Font-Size="13px" 
                    ForeColor="Red" CssClass="pinput"></asp:RequiredFieldValidator>
            </div>
            
			<div id="pwdInfo"></div>
            <div class="iptVcodeClass" id="vcodeDiv">
                    <asp:Label ID="vcodeLab"  CssClass="iptTitle" runat="server" Text="验证码:"></asp:Label><br />
                    <asp:TextBox ID="validCode" runat="server" Height="25px" Width="100px" 
                        Font-Size="18px"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/checkMode.aspx" 
                        width="70px" height="30px"  />
            </div>
            
            <div id="auto_login">
                <asp:CheckBox ID="autoLoging" runat="server"  Text=""/>记住密码
            <a class="lostfound" href="Reset.aspx">忘记密码？</a></div>
            <asp:Button ID="loginBtn" runat="server" Text="登录" CssClass="form_btn" 
                onclick="loginBtn_Click" />
            <input type="reset" value="重置" class="form_btn" />
          </form>
        </div>
    </div>
    <div id="footer">
    	Copyright&nbsp;&copy;&nbsp;<span class="cr_time">2002-2013</span>&nbsp;版权所有&nbsp;<span
            class="corp_name">同程网络科技股份有限公司</span>&nbsp;<a target="_blank" href="http://img1.40017.cn/cn/new_ui/public/images/ICP.jpg"
                class="icp_num">苏ICP证B2-20100204</a>
    </div>
</body>
</html>
