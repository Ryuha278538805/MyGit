﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="yc_list.aspx.cs" Inherits="Www.yc.yc_list" %>
<%@ Register src="../header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="../footer.ascx" tagname="footer" tagprefix="uc2" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>福彩三D预测<%=yzinfo.name%> <%=GetPage()%>\胆码杀码推荐 - 好彩网</title>
<meta name="keywords" content="<%if(yzinfo.keywords!=null && yzinfo.keywords.Length>0){%><%=yzinfo.keywords%><%}else{%><%=yzinfo.name%><%}%>" />
<meta name="description" content="<%if(yzinfo.description!=null && yzinfo.description.Length>0){%><%=yzinfo.description%><%}else{%><%=yzinfo.name%><%}%>" />
<link rel="icon" href="/favicon.ico" type="image/x-icon" />
<link rel="shortcut icon" href="/favicon.ico" type="image/x-icon" />
<link href="/css/css.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="http://cbjs.baidu.com/js/m.js"></script>
<script type="text/javascript">
BAIDU_CLB_preloadSlots("731256","642651","730669","643928","680180","663798","632248","632247");
</script>
</head>

<body>
<uc1:header ID="header1" runat="server" />

<div class="w1200">
	<div style="margin-top:15px;"><script type="text/javascript" src="/js/1.js"></script></div>
	<div id="fen">
		<div class="left">
			<div class="title p14"><img src="/image/weizhit.gif" border="0" align="absmiddle" /><a href="/">好彩网首页</a><img src="/image/weizhij.gif" border="0" align="absmiddle" /><a href="/dsyc/index.html">胆码杀码推荐</a><%if(yzinfo.name!=null && yzinfo.name.Length>0){%><img src="../image/weizhij.gif" align="absmiddle" /><%=yzinfo.name%><%}%></div>
			<div class="list p14">
            <%i=0;%>
            <asp:Repeater ID="yclist" runat="server" EnableViewState="false">
            <ItemTemplate>
            <div class="txbox"><div class="tx1"><a href="/dsyc/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime")) %>/<%#DataBinder.Eval(Container.DataItem,"yid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "title").ToString().Trim()%>" target="_blank"><%#GetQi(DataBinder.Eval(Container.DataItem, "qi"))%>期 <%#DataBinder.Eval(Container.DataItem, "name").ToString().Trim()%></a></div></div>		
             <%i++;%><%if(i%10==0){%><hr color="#FFFFFF"; style="width:750px;height:0px; border-top:1px #CCC dashed; margin:0 0 10px 0;"><%}%>
            </ItemTemplate>
            </asp:Repeater>            
			</div>
			
			<div style="font-size:14px; text-align:center; line-height:40px;"><webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" 
FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PagingButtonSpacing="8px" PrevPageText="上一页" PageSize="50"  EnableUrlRewriting="True" UrlPaging="True" ShowInputBox="Never"></webdiyer:AspNetPager></div>
	</div>
	
	</div>
	<div id="dhtj" style="margin-left:15px;">
	<script type="text/javascript" src="/js/6.js"></script>
		<div class="title_k">
		<div class="title p14"><a href="/dsyc/index_1.html">胆码推荐</a></div>
		<div class="title_t p12"><a href="/dsyc/index_1.html">独胆</a>  <a href="/dsyc/index_2.html">双胆</a> <a href="/dsyc/index_3.html">三胆</a></div>
		</div>
		<div class="t_box">
		<asp:Repeater ID="danmalist" runat="server" EnableViewState="false"><ItemTemplate>
             <%#GetTop2YcInfoStrByYZID(DataBinder.Eval(Container.DataItem,"yzid"))%>
            </ItemTemplate></asp:Repeater>		
		</div>
	<script type="text/javascript" src="/js/yx.js"></script>
	</div>
	
	<div style=" float:right;margin-top:15px;"><a href="/jpt/list.html"><img src="/image/jptgg.gif" width="379" height="67" border="0" /></a></div>
	<div style=" float:right;margin-top:15px;"><a href="/sdhot/list.html"><img src="/image/rmgg.gif" width="379" height="67" border="0" /></a></div>
	<div style=" float:right;margin-top:15px;"><a href="/dyt/list.html"><img src="/image/djgg.gif" width="379" height="67" border="0" /></a></div>
	
	<div id="dhtj" style="margin-left:15px;">
		<div class="title_k">
		<div class="title p14"><a href="/dsyc/index_1.html">杀码推荐</a></div>
		<div class="title_t p12"><a href="/dsyc/index_4.html">杀一码</a>  <a href="/dsyc/index_5.html">杀二码</a></div>
		</div>
		<div class="t_box">
		<asp:Repeater ID="shamalist" runat="server" EnableViewState="false"><ItemTemplate>
             <%#GetTop2YcInfoStrByYZID(DataBinder.Eval(Container.DataItem,"yzid"))%>
            </ItemTemplate></asp:Repeater>		
		</div>
	</div>
</div>

<div class="w1000 h8" >
<uc2:footer ID="footer1" runat="server" />
</div>
</body>
</html>