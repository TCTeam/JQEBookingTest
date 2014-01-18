function inputCheck() {
	var username = $("#username").val();
	var password = $("#password").val();
	if (!(/^\w{1,15}$/.test(username))) {
	    alert( "用户名错误");
	    return false;
	}
	if (!(/^\w{1,15}$/.test(f.password.value))) {
	    alert("密码格式不正确");
	    return false;
	}
	return true;
}