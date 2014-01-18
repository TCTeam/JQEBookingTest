<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="Styles/common.css" rel="stylesheet" type="text/css" />
    <link href="Styles/Login.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/login.js" type="text/javascript"></script>
    <title>同程网eBooking</title>
    <%--login页v2 修改的文件包括default.aspx login.css 增加了Scripts/login.js和Styles/common.css 删除了无用的css文件夹--%>
</head>
<body>
    <div id="header" class="logo">
       	<a href="http://www.17u.cn/" target="_blank">
        	<img src="images/logo.gif" alt="同程网" title="同程网"/>
        </a>
        <div class="clf"></div>
    </div>
   <%-- header End--%>
	<div id="content">
        <div id="left_content">
        	<h3><a href="#" title="同程网景区服务"><img src="Images/jq14.jpg" alt="同程网景区服务" /></a></h3>
        </div>
         <%-- 登陆框 Start--%>
        <div id="right_content">
    	    <p>用户登录</p>
            <div id="login_box">
        	    <div id="errInfo"></div>
                <form ID="login_form" method="post" runat="server">
          	    <div class="uname">
                    <asp:Label ID="lbName" runat="server" CssClass="inpName Nplace">用户名：</asp:Label><br />
                    <asp:TextBox ID="userName" runat="server" CssClass="ninput" Font-Size="18px" onBlur="javascript:NameOnBlurFun()" ></asp:TextBox>
                    <%--如果不影响后台，请把被注释的代码删除，以及本句--%>
                    <%--<asp:RequiredFieldValidator ID="userNameCheck" runat="server" 
                    ControlToValidate="userName" CssClass="ninput" ErrorMessage="用户名不能为空" Font-Size="13px" 
                    ForeColor="Red"></asp:RequiredFieldValidator>--%>
                </div>
            <div class="password">
				<asp:Label ID="lbPwd" runat="server" CssClass="inpName Nplace">密码：</asp:Label> <br />
                <asp:TextBox ID="userPwd" CssClass="ninput" runat="server" TextMode="Password" onBlur="javascript:PwdOnBlurFun()"
                    Font-Size="18px"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="userPwdCheck" runat="server" 
                    ControlToValidate="userPwd" ErrorMessage="请输入密码" Font-Size="13px" 
                    ForeColor="Red" CssClass="ninput"></asp:RequiredFieldValidator>--%>
            </div>
            <div class="iptVcodeClass" id="vcodeDiv">
                    <asp:Label ID="vcodeLab" runat="server" CssClass="inpName Nplace" >验证码：</asp:Label><br />
                    <asp:TextBox ID="validCode" runat="server" CssClass="ninput" Height="25px" Width="100px"  onBlur="javascript:VcodeOnBlurFun()"
                        Font-Size="18px"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/checkMode.aspx" 
                        width="70px" height="30px"  />
            </div>
            <div id="auto_login">
                <asp:CheckBox ID="autoLoging" runat="server"  CssClass="Nplace" /><label for="autoLoging" class="labAuto">记住密码</label>
            <a class="lostfound" href="Reset.aspx">忘记密码？</a></div>
            <asp:Button ID="loginBtn" runat="server" Text="登录" CssClass="form_btn Nplace" OnClientClick="return CheckFun();"
                onclick="loginBtn_Click"  />
            <input type="reset" value="重置" class="form_btn" />
          </form>
        </div>
    </div>
    </div>
    <%-- 登陆框 End--%>
    <div class="clear"></div>
    <div id="footer">
    	Copyright&nbsp;&copy;&nbsp;<span class="cr_time">2002-2014</span>&nbsp;版权所有&nbsp;<span
            class="corp_name">同程网络科技股份有限公司</span>&nbsp;<a target="_blank" href="http://img1.40017.cn/cn/new_ui/public/images/ICP.jpg"
                class="icp_num">苏ICP证B2-20100204</a>
    </div>
</body>
</html>
