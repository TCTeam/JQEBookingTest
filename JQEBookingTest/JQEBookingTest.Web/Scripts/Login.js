/*!
* Login info check v1.0
* Date: 2014-01-14 10:17:11 
* Copyright 2014 Hu Guiliang
*/
function NameOnBlurFun(){
    var lab = document.getElementById("userName");
    var pattern = new RegExp("^[a-z,A-Z,0-9,_]{1,15}$", "i"); //用户名为1-15位字母、数字、下划线组合
    if (lab.value == "" || lab.value.replace(/\s/g, "") == "") {
        document.getElementById("errInfo").style.visibility = "visible";
        document.getElementById("errInfo").innerHTML = "请输入用户名！";
        return false;
    }
    if (!(pattern.test(lab.value))) {
        document.getElementById("errInfo").style.visibility = "visible";
        document.getElementById("errInfo").innerHTML = "用户名包含非法字符!";
        lab.select();
        return false;
    }
    else {
        document.getElementById("errInfo").style.visibility = "hidden";
        document.getElementById("errInfo").innerHTML = "";
    }
}
function PwdOnBlurFun() {
    var pass = document.getElementById("userPwd");
    if (pass.value.length == 0) {
        document.getElementById("errInfo").style.visibility = "visible";
        document.getElementById("errInfo").innerHTML = "请输入密码!";
        return false;
    }
    else {
        document.getElementById("errInfo").style.visibility = "hidden";
        document.getElementById("errInfo").innerHTML = "";
    }
}
function VcodeOnBlurFun() {
    var vcode = document.getElementById("validCode");
    if (vcode.value == "") {
        document.getElementById("errInfo").style.visibility = "visible";
        document.getElementById("errInfo").innerHTML = "请输入验证码！";
        return false;
    }
    else {
        document.getElementById("errInfo").style.visibility = "hidden";
        document.getElementById("errInfo").innerHTML = "";
    }
}
function CheckFun() {               //登录按钮
    var check = document.getElementById("validCode");
    var val = check.value;
    if (val == "") {
        document.getElementById("errInfo").style.visibility = "visible";
        document.getElementById("errInfo").innerHTML = "验证码不能为空！";
        return false;
    }
    var name = document.getElementById("userName");
    if (name.value == "") {
        document.getElementById("errInfo").style.visibility = "visible";
        document.getElementById("errInfo").innerHTML = "请输入用户名！";
        name.focus();
        return false;
    }
    var pattern = new RegExp("^[a-z,A-Z,0-9,_]{1,15}$", "i"); ;
    if (!(pattern.test(name.value))) {
        document.getElementById("errInfo").style.visibility = "visible";
        document.getElementById("errInfo").innerHTML = "用户名包含非法字符！";
        alert(name.value);
        name.select();
        return false;
    }
    var pass = document.getElementById("userPwd");
    if (pass.value.length == 0) {
        document.getElementById("errInfo").style.visibility = "visible";
        document.getElementById("errInfo").innerHTML = "请输入密码!";
        return false;
    }
    return true;
}