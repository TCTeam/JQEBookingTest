<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reset.aspx.cs" Inherits="Reset" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/FindPassword.css" rel="stylesheet" type="text/css" />
    <title>重置密码</title>
</head>
<body>
  <div id="head">
    <div id="logo">
      <a href="http://www.17u.cn" target="_blank"><img src="Images/logo.gif" alt="同程网" title="同程网" /></a>
    </div>
    <div id="findPwd">
      	<span>重置密码</span>
    </div>  
  </div>
      <div id="clear-float"></div>
    <div id="position">
    <div id="main">
    	<div id="main-head">
        	<span id="img"></span><span class="imgNote">请输入用户名和手机号</span>
        </div>
        <div id="main-body">
        <form id="Form1" name="form1" action="" runat="server" >
        	<div id="errName" class="err">
        		用户名：<asp:TextBox ID="userName" runat="server"></asp:TextBox>
                <span  class="errName" id="errorUserName"></span>
            </div>
            <div class="err">
            	手机号：<asp:TextBox ID="phoNum" runat="server"></asp:TextBox>
               <span class="errNum" id="errUserNum"></span>
            </div>
            <div id="next">
            <asp:Button ID="nextBtn" runat="server" Text="验证" CssClass="btnYellow" 
                    onclick="nextBtn_Click"/>
            <asp:Button ID="resetBtn" runat="server" Text="重置" CssClass="btnYellow" 
                    style="margin-left:30px;" onclick="resetBtn_Click"/>           
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
