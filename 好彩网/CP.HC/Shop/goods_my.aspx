<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="goods_my.aspx.cs" Inherits="Shop.goods_my" %>
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
          <h1>我已买到的东西</h1> <span class="forumstats">&nbsp;</span>
        </div>
        <div class="main thread">
                <div class="category">
                <table summary="2" cellspacing="0" cellpadding="0"><tbody>
                    <tr>
                        <td class="by">商品分类</td>
                        <th>商品名</th>
                        <td class="by">发货状态</td>
                        <td class="by">购买时间</td>
                        <td class="by"></td>
                        <td class="num">操作</td>
                    </tr>
                </tbody></table>
                </div>
                <div class="threadlist">
                <table summary="2" id="threadlist" cellspacing="0" cellpadding="0">						
                    <asp:Repeater ID="list" runat="server" EnableViewState="false"><ItemTemplate>
                    <tbody><tr>		
                            <td class="by"><%#GetCutString(GetGcNamebyGid(DataBinder.Eval(Container.DataItem, "gid")),10)%></td>
                            <th class="subject hot"><a href="/goods/my_<%#DataBinder.Eval(Container.DataItem, "sid")%>.html" title="查看详情" ><%#GetGName(DataBinder.Eval(Container.DataItem, "gid"))%></a></th>
                            <td class="by"><em><%#GetIsPostString(DataBinder.Eval(Container.DataItem, "isposted"))%></em></td>
                            <td class="by"><em><%#DataBinder.Eval(Container.DataItem, "addtime")%></em></td>
                            <td class="by" align="center"><%#GetChangeAddress(DataBinder.Eval(Container.DataItem, "gid"),DataBinder.Eval(Container.DataItem, "sid"),DataBinder.Eval(Container.DataItem, "isposted"))%></td>
                            <td class="num"><a href="/goods/my_<%#DataBinder.Eval(Container.DataItem, "sid")%>.html">查看</a></td>
                    </tr></tbody>
                    </ItemTemplate></asp:Repeater>      
                </table>
            </div>
	</div>
</div>
<uc1:bottom ID="bottom1" runat="server" />
</body>
</html>
