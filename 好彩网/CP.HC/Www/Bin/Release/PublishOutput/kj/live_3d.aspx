<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="live_3d.aspx.cs" Inherits="Www.kj.live_3d" %>
<%@ Register src="/header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="/footer.ascx" tagname="footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>福彩3D在线开奖直播  — 好彩网</title>
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
    <td height="30" align="center" bgcolor="#FFFFFF">福彩3D在线开奖(每天20:30-20:33直播)</td>
  </tr>
  <tr>
    <td  align="center" valign="middle" bgcolor="#f4f4f4">
		<iframe src="http://211.89.225.117/player_zgzs/play.html" width="222" height="100" frameborder="0" scrolling="no"></iframe>  </td>
    </tr>
  <tr>
    <td height="30"  align="center" valign="middle" bgcolor="#FFFFFF">福彩3D 第<%= GetQi(info.qi) %>期 试机号：<%=info.sjx %> <strong style="color:#FF0000"><%= info.sjh %></strong> 开奖号：<strong style="color:#FF0000"><%= info.a %> <%= info.b %> <%= info.c %></strong> <a href="/kj/3d/<%= info.qi%>.html">详细开奖</a></td>
  </tr>
</table>
	</div>
</div>


<div class="w1000 h8" >
<uc2:footer ID="footer1" runat="server" />
</div>
</body>
</html>
