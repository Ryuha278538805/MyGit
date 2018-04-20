<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Www.index" %>
<%@ Register src="header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="footer.ascx" tagname="footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>好彩网|收录彩摘网\乐彩网\天齐网\布衣天下\3d布衣图库等网站的精华内容</title>
<meta name="description" content="好彩网致力于彩票资讯,收录各大专业彩票网站上收录其精华内容,方便彩民朋友浏览。" />
<meta name="keywords" content="好彩网,彩摘网,乐彩网,天齐网,布衣天下,红五图库,布衣图库,彩吧论坛,3d预测,3d字谜,排列三预测,排列3字谜,双色球开奖结果" />
<meta http-equiv="X-UA-Compatible" content="IE=7" />
<link rel="icon" href="/favicon.ico" type="image/x-icon" />
<link rel="shortcut icon" href="/favicon.ico" type="image/x-icon" />
<link href="/css/css.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="/js/jquery.js"></script>
</head>
<body>
<uc1:header ID="header1" runat="server" />

<div class="dhbg"></div>
<div class="w1200">
	<div class="kjh p12">
		<div class="kjh_box">
			<div class="cz">福彩3D</div>
			<div class="qh"><%=GetQi(info3d.qi)%></div>
			<div class="red"><%=info3d.a%></div>
			<div class="red"><%=info3d.b%></div>
			<div class="red"><%=info3d.c%></div>
			<div  style=" float:left; margin-left:15px;"><%if (info3dnew.tzmoney == null || info3dnew.tzmoney.Length == 0){%><%=GetQi(info3dnew.qi)%><%} else{%><%=GetQi(info3d.qi)%><%} %>试机:</div> 
			<div class="org"><%if(info3dnew.tzmoney==null||info3dnew.tzmoney.Length==0){%><%=info3dnew.sjh.ToString("000").Substring(0,1)%><%}else{%><%=info3d.sjh.ToString("000").Substring(0,1)%><%}%></div>
			<div class="org"><%if(info3dnew.tzmoney==null||info3dnew.tzmoney.Length==0){%><%=info3dnew.sjh.ToString("000").Substring(1,1)%><%}else{%><%=info3d.sjh.ToString("000").Substring(1,1)%><%}%></div>
			<div class="org"><%if(info3dnew.tzmoney==null||info3dnew.tzmoney.Length==0){%><%=info3dnew.sjh.ToString("000").Substring(2,1)%><%}else{%><%=info3d.sjh.ToString("000").Substring(2,1)%><%}%></div>
		</div>
		<div class="kjh_box">
			<div class="cz">双色球</div>
			<div class="qh"><%=GetQi(infossq.qi)%></div>
			<div class="red"><%=GetKjh(infossq.a)%></div>
			<div class="red"><%=GetKjh(infossq.b)%></div>
			<div class="red"><%=GetKjh(infossq.c)%></div>
			<div class="red"><%=GetKjh(infossq.d)%></div>
			<div class="red"><%=GetKjh(infossq.e)%></div>
			<div class="red"><%=GetKjh(infossq.f)%></div>
			<div class="blue"><%=GetKjh(infossq.g)%></div>
		</div>
		<div class="kjh_box">
			<div class="cz">大乐透</div>
			<div class="qh"><%=GetQi(infodlt.qi)%></div>
			<div class="red"><%=GetKjh(infodlt.a)%></div> 
			<div class="red"><%=GetKjh(infodlt.b)%></div> 
			<div class="red"><%=GetKjh(infodlt.c)%></div> 
			<div class="red"><%=GetKjh(infodlt.d)%></div> 
			<div class="red"><%=GetKjh(infodlt.e)%></div> 
			<div class="blue"><%=GetKjh(infodlt.f)%></div>
			<div class="blue"><%=GetKjh(infodlt.g)%></div>
		</div>
		<div class="kjh_box">
			<div class="cz">排列三</div>
			<div class="qh"><%=GetQi(infop3.qi)%></div>
			<div class="red"><%=infop3.a%></div> 
			<div class="red"><%=infop3.b%></div> 
			<div class="red"><%=infop3.c%></div>    
		</div>
		<div class="kjh_box">
			<div class="cz">七星彩</div>
			<div class="qh"><%=GetQi(infoqxc.qi)%></div>
			<div class="red"><%=infoqxc.a%></div> 
			<div class="red"><%=infoqxc.b%></div> 
			<div class="red"><%=infoqxc.c%></div> 
			<div class="red"><%=infoqxc.d%></div> 
			<div class="red"><%=infoqxc.e%></div> 
			<div class="red"><%=infoqxc.f%></div> 
			<div class="red"><%=infoqxc.g%></div>
		</div>
		<div class="kjh_box">
			<div class="cz">七乐彩</div>
			<div class="qh"><%=GetQi(infoqlc.qi)%></div>
			<div class="red"><%=GetKjh(infoqlc.a)%></div> 
			<div class="red"><%=GetKjh(infoqlc.b)%></div> 
			<div class="red"><%=GetKjh(infoqlc.c)%></div> 
			<div class="red"><%=GetKjh(infoqlc.d)%></div> 
			<div class="red"><%=GetKjh(infoqlc.e)%></div> 
			<div class="red"><%=GetKjh(infoqlc.f)%></div> 
			<div class="red"><%=GetKjh(infoqlc.g)%></div> 
			<div class="blue"><%=GetKjh(infoqlc.h)%></div> 
		</div>
	</div>
	<div class="kjhzb p12">直播开奖： <a href="/kj/live_3d.html">福彩3d</a> <a href="/kj/live_p3.html">排列三</a> <a href="/kj/live_ssq.html">双色球</a></div>
