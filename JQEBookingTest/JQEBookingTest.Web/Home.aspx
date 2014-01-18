<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html content="text/html; charset=utf-8" />
<head>
<link href="Styles/bootstrap.css" rel="stylesheet" type="text/css" />
<link href="Styles/Style.css" rel="stylesheet" type="text/css" />
<link href="Styles/OrderQuery.css" rel="stylesheet" type="text/css" />
<link href="Styles/jquery-ui-1.10.0.custom.css" rel="stylesheet" type="text/css" />
<script src="Scripts/jquery-1.10.2.min.js" type="text/javascript"></script>
<script src="Scripts/jquery-ui-1.10.0.custom.min.js" type="text/javascript"></script>
<script src="Scripts/OrderQuery.js" type="text/javascript"></script>
<script src="Scripts/JScript.js" type="text/javascript"></script>
<title></title>
</head>
<body>
    <form runat="server" id="formQueryCondition">
<div class="head">
	<div class="mainnav navbar">
		<ul class="nav navbar-nav nav-pills pull-left">
			<li><a href="#">首页</a></li>
			<li class="active"><a href="#">订单查询</a></li>
			<li><a href="#">订单确认</a></li>
			<li><a href="#">订单统计</a></li>
			<li><a href="#">点评管理</a></li>
		</ul>
		<ul class="nav navbar-nav nav-tabs pull-right">
			<li><a href="#">zhouzhuang，您好</a></li>
			<li><a href="#">[修改密码]</a></li>
			<li><a href="#">[安全退出]</a></li>
		</ul>
	</div>
</div>
<div class="query-condition">
	<h4>查询条件：</h4>
	<ul>
		<li><div>日期选择：</div>
            <asp:RadioButton ID="raidoCreateTime" runat="server" Checked="true" GroupName="date" />
			<input type="radio" id="CreateTime" name="QTime" /><label for="CreateTime">下单时间</label>
			<asp:RadioButton ID="raidoTravelTime" runat="server" name="date" GroupName="date"  />
			<input type="radio" id="TravelTime" name="QTime" /><label for="TravelTime">取票时间</label>
		</li>
		<li> <div>起始日期：</div>
			<input type="text" id="textStartDate" runat="server" style="width:80px;" />
			截止日期：
			<input type="text" id="textEndDate" runat="server" style="width:80px;"/>
		</li>
		<li> <div>订单号：</div>
			<input id="textSerialNum" runat="server" type="text" />
		</li>
	</ul>
	<ul>
		<li><div>订单确认号：</div>
			<input id="textConfirmNum" runat="server" type="text" />
		</li>
		<li><div>客人姓名：</div>
			<input id="textTakerName" runat="server" type="text" />
			（可模糊查询） </li>
		<li><div>取票人手机：</div>
			<input id="textTakerPhone" runat="server" type="text" />
		</li>
	</ul>
	<ul>
		<li><div> 订单状态：</div>
			<select id="selectOrderStatus" runat="server">
				<option>全部</option>
				<option>新订单</option>
				<option>已核单</option>
				<option>NoShow</option>
				<option>景区确认</option>
			</select>
		</li>
		<li><div> 门票排序：</div>
			<select id="selectTicketOrderWay" runat="server">
				<option>取票人姓名</option>
				<option>游玩日期</option>
				<option>下单日期</option>
			</select>
			<select id="selectTicketOrder" runat="server">
				<option>升序</option>
				<option>降序</option>
			</select>
		</li>
		<li style="width:200px;"><div> 支付方式：</div>
			<select id="selectPaymentMode" runat="server">
				<option>全部</option>
				<option>景区到付</option>
				<option>在线支付</option>
			</select>
		</li>
        <button class="btn-query btn btn-primary">查询</button>
        <asp:Button ID="buttonDoQuery" runat="server" Text="查询" CssClass="btn-query btn btn-primary" onclick="buttonDoQuery_Click"/>
                <asp:Button ID="buttonExcelOut" runat="server" Text="导出" CssClass="btn-query btn btn-primary" onclick="buttonExcelOut_Click" />
	</ul>
</div>


    <table class="table table-bordered table-hover" id="showtable" runat="server">
            <tr  class="success">
			    <td>确认号</td>
			    <td>订单流水号</td>
			    <td>状态</td>
			    <td>取票人</td>
			    <td>取票人手机</td>
			    <td>下单时间</td>
			    <td>旅游时间</td>
			    <td>票数</td>
			    <td>单价</td>
			    <td>总金额</td>
			    <td>门票类型</td>
			    <td>备注</td>
		    </tr>
	</table>
    <div style="float: right; right: 50px; border-right-width: 30px; margin-right: 50px;">
        <asp:PlaceHolder ID="placeHolder" runat="server"></asp:PlaceHolder>
    </div>
    </form>
</body>
</html>
