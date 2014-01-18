<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Change.aspx.cs" Inherits="Change" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/FindPassword.css" rel="stylesheet" type="text/css" />
    <title>修改密码</title>
</head>
<body>
    <div id="head">
    <div id="logo">
      <a href="http://www.17u.cn" target="_blank"><img src="Images/logo.gif" alt="同程网" title="同程网" /></a>
    </div>
    <div id="findPwd">
      	<span>修改密码</span>
    </div>  
  </div>
      <div id="clear-float"></div>
    <div id="position">
    <div id="main">
    	<div id="main-head">
        	<span id="img"></span><span class="imgNote">请输入密码</span>
        </div>
        <div id="main-body">
        <form id="Form1" name="form1" action="" runat="server" >
        	<div id="errName" class="err">
        		<span style="display:inline-block;width:80px;">密&nbsp;&nbsp;&nbsp;&nbsp;码：</span><asp:TextBox ID="userPwd" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="NoneCheck" runat="server" ErrorMessage="请输入密码" 
                    ControlToValidate="userPwd"></asp:RequiredFieldValidator>
            </div>
            <div class="err">
            	密码确认：<asp:TextBox ID="userPwdCheck" runat="server"></asp:TextBox>
               <span class="errNum" id="errUserNum"></span>
                <asp:RequiredFieldValidator ID="None" runat="server" ErrorMessage="请再次输入密码" ControlToValidate="userPwdCheck"></asp:RequiredFieldValidator> 
                <asp:CompareValidator ID="Compare" runat="server" ErrorMessage="输入密码不一致" ControlToCompare="userPwd" ControlToValidate="userPwdCheck"></asp:CompareValidator>
            </div>
            <div id="next">
            <asp:Button ID="nextBtn" runat="server" Text="确认" CssClass="btnYellow" 
                    onclick="nextBtn_Click" />          
            </div>
            </form>
        </div>
    </div>
    </div>
    <div id="bottom">
    	<span>Copyright © 2002-2014  版权所有  同程网络科技股份有限公司   苏ICP证B2-20100204  [乙测资字32005078]   旅行社业务许可证：L-JS-CJ00070</span>	
    </div>
</body>
</html>
