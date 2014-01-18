$(this).ready(function(e) {
	$(".chooseTicketNum").click(function(){
		//显示再次确认弹窗
		$("#btn_tip").show();
		$("#body_cont").show();
		//给弹窗绑定数据
		var $thisTr = $(this).parents("tr");
		$(".tip_cont:eq(0)").text($thisTr.children("td:eq(0)").text());
		$(".tip_cont:eq(1)").text($thisTr.children("td:eq(4)").text());
		$(".tip_cont:eq(2)").text($thisTr.children("td:eq(10)").text());
		$(".tip_cont:eq(3)").text($thisTr.children("td:eq(6)").text());
		$(".tip_cont:eq(4)").text($thisTr.children("td:eq(10)").text());
		$(".tip_cont:eq(5)").text($thisTr.children("td:eq(7)").text());
		$(".tip_cont:eq(6) input").val($thisTr.children("td:eq(7)").text());
		$("#HiddenFieldForOrderSerialNum").val($(this).attr("data"));
	});
	$(".CancelReConcirm").click(function(){
    if (confirm("您确定游客未购票吗？")) {
			$("#ButtonCancelClickHidden").val($(this).attr("data"));
			alert($(this).attr("data"));
			//$("#ButtonCancelClickHidden").click();
			return true;
		}else{
			return false;
		}
	});
});
