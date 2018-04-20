<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="goods_bay.aspx.cs" Inherits="Shop.goods_buy" %>
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
<body>
<uc1:head ID="head1" runat="server" />
 <div class="wrap cl">
  <div id="forumheader" class="main cl">
                <h1>确认购买 <%=ginfo.gname%></h1>
             <span class="forumstats">销量: <strong class="xi1"><%=ginfo.countselled%></strong> <span class="pipe">|</span>总量: <strong class="xi1"><%=ginfo.count%></strong></span>
        </div>
    <form id="form1" runat="server">
   <table cellspacing="0" cellpadding="0" width="100%" class="goodsinfotb">
        <tbody>
            <tr>             
              <td colspan="2"><div id="name"><h2>确认购买  <%=ginfo.gname%> </h2> &nbsp;</div></td>   
              <td width="50%" rowspan="12"><div align="center"><img class="gimg" src="<%=ginfo.img%>"  alt="<%=ginfo.gname%>" align="absmiddle"/></div></td>     
        </tr>
            <tr>
              <td width="8%"><div align="right">价&nbsp;&nbsp;&nbsp;&nbsp;格:&nbsp;&nbsp;</div></td>
              <td width="42%"><div align="left price">&#65509;  <%=ginfo.score%> <%=GetPayMethod(ginfo.payextcredits)%></div></td>
            </tr>
            <tr>
              <td ><div align="right">库&nbsp;&nbsp;&nbsp;&nbsp;存:&nbsp;&nbsp;</div></td>
              <td><div align="left"><%=ginfo.count-ginfo.countselled%></div></td>
            </tr>
             <tr style="display:<%=GetShowAddress(ginfo.needpost)%>">
              <td ><div align="right">收货地址:&nbsp;&nbsp;</div></td>
              <td><div align="left"><asp:TextBox ID="postaddress" CssClass="txt" Width="360px" runat="server"></asp:TextBox></div></td>
            </tr>
             <tr style="display:<%=GetShowAddress(ginfo.needpost)%>">
              <td ><div align="right">收货人:&nbsp;&nbsp;</div></td>
              <td><div align="left"><asp:TextBox ID="postname" CssClass="txt" Width="360px"  runat="server"></asp:TextBox></div></td>
            </tr>           
             <tr style="display:<%=GetShowAddress(ginfo.needpost)%>">
              <td ><div align="right" title="预计收到货时间">联系电话:&nbsp;&nbsp;</div></td>
              <td><div align="left"><asp:TextBox ID="posttel" CssClass="txt" Width="360px"  runat="server"></asp:TextBox></div></td>
            </tr>
              <tr style="display:<%=GetShowAddress(ginfo.needpost)%>">
              <td ><div align="right">邮&nbsp;&nbsp;&nbsp;&nbsp;编:&nbsp;&nbsp;</div></td>
              <td><div align="left"><asp:TextBox ID="postno" CssClass="txt" Width="360px"  runat="server"></asp:TextBox></div></td>
            </tr>
             <tr>
              <td colspan="2" align="center"><div style="padding:10px;"><asp:Button ID="enter" runat="server" CssClass="submit" onclick="enter_Click" Text="提交订单" /></div></td>
            </tr>  
        </tbody>
  </table> 
    </form>
</div>
    <uc1:bottom ID="bottom1" runat="server" />

</body>
</html>
