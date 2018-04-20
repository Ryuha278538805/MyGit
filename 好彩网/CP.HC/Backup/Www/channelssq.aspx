<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="channelssq.aspx.cs" Inherits="Www.channelssq" %>
<%@ Register src="header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="footer.ascx" tagname="footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>福彩双色球频道-好彩网\好彩网首页\好彩论坛\好彩3d</title>
<meta http-equiv="X-UA-Compatible" content="IE=7" />
<meta name="keywords" content="好彩网,双色球图库，布衣图库，红五图谜汇总" />
<meta name="description" content="好彩网致力于彩票资讯、3D图谜、3D字谜、3d预测、开奖公告、双色球开奖号等。" />
<link rel="icon" href="/favicon.ico" type="image/x-icon" />
<link rel="shortcut icon" href="/favicon.ico" type="image/x-icon" />
<link href="/css/css.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="/js/jquery-1.8.0.min.js"></script>
</head>

<body>
<uc1:header ID="header1" runat="server" />
<div class="w1000" >

	<div id="zq">
		<div class="top">
			<div class="img"><img src="image/jian.jpg"  alt="福彩双色球开奖结果"/></div>
			<div class="tm p12">第<%=info.qi%>期福彩双色球开奖结果</div>
		</div>
 		<div class="kjh p12">
		  <div  style=" float:left; margin-left:15px;">开奖号:</div>
		  <div class="red"><%=GetKjh(info.a)%></div>
          <div class="red"><%=GetKjh(info.b)%></div>
		  <div class="red"><%=GetKjh(info.c)%></div>
          <div class="red"><%=GetKjh(info.d)%></div>
          <div class="red"><%=GetKjh(info.e)%></div>
          <div class="red"><%=GetKjh(info.f)%></div>
          <div class="blue"><%=GetKjh(info.g)%></div>
		</div>
 		<div class="kjxq p12">
		<div  style=" float:left; width:40px;">期号</div>
		<div  style=" float:left; width:80px;">开奖日期</div> 
		<div  style=" float:left; width:160px;">开奖结果</div> 
		<div  style=" float:left; width:40px;">详情</div> 
		</div><%i=0;%>
		<table width="100%" border="0" cellspacing="0" cellpadding="0" style="float:left;">
	      <asp:Repeater ID="kjhlist" runat="server" EnableViewState="false"><ItemTemplate>
		  <tr>
			<td<%if(i==0){%> width="40"<%}%> height="24"><%#GetQi(DataBinder.Eval(Container.DataItem,"qi"))%></td>
			<td<%if(i==0){%> width="80"<%}%>><%#GetDate(DataBinder.Eval(Container.DataItem,"date"))%></td>
			<td<%if(i==0){%> width="160"<%}%>><%#GetKjh(DataBinder.Eval(Container.DataItem,"a"))%> <%#GetKjh(DataBinder.Eval(Container.DataItem,"b"))%> <%#GetKjh(DataBinder.Eval(Container.DataItem,"c"))%> <%#GetKjh(DataBinder.Eval(Container.DataItem,"d"))%> <%#GetKjh(DataBinder.Eval(Container.DataItem,"e"))%> <%#GetKjh(DataBinder.Eval(Container.DataItem,"f"))%> -<%#GetKjh(DataBinder.Eval(Container.DataItem,"g"))%></td>
			<td<%if(i==0){%> width="40"<%}%>><a href="/kj/ssq/<%#DataBinder.Eval(Container.DataItem,"qi")%>.html" target="_blank">详情</a></td>
			</tr>
		  </ItemTemplate></asp:Repeater>	
		</table> 
 	</div>
	<div id="xbao">
		<div class="top">福彩双色球预测字谜</div>
		<div class="txt p14"><%i=0;%>
		<asp:Repeater ID="topnewslist" runat="server" EnableViewState="false"><ItemTemplate>
             <div class="tm<%if(i==4){%> hs8<%}%>"><a href="/<%#GetNewsClassInfo(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"cid"))).ename %>/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime")) %>/<%#DataBinder.Eval(Container.DataItem,"nid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "title")%>" target="_blank">· <%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),38)%></a></div><div class="ty<%if(i==4){%> hs8<%}%>"><%#GetQi(DataBinder.Eval(Container.DataItem,"qi"))%>期</div> <div class="tim<%if(i==4){%> hs8<%}%>"><%#GetDate(DataBinder.Eval(Container.DataItem,"addtime"))%></div><%i++;%>
        </ItemTemplate></asp:Repeater>
		</div>
	</div>
	<div id="flone" >
	<div class="wk">
		<div class="lbk" >
			<div class="lbtop p14" >
				<div class="tx1" ><a href="#">福彩双色球排行榜</a></div>
				<div class="tx2 p12" ><a href="#">更多</a></div>
				<div class="fenl p12" >
					<div class="timu1"><a href="javascript:void(0);" class="tab" onmouseover="switchmenus(1)" id="nav1">独胆</a></div>
					<div class="timu1"><a href="javascript:void(0);"  onmouseover="switchmenus(2)" id="nav2">双胆</a></div>
					<div class="timu1"><a href="javascript:void(0);"  onmouseover="switchmenus(3)" id="nav3">三胆</a></div>
					<div class="timu1"><a href="javascript:void(0);"  onmouseover="switchmenus(4)" id="nav4">五码</a></div>

				</div>
					<div class="txt" style="width:50px;">名次</div>
					<div class="txt" style="width:50px;">专家</div>
					<div class="txt" style="width:40px;">成绩</div>
					<div class="txt" style="width:40px;">排名</div>
			</div>
		</div>
		<div class="timu2">
		<div class="table" id="table1">
		<table width="188" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="#C4DCF1">
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
	 	</table>
		</div>
		<div class="table" id="table2" style="display:none;">
		<table width="188" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="#C4DCF1">
		  <tr>
			<td height="21" bgcolor="#FFFFFF">1</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
	 	</table>
		</div>
		<div class="table" id="table3" style="display:none;">
		<table width="188" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="#C4DCF1">
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
	 	</table>
		</div>
		<div class="table" id="table4" style="display:none;">
		<table width="188" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="#C4DCF1">
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
		  <tr>
			<td height="21" bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
			<td bgcolor="#FFFFFF">&nbsp;</td>
		  </tr>
	 	</table>
		</div>
	</div>
  </div>
	</div>
