<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="goods.aspx.cs" Inherits="Shop.goods" %>
<%@ Register TagPrefix="uc1" TagName="head" Src="head.ascx" %>
<%@ Register TagPrefix="uc1" TagName="bottom" Src="bottom.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>社区商店 — 好彩论坛</title>
  <meta name="keywords" content="社区商店,3d太湖字谜,太湖图库,太湖钓叟字谜,藏机图,红五3d图库,阿福图库,布衣图库,小军图库,3d一九图库等精华图片供大家" />
  <meta name="description" content="灵感往往来源于一瞬，或许号码恰巧隐藏于这短短玄机中！" />
  <meta http-equiv="x-ua-compatible" content="ie=7" />
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
    
 <div class="wrap cl">
   <div id="forumheader" class="main cl">
        <h1><%=ginfo.gname%></h1>
          <span class="forumstats">销量: <strong class="xi1"><%=ginfo.countselled%></strong> <span class="pipe">|</span>总量: <strong class="xi1"><%=ginfo.count%></strong></span>
   </div>
     
   <table cellspacing="0" cellpadding="0" width="100%" class="goodsinfotb">
        <tbody>
            <tr>
              <td width="50%" rowspan="9"><div align="center"><img class="gimg" src="<%=ginfo.img%>"  alt="<%=ginfo.gname%>" align="absmiddle"/></div></td>
              <td colspan="2"><div id="name"><h2><%=ginfo.gname%> </h2>&nbsp;&nbsp;&nbsp;&nbsp;<span class="hits">热门指数:<%=ginfo.hits%></span></div></td>              
            </tr>
            <tr>
              <td width="8%"><div align="right">价&nbsp;&nbsp;&nbsp;&nbsp;格:&nbsp;&nbsp;</div></td>
              <td width="42%"><div align="left price"><%=ginfo.score%> <%=GetPayMethod(ginfo.payextcredits)%></div></td>
            </tr>
            <tr>
              <td ><div align="right">库&nbsp;&nbsp;&nbsp;&nbsp;存:&nbsp;&nbsp; </div></td>
              <td><div align="left"><%=ginfo.count-ginfo.countselled%></div></td>
            </tr>
             <tr>
              <td ><div align="right">自动发货: &nbsp;&nbsp;</div></td>
              <td><div align="left"><%=GetAutoPost(ginfo.isautopost)%></div></td>
            </tr>
             <tr>
              <td ><div align="right">限&nbsp;&nbsp;&nbsp;&nbsp;制: &nbsp;&nbsp;</div></td>
              <td><div align="left"><%=GetIsEveryday(ginfo.iseveryday)%></div></td>
            </tr>           
             <tr>
              <td ><div align="right" title="预计收到货时间">到货时间:&nbsp;&nbsp; </div></td>
              <td><div align="left"><%=ginfo.gettime%></div></td>
            </tr>
              <tr>
              <td ><div align="right">摘&nbsp;&nbsp;&nbsp;&nbsp;要: &nbsp;&nbsp;</div></td>
              <td><div align="left"><%=ginfo.aboutshort%></div></td>
            </tr>
             <tr>
              <td colspan="2"><div style="padding:10px;">
					<div class="tb-btn-buy"><a href="/goods_bay.aspx?gid=<%=gid%>" data-addfastbuy="true" title="点击此按钮，到下一步确认购买信息。">立即购买<b></b></a></div> 
					<div class="tb-btn-back"><a href="/" title="返回列表">返回列表<b></b></a></div>
				</div></td>
            </tr>
            <tr>
              <td colspan="2">&nbsp;</td>
            </tr>
             <tr>
              <td colspan="3"><div align="left">详细说明: </div></td>               
            <tr>
             <tr>
              <td colspan="3"><p><%=ginfo.about%></p></td>       
              </tr>       
        </tbody>
    </table> 
       
</div>
    <uc1:bottom ID="bottom1" runat="server" />
</body>
</html>
