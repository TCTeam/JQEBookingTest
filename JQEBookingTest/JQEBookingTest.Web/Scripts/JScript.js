/********************************************************************
*       异步数据处理程序
*       made by jun
********************************************************************/


//
$(function () {

    // 为“上一页”“下一页”选项所用
    var page = 1;

    // 第一次加载时显示第一页页面
    $.ajax({
        url: "AccessDataWithAjax.aspx?index=1",
        type: "post",
        success: function (data) {
            //alert("ok");
            tempdata = data;
            document.getElementById("showtable").innerHTML += data;
            //$("#showview").text(data);
        },
        error: function () {
            alert("数据访问失败");
        }
    });

    // 点击事件响应
    $("._textview").each(function () {
        $(this).click(function () {
            $.ajax({
                url: "AccessDataWithAjax.aspx?index=" + $(this).html(),
                type: "post",
                success: function (data) {
                    document.getElementById("showview").innerHTML = data;
                },
                error: function () {
                    alert("数据访问错误");
                }
            });
        });
    });
});