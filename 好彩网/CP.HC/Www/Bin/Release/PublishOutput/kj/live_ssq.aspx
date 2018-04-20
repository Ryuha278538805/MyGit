<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="live_ssq.aspx.cs" Inherits="Www.kj.live_ssq" %>
<%@ Register src="/header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="/footer.ascx" tagname="footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>双色球开奖直播视频 — 好彩网</title>
<meta http-equiv="X-UA-Compatible" content="IE=7" />
<link href="/css/css.css" rel="stylesheet" type="text/css" />
<style type="text/css">
<!--
#kaij3 a{ color:#333333;}
-->
</style>
</head>

<body>
<uc1:header ID="header1" runat="server" />
<div class="w1200" >
	<div style="margin-top:15px;"><script type="text/javascript" src="http://www.haocw.com/js/1.js"></script></div>
	<div id="kaij3">
	<table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#CCCCCC">
  <tr>
    <td height="19" align="center" bgcolor="#FFFFFF"><h1><a href="live_3d.html">福彩3D在线开奖直播</a>&nbsp;&nbsp; <a href="live_p3.html">排列三在线开奖直播</a>&nbsp;&nbsp; <a href="live_ssq.html">双色球开奖直播视频</a>&nbsp;&nbsp;</h1></td>
    </tr>
  <tr>
    <td height="30" align="center" bgcolor="#FFFFFF">双色球开奖视频高清直播 双色球在线开奖视频(每周二、四、日 21:30 )现场高清直播</td>
  </tr>
  <tr>
    <td bgcolor="#f4f4f4" valign="middle">
						  <div align="center" style="height:477px; overflow:hidden;">
						  <embed id="player1353380193314" width="640" height="515" flashvars="&domain=inner&sogouBtn=0&skin=0&vid=377&ltype=1&autoplay=true&pageurl=http://live.tv.sohu.com/cetv1&showCtrlBar=1&jump=0&sid=1211201055046405&ua=http://live.tv.&api_key=&tlogoad=http://tv.sohu.com/upload/swf/empty.swf|http://tv.sohu.com/upload/swf/time.swf&topBarFull=1" wmode="transparent" allowscriptaccess="always" allowfullscreen="true" bgcolor="#000000" quality="high" src="http://tv.sohu.com/upload/swf/lp0928/Main.swf" type="application/x-shockwave-flash" pluginspage="http://www.macromedia.com/go/getflashplayer">						   </div></td>
    </tr>
  <tr>
    <td height=30 align="center" valign="middle" bgcolor="#FFFFFF">双色球 第<%= GetQi(info.qi) %>期 开奖号 <strong style="color:#FF0000"><%= GetKjh(info.a)%> <%= GetKjh(info.b)%> <%= GetKjh(info.c)%> <%= GetKjh(info.d)%> <%= GetKjh(info.e)%> <%= GetKjh(info.f)%> + <%= GetKjh(info.g)%></strong> <a href="/kj/ssq/<%= info.qi%>.html">详细开奖</a></td>
  </tr>
</table>
	</div>
</div>

<div class="w1000 h8" >
<uc2:footer ID="footer1" runat="server" />
</div>
</body>
</html>