</div>

<div class="w1200" style="height:834px";>
<div class="t1_left">
	<div id="dhtj">
		<div class="title_k">
            <div class="title p14"><a href="/dsyc/index_1.html">胆码推荐</a></div>
            <div class="title_t p12"><a href="/dsyc/index_1.html">独胆</a>  <a href="/dsyc/index_2.html">双胆</a> <a href="/dsyc/index_3.html">三胆</a></div>
            <div class="title_m p12"><a href="/dsyc/index_1.html">MORE...</a></div>
		</div>
		<div class="t_box">
        	<asp:Repeater ID="danmalist" runat="server" EnableViewState="false"><ItemTemplate>
             <%#GetTop2YcInfoStrByYZID(DataBinder.Eval(Container.DataItem,"yzid"))%>
            </ItemTemplate></asp:Repeater>
		</div>
	</div>
	
	<div class="t1_cen">
		<div class="wrap">
            <div class="content">
                <div class="article">
                    <div class="artlist">
                        <div class="title">
                            <ul id="p3-lab">
                                <li onmouseover="selectArtLab(&#39;p3-lab&#39;,&#39;p3-list&#39;,0)" class="select"><a href="/jpt/list.html" target="_blank">布衣图库</a></li>
                                <li onmouseover="selectArtLab(&#39;p3-lab&#39;,&#39;p3-list&#39;,1)"><a href="/sanmaotuku/list.html" target="_blank">三毛图库</a></li>
                                <li onmouseover="selectArtLab(&#39;p3-lab&#39;,&#39;p3-list&#39;,2)"><a href="/hongwutuku/list.html" target="_blank">红五图库</a></li>
                            </ul>
                        </div>
                        <div id="p3-list" class="list">
                            <ul>
                                <asp:Repeater ID="buyitukuzonelist" runat="server" EnableViewState="false"><ItemTemplate>
                                <li><a href="/<%#GetNewsClassInfo(DataBinder.Eval(Container.DataItem, "cid")).ename%>/list_<%#DataBinder.Eval(Container.DataItem, "zid")%>_1.html" class="<%#GetIsNewQi(DataBinder.Eval(Container.DataItem,"zid"),DataBinder.Eval(Container.DataItem,"cid"))%>"  title="<%#DataBinder.Eval(Container.DataItem, "name")%>"><%#DataBinder.Eval(Container.DataItem, "name")%></a></li>
                                </ItemTemplate></asp:Repeater>
                            </ul>
                            <ul style="display:none;">
                                <asp:Repeater ID="sanmaotukuzonelist" runat="server" EnableViewState="false"><ItemTemplate>
                                <li><a href="/<%#GetNewsClassInfo(DataBinder.Eval(Container.DataItem, "cid")).ename%>/list_<%#DataBinder.Eval(Container.DataItem, "zid")%>_1.html"  class="<%#GetIsNewQi(DataBinder.Eval(Container.DataItem,"zid"),DataBinder.Eval(Container.DataItem,"cid"))%>" title="<%#DataBinder.Eval(Container.DataItem, "name")%>"><%#DataBinder.Eval(Container.DataItem, "name")%></a></li>
                                </ItemTemplate></asp:Repeater>							
                            </ul>
                            <ul style="display:none;">
                                <asp:Repeater ID="jptzonelist" runat="server" EnableViewState="false"><ItemTemplate>
                                <li><a href="/<%#GetNewsClassInfo(DataBinder.Eval(Container.DataItem, "cid")).ename%>/list_<%#DataBinder.Eval(Container.DataItem, "zid")%>_1.html"  class="<%#GetIsNewQi(DataBinder.Eval(Container.DataItem,"zid"),DataBinder.Eval(Container.DataItem,"cid"))%>" title="<%#DataBinder.Eval(Container.DataItem, "name")%>"><%#DataBinder.Eval(Container.DataItem, "name")%></a></li>
                                </ItemTemplate></asp:Repeater>							
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
		</div>
		
		<div id="hzt" class="p14">
          <asp:Repeater ID="huizongzonelist" runat="server" EnableViewState="false"><ItemTemplate>               
               <div class="ht"><%#GetZoneNewsLink(DataBinder.Eval(Container.DataItem, "zid"),12)%></div>
          </ItemTemplate></asp:Repeater>
		</div>
	</div>
	<div style=" float:left;margin-top:15px;"><a href="www.haocw.com"><img src="image/newhc.gif" width="890" height="60" border="0" /></a></div>
	<div id="dhtj">
		<div class="title_k">
            <div class="title p14"><a href="/dsyc/index_1.html">杀码推荐</a></div>
            <div class="title_t p12"><a href="/dsyc/index_4.html">杀一码</a>  <a href="/dsyc/index_5.html">杀二码</a></div>
            <div class="title_m p12"><a href="/dsyc/index_1.html">MORE...</a></div>
		</div>
		<div class="t_box">
        	<asp:Repeater ID="shamalist" runat="server" EnableViewState="false"><ItemTemplate>
             <%#GetTop2YcInfoStrByYZID(DataBinder.Eval(Container.DataItem,"yzid"))%>
            </ItemTemplate></asp:Repeater>
		</div>
	</div>
	<div id="thzt">
		<div class="title_k">
            <div class="title p14"><a href="/jth/list.html">解太湖专题</a></div>
            <div class="title_t p12">
                <a href="http://www.55126.cn/so.aspx?wd=%E8%AF%95%E6%9C%BA%E5%8F%B7&userid=764" target="_blank">试机号</a> 
                <a href="http://www.55126.cn/so.aspx?wd=%E4%B8%80%E5%8F%A5%E5%AE%9A%E4%B8%89%E7%A0%81&userid=764" target="_blank">一句定三码</a> 
                <a href="http://www.55126.cn/so.aspx?wd=%E5%A4%AA%E6%B9%96%E5%AD%97%E8%B0%9C&userid=764" target="_blank">金胆</a> 
                <a href="http://www.55126.cn/so.aspx?wd=%E9%87%91%E8%83%86&userid=764" target="_blank">太湖</a> 
                <a href="http://www.55126.cn/so.aspx?wd=%E5%A4%A9%E6%9C%BA%E5%9B%BE&userid=764" target="_blank">天机图</a> 
    
            </div>
            <div class="title_m p12"><a href="/jth/list.html">MORE...</a></div>
		</div>
		<div class="list p14">
        	<asp:Repeater ID="fc3djthlist" runat="server" EnableViewState="false"><ItemTemplate>
             <div class="<%#GetIsHot(DataBinder.Eval(Container.DataItem,"ishot"),DataBinder.Eval(Container.DataItem,"isbest"),DataBinder.Eval(Container.DataItem,"istop"))%>"><a href="/<%#GetNewsClassInfo(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"cid"))).ename %>/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime")) %>/<%#DataBinder.Eval(Container.DataItem,"nid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "title")%>" target="_blank"><%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),30)%></a></div>
			<div class="tx3"><%#GetDate(DataBinder.Eval(Container.DataItem,"addtime"))%></div>
            </ItemTemplate></asp:Repeater>
		</div>
	</div>
