<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Shop.index" %>
<%@ Register TagPrefix="uc1" TagName="head" Src="head.ascx" %>
<%@ Register TagPrefix="uc1" TagName="bottom" Src="bottom.ascx" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>
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
  <script type="text/javascript">
      var aspxrewrite = 1;
      var IMGDIR = '/templates/default/images';
      var disallowfloat = '';
      var rooturl = "http://bbs.haocw.com/";
      var imagemaxwidth = '750';
      var cssdir = '/templates/default';
  </script>    
<script type="text/javascript">    var Allowhtml = 1;
  var Allowsmilies = 1;
  var Allowbbcode = 1;
  var Allowimgcode = 1;
</script>
</head>
<body>
<uc1:head ID="head1" runat="server" />
    
   <div class="wrap cl">
        <div id="forumheader" class="main cl">
            <div class="forumaction y">
                <a class="feed" href="#">RSS</a>		
            </div>
            <h1>社区商店</h1>
            <span class="forumstats">商品: <strong class="xi1"><%=count%></strong> 件<span class="pipe"></span>
            <p>社区商店，好彩网社区商店出售各种有趣商品！人品恰巧隐藏于这玄机中！</p>
            <p id="modedby">店主: <span class="f_c">太湖之家</span></p>
        
        </div>
        
        <div class="pages_btns cl">
            <div class="pages">
                <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True"  FirstPageText="首页" LastPageText="尾页" NextPageText="下页" PagingButtonSpacing="8px" PrevPageText="上页" PageSize="30"  EnableUrlRewriting="True" UrlPaging="True" ShowInputBox="Never"></webdiyer:AspNetPager>
            </div>
        </div>
        
            <div id="headfilter" class="cl">
                <a href="?order=<%=order%>&direct=<%=direct%>" <%=GetCurrentClass(gcid,0)%>>全部</a>
                <asp:Repeater ID="goodsclasslist" runat="server" EnableViewState="false"><ItemTemplate>
                          <div><a href="?gcid=<%#DataBinder.Eval(Container.DataItem, "gcid")%>&order=<%=order%>&direct=<%=direct%>" title="<%#DataBinder.Eval(Container.DataItem, "name").ToString().Trim()%>" <%#GetCurrentClass(gcid,DataBinder.Eval(Container.DataItem, "gcid"))%>><%#GetCutString(DataBinder.Eval(Container.DataItem, "name").ToString().Trim(),10)%></a></div>
                </ItemTemplate></asp:Repeater>                  
            </div>
        <div class="main thread">	
                <div class="category">
                <table summary="3" cellspacing="0" cellpadding="0">
                    <tr>
                    <th>按照:
                        <a id="ordermenu" onclick="showMenu(this.id);" href="javascript:;"  class="drop xg2">人气</a>
                        <ul id="ordermenu_menu" class="p_pop" style="display: none">
                            <li><a href="javascript:selectorder(1);">人气</a></li>
                            <li><a href="javascript:selectorder(2);">销量</a></li>
                            <li><a href="javascript:selectorder(3);">上架时间</a></li>
                        </ul>
                        <span class="pipe">|</span>排序:
                        <a id="directmenu" onclick="showMenu(this.id);" href="javascript:;" class="drop xg2">按降序排列</a>
                        <ul id="directmenu_menu" class="p_pop" style="display: none">
                            <li><a href="javascript:selectdirect(1);">按降序排列</a></li>
                            <li><a href="javascript:selectdirect(0);">按升序排列</a></li>
                        </ul>
                        <script type="text/javascript" reload=1>
                            function loadsearchconditionlink() {
                                var ordermenuarray = ['人气', '销量', '上架时间', ];
								if(<%=order%>>0)
                                    $('ordermenu').innerHTML = ordermenuarray[<%=order%> - 1];
								else
									$('ordermenu').innerHTML = ordermenuarray[0];
                                if (<%=direct%> == 0)
                                    $('directmenu').innerHTML = '按升序排列';
                            }
                            loadsearchconditionlink();
                            function selectorder(selectvalue) {
                                window.location.href = '?gcid=<%=gcid%>&order=' + selectvalue + '&direct=<%=direct%>';
                            }
                            function selectdirect(selectvalue) {
                                window.location.href = '?gcid=<%=gcid%>&order=<%=order%>&direct=' + selectvalue;
                            }
                        </script>
                    </th>
                    <td class="by"></td>
                    <td class="num"></td>
                    <td class="by"></td>
                    </tr>
                </table>
                </div>
        </div>
        <ul class="goodslist">
              <asp:Repeater ID="list" runat="server" EnableViewState="false"><ItemTemplate>
              <li>
                  <p><a href="/goods/<%#DataBinder.Eval(Container.DataItem, "gid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "gname")%>" target="_blank"><img src="<%#PicChangeSmallUrl(DataBinder.Eval(Container.DataItem, "img"))%>"  alt="<%#DataBinder.Eval(Container.DataItem, "gname")%>" align="absmiddle"/></a></p>
                  <p class="red b">&#65509; <%#DataBinder.Eval(Container.DataItem, "score")%> <%#GetPayMethod(DataBinder.Eval(Container.DataItem, "payextcredits"))%></p>
                  <p>[<%#GetGcName(DataBinder.Eval(Container.DataItem, "gcid"))%>] <a href="/goods/<%#DataBinder.Eval(Container.DataItem, "gid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "gname")%>" target="_blank"><%#DataBinder.Eval(Container.DataItem, "gname")%></a></p>
                  <p><span class="gray b">销量:</span><span class="orege b"><%#DataBinder.Eval(Container.DataItem, "countselled")%></span> | <span class="blue">商品总量:
				  <%#GetNowNum(DataBinder.Eval(Container.DataItem, "count"),DataBinder.Eval(Container.DataItem, "countselled"))%></span></p>
                  <p class="button"><a href="/goods_bay.aspx?gid=<%#DataBinder.Eval(Container.DataItem, "gid")%>">购买</a><a href="/goods/<%#DataBinder.Eval(Container.DataItem, "gid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "gname")%>" target="_blank">查看</a></p>
              </li>
               </ItemTemplate></asp:Repeater>
          </ul>
        
        <div class="pages_btns cl">
            <div class="pages">
                <webdiyer:AspNetPager ID="AspNetPager2" runat="server" AlwaysShow="True"  FirstPageText="首页" LastPageText="尾页" NextPageText="下页" PagingButtonSpacing="8px" PrevPageText="上页" PageSize="30"  EnableUrlRewriting="True" UrlPaging="True" ShowInputBox="Never"></webdiyer:AspNetPager>		
            </div>
        </div>
    </div>
    <uc1:bottom ID="bottom1" runat="server" />
</body>
</html>
