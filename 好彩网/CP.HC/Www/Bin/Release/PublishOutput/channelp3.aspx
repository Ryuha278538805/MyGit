﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="channelp3.aspx.cs" Inherits="Www.channelp3" %>
<%@ Register src="header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="footer.ascx" tagname="footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>体彩P3频道-好彩网\好彩网首页\好彩论坛\好彩3d</title>
<meta http-equiv="X-UA-Compatible" content="IE=7" />
<meta name="keywords" content="好彩网,P3图库，布衣图库，红五图谜汇总" />
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
			<div class="img"><img src="image/jian.jpg"  alt="体彩P3开奖结果"/></div>
			<div class="tm p12">第<%=info.qi%>期体彩P3开奖结果</div>
		</div>
 		<div class="kjh p12">
		  <div  style=" float:left; margin-left:15px;">开奖号:</div>
		  <div class="red"><%=info.a%></div>
		  <div class="red"><%=info.b%></div>
		  <div class="red"><%=info.c%></div>
		  <div  style=" float:left; margin-left:15px; display:none;">试机号:</div> 
		  <div style="display:none;" class="org">7</div>
		  <div style="display:none;" class="org">4</div>
		  <div style="display:none;" class="org">1</div>
		</div>
 		<div class="kjxq p12">
		<div  style=" float:left; width:40px;">期号</div>
		<div  style=" float:left; width:80px;">开奖日期</div> 
		<div  style=" float:left; width:80px;">开奖结果</div> 
		<div  style=" float:left; width:80px;">直选注数</div> 
		<div  style=" float:left; width:40px;">详情</div> 
		</div><%i=0;%>
		<table width="100%" border="0" cellspacing="0" cellpadding="0" style="float:left;">
	      <asp:Repeater ID="kjhlist" runat="server" EnableViewState="false"><ItemTemplate>
		  <tr>
			<td<%if(i==0){%> width="40"<%}%> height="24"><%#GetQi(DataBinder.Eval(Container.DataItem,"qi"))%></td>
			<td<%if(i==0){%> width="80"<%}%>><%#GetDate(DataBinder.Eval(Container.DataItem,"date"))%></td>
			<td<%if(i==0){%> width="80"<%}%>><%#DataBinder.Eval(Container.DataItem,"a")%>, <%#DataBinder.Eval(Container.DataItem,"b")%>, <%#DataBinder.Eval(Container.DataItem,"c")%></td>
			<td<%if(i==0){%> width="80"<%}%>><%#DataBinder.Eval(Container.DataItem,"zj1")%></td>
			<td<%if(i==0){%> width="40"<%}%>><a href="/kj/p3/<%#DataBinder.Eval(Container.DataItem,"qi")%>.html" target="_blank">详情</a></td>
			</tr>
          </ItemTemplate></asp:Repeater>		  
		</table>
 	</div>
	<div id="xbao">
		<div class="top">体彩P3预测字谜</div>
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
				<div class="tx1" ><a href="#">体彩P3排行榜</a></div>
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
					<div class="rq" >最新排列三论坛贴</div>
					<div class="gd" ><a href="http://bbs.haocw.com/showforum-9.aspx" target="_blank">进入论坛</a></div>
                    <div class="txt" style="height:215px;">
                        <asp:Repeater ID="bbsp3list" runat="server" EnableViewState="false"><ItemTemplate>
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
						<div class="lanmm bh" ><span class="title">体彩P3预测</span><span class="more"><a href="/p3yc/list.html" target="_blank">更多...</a></span></div>
						<div class="lanmm" ><span class="title">体彩P3字谜</span><span class="more"><a href="/p3zm/list.html" target="_blank">更多...</a></span></div>
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
                <div class="lanmm bh" >&nbsp;&nbsp;<a href="/p3sy/list.html">相关术语 </a> </div>
                <div class="lanmm bh" >&nbsp;&nbsp;技巧方法 </div>
                <div class="lanmm" >&nbsp;&nbsp;中奖规则</div>
            </div>
            <div class="xiak">
                <div class="lbtxt p12" >
                    <div class="tk"><A title="排列三什么是<形态>名词解释-<形态>值是什么意思?" href="/p3sy/1130/1751.html" target="_blank">形态</A></div>
                    <div class="tk"><A title="排列三什么是<两码>名词解释-<两码>值是什么意思?" href="/p3sy/1130/1750.html" target="_blank">两码</A></div>
                    <div class="tk"><A title="排列三什么是<大小奇偶>名词解释-<大小奇偶>值是什么意思?" href="/p3sy/1130/1749.html" target="_blank">大小奇偶</A></div>
                    <div class="tk"><A title="排列三什么是<合数>名词解释-<合数>值是什么意思?" href="/p3sy/1130/1748.html" target="_blank">合数</A></div>
                    <div class="tk"><A title="排列三什么是<和值>名词解释-<和值>值是什么意思?" href="/p3sy/1130/1747.html" target="_blank">和值</A></div>
                    <div class="tk"><A title="排列三什么是<定位>名词解释-<定位>值是什么意思?" href="/p3sy/1130/1746.html" target="_blank">定位</A></div>
                    <div class="tk"><A title="排列三什么是<传递、加减>名词解释-<传递、加减>值是什么意思?" href="/p3sy/1130/1745.html" target="_blank">传递、加减</A></div>
                    <div class="tk"><A title="排列三什么是<码>名词解释-<码>值是什么意思?" href="/p3sy/1130/1744.html" target="_blank">码 值</A></div>
                    <div class="tk"><A title="排列三什么是遗漏值名词解释-遗漏值是什么意思?" href="/p3sy/1130/1743.html" target="_blank">遗漏值</A></div>
                    <div class="tk"><A title="排列三什么是邻孤传名词解释-邻孤传是什么意思?" href="/p3sy/1130/1742.html" target="_blank">邻孤传</A></div>
                    <div class="tk"><A title="排列三什么是热温冷名词解释-热温冷是什么意思?" href="/p3sy/1130/1741.html" target="_blank">热温冷</A></div>
                    <div class="tk"><A title="排列三什么是号码特性名词解释-号码特性是什么意思?" href="/p3sy/1130/1740.html" target="_blank">号码特性</A></div>
                    <div class="tk"><A title="排列三什么是跨度名词解释-跨度是什么意思?" href="/p3sy/1130/1739.html" target="_blank">跨度</A></div>
                    <div class="tk"><A title="排列三什么是合值、和值名词解释-合值、和值是什么意思?" href="/p3sy/1130/1738.html" target="_blank">合值、和值</A></div>
                    <div class="tk"><A title="排列三什么是组三、组六、豹子名词解释-组三、组六、豹子是什么意思?" href="/p3sy/1130/1737.html" target="_blank">组三组六豹子</A></div>
                    <div class="tk"><A title="排列三什么是复合跨度名词解释-复合跨度是什么意思?" href="/p3sy/1130/1736.html" target="_blank">复合跨度</A></div>
                    <div class="tk"><A title="排列三什么是余数和名词解释-余数和是什么意思?" href="/p3sy/1130/1735.html" target="_blank">余数和</A></div>
                    <div class="tk"><A title="排列三什么是聪明组六名词解释-聪明组六是什么意思?" href="/p3sy/1130/1734.html" target="_blank">聪明组六</A></div>
                    <div class="tk"><A title="排列三什么是位差位和名词解释-位差位和是什么意思?" href="/p3sy/1130/1733.html" target="_blank">位差位和</A></div>
                    <div class="tk"><A title="排列三什么是排三合值名词解释-排三合值是什么意思?" href="/p3sy/1130/1732.html" target="_blank">排三合值</A></div>       
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