</div>

<div class="t1_right">
	<div id="caib">
		<div class="title_k">
		<div class="title p14"><a href="/jth/list.html">彩&nbsp;&nbsp;报</a></div>
		<div class="title_t p12">好彩网独家彩报</div>
		</div>
        <asp:Repeater ID="tumizonelist" runat="server" EnableViewState="false"><ItemTemplate>               
               <div class="dyt"><%#GetZoneNewsLink(DataBinder.Eval(Container.DataItem, "zid"),14)%></div>
         </ItemTemplate></asp:Repeater>
	</div>
	
	<div class="rmyc">
	<table width="295" height="348" border="0" cellpadding="0" cellspacing="2" bgcolor="#FFFFFF">
  <tr>
    <td height="22" align="center" bgcolor="#EA7B68"><a href="/sdhot/list_140_1.html">幸运彩仙</a></td>
    <td colspan="2" rowspan="2" align="center" bgcolor="#7C4268"><a href="/sdhot/list_156_1.html">蓝仙子一句定三码</a></td>
  </tr>
  <tr bgcolor="#EA7B68">
    <td height="22" align="center" bgcolor="#EA7B68"><a href="/sdhot/list_153_1.html">山东真言</a></td>
  </tr>
  <tr>
    <td colspan="2" align="center" bgcolor="#7C4268"><a href="/sdhot/list_139_1.html">詹天佑点评</a></td>
    <td height="44" align="center" bgcolor="#58558A"><a href="/sdhot/list_158_1.html">晚秋</a></td>
  </tr>
  <tr>
    <td height="22" align="center" bgcolor="#EA7B68"><a href="/sdhot/list_146_1.html">运财福音</a></td>
    <td rowspan="2" align="center" bgcolor="#58558A"><a href="/sdhot/list_154_1.html">马后炮解太湖</a></td>
    <td align="center" bgcolor="#EA7B68"><a href="/sdhot/list_145_1.html">孤舟预测</a></td>
  </tr>
  <tr>
    <td height="22" align="center" bgcolor="#58558A"><a href="/sdhot/list_148_1.html">鬼六神算</a></td>
    <td align="center" bgcolor="#EA7B68"><a href="/sdhot/list_155_1.html">廊坊鸿运</a></td>
  </tr>
  <tr>
    <td rowspan="2" align="center" bgcolor="#58558A"><a href="/sdhot/list_138_1.html">于海滨点评</a></td>
    <td height="22" colspan="2" align="center" bgcolor="#7C4268"><a href="/sdhot/list_144_1.html">小糊涂+老糊涂</a></td>
  </tr>
  <tr>
    <td height="22" align="center" bgcolor="#EA7B68"><a href="/sdhot/list_147_1.html">天涯过客</a></td>
    <td align="center" bgcolor="#58558A"><a href="/sdhot/list_157_1.html">千年虫</a></td>
  </tr>
  <tr>
    <td colspan="2" align="center" bgcolor="#7C4268"><a href="/sdhot/list_142_1.html">钱王点评</a></td>
    <td height="22" align="center" bgcolor="#EA7B68"><a href="/sdhot/list_149_1.html">紫云涧</a></td>
  </tr>
  <tr>
    <td height="22" align="center" bgcolor="#EA7B68"><a href="/sdhot/list_141_1.html">唐龙点评</a></td>
    <td colspan="2" align="center" bgcolor="#7C4268"><a href="/sdhot/list_152_1.html">崂山道士字谜</a></td>
  </tr>
  <tr>
    <td height="22" align="center" bgcolor="#58558A"><a href="/sdhot/list_160_1.html">彩谍分析</a></td>
    <td align="center" bgcolor="#EA7B68"><a href="/sdhot/list_151_1.html">上下五千年</a></td>
    <td align="center" bgcolor="#EA7B68"><a href="/sdhot/list_143_1.html">中彩龙</a></td>
  </tr>
