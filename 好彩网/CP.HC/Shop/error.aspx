<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="error.aspx.cs" Inherits="Shop.error" %>
<%@ Register TagPrefix="uc1" TagName="head" Src="head.ascx" %>
<%@ Register TagPrefix="uc1" TagName="bottom" Src="bottom.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>社区商店提示信息 — 好彩论坛</title>
  <meta name="keywords" content="社区商店,3d太湖字谜,太湖图库,太湖钓叟字谜,藏机图,红五3d图库,阿福图库,布衣图库,小军图库,3d一九图库等精华图片供大家" />
  <meta name="description" content="灵感往往来源于一瞬，或许号码恰巧隐藏于这短短玄机中！" />
  <meta http-equiv="x-ua-compatible" content="ie=7" /><%=refresh%>
  <link rel="icon" href="http://bbs.haocw.com/favicon.ico" type="image/x-icon" />
  <link rel="shortcut icon" href="http://bbs.haocw.com/favicon.ico" type="image/x-icon" />
  <link rel="stylesheet" href="http://bbs.haocw.com/templates/default/dnt.css" type="text/css" media="all" />
  <link rel="stylesheet" href="http://bbs.haocw.com/templates/default/float.css" type="text/css" />
  <link type="text/css" rel="stylesheet" href="http://bbs.haocw.com/templates/default/widthauto.css" id="css_widthauto" />
  <link rel="stylesheet" href="/css/css.css" type="text/css" media="all" />
  <script type="text/javascript">
      var creditnotice = '1|威望|,2|金钱|,3|彩贝|';
      var forumpath = "/";
  </script>
  <script type="text/javascript" src="http://bbs.haocw.com/javascript/jquery.js"></script>
  <script type="text/javascript"> jQuery.noConflict();</script>
  <script type="text/javascript" src="http://bbs.haocw.com/javascript/common.js"></script>
  <script type="text/javascript" src="http://bbs.haocw.com/javascript/template_report.js"></script>
  <script type="text/javascript" src="http://bbs.haocw.com/javascript/template_utils.js"></script>
  <script type="text/javascript" src="http://bbs.haocw.com/javascript/ajax.js"></script>
</head>
<body onkeydown="if(event.keyCode==27) return false;">
<uc1:head ID="head1" runat="server" />
   
 <div class="wrap uc c1">	
   	<div class="uc_main">
	<div class="uc_content">
		<div class="msgbox error_msg">
	<h3>提示信息</h3>
	<p><%=msg%></p>
	<p class="errorback">
		<script type="text/javascript"> if(true)	{document.write("<a href=\"javascript:history.back();\">返回上一步</a> &nbsp; &nbsp;|  ");}	</script>
		&nbsp; &nbsp; <a href="/">商店首页</a>		
		 <%if(er==1){%>&nbsp; &nbsp;|&nbsp; &nbsp; <a href="http://bbs.haocw.com/login.aspx">登录</a>&nbsp; &nbsp;|&nbsp; &nbsp; <a href="http://bbs.haocw.com/register.aspx">注册</a>		<%}%>
	</p>
</div>
	</div>
   </div>
</div>

    <uc1:bottom ID="bottom1" runat="server" />
</body>
</html>
