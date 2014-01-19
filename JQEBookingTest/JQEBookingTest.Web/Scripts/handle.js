$(this).ready(function (e) {
//     //navSon展开
//    $("#OrderQuery").hover(function(){
//        var $son = $("#OrderQuery .actSon");
//        if($son.is(":visible")){
//            $son.hide();
//        }else
//        {
//            $son.show();
//        }
//    });

   //点评管理页面
	$("#Comments").click(function() {
		$.ajax({
			url: "AccessDataWithAjax.aspx?index=1&type=CommentsQuery",
			type: "get",
			success: function(data) {
				tempdata = data;
				$("#Item6Table tr:not('.tabtitle')").remove();
				$("#Item6Table").append(data);
				OrderConfirmInit();
			},
			error: function() {
				alert("数据访问失败");
			}
		});
	});
	//上月点评
	$(".Item6QueryTime").click(function() {
    var queryTime= $(this).attr("data");
		$.ajax({
			url: "AccessDataWithAjax.aspx?index=1&type=CommentsQuery&QueryTime="+queryTime,
			type: "get",
			success: function(data) {
				tempdata = data;
				$("#Item6Table tr:not('.tabtitle')").remove();
				$("#Item6Table").append(data);
				OrderConfirmInit();
			},
			error: function() {
				alert("数据访问失败");
			}
		});
        $(this).blur();
	});
	//自定义查询
	$("#Item6CustomQuery").click(function() {
		var startDate = $("#Item6StartDate").val();
		var endDate = $("#Item6EndDate").val();
		var Evaluate = $("#Item6Evaluate option:selected").val();
		$.ajax({
			url: "AccessDataWithAjax.aspx?index=1&type=CommentsQuery&CustomQuery=CustomQuery&StartDate=" + startDate + "&EndDate=" + endDate + "&Evaluate=" + Evaluate,
			type: "get",
			success: function(data) {
				tempdata = data;
				$("#Item6Table tr:not('.tabtitle')").remove();
				$("#Item6Table").append(data);
				OrderConfirmInit();
			},
			error: function() {
				alert("数据访问失败");
			}
		});
        $(this).blur();
	});
	//回复点评
	$("#BtnCommentsReply").click(function() {
		var commentsReply = $("#textReplyContent").val();
		var orderSerialNo = $("#BtnCommentsReply").attr("data");
		if (commentsReply == "") {
			alert("请输入回复内容！");
			return false;
		}
		else {
			$.ajax({
				url: "AccessDataWithAjax.aspx?type=CommentsReply&orderSerialNo=" + orderSerialNo + "&commentsReply=" + commentsReply,
				type: "get",
				success: function(data) {
					if (data == "true") {
						alert("回复成功");
					} else {
						alert("回复失败");
					}
					$("#body_cont").hide();
					$("#CommentsReply").hide();
					$("#textReplyContent").val("");
					$("#BtnOrderSerialNo").attr("data", "");
					$("#Comments").click();
				}
			});
		}
	});
	$("#BtnCommentsCancel").click(function() {
		$("#body_cont").hide();
		$("#CommentsReply").hide();
		$("#CommentsUserName").text("");
		$("#BtnCommentsReply").attr("data", "");
		$("#textReplyContent").val("");
	});
    //订单查询页面
    $("#OrderQuery").click(function () {
        $.ajax({
            url: "AccessDataWithAjax.aspx?index=1&type=OrderQuery",
            type: "get",
            success: function (data) {
                $("#TabelOrderQuery tr:not('.tabtitle')").remove();
                $("#TabelOrderQuery").append(data);
                OrderConfirmInit();
            },
            error: function () {
                alert("数据访问失败");
            }
        });
    });
    //
    //订单查询页面查询按钮点击
    $("#ButtonItem2Query").click(function () {
        var orderComfirmNo = $("#orderComfirmNo").val();
        var takeTicketTime = $("#takeTicketTime").val();
        var orderNo = $("#orderNo").val();
        var identityId = $("#identityId").val();
        var takeTicketName = $("#takeTicketName").val()
        var takeTicketPhone = $("#takeTicketPhone").val();
        var ticketSort = $("#Item1ticketSort option:selected").val();
        var sortType = $("#Item1SortType option:selected").val();
        var payType = $("#Item1PayType option:selected").val();
        $.ajax({
            url: "AccessDataWithAjax.aspx?index=1&type=OrderQuery&orderComfirmNo=" + orderComfirmNo + "&takeTicketTime=" + takeTicketTime + "&orderNo=" + orderNo + "&identityId=" + identityId + "&takeTicketName=" + takeTicketName + "&takeTicketPhone=" + takeTicketPhone + "&ticketSort=" + ticketSort + "&sortType=" + sortType + "&payType=" + payType,
            type: "get",
            success: function (data) {
                tempdata = data;
                $("#TabelOrderQuery tr:not('.tabtitle')").remove();
                $("#TabelOrderQuery").append(data);
                OrderConfirmInit();
            }
        });
        $(this).blur();
    });

    $("#OrderConfirm").click(function () {
        $.ajax({
            url: "AccessDataWithAjax.aspx?index=1&type=OrderConfirmQuery",
            type: "get",
            success: function (data) {
                tempdata = data;
                $("#TableOrderConfirm tr:not('.tabtitle')").remove();
                $("#TableOrderConfirm").append(data);
                OrderConfirmInit();
            },
            error: function () {
                alert("数据访问失败");
            }
        });
    });
    $("#ButtonCancel").click(function () {
        $("#btn_tip").hide();
        $("#body_cont").hide();
    });
    $("#CanBz").click(function(){
        $("#body_cont").hide();
        $("#BzDiv").hide();
    });
    //订单确认页面查询按钮点击
    $("#ButtonItem3Query").click(function () {
        var chooseDate = $("input:radio[name='Item3nation']:checked").val();
        var dateStart = $("#Item3dateStart").val();
        var dateEnd = $("#Item3dateEnd").val();
        var orderSerialNum = $("#Item3OrderSerialNum").val();
        var orderConfirmNum = $("#Item3OrderConfirmNum").val();
        var orderName = $("#Item3OrderName").val();
        var ticketPhone = $("#Item3TicketPhone").val();
        var ticketSort = $("#Item3TicketSort option:selected").text();
        var payType = $("input:radio[name='Item3payType']:checked").val();
        $.ajax({
            url: "AccessDataWithAjax.aspx?index=1&type=OrderConfirmQuery&chooseDate=" + chooseDate + "&dateStart=" + dateStart + "&dateEnd=" + dateEnd + "&otOrderSerialNo=" + orderSerialNum + "&orderConfirmNum=" + orderConfirmNum + "&orderName=" + orderName + "&ticketPhone=" + ticketPhone + "&ticketSort=" + ticketSort + "&payType=" + payType,
            type: "get",
            success: function (data) {
                tempdata = data;
                $("#TableOrderConfirm tr:not('.tabtitle')").remove();
                $("#TableOrderConfirm").append(data);
                OrderConfirmInit();
            }
        });
        $(this).blur();
    });
    $("#ButtonItem4Query").click(function () {
        var conStion = $("input:radio[name='chooseOrderByDate']:checked").val();
        var dateStart1 = $("#Item4dateStart1").val();
        var dateEnd1 = $("#Item4dateEnd1").val();
        var dateStart2 = $("#Item4dateStart2").val();
        var dateEnd2 = $("#Item4dateEnd2").val();
        var chooseOrder = $("#item4payType option:selected").val();
        $.ajax({
            url: "AccessDataWithAjax.aspx?index=1&type=OrderStatistical&chooseOrder=" + chooseOrder + "&dateStart1=" + dateStart1 + "&dateEnd1=" + dateEnd1 + "&dateStart2=" + dateStart2 + "&dateEnd2=" + dateEnd2 + "&conStion=" + conStion,
            type: "get",
            success: function (data) {
                tempdata = data;
                $("#Chitem4 tr:not('.tabtitle')").remove();
                $("#Chitem4").append(data);
                OrderConfirmInit();
            }
        });
        $(this).blur();
    });

    $("#OrderSta").click(function () {
        $.ajax({
            url: "AccessDataWithAjax.aspx?index=1&type=OrderStatistical",
            type: "get",
            success: function (data) {
                tempdata = data;
                $("#Chitem4 tr:not('.tabtitle')").remove();
                $("#Chitem4").append(data);
                OrderConfirmInit();
            }
        });
    });
    //执行订单确认
    $("#ButtonConfirm").click(function () {
        var realTicketNum = $(".tip_cont:eq(6) input").val();
        var otOrderSerialNo = $(this).attr("data");
        $.ajax({
            url: "AccessDataWithAjax.aspx?type=OrderConfirmOk&otOrderSerialNo=" + otOrderSerialNo + "&realTicketNum=" + realTicketNum,
            type: "get",
            success: function (data) {
                if (data == "true") {
                    alert("订单确认成功");
                } else {
                    alert("订单确认失败");
                }
                $("#btn_tip").hide();
                $("#body_cont").hide();
                $("#OrderConfirm").click();
            }
        });
    });

   //处理各个页面动态生成的标签的事件的初始化
    function OrderConfirmInit() {
        //点评管理，回复按钮点击
        $(".CommentsReply").click(function(){
            $("#body_cont").show();
            $("#CommentsReply").show();
            $("#CommentsUserName").text($(this).parents("tr").children("td:eq(2)").text());
            $("#BtnCommentsReply").attr("data",$(this).attr("data"));
            $("#textReplyContent").val($(this).parents("tr").children("td:eq(5)").text());
        });
        //订单确认，确认订单按钮点击
        $(".ChooseTicketNum").click(function () {
            //显示再次确认弹窗
            $("#btn_tip").show();
            $("#body_cont").show();
            //给弹窗绑定数据
            var $thisTr = $(this).parents("tr");
            $(".tip_cont:eq(0)").text($thisTr.children("td:eq(1)").text());
            $(".tip_cont:eq(1)").text($thisTr.children("td:eq(4)").text());
            $(".tip_cont:eq(2)").text($thisTr.children("td:eq(10)").text());
            $(".tip_cont:eq(3)").text($thisTr.children("td:eq(6)").text());
            $(".tip_cont:eq(4)").text($thisTr.children("td:eq(10)").text());
            $(".tip_cont:eq(5)").text($thisTr.children("td:eq(7)").text());
            $(".tip_cont:eq(6) input").val($thisTr.children("td:eq(7)").text());
            $("#ButtonConfirm").attr("data", $(this).attr("data"));
        });
        //执行订单未购票
        $(".CancelReConfirm").click(function () {
            if (confirm("您确定游客未购票吗？")) {
                var otOrderSerialNo = $(this).attr("data");
                $.ajax({
                    url: "AccessDataWithAjax.aspx?type=CancelReConfirm&otOrderSerialNo=" + otOrderSerialNo,
                    type: "get",
                    success: function (data) {
                        if (data == "true") {
                            alert("操作成功");
                        } else {
                            alert("操作失败");
                        }
                        $("#btn_tip").hide();
                        $("#body_cont").hide();
                        $("#OrderConfirm").click();
                    }
                });
                return true;
            } else {
                return false;
            }
        });
        // 备注按钮
        $(".sbutton").click(function(){
        
            //保存备注信息，减少数据库的访问频率
            var textarea = "";
            $("#body_cont").show();
            $("#BzDiv").show();
            var otOrderSerialNo = $(this).attr("data");
            $.ajax({
                    url: "AccessDataWithAjax.aspx?type=GetRemark&otOrderSerialNo=" + otOrderSerialNo+"&randomtext="+Math.random(),
                    type: "get",
                    success: function (data) {
                        if(data!="")
                        {
                            $(".BzText").val(data);
                        }else{
                            $(".BzText").val("请添加备注！");
                        }
                        
                        textarea = data;
                        $("#AddBz").click(function(){
                            var text = $(".BzText").val();
                            if(text===textarea)
                            {
                                alert("备注未改变");
                            }else{
                                $.ajax({
                                url: "AccessDataWithAjax.aspx?index=&type=UpdataRemark&otOrderSerialNo="+otOrderSerialNo+"&text="+text,
                                type: "get",
                                success: function (data) {
                                    if(data==="true"){
                                        $("#body_cont").hide();
                                        $("#BzDiv").hide();
                                        alert("添加成功");
                                        return;
                                    }else{
                                        alert("添加失败");
                                    }
                                },
                                error: function () {
                                    alert("数据访问失败");
                                }
                                });
                            }
                            return;
                        });
                    }
                });
                return;
        });
        //分页页码点击事件
        $(".item2ListPage").click(function () {
            $.ajax({
                url: "AccessDataWithAjax.aspx?index=" + $(this).text() + "&type=OrderQuery",
                type: "get",
                success: function (data) {
                    $("#TabelOrderQuery tr:not('.tabtitle')").remove();
                    $("#TabelOrderQuery").append(data);
                    OrderConfirmInit();
                }
            });
        });
        $(".item3ListPage").click(function () {
            $.ajax({
                url: "AccessDataWithAjax.aspx?index=" + $(this).text() + "&type=OrderConfirmQuery",
                type: "get",
                success: function (data) {
                    $("#TableOrderConfirm tr:not('.tabtitle')").remove();
                    $("#TableOrderConfirm").append(data);
                    OrderConfirmInit();
                }
            });
        });
        $(".item4ListPage").click(function () {
            $.ajax({
                url: "AccessDataWithAjax.aspx?index=" + $(this).text() + "&type=OrderStatistical",
                type: "get",
                success: function (data) {
                    $("#Chitem4 tr:not('.tabtitle')").remove();
                     $("#Chitem4").append(data);
                    OrderConfirmInit();
                }
            });
        });
        $(".item6ListPage").click(function () {
            $.ajax({
                url: "AccessDataWithAjax.aspx?index=" + $(this).text() + "&type=CommentsQuery",
                type: "get",
                success: function (data) {
                    $("#Item6Table tr:not('.tabtitle')").remove();
                    $("#Item6Table").append(data);
                    OrderConfirmInit();
                }
            });
        });
    }
    //日历初始化
    $(".dateStart").datepicker({
        dateFormat: 'yy-mm-dd',
        defaultDate: "+1w",
        numberOfMonths: 2,
        monthNames: ['1月', '2月', '3月', '4月', '5月', '6月', '7月', '8月', '9月', '10月', '11月', '12月'],
        onClose: function (selectedDate) {
            $(".dateEnd").datepicker("option", "minDate", selectedDate);
            $(".dateEnd").focus();
        }
    });
    $(".dateEnd").datepicker({
        dateFormat: 'yy-mm-dd',
        defaultDate: "+1w",
        numberOfMonths: 2,
        onClose: function (selectedDate) {
            $(".dateStart").datepicker("option", "maxDate", selectedDate);
        }
    });
    $(".dateStart2").datepicker({
        dateFormat: 'yy-mm-dd',
        defaultDate: "+1w",
        numberOfMonths: 2,
        monthNames: ['1月', '2月', '3月', '4月', '5月', '6月', '7月', '8月', '9月', '10月', '11月', '12月'],
        onClose: function (selectedDate) {
            $(".dateEnd2").datepicker("option", "minDate", selectedDate);
            $(".dateEnd2").focus();
        }
    });
    $(".dateEnd2").datepicker({
        dateFormat: 'yy-mm-dd',
        defaultDate: "+1w",
        numberOfMonths: 2,
        onClose: function (selectedDate) {
            $(".dateStart2").datepicker("option", "maxDate", selectedDate);
        }
    });
    $(".dateH").datepicker({
        dateFormat: 'yy-mm-dd',
        defaultDate: "+1w",
        numberOfMonths: 1,
    });
    /*动作条控制*/
    $(".actionbar li").click(function () {
        $(".content").children("div").css("display", "none");
        var index = $(".actionbar li").index(this);
        $(".content").children("div:eq(" + index + ")").show();
        $(this).children("a").addClass("nowPlace").end().siblings().children("a").removeClass("nowPlace");
        $(".uDefined").css("display","none");//自定义查询关闭
        $(".uDefined2").css("display","none");
    })
    /*主页导航*/
    $(".contentItem1 .Chandle").click(function () {
        var index = $(".contentItem1 .Chandle").index(this) + 1;
         $(".actionbar ul li:eq(" + index + ")").click();
    });
    $(".contentItem1 li").click(function () {
        var index = $(".contentItem1 li").index(this) + 1;
         $(".actionbar ul li:eq(" + index + ")").click();
    });
    $(".mySearchP").click(function () {
        $(".uDefined").toggle();
    });
    $(".mySearchP2").click(function () {
        $(".uDefined2").toggle();
    });
    /*自定义查询收起*/

    /*ajax*/
    $('#Form1').bind('submit', function () {
        ajaxSubmit(this, function (data) {
            alert(data);
        });
        return false;
    });
});