</div>
<div class="w1000 h8" style="display:none;">
	<div id="zjtj">
	<div class="grb">
		<div class="grbbg p12">
			<div class="bg">推荐专家</div>
				<div class="timu1"><a href="javascript:void(0);"  onmouseover="switchmenusss(9)"  class="tab" id="nav9">福彩3D</a></div>
				<div class="timu1"><a href="javascript:void(0);"  onmouseover="switchmenusss(10)" class="tab"id="nav10">排列三</a></div>
				<div class="timu1"><a href="javascript:void(0);"  onmouseover="switchmenusss(11)" class="tab"id="nav11">双色球</a></div>
				<div class="bg3">&nbsp;</div>
				<div class="table" id="table9">
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
				</div>
				
				<div class="table" id="table10" style="display:none;">
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
				</div>
				
				<div class="table" id="table11" style="display:none;">
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
					<div class="txt">
						<div class="tx"><a href="#">用户名</a></div>
						<div class="tx1"><a href="#">个人专栏</a></div><div class="tx2"><a href="#">成绩</a></div>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>

<div class="w1000 h8" >
	<div id="pingdao" >
		<div class="top" >
			<div class="tup" ><img src="image/p3.jpg" /></div>
			<div class="gjz p12" >
				<asp:Repeater ID="zonelist" runat="server" EnableViewState="false"><ItemTemplate>
                  <div><a href="<%#GetZoneNewsUrl(DataBinder.Eval(Container.DataItem, "zid"))%>" title="<%#DataBinder.Eval(Container.DataItem, "name").ToString().Trim()%>" target="_blank"><%#GetCutString(DataBinder.Eval(Container.DataItem, "name").ToString().Trim(),10)%></a></div>
                 </ItemTemplate></asp:Repeater>    
			</div>
		</div>
		<div class="lur" >
			<div class="rqleft" >
				<div class="renqi p12" >
					<div class="rq" >最新双色球论坛贴</div>
					<div class="gd" ><a href="http://bbs.haocw.com/showforum-7.aspx" target="_blank">进入论坛</a></div>
                    <div class="txt" style="height:215px;">
                        <asp:Repeater ID="bbsssqlist" runat="server" EnableViewState="false"><ItemTemplate>
                    	<div class="tx"><a href="http://bbs.haocw.com/showtopic-<%#DataBinder.Eval(Container.DataItem, "tid").ToString().Trim()%>.aspx" target="_blank" title="<%#DataBinder.Eval(Container.DataItem, "title").ToString().Trim()%>"> <%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),28)%></a></div>
                    	</ItemTemplate></asp:Repeater> 
                    </div>
				</div>
				<div class="bd_200 h8" >
					
					<div class="t">

