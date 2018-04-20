<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dlt_list.aspx.cs" Inherits="Www.kj.dlt_list" %>
<%@ Register src="/header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="/footer.ascx" tagname="footer" tagprefix="uc2" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>大乐透开奖公告 - 太湖彩票网</title>
<meta name="description" content="开奖公告" /> 
<link href="/css/css.css" rel="stylesheet" type="text/css" />
</head>
<body>
<uc1:header ID="header1" runat="server" />
<div class="w1200" >
	<div style="margin-top:15px;"><script type="text/javascript" src="http://www.haocw.com/js/1.js"></script></div>
	<div id="kaij2">
		<h1>大乐透开奖公告</h1>
		<div class="top p14">
			<div class="w1">期号</div>
			<div class="w2">中奖号码</div>
			<div class="w3">总销售额</div>
			<div class="w4">一等奖</div>
			<div class="w4">一等奖金</div>
		  <div class="w4">追加一等奖</div>
			<div class="w4">追一等奖金</div>
		  <div class="w4">二等奖</div>
			<div class="w4">二等奖金</div>
			<div class="w3">开奖日期</div>
			<div class="w5">详情</div>
		</div>
        <asp:Repeater ID="kjhlist" runat="server" EnableViewState="false"><ItemTemplate>
		<div class="lin p12">        	
			<div class="w1"><%#DataBinder.Eval(Container.DataItem,"qi")%></div>
			<div class="w2">
				 <div class="red"><%#GetKjh(DataBinder.Eval(Container.DataItem,"a"))%></div>
				 <div class="red"><%#GetKjh(DataBinder.Eval(Container.DataItem,"b"))%></div>
				 <div class="red"><%#GetKjh(DataBinder.Eval(Container.DataItem,"c"))%></div>
                 <div class="red"><%#GetKjh(DataBinder.Eval(Container.DataItem,"d"))%></div>
                 <div class="red"><%#GetKjh(DataBinder.Eval(Container.DataItem,"e"))%></div>
                 <div class="blue"><%#GetKjh(DataBinder.Eval(Container.DataItem,"f"))%></div>
                 <div class="blue"><%#GetKjh(DataBinder.Eval(Container.DataItem,"g"))%></div>
			</div>
			<div class="w3"><%#GetNumStr(DataBinder.Eval(Container.DataItem,"tzmoney").ToString())%></div>
			<div class="w4"><%#DataBinder.Eval(Container.DataItem,"zj1")%></div>
			<div class="w4"><%#GetNumStr(DataBinder.Eval(Container.DataItem,"jo1").ToString())%></div>
			<div class="w4"><%#DataBinder.Eval(Container.DataItem,"zzj1")%></div>
			<div class="w4"><%#GetNumStr(DataBinder.Eval(Container.DataItem,"zjo1").ToString())%></div>
			<div class="w4"><%#GetNumStr(DataBinder.Eval(Container.DataItem,"zj2").ToString())%></div>
			<div class="w4"><%#GetNumStr(DataBinder.Eval(Container.DataItem,"jo2").ToString())%></div>
			<div class="w3"><%#GetDateStr(DataBinder.Eval(Container.DataItem,"date"))%></div>
			<div class="w5"><a href="/kj/dlt/<%#DataBinder.Eval(Container.DataItem,"qi")%>.html"><img src="/image/xiangqing.jpg" alt="详情"  border="0"/></a></div>
		</div>
		</ItemTemplate></asp:Repeater>	
         <div class="pag p14"><webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" 
FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PagingButtonSpacing="8px" PrevPageText="上一页" PageSize="18"  EnableUrlRewriting="True" UrlPaging="True" ShowInputBox="Never"></webdiyer:AspNetPager></div>	
	</div>
</div>

<div class="w1000 h8" >
<uc2:footer ID="footer1" runat="server" />
</div>
</body>
</html>