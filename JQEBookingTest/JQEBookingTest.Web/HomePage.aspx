<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

<link href="Styles/jquery-ui-1.10.0.custom.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="Scripts/jquery-1.10.2.min.js"></script>
<script src="Scripts/jquery-ui-1.10.0.custom.min.js" type="text/javascript"></script>
<script src="Scripts/handle.js" type="text/javascript"></script>
<title>ebooking订单处理</title>
<style type="text/css" media="screen">
		@import url("css/handle.css");
	</style>
</head>
<body>
<form runat="server">
<!--PageHead-->
	<div class="head">
    	<img id="logo" src="Images/cnLogo.png" />
        <span class="title">订单处理系统</span>
        <ul class="headright">
        	<li>
            	<span id="head_uname"><asp:PlaceHolder runat="server" ID="Place"></asp:PlaceHolder></span>,<span>欢迎您!</span>
                <span></span>
            </li>
            <li>
                <a href="PwdChange.aspx">修改密码</a>
            </li>
            <li>
            	<a href="Default.aspx">退出</a>
            </li>
        </ul>
    </div>
 <!--   PageHeadEnd-->
  <!--   Action-->
    <div class="actionbar">
    	<ul >
        	<li>首页</li>
            <li id="OrderQuery">订单查询</li>
            <li id="OrderConfirm">订单确认</li>
            <li id="OrderSta">订单统计</li>
            <li id="DataOut" runat="server">数据导出</li>
            <li id="Comments">点评管理</li>
        </ul>
    </div>
    <div class="content">
    <!--Item1-->
    	<div class="contentItem1">
        	<ul>
            	<li>
                	<p class="Chandle">订单查询</p>
                    <p>按照游客下单日期、取票日期、订单号、取票人姓名和手机，进行订单查询功能 </p>
                </li>   	
                <li>
                	<p class="Chandle">订单确认</p>
                    <p>对客户购票票数进行确认。方便景区与同程网之间的订单确认。 </p>
                </li>
            </ul>
            <ul>
            	<li>
                	<p class="Chandle">订单统计</p>
                    <p>按照游客下单日期、取票日期、付费类型对已核单的账单进行统计</p>
                </li>   	
                <li>
                	<p class="Chandle">数据导出</p>
                    <p>按照游客下单日期、取票日期、付费类型对数据导出（高级管理员权限）</p>
                </li>
            </ul>
        </div>
     <!--Item1 End-->
      <!--Item2-->
        <div class="contentItem2" style="display:none">
        	<div class="selectBar">
                
                <p class="mySearchP">【<span class="mySearch">自定义查询</span>】</p>
                 <div style="display:none" class="uDefined">
                	
                    <ul>
                        <li>
                            <span>订单确认号：</span>
                            <span><input id="orderComfirmNo" type="text" value=""/></span>
                        </li>
                        <li>
                            <span>取&nbsp;票&nbsp;日&nbsp;期：&nbsp;</span>
                            <span><input id="takeTicketTime" type="text" value="" class="dateH"/></span>
                        </li>
                    </ul>
                    <ul>
                        <li>
                            <span>订单号：</span>
                            <span><input id="orderNo" type="text" value=""/></span>
                        </li>
                        <li>
                            <span>取票人：</span>
                            <span><input id="takeTicketName" type="text" value=""/></span>
                        </li>
                    </ul>
                    <ul>
                        <li>
                            <span>门&nbsp;票&nbsp;排&nbsp;序&nbsp;：&nbsp&nbsp&nbsp;</span>
                            <span>
                                <select id="Item1ticketSort" name="ticketSort">
                                    <option value="drawTicketName">取票人姓名</option>
                                    <option value="drawTicketTime">取票时间</option>
                                    <option value="buyTime">下单时间</option>
                                </select>
                            </span>
                            <span>
                            	<select id="Item1SortType" name="sortType">
                                    <option value="up">升序</option>
                                    <option value="down">降序</option>
                                </select>
                            </span>
                        </li>
                        <li>
                            <span>取票人手机号：</span>
                            <span><input id="takeTicketPhone" type="text" value=""/></span>
                        </li>
                    </ul>
                    <ul class="PayWay">
                        <li>
                             <span>支付方式：</span>
                            <span>
                            	<select id="Item1PayType" name="payType">
                                    <option value="noPlace" >不限</option>
                                    <option value="viewPay" >景区到付</option>
                                    <option value="onlinePay" >在线支付</option>
                                </select>
                            </span>   
                            <span>身份证号：</span>
                           <span><input id="identityId" type="text" value=""/></span>
                        </li>
                    </ul>
                    
                     <div class="btn" >
                      <span><input id="ButtonItem2Query" class="item2input" type="button" value="查询"/></span>
                     <%-- <span><input class="putout" type="button" value="导出数据"/></span>--%>
                  </div>
                  
                 
            </div>
       
            <div class="form">
            	<table class="selectTab" id="TabelOrderQuery">
                	<tr class="tabtitle">
                    	<td width="100px">订单确认号</td>
                        <td width="175px">订单流水号</td>
                        <td width="100px">订单状态</td>
                        <td width="105px">取票人</td>
                        <td width="120px">取票人手机</td>
                        <td width="100px">下单时间</td>
                        <td width="80px">旅游时间</td>
                        <td width="40px">票数</td>
                        <td width="80px">实际取票数</td>
                        <td width="100px">单价</td>
                        <td width="100px">总金额</td>
                        <td width="110px">门票类型</td>
                        <td width="100px">支付方式</td>
                        <td width="80px">备注</td>
                    </tr>
                </table>
            </div>
        </div>
        </div>
 <!--Item2 End-->
      <!--订单确认-->
        <div class="contentItem3" style="display: none">
            <%--<div id="quick">
                <span>
                    <asp:Button ID="ButtonNewOrder" CssClass="put" runat="server" Text="今日未确认订单" /></span><span>订单确认号：</span>
                <span>
                    <input type="text" value="" /></span> <span>
                        <input class="put" type="button" value="查询" /></span>
            </div>--%>
            <p class="mySearchP2">
                【<span class="mySearch">自定义查询</span>】</p>
            <div id="item3Form" style="display: none" class="uDefined2">
                <ul>
                    <li><span>日期选择：</span> <span>
                        <input id="Item3OrderDate" type="radio" name="Item3nation" value="buyTime" checked="checked" />
                        <lable for="Item3OrderDate">下单日期</lable>
                    </span><span>
                        <input id="Item3TravelDate" type="radio" name="Item3nation" value="drawTicketTiem" />
                        <lable for="Item3TravelDate">取票时间</lable>
                    </span></li>
                </ul>
                <ul>
                    <li><span style="display: inline-block; width: 60px">起始日期：</span> <span>
                        <input id="Item3dateStart" type="text" value="" class="dateStart" /></span> <span style="display: inline-block;
                            width: 85px; margin-left: 5px">截止到</span> <span>
                        <input id="Item3dateEnd" type="text" value="" class="dateEnd" /><span> </li>
                </ul>
                <ul>
                    <li><span style="display: inline-block; width: 60px">订单号：</span> <span>
                        <input id="Item3OrderSerialNum" type="text" value="" /></span> </li>
                    <li><span style="display: inline-block; width: 85px; margin-left: 8px">订单确认号：</span>
                        <span>
                            <input id="Item3OrderConfirmNum" type="text" value="" /></span> </li>
                </ul>
                <ul>
                    <li><span style="display: inline-block; width: 60px">客户姓名：</span> <span>
                        <input id="Item3OrderName" type="text" value="" /></span> <span style="display: inline-block; width: 85px;
                            margin-left: 5px">取票人手机号：</span> <span>
                                <input id="Item3TicketPhone" type="text" value="" /></span> </li>
                    <ul>
                        <li><span>门票排序：</span> <span>
                            <select id="Item3TicketSort" name="ticketSort">
                                <option value="drawTicketName">取票人姓名</option>
                                <option value="drawTicketTime">取票时间</option>
                                <option value="buyTime">下单时间</option>
                            </select>
                        </span></li>
                    </ul>
                    <ul>
                        <li><span>支付方式：</span> <span>
                            <input id="Item3payType1" type="radio" name="Item3payType" value="noPlace" checked="checked" />
                            <label for="Item3payType1">
                                不限</label></span> <span>
                                    <input id="Item3payType2" type="radio" name="Item3payType" value="viewPay" />
                                    <label for="Item3payType2">
                                        景区到付</label></span> <span>
                                            <input id="Item3payType3" type="radio" name="Item3payType" value="onlinePay" />
                                            <label for="Item3payType3">
                                                在线支付</label></span> </li>
                    </ul>
                    <div class="clear">
                    </div>
                    <input class="put" type="button" id="ButtonItem3Query" value="查询" />
                    <div class="clear">
                    </div>
            </div>
            <div class="form">
                <table id="TableOrderConfirm" class="selectTab">
                    <tr class="tabtitle">
                        <td>
                            确认号
                        </td>
                        <td>
                            订单流水号
                        </td>
                        <td>
                            状态
                        </td>
                        <td>
                            取票人
                        </td>
                        <td>
                            取票人手机
                        </td>
                        <td>
                            下单时间
                        </td>
                        <td>
                            旅游时间
                        </td>
                        <td>
                            票数
                        </td>
                        <td>
                            单价
                        </td>
                        <td>
                            总金额
                        </td>
                        <td>
                            门票类型
                        </td>
                        <td>
                            订单确认
                        </td>
                        <td>
                            未购票
                        </td>
                    </tr>
                    <!--遍历数据形成表格,后台数据返回到这里-->
                </table>
            </div>
            <div>
            </div>
        </div>
        <!--订单确认 End-->
          
        <div class="contentItem4" style="display:none;" >
        	  <div class="selectBar">
                     <ul class="PayWay">
                        <li>
                             <span>支付方式：</span>
                            <span>
                            	<select id="item4payType">
                                    <option value="0" >不限</option>
                                    <option value="1" >景区到付</option>
                                    <option value="2" >在线支付</option>
                                </select>
                            </span>   
                        </li>
                         <li>
                         		<input type="radio" name="chooseOrderByDate" id="chOrByDate" value="ordertime" checked="checked" /><label for="chOrByDate">下单日期：</label>
                                <span>从</span>
                                <span><input type="text" value="" class="dateStart" id="Item4dateStart1"/></span>
                                <span>到</span>
                                <span><input type="text" value="" class="dateEnd" id="Item4dateEnd1"/></span>
                            </li>
                            <li>
                         		<input type="radio" name="chooseOrderByDate" id="chOrByDate2" value="taketime" /><label for="chOrByDate2">取票日期：</label>
                                <span>从</span>
                                <span><input type="text" value="" class="dateStart2" id="Item4dateStart2"/></span>
                                <span>到</span>
                                <span><input type="text" value="" class="dateEnd2" id="Item4dateEnd2"/></span>
                            </li>
                    </ul>
                        <ul class="PayWay">
                            <li><input id="ButtonItem4Query" type="button" value="查询"/></li>
                        </ul>
               </div>
                <div class="form">
            	<table class="selectTab" id="Chitem4">
                	<tr class="tabtitle">
                    	
                        <td width="175px">订单确认号</td>
                        <td width="100px">订单流水号</td>
                        <td width="105px">票数</td>
                        <td width="98px">取票人</td>
                        <td width="88px">取票人手机</td>
                        <td width="88px">下单时间</td>
                        <td width="88px">旅游时间</td>
                        <td width="60px">票数</td>
                        <td width="60px">实际取票数</td>
                        <td width="200px">门票类型</td>
                        
                    </tr>
                     
                </table>
            </div>
        </div>  
         <!--Item4End-->
         <!--数据导出-->
        <div class="contentItem5" style="display: none;">
            <div class="selectBar">
                <ul>
                    <li><span>支付方式：</span> <span>
                        <select name="payType" runat="server" id="Item5payType">
                            <option value="noPlace">不限</option>
                            <option value="viewPay">景区到付</option>
                            <option value="onlinePay">在线支付</option>
                        </select>
                    </span></li>
                    <li><span>下单日期：</span> <span>从</span> <span>
                        <input id="Item5TextCreateTimeStart" type="text" value="" class="dateStart" runat="server"/></span> <span>到</span> <span>
                        <input id="Item5TextCreateTimeEnd" type="text" value="" class="dateEnd" runat="server"/><span> </li>
                    <li><span>取票日期：</span> <span>从</span> <span>
                        <input id="Item5TextTravelTimeStart" type="text" value="" class="dateStart2" runat="server" /></span> <span>到</span> <span>
                        <input id="Item5TextTravelTimeEnd" type="text" value="" class="dateEnd2" runat="server" /><span> </li>
                    <li><span>订单状态：</span> <span>
                        <select name="ticketState" runat="server" id="Item5ticketState">
                            <option value="all">全部</option>
                            <option value="alreadyCheck">已核单</option>
                            <option value="NoShow">NoShow</option>
                            <option value="viewSure">景区确认</option>
                        </select>
                    </span></li>
                </ul>
                <ul class="PayWay">
                    <li><span>导出类型：</span> <span>
                        <input id="RadioBackTypeDefault" type="radio" name="bayType" value="OutDeafult" checked="checked" />
                        <lable for="RadioBackTypeDefault">默认</lable>
                    </span><span>
                        <input id="RadioBackTypeDate" type="radio" name="bayType" value="DateTecType" />
                        <lable for="RadioBackTypeDate">按日期票型</lable>
                    </span></li>
                    <li>
                        <asp:Button ID="ButtonOrderBackExcel" runat="server" Text="导出" OnClick="ButtonOrderBackExcel_Click" />
                    </li>
                </ul>
            </div>
            <div class="form" style="display: none;">
                <table class="selectTab">
                    <tr class="tabtitle">
                        <td width="175px">
                            订单确认号
                        </td>
                        <td width="175px">
                            订单流水号
                        </td>
                        <td width="100px">
                            订单状态
                        </td>
                        <td width="105px">
                            取票人
                        </td>
                        <td width="120px">
                            取票人手机
                        </td>
                        <td width="88px">
                            下单时间
                        </td>
                        <td width="88px">
                            旅游时间
                        </td>
                        <td width="100px">
                            单价
                        </td>
                        <td width="88px">
                            票数
                        </td>
                        <td width="120px">
                            总金额
                        </td>
                        <td width="200px">
                            门票类型
                        </td>
                        <td width="160px">
                            支付方式
                        </td>
                    </tr>
                    <!--遍历数据形成表格,后台数据返回到这里-->
                   
                </table>
            </div>
        </div>
        <!--数据导出 End-->
        <!--点评管理-->
        <div class="contentItem6" style="display: none">
            <div class="form">
                <table id="Item6Table" class="selectTab">
                    <tr class="tabtitle">
                       <td><input type="checkbox" /></td>
                       <td>订单流水号</td>
                       <td>用户名</td>
                       <td>点评内容</td>
                       <td>点评日期</td>
                       <td>回复内容</td>
                       <td>状态</td>
                       <td>操作</td>
                    </tr>
                    <!--遍历数据形成表格,后台数据返回到这里-->
                </table>
            </div>
        </div>
        <!--点评管理 End-->
    </div>
    <div id="body_cont" class="tip_window" style="display: none;"></div>
    <div id="btn_tip" class="tip_window" style="display: none;">
        <div id="tip_up">
            <span id="tip_title">确认提示</span><span id="tip_close" onclick="javascript:closeTip()"></span>
        </div>
        <div id="tip_down">
            <div class="downCont">
                <div class="tip_title">
                    <span>待确认订单号</span></div>
                <div class="tip_cont">
                </div>
            </div>
            <div class="downCont">
                <div class="tip_title">
                    <span>取票人手机号</span></div>
                <div class="tip_cont">
                </div>
            </div>
            <div class="downCont">
                <div class="tip_title">
                    <span>门票类型</span></div>
                <div class="tip_cont">
                </div>
            </div>
            <div class="downCont">
                <div class="tip_title">
                    <span>旅游日期</span></div>
                <div class="tip_cont">
                </div>
            </div>
            <div class="downCont">
                <div class="tip_title">
                    <span>实际门票类型</span></div>
                <div class="tip_cont">
                </div>
            </div>
            <div class="downCont">
                <div class="tip_title">
                    <span>游客预定票数</span></div>
                <div class="tip_cont">
                </div>
            </div>
            <div class="downCont">
                <div class="tip_title">
                    <span>实际取票张数</span></div>
                <div class="tip_cont">
                    <input id="TextRealTicketNum" type="text" runat="server" /></div>
            </div>
            <div class="downCont">
                <div class="tip_title">
                    <span>已支付</span></div>
                <div class="tip_cont">
                    <!--最初是将要进行操作的订单流水号绑定到button的data参数中，-->
                    <!--但是js修改此参数以后后台无法获取变化后的值，故此设置隐藏域-->
                    <input type="button" value="确认" id="ButtonConfirm" />
                    <input type="button" value="取消" id="ButtonCancel" />
                </div>
            </div>
        </div>
    </div>
    <div id="BzDiv" class="tip_window" style="display:none;">
        <div class="BzDivUp">
            <span class="BzTitle">添加备注</span>
        </div>
        <div class="BzDivDown">
            <textarea class="BzText" cols="46" rows="8" placeholder="在此添加备注"></textarea>
            <div>
                <input class="BzBtn" id="AddBz" type="button" value="添加" />
                <input class="BzBtn" id="CanBz" type="button" value="取消" />
            </div>
        </div>
    </div>
    </form>
</body>
</html>
