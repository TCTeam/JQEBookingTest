
/*验证用户名和密码是否存在特殊字符以及密码长度*/
var CheckCodeVal;
function initCode() {
    var texts = new Array("1", "2", "3", "4", "5", "6", "7", "8", "9", "0");
    var index1 = parseInt(Math.random() * 10);
    var index2 = parseInt(Math.random() * 10);
    var index3 = parseInt(Math.random() * 10);
    var index4 = parseInt(Math.random() * 10);
    CheckCodeVal = texts[index1] + texts[index2] + texts[index3] + texts[index4];
    var html = texts[index1] + " " + texts[index2] + " " + texts[index3] + " " + texts[index4];
    var yan = document.getElementById("imgValidCode");
    yan.innerHTML = html;
}

function checkCode() {
    var check = document.getElementById("validCode");
    var val = check.value;
    if (val == "") {
        document.getElementById("errInfo").innerHTML = "验证码不能为空！";
        return false;
    }
    else {
        if (val != CheckCodeVal) {
            document.getElementById("errInfo").innerHTML = "验证码不正确";
            return false;
        }
    }


    var name = document.getElementById("userName");

    if (name.value == "") {
        document.getElementById("errInfo").innerHTML = "请输入登录名";
        name.focus();

        return false;

    }




    var pattern = new RegExp("^[a-z,A-Z,0-9,_]{4,15}$", "i"); ;
    if (!(pattern.test(name.value))) {
        document.getElementById("errInfo").innerHTML = "错误：用户名包含非法字符或者用户名少于4位";
        alert(name.value);

        name.select();

        return false;

    }



    //密码非空+长度+密码确认验证



    //var pass=document.getElementById("txtPass");
    //
    //	var rpass=document.getElementById("txtRPass");
    //
    //	if(pass.value==""){
    //
    //		alert("密码不能为空");
    //
    //		pass.focus();
    //
    //		return false;
    //
    //	}if(pass.value.length!=8){
    //
    //		alert("密码长度为8个字符");
    //
    //		pass.select();
    //
    //		return false;
    //
    //	}
    //
    //	if(rpass.value!=pass.value){
    //
    //		alert("确认密码与密码输入不一致");
    //
    //		rpass.select();
    //
    //		return false;
    //
    //	}
    var pass = document.getElementById("userPwd");
    if (pass.value.length != 8) {
        document.getElementById("errInfo").innerHTML = "密码长度为8个字符";
        pass.select();

        return false;
    }
    document.getElementById("errInfo").innerHTML = "";
    //alert("检验完成");
    return true;


}