</table>
	</div>
	<div class="ylw">
	 <div class="ylwtxt p14"><a href="http://bbs.haocw.com/showtopic-10019.aspx">有奖发贴第三期正式启动<br />论坛发3D、排三、双色球奖50~200 RMB！</a>	</div>	 
	 <div class="ylwtxt p14"><a href="#">欢迎大家给我们提意见，用户至上，我们尽量满足大家的需求，点击这里提意见！ </a></div>
</div>
</div>
 </div>


<div class="w1200">
	<div class="bd_1"></div>
	<div class="bd_2"></div>
</div>

<div class="w1200">
	<div id="wen">
		<div class="left">
			<div class="title_k">
			<div class="title p14"><a href="/sdyc/list.html">福彩3D预测</a></div>
			<div class="title_t p12">
				<div class="title_tbox"><a href="http://bbs.haocw.com/showforum-2.aspx">论坛3D预测</a>  </div>
				<div class="title_tbox"><a href="http://bbs.haocw.com/showforum-3.aspx">论坛3D字谜</a> </div>
				<div class="title_tbox"><a href="/sdsy/list.html">相关术语</a></div>
			</div>
			<div class="title_m p12"><a href="/sdyc/list.html">MORE...</a></div>
			</div>
			
			<div class="list p14">				
				<asp:Repeater ID="fc3dyclist" runat="server" EnableViewState="false"><ItemTemplate>
                	<div class="txbox"><div class="<%#GetIsHot(DataBinder.Eval(Container.DataItem,"ishot"),DataBinder.Eval(Container.DataItem,"isbest"),DataBinder.Eval(Container.DataItem,"istop"))%>"><a href="/<%#GetNewsClassInfo(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"cid"))).ename %>/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime")) %>/<%#DataBinder.Eval(Container.DataItem,"nid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "title")%>" target="_blank"><%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),30)%></a></div><div class="tx3"><%#GetDate(DataBinder.Eval(Container.DataItem,"addtime"))%></div></div>
                 </ItemTemplate></asp:Repeater>						
			</div>
	</div>
	
		<div id="wzri">
		<div class="title_k">
		<div class="title p14"><a href="/sdzm/list.html">福彩3D字谜</a></div>
		<div class="title_t p12">&nbsp;</div>
		<div class="title_m p12"><a href="/sdzm/list.html">MORE...</a></div>
		</div>
			<div class="list p14">
				<asp:Repeater ID="fc3dzmlist" runat="server" EnableViewState="false"><ItemTemplate>
                	<div class="txbox"><div class="<%#GetIsHot(DataBinder.Eval(Container.DataItem,"ishot"),DataBinder.Eval(Container.DataItem,"isbest"),DataBinder.Eval(Container.DataItem,"istop"))%>"><a href="/<%#GetNewsClassInfo(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"cid"))).ename %>/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime")) %>/<%#DataBinder.Eval(Container.DataItem,"nid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "title")%>" target="_blank"><%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),30)%></a></div><div class="tx3"><%#GetDate(DataBinder.Eval(Container.DataItem,"addtime"))%></div></div>
                 </ItemTemplate></asp:Repeater>		
			</div>
		</div>
			
	</div>
