<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="news_info_pic.aspx.cs" Inherits="Www.news.news_info_pic" %>
<%@ Register src="/header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="/footer.ascx" tagname="footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title><%=info.title%> - <%=GetNewsClassInfo(info.cid).name%>好彩网发布</title>
<meta name="keywords" content="<%=info.title%> <%=GetNewsClassInfo(info.cid).name%>" />
<meta name="description" content="<%=info.title%> <%=GetCutString(Common.Utils.RemoveHtml(info.context),30) %>" />
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

<div class="w1200 h8" >
	<div style="margin-top:15px;"><script type="text/javascript" src="/js/1.js"></script></div>
	<div class="title p14"><img src="/image/weizhit.gif" border="0" align="absmiddle" /><a href="/">好彩网首页</a><img src="/image/weizhij.gif" border="0" align="absmiddle" /><a href="/<%=GetNewsClassInfo(info.cid).ename%>/list.html"><%=GetNewsClassInfo(info.cid).name%></a><img src="/image/weizhij.gif" border="0" align="absmiddle" /><%=info.title%></div>

     <div class="h8"  style="text-align:center;clear:both; width:1198px;border-top: 2px solid #F00;border-left: 1px solid #ccc;border-right: 1px solid #ccc;border-bottom: 1px solid #ccc;" >
            <h1 style="font-size:16px; line-height:40px;"><%=info.title%></h1>
            <div style=" color:#666666; line-height:25px; font-size:12px;"><%=info.addtime.ToString("MM月dd日  HH:mm")%>  作者：<a href="#"><%=info.anthor %></a></div>
            <div class="picinfo" style="text-align:center">
                <%=info.context%>
                <div style="clear:both; height:15px;"></div>
            </div>
            
          <div class="lry_t">
			<div class="lry_shan">上一篇: <%=pre%></div>
			<div class="lry_xia">下一篇: <%=next%></div>
		  </div>
    </div>
</div>
<uc2:footer ID="footer1" runat="server" />
</body>
</html>