function ajaxSubmit(frm, fn) {
    var dataPara = getFormJson(frm);
    $.ajax(
	{
	    url: frm.action,
	    type: frm.method,
	    data: dataPara,
	    success: fn
	});
}
function getFormJson(frm) {
    var o = {};
    var a = $(frm).serializeArray();
    $.each(a, function () {
        if (o[this.name] !== undefined) {
            if (!o[this.name].push) {
                o[this.name] = [o[this.name]];
            }
            o[this.name].push(this.value || '');
        } else {
            o[this.name] = this.value || '';
        }
    });
    return o;
}

function GetBaseData() {
    // “今天”订单索引
    $(".linkPage").each(function () {
        $(this).click(function () {
            $.ajax({
                url: "AccessDataWithAjax.aspx?index=" + $(this).html() + "&&type=orderNow",
                typr: "get",
                success: function (data) {
                    $("#Chitem1 tr:not('.tabtitle')").remove();
                    document.getElementById("Chitem1").innerHTML += data;
                },
                error: function () {
                    alert("访问数据失败！");
                }
            });
        });
    });
    // item2查询提交相应
    $("#item2input").click(function () {
        $.ajax({
            url: "AccessDataWithAjax.aspx?index=1&&type=Search&&orderComfirmNo=" + $("#orderComfirmNo").val() + "&&takeTicketTime=" + $("#takeTicketTime").val() + "&&orderNo=" + $("#orderNo").val() + "&&takeTicketName" + $("#takeTicketName").val() + "&&ticketSort=" + $("#ticketSort option:selected").text() + "&&sortType=" + $("#sortType option:selected").text() + "&&takeTicketPhone=" + $("#takeTicketPhone").val() + "&&payType=" + $("#payType option:selected").text() + "&&identityId=" + $("#identityId").val(),
            type: "get",
            success: function (data) {
                $("#Chitem1 tr:not('.tabtitle')").remove();
                document.getElementById("Chitem1").innerHTML += data;
            },
            error: function () {
                alert("数据访问错误！");
            }
        });
    });
    // item4查询提交相应
    $(".item4input").click(function () {
        var selection = document.getElementsByName("chooseOrderByDate");
        var res = "";
        if (selection[0].checked) {
            res = selection[0].value;
        } else {
            res = selection[1].value;
        }

        $.ajax({
            url: "AccessDataWithAjax.aspx?index=1&&type=" + res + "&&starttime=" + $(".starttime1").val() + "&&endtime=" + $(".endtime1").val(),
            type: "get",
            success: function (data) {
                $("#Chitem1 tr:not('.tabtitle')").remove();
                document.getElementById("Chitem4").innerHTML += data;
            },
            error: function () {
                alert("数据访问错误！");
            }
        });
    });
   
}