</div>

<div class="w1200">
	<div id="wen">
		<div class="left">
			<div class="title_k">
			<div class="title p14"><a href="/p3yc/list.html">排列三预测</a></div>
			<div class="title_t p12">
				<div class="title_tbox"><a href="http://bbs.haocw.com/showforum-9.aspx">排列三论坛预测</a>  </div>
				<div class="title_tbox"><a href="http://bbs.haocw.com/showforum-10.aspx">排列三论坛字谜</a> </div>
				<div class="title_tbox"><a href="http://bbs.haocw.com/showforum-15.aspx">排列三论坛图谜</a> </div>
				<div class="title_tbox"><a href="/p3sy/list.html">相关术语</a></div>
			</div>
			<div class="title_m p12"><a href="/p3yc/list.html">MORE...</a></div>
			</div>
			
			<div class="list p14">
				<asp:Repeater ID="tcp3yclist" runat="server" EnableViewState="false"><ItemTemplate>
                	<div class="txbox"><div class="<%#GetIsHot(DataBinder.Eval(Container.DataItem,"ishot"),DataBinder.Eval(Container.DataItem,"isbest"),DataBinder.Eval(Container.DataItem,"istop"))%>"><a href="/<%#GetNewsClassInfo(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"cid"))).ename %>/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime")) %>/<%#DataBinder.Eval(Container.DataItem,"nid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "title")%>" target="_blank"><%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),30)%></a></div><div class="tx3"><%#GetDate(DataBinder.Eval(Container.DataItem,"addtime"))%></div></div>
                 </ItemTemplate></asp:Repeater>	
			</div>
	</div>
	
		<div id="wzri">
		<div class="title_k">
		<div class="title p14"><a href="/p3zm/list.html">排列三字谜</a></div>
		<div class="title_t p12">&nbsp;</div>
		<div class="title_m p12"><a href="/p3zm/list.html">MORE...</a></div>
		</div>
			<div class="list p14">
				<asp:Repeater ID="tcp3zmlist" runat="server" EnableViewState="false"><ItemTemplate>
                	<div class="txbox"><div class="<%#GetIsHot(DataBinder.Eval(Container.DataItem,"ishot"),DataBinder.Eval(Container.DataItem,"isbest"),DataBinder.Eval(Container.DataItem,"istop"))%>"><a href="/<%#GetNewsClassInfo(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"cid"))).ename %>/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime")) %>/<%#DataBinder.Eval(Container.DataItem,"nid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "title")%>" target="_blank"><%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),30)%></a></div><div class="tx3"><%#GetDate(DataBinder.Eval(Container.DataItem,"addtime"))%></div></div>
                 </ItemTemplate></asp:Repeater>	
			</div>
		</div>			
  </div>
