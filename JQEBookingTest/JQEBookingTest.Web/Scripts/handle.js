$(this).ready(function (e) {
    //订单查询页面查询按钮点击
    $("#OrderQuery").click(function () {
        $.ajax({
            url: "AccessDataWithAjax.aspx?index=1&type=OrderQuery",
            type: "post",
            success: function (data) {
                tempdata = data;
                $("#TabelOrderQuery tr:not('.tabtitle')").parent("tbody").remove();
                document.getElementById("TabelOrderQuery").innerHTML += data;
                OrderConfirmInit();
            },
            error: function () {
                alert("数据访问失败");
            }
        });
    });
    //
    //订单确认页面查询按钮点击
    $("#ButtonItem2Query").click(function () {
        var orderComfirmNo = $("#orderComfirmNo").val();
        var takeTicketTime = $("#takeTicketTime").val();
        var orderNo = $("#orderNo").val();
        var identityId = $("#identityId").val();
        var takeTicketName = $("#takeTicketName").val()
        var takeTicketPhone = $("#takeTicketPhone").val();
        var ticketSort = $("#ticketSort option:selected").text();
        var sortType = $("input:radio[name='sortType']:checked").val();
        var payType = $("input:radio[name='payType']:checked").val();
        $.ajax({
            url: "AccessDataWithAjax.aspx?index=1&type=OrderQuery&orderComfirmNo=" + orderComfirmNo + "&takeTicketTime=" + takeTicketTime + "&orderNo=" + orderNo + "&identityId=" + identityId + "&takeTicketName=" + takeTicketName + "&takeTicketPhone=" + takeTicketPhone + "&ticketSort=" + ticketSort + "&sortType=" + sortType + "&payType=" + payType,
            type: "get",
            success: function (data) {
                tempdata = data;
                $("#TabelOrderQuery tr:not('.tabtitle')").parent("tbody").remove();
                document.getElementById("TabelOrderQuery").innerHTML += data;
                //OrderConfirmInit();
            }
        });
        $(this).blur();
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
            type: "post",
            success: function (data) {
                tempdata = data;
                $("#TableOrderConfirm tr:not('.tabtitle')").parent("tbody").remove();
                document.getElementById("TableOrderConfirm").innerHTML += data;
                OrderConfirmInit();
            }
        });
        $(this).blur();
    });
    $("#ButtonItem4Query").click(function () {
        var conStion = $("input:radio[name='chooseOrderByDate']:checked").val();
        var dateStart1 = $("#dataStart1").val();
        var dateEnd1 = $("#dataEnd1").val();
        var dateStart2 = $("#dataStart2").val();
        var dateEnd2 = $("#dataEnd2").val();
        var chooseOrder = $("#item4payType option:selected").val();
        $.ajax({
            url: "AccessDataWithAjax.aspx?index=1&type=OrderStatistical&chooseOrder=" + chooseOrder + "&dateStart1=" + dateStart1 + "$dateEnd1=" + dateEnd1 + "&dateStart2=" + dateStart2 + "&dateEnd2=" + dateEnd2 + "&conStion=" + conStion,
            type: "post",
            success: function (data) {
                tempdata = data;
                $("#Chitem4 tr:not('.tabtitle')").parent("tbody").remove();
                document.getElementById("Chitem4").innerHTML += data;
                OrderConfirmInit();
            }
        });
    });

    $("#OrderSta").click(function () {
        $.ajax({
            url: "AccessDataWithAjax.aspx?index=1&type=OrderStatistical",
            type: "post",
            success: function (data) {
                tempdata = data;
                $("#Chitem4 tr:not('.tabtitle')").parent("tbody").remove();
                document.getElementById("Chitem4").innerHTML += data;
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
            type: "post",
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


    //订单确认页面初始化
    function OrderConfirmInit() {
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
        //分页页码点击事件
        $(".item2ListPage").click(function () {
            $.ajax({
                url: "AccessDataWithAjax.aspx?index=" + $(this).text() + "&type=OrderQuery",
                type: "post",
                success: function (data) {
                    tempdata = data;
                    $("#TabelOrderQuery tr:not('.tabtitle')").parent("tbody").remove();
                    document.getElementById("TabelOrderQuery").innerHTML += data;
                    OrderConfirmInit();
                }
            });
        });
        $(".item3ListPage").click(function () {
            $.ajax({
                url: "AccessDataWithAjax.aspx?index=" + $(this).text() + "&type=OrderConfirmInit",
                type: "post",
                success: function (data) {
                    tempdata = data;
                    $("#TableOrderConfirm tr:not('.tabtitle')").parent("tbody").remove();
                    document.getElementById("TableOrderConfirm").innerHTML += data;
                    OrderConfirmInit();
                }
            });
        });
        $(".item4ListPage").click(function () {
            $.ajax({
                url: "AccessDataWithAjax.aspx?index=" + $(this).text() + "&type=OrderStatistical",
                type: "post",
                success: function (data) {
                    tempdata = data;
                    $("#Chitem4 tr:not('.tabtitle')").parent("tbody").remove();
                    document.getElementById("Chitem4").innerHTML += data;
                    OrderConfirmInit();
                }
            });
        });
        //执行订单未购票
        $(".CancelReConfirm").click(function () {
            if (confirm("您确定游客未购票吗？")) {
                var otOrderSerialNo = $(this).attr("data");
                $.ajax({
                    url: "AccessDataWithAjax.aspx?type=CancelReConfirm&otOrderSerialNo=" + otOrderSerialNo,
                    type: "post",
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
    }
    $("#OrderConfirm").click(function () {
        $.ajax({
            url: "AccessDataWithAjax.aspx?index=1&type=OrderConfirmInit",
            type: "post",
            success: function (data) {
                tempdata = data;
                $("#TableOrderConfirm tr:not('.tabtitle')").parent("tbody").remove();
                document.getElementById("TableOrderConfirm").innerHTML += data;
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
        onClose: function (selectedDate) {
            $(".dateH").datepicker("option", "maxDate", selectedDate);
        }
    });
    /*动作条控制*/
    $(".actionbar li").click(function () {
        $(".actionbar li").removeClass("active");
        $(".content").children("div").css("display", "none");
        $(this).addClass("active");
        var index = $(".actionbar li").index(this);
        $(".content").children("div:eq(" + index + ")").show();
    });
    /*主页导航*/
    $(".contentItem1 .Chandle").click(function () {
        $(".actionbar li").removeClass("active");
        $(".content").children("div").css("display", "none");
        var index = $(".contentItem1 .Chandle").index(this) + 1;
        $(".actionbar ul").children("li:eq(" + index + ")").addClass("active");
        $(".content").children("div:eq(" + index + ")").show();
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
    $(".linkpage").each(function () {
        $(this).click(function () {
            $.ajax({
                url: "AccessDataWithAjax.aspx?index=" + $(this).html() + "&&type=orderNow",
                typr: "post",
                success: function (data) {
                    $("#Chitem1 tr:not('.tabtitle')").parent("tbody").remove();
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
            type: "post",
            success: function (data) {
                $("#Chitem1 tr:not('.tabtitle')").parent("tbody").remove();
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
            type: "post",
            success: function (data) {
                $("#Chitem1 tr:not('.tabtitle')").parent("tbody").remove();
                document.getElementById("Chitem4").innerHTML += data;
            },
            error: function () {
                alert("数据访问错误！");
            }
        });
    });

}