<script type="text/javascript">
/*200*200，创建于2011-1-21*/
var cpro_id = "u358808";
</script>
<script src="http://cpro.baidustatic.com/cpro/ui/c.js" type="text/javascript"></script>

					</div>
				</div>
				</div>
				<div class="lbright" >
					<div class="lbtop p14" >
						<div class="lanmm bh" ><span class="title">福彩双色球预测</span><span class="more"><a href="/ssqyc/list.html" target="_blank">更多...</a></span></div>
						<div class="lanmm" ><span class="title">福彩双色球字谜</span><span class="more"><a href="/ssqzm/list.html" target="_blank">更多...</a></span></div>
					</div>
					<div class="lbtxt p12" >
						<asp:Repeater ID="yclist" runat="server" EnableViewState="false"><ItemTemplate>                                               
                        <div><div class="tx1"><a href="/<%#GetNewsClassInfo(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"cid"))).ename %>/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime")) %>/<%#DataBinder.Eval(Container.DataItem,"nid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "title")%>" target="_blank"><%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),32)%></a></div><div class="tx2"><%#GetQi(DataBinder.Eval(Container.DataItem,"qi"))%>期</div><div class="tx3"><%#GetDate(DataBinder.Eval(Container.DataItem,"addtime"))%></div></div>
                        </ItemTemplate></asp:Repeater>
					</div>
					<div class="lbtxt p12" >
						<asp:Repeater ID="zmlist" runat="server" EnableViewState="false"><ItemTemplate>
                        <div><div class="tx1"><a href="/<%#GetNewsClassInfo(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"cid"))).ename %>/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime")) %>/<%#DataBinder.Eval(Container.DataItem,"nid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "title")%>" target="_blank"><%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),32)%></a></div><div class="tx2"><%#GetQi(DataBinder.Eval(Container.DataItem,"qi"))%>期</div><div class="tx3"><%#GetDate(DataBinder.Eval(Container.DataItem,"addtime"))%></div></div>
                        </ItemTemplate></asp:Repeater>
					</div>
				</div>
			</div>
		</div>

    <div id="zjtjs">
        <div class="lbright" >
            <div class="lbtop p14" >
                <div class="lanmm bh" >&nbsp;&nbsp;<a href="/ssqsy/index.html">相关术语</a> </div>
                <div class="lanmm bh" >&nbsp;&nbsp;技巧方法 </div>
                <div class="lanmm" >&nbsp;&nbsp;中奖规则</div>
            </div>
            <div class="xiak">
                <div class="lbtxt p12" >
                    <div class="tk"><A title="双色球什么是5行相生相克码解释-5行相生相克码是什么意思？" href="/ssqsy/1129/1517.html" target="_blank">5行相生相克</A></div>
                    <div class="tk"><A title="双色球什么是五行取数解释-五行取数是什么意思？" href="/ssqsy/1129/1516.html" target="_blank">五行取数</A></div>
                    <div class="tk"><A title="双色球什么是相关性解释-相关性是什么意思？" href="/ssqsy/1129/1515.html" target="_blank">相关性</A></div>
                    <div class="tk"><A title="双色球什么是整体走势解释-整体走势是什么意思？" href="/ssqsy/1129/1514.html" target="_blank">整体走势</A></div>
                    <div class="tk"><A title="双色球什么是概率守恒定律解释-概率守恒定律是什么意思？" href="/ssqsy/1129/1513.html" target="_blank">概率守恒定律</A></div>
                    <div class="tk"><A title="双色球什么是随出有缘性解释-随出有缘性是什么意思？" href="/ssqsy/1129/1512.html" target="_blank">随出有缘性</A></div>
                    <div class="tk"><A title="双色球什么是聚集和远距解释-聚集和远距是什么意思？" href="/ssqsy/1129/1511.html" target="_blank">聚集和远距</A></div>
                    <div class="tk"><A title="双色球什么是万能23红球解释-万能23红球是什么意思？" href="/ssqsy/1129/1510.html" target="_blank">万能23红球</A></div>
                    <div class="tk"><A title="双色球什么是和值分析解释-和值分析是什么意思？" href="/ssqsy/1129/1509.html" target="_blank">和值分析</A></div>
                    <div class="tk"><A title="双色球什么是旋转矩阵解释-旋转矩阵是什么意思？" href="/ssqsy/1129/1508.html" target="_blank">旋转矩阵</A></div>
                    <div class="tk"><A title="双色球什么是黄金分割解释-黄金分割是什么意思？" href="/ssqsy/1129/1507.html" target="_blank">黄金分割</A></div>
                    <div class="tk"><A title="双色球什么是连码组数解释-连码组数是什么意思？" href="/ssqsy/1129/1506.html" target="_blank">连码组数</A></div>
                    <div class="tk"><A title="双色球什么是连码解释-连码是什么意思？" href="/ssqsy/1129/1505.html" target="_blank">连码</A></div>
                    <div class="tk"><A title="双色球什么是除三、除五、除七名词解释-除三、除五、除七是什么意思？" href="/ssqsy/1129/1504.html" target="_blank">除三、除五</A></div>
                    <div class="tk"><A title="双色球什么是中奖号码模式名词解释-中奖号码模式是什么意思？" href="/ssqsy/1129/1503.html" target="_blank">中奖号码模式</A></div>
                    <div class="tk"><A title="双色球什么是质数名词解释-质数是什么意思？" href="/ssqsy/1129/1502.html" target="_blank">质数</A></div>
                    <div class="tk"><A title="双色球什么是缩水公式名词解释-缩水公式是什么意思？" href="/ssqsy/1129/1501.html" target="_blank">缩水公式</A></div>
                    <div class="tk"><A title="双色球什么是首尾间距名词解释-首尾间距是什么意思？" href="/ssqsy/1129/1500.html" target="_blank">首尾间距</A></div>
                    <div class="tk"><A title="双色球什么是最大间距名词解释-最大间距是什么意思？" href="/ssqsy/1129/1499.html" target="_blank">最大间距</A></div>
                    <div class="tk"><A title="双色球什么是号码间距名词解释-号码间距是什么意思？" href="/ssqsy/1129/1498.html" target="_blank">号码间距</A></div>
                    <div class="tk"><A title="双色球什么是数据密度名词解释-数据密度是什么意思？" href="/ssqsy/1129/1497.html" target="_blank">数据密度</A></div>
                    <div class="tk"><A title="双色球什么是间距密度名词解释-间距密度是什么意思？" href="/ssqsy/1129/1496.html" target="_blank">间距密度</A></div>
                    <div class="tk"><A title="双色球什么是右斜码名词解释-右斜码是什么意思？" href="/ssqsy/1129/1495.html" target="_blank">右斜码</A></div>
                    <div class="tk"><A title="双色球什么是左斜码名词解释-左斜码是什么意思？" href="/ssqsy/1129/1494.html" target="_blank">左斜码</A></div>
            
                </div>
                <div class="lbtxt p12" >
                    <asp:Repeater ID="jqfflist" runat="server" EnableViewState="false"><ItemTemplate>
                    <div class="tx1"><a href="/<%#GetNewsClassInfo(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"cid"))).ename %>/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime")) %>/<%#DataBinder.Eval(Container.DataItem,"nid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "title")%>" target="_blank"><%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),28)%></a></div><div class="tx3"><%#GetDate(DataBinder.Eval(Container.DataItem,"addtime"))%></div>
                    </ItemTemplate></asp:Repeater>
                </div>
                <div class="lbtxt p12" >
                    <asp:Repeater ID="zjgzlist" runat="server" EnableViewState="false"><ItemTemplate>
                    <div class="tx1"><a href="/<%#GetNewsClassInfo(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"cid"))).ename %>/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime")) %>/<%#DataBinder.Eval(Container.DataItem,"nid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "title")%>" target="_blank"><%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),28)%></a></div><div class="tx3"><%#GetDate(DataBinder.Eval(Container.DataItem,"addtime"))%></div>
                    </ItemTemplate></asp:Repeater>  
                </div>
            </div>
        </div>
    </div>
</div>

<div class="w1000 h8" >
<uc2:footer ID="footer1" runat="server" />
</div>
</body>
</html>