</div>
</div>


<div class="w1200" style="margin-top:15px;"><a href="www.haocw.com"><img src="image/haog.gif" width="1199" height="104" border="0" /></a></div>

<div class="w1200">
	<div id="wen">
		<div class="left">
			<div class="title_k">
			<div class="title p14"><a href="/ssqyc/list.html">双色球预测</a></div>
			<div class="title_t p12">
				<div class="title_tbox"><a href="http://bbs.haocw.com/showforum-7.aspx">双色球论坛预测</a>  </div>
				<div class="title_tbox"><a href="http://bbs.haocw.com/showforum-8.aspx">双色球论坛字谜</a> </div>
				<div class="title_tbox"><a href="/ssqsy/list.html">相关术语</a></div>
			</div>
			<div class="title_m p12"><a href="/sdyc/list.html">MORE...</a></div>
			</div>
			
			<div class="list p14">
				<asp:Repeater ID="fcssqyclist" runat="server" EnableViewState="false"><ItemTemplate>
                	<div class="txbox"><div class="<%#GetIsHot(DataBinder.Eval(Container.DataItem,"ishot"),DataBinder.Eval(Container.DataItem,"isbest"),DataBinder.Eval(Container.DataItem,"istop"))%>"><a href="/<%#GetNewsClassInfo(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"cid"))).ename %>/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime")) %>/<%#DataBinder.Eval(Container.DataItem,"nid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "title")%>" target="_blank"><%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),30)%></a></div><div class="tx3"><%#GetDate(DataBinder.Eval(Container.DataItem,"addtime"))%></div></div>
                 </ItemTemplate></asp:Repeater>	
			</div>
	</div>
	
		<div id="wzri">
		<div class="title_k">
		<div class="title p14"><a href="/ssqzm/list.html">双色球字谜</a></div>
		<div class="title_t p12">&nbsp;</div>
		<div class="title_m p12"><a href="/ssqzm/list.html">MORE...</a></div>
		</div>
			<div class="list p14">
				<asp:Repeater ID="fcssqzmlist" runat="server" EnableViewState="false"><ItemTemplate>
                	<div class="txbox"><div class="<%#GetIsHot(DataBinder.Eval(Container.DataItem,"ishot"),DataBinder.Eval(Container.DataItem,"isbest"),DataBinder.Eval(Container.DataItem,"istop"))%>"><a href="/<%#GetNewsClassInfo(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"cid"))).ename %>/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime")) %>/<%#DataBinder.Eval(Container.DataItem,"nid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "title")%>" target="_blank"><%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),30)%></a></div><div class="tx3"><%#GetDate(DataBinder.Eval(Container.DataItem,"addtime"))%></div></div>
                 </ItemTemplate></asp:Repeater>	
			</div>
		</div>			
  </div>
</div>
</div>

<div class="w1200 p14" style="margin-top:30px;">
	<div class="hzmt">合作媒体</div>
	<div id="yq">
    	<%=friendlink%>
	</div>
</div>

<uc2:footer ID="footer" runat="server" />
</body>
</html>