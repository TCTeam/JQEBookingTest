<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PwdChange.aspx.cs" Inherits="PwdChange" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>密码修改</title>
    <script type="text/javascript">
    // 密码输入规范简单判断
	function CheckPwd()
	{
		var pwdVal = document.getElementById("userPwd").value;	
		var pwdChe = document.getElementById("checkPwd").value;
		var reg = /^[{A-Z},{a-z},0-9]{8}$/;
		
        // 是否一致
		if(pwdVal === pwdChe) {
            // 是否符合正则
			if(!(reg.test(pwdVal)&&reg.test(pwdChe)))
			{
				document.getElementById("pwdInfo").innerHTML="密码必须是字母和汉字组合！";
				return false;
			}
			else
			{
				document.getElementById("pwdInfo").innerHTML="";
				
				return true;
			}	
		}
		else
		{
			document.getElementById("pwdInfo").innerHTML="两次输入的密码不一致！";
			return false;
		}
	}

</script>
<style type="text/css">
body{
	font-family:"微软雅黑";
}
#logo{
	margin-left:200px;
	margin-top:54px;
	width:990px;
}
#logo a img{
	border:0px;
}
#changePwd{
	border-left:1px solid #9f9f9f;
	float: right;
	margin-right:550px;
}
#changePwd h1{
	color:#6d6b6b;
	margin-left:20px;
}
#main{
	border:1px solid;
	border-color:#EEEEEE;
	margin:0 auto;
	margin-top:40px;
	width:690px;
	height:275px;
		
}
#img{
	background:url(file:///H|/%E6%B1%AA%E7%90%9B2014-1-9/images/btn_1.png) 0 0 no-repeat;
	width:17px;
	height:15px;
	display:inline-block;
	margin-left:20px;
	margin-top:15px;
}
#main-head .imgNote{
	font-size:13px;
	color:#666;
	height:20px;
	line-height:20px;
}
.err span{
	font-size:12px;
	color:#F00;
	margin-left:65px;
}
.err{

	height:50px;
	margin-left:220px;
	width:500px; 
	color:#666;
}
.err input{
	border:1px solid #999;
	height:25px;
	width:180px;
}
#main-body{
	margin-top:15px;
	border-top:1px solid #EEEEEE;	
}
.errpwd{
	margin-top:60px;
	line-height:normal;
	font-size:10px;	
}
#errPwd{
	margin-top:45px;
}
#btn{
	margin-left:290px;
}
.btnYellow{
	background-color:#EC8C0A;
	padding:6px 20px;
	border:1px solid #fff;	
	text-align:center;
	color:#FFF;
}
#userpassword,#checkpwd{
	height:30px;
	width:180px;
 }
#bottom{
	text-align:center;
	border-top:1px solid #EEEEEE;
	padding:10px 0;
	width:1080px;
	margin:0 auto;
	margin-top:125px;
	margin-left:150px;
}
#bottom span{
	font-size:13px;
	color:#999;
}
.btnYellow:hover{
	background-color:#FC0;	
}
#pwdInfo{
	height:20px;
	line-height:20px;
	text-align:center;
	color:#F00;
	}
</style>
</head>

<body>
    <form name="form" action="PwdChange.aspx" method="post" onsubmit="return CheckPwd()">
		<div id="logo">
			<a href="http://www.17u.cn/" target="_blank"><img src="images/logo.gif" alt="同程网" title="同程网" /></a>
			<div id="changePwd">
				<h1>修改密码</h1></div>
		</div>
		<div id="main">
			<div id="main-head">
				<span id="img"></span>
                <span class="imgNote">请输入密码</span>
			</div>
		<div id="main-body">
        	<div id="pwdInfo"></div>
			<div class="err" id="errPwd">
 				密&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;码：
                <input id="userPwd" type="password" name="userPwd" maxlength="8" />
				<br/>
              <!--  <span class="errpwd" id="pwdInfo"></span>-->
            </div>
			<div class="err">
 				密码确认：
                <input id="checkPwd" type="password" name="checkPwd" maxlength="8"/>
				<br/>
                <!--<span class="errpwd"  id="confirmPwdInfo"></span>-->
       		</div>
			<div id="btn">
				<!--<input class="btnYellow" id="confirmbtn" type="button" value="确认" onclick="CheckPwd()" />
                <input class="btnYellow" id="removebtn" type="reset"  value="取消" />-->
                <input class="btnYellow" id="confirmbtn" type="submit" value="确认" />
            </div>
 		</div>
 	</div>
 	<div id="bottom">
 		<span>
        	Copyright © 2002-2014  版权所有  同程网络科技股份有限公司   苏ICP证B2-20100204  [乙测资字32005078]   旅行社业务许可证：L-JS-CJ00070 
        </span>
    </div>
 </form>
    </form>
</body>
</html>
