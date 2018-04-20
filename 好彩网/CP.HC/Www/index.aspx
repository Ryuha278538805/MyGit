<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Www.index" %>
<%@ Register src="header1.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="footer1.ascx" tagname="footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>好彩网首页-3d字谜\3d预测\彩摘网\乐彩网\天齐网\布衣天下\3d布衣图库\天下彩</title>
<meta name="description" content="好彩网致力于彩票资讯,收录各大专业彩票网站上收录其精华内容,方便彩民朋友浏览。" />
<meta name="keywords" content="好彩网,彩摘网,乐彩网,天齐网,布衣天下,红五图库,布衣图库,彩吧论坛,3d预测,3d字谜,双色球开奖结果" />
<meta http-equiv="X-UA-Compatible" content="IE=7" />
<meta name="baidu-site-verification" content="pPbx1PSMVW" />
<link rel="icon" href="/favicon.ico" type="image/x-icon" />
<link rel="shortcut icon" href="/favicon.ico" type="image/x-icon" />
<link href="/css/css.css" rel="stylesheet" type="text/css" />
<style type="text/css">
    .rtNews {float:left;width:295px;background-color:#fff;}
    .rtNews .rtTitle_k{float:left;width:285px; height:33px; border-bottom:1px solid #ddd; margin-left:5px;margin-top:5px;display:inline;}
    .rtNews .rtTitle{float:left;width:100px;height:33px;background-color:#D80C18;text-align:center; line-height:33px; }
    .rtNews .rtTitle a{ color:#FFFFFF}
    .rtNews .rtTitle_t{float:left; width:180px; line-height:33px; text-align:center; color:#5e5e5e;}
    .rtNews .rtList{float:left;width:280px;padding:10px 0 2px 15px;}
    .rtNews .rtDyr{float:left;width:270px;background:url(/image/jdr.gif) no-repeat 0px -114px;padding-left:20px;line-height:29px;font-size:14px;}
    .rtNews .rtDyj{float:left;width:270px;background:url(/image/jdr.gif) no-repeat 0px -38px;padding-left:20px;line-height:29px;font-size:14px;}
    .rtNews .rtDyd{float:left;width:270px;background:url(/image/jdr.gif) no-repeat 0px -77px;padding-left:20px;line-height:29px;font-size:14px;}
    .rtNews .rtDy{float:left;width:270px;background:url(/image/jdr.gif) no-repeat;padding-left:20px;line-height:29px;font-size:14px;}
</style>
<script type="text/javascript" src="/js/jquery.js"></script>
</head>
<base target="_blank" /><body>
<uc1:header ID="header1" runat="server" />

<div class="dhbg"></div>
<div class="w1200"><a href="http://www.haocw.com/tk"><img id="logo" alt="好彩图库" src="/image/yl.jpg" width="1200" height="50"  /></a></div>
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
</div>

<div class="w1200">
<div class="t1_left">
	<div id="dhtj"  style="display:none;">
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
	
	
<div id="tk_k">
	<div class="title">
		<div class="tk" style="background-color:#A37BAD;"><a href="/jpt/list.html" target="_blank">布衣图库</a></div>
		<div class="tk" style="background-color:#CF6490;"><a href="/sanmaotuku/list.html" target="_blank">三毛图库&nbsp;<img src="image/new.gif" width="21" height="12" border="0" /></a></div>
		<div class="tk" style="background-color:#EC89A5;"><a href="/hongwutuku/list.html" target="_blank">红五图库&nbsp;<img src="image/new.gif" width="21" height="12" border="0" /></a></div>
	</div>
	<div class="tk_txt" style="background-color:#FAE5FF;">
	
		<asp:Repeater ID="buyitukuzonelist" runat="server" EnableViewState="false"><ItemTemplate>
		<div><a href="/<%#GetNewsClassInfo(DataBinder.Eval(Container.DataItem, "cid")).ename%>/list_<%#DataBinder.Eval(Container.DataItem, "zid")%>_1.html" class="<%#GetIsNewQi(DataBinder.Eval(Container.DataItem,"zid"),DataBinder.Eval(Container.DataItem,"cid"))%>"  title="<%#DataBinder.Eval(Container.DataItem, "name")%>"><%#DataBinder.Eval(Container.DataItem, "name")%></a></div>
		</ItemTemplate></asp:Repeater>
	</div>
	<div class="tk_txt" style="background-color:#FFF0F6;">
		<asp:Repeater ID="sanmaotukuzonelist" runat="server" EnableViewState="false"><ItemTemplate>
                                <div><a href="/<%#GetNewsClassInfo(DataBinder.Eval(Container.DataItem, "cid")).ename%>/list_<%#DataBinder.Eval(Container.DataItem, "zid")%>_1.html"  class="<%#GetIsNewQi(DataBinder.Eval(Container.DataItem,"zid"),DataBinder.Eval(Container.DataItem,"cid"))%>" title="<%#DataBinder.Eval(Container.DataItem, "name")%>"><%#DataBinder.Eval(Container.DataItem, "name")%></a></div>
                                </ItemTemplate></asp:Repeater>
	</div>
	<div class="tk_txt" style="background-color:#FFE2EA;">
		<asp:Repeater ID="jptzonelist" runat="server" EnableViewState="false"><ItemTemplate>
                                <div><a href="/<%#GetNewsClassInfo(DataBinder.Eval(Container.DataItem, "cid")).ename%>/list_<%#DataBinder.Eval(Container.DataItem, "zid")%>_1.html"  class="<%#GetIsNewQi(DataBinder.Eval(Container.DataItem,"zid"),DataBinder.Eval(Container.DataItem,"cid"))%>" title="<%#DataBinder.Eval(Container.DataItem, "name")%>"><%#DataBinder.Eval(Container.DataItem, "name")%></a></div>
                                </ItemTemplate></asp:Repeater>
	</div>
</div>


<!-- /*彩报与汇总块 begin*/ -->
	<div style="float:left;width:860px;background-color:#FFF;margin-top:15px;padding:6px 15px;">
        <asp:Repeater ID="tumizonelist" runat="server" EnableViewState="false"><ItemTemplate>               
        <div style="float:left;width:172px;line-height:28px;"><%#GetZoneNewsLink(DataBinder.Eval(Container.DataItem, "zid"),14)%></div>
        </ItemTemplate></asp:Repeater>
	</div>
	<div style="float:left;width:860px;background-color:#FFF;margin-top:15px;padding:6px 15px;">
        <asp:Repeater ID="huizongzonelist" runat="server" EnableViewState="false"><ItemTemplate>               
        <div style="float:left;width:215px;line-height:28px;"><%#GetZoneNewsLink(DataBinder.Eval(Container.DataItem, "zid"),12)%></div>
        </ItemTemplate></asp:Repeater>
	</div>
<!-- /*彩报与汇总块 end*/ -->
	
	<div style=" float:left;margin-top:15px;background-color:#EBBF73"">
<script type="text/javascript">
    /*890*60 创建于 2015-07-15*/
    var cpro_id = "u2210314";
</script>
<script src="https://cpro.baidustatic.com/cpro/ui/c.js" type="text/javascript"></script>

</div>
	<div id="dhtj">
		<div class="title_k">
            <div class="title p14"><a href="/dsyc/index.html">胆码杀码推荐</a></div>
            <div class="title_t p12"><a href="/dsyc/index_1.html">独胆推荐</a><a href="/dsyc/index_2.html">双胆推荐</a><a href="/dsyc/index_4.html">杀一码</a>  <a href="/dsyc/index_5.html">杀二码</a></div>
		</div>
		<div class="t_box p14">
            <div class="txx"><a href="/dsyc/list_2_1.html" title="好彩仙子">好彩仙子</a></div>
            <div class="txx"><a href="/dsyc/list_3_1.html" title="健哥三码">健哥三码</a></div>
            <div class="txx"><a href="/dsyc/list_4_1.html" title="河北老人pk10">河北老人pk10</a></div>
            <div class="txx"><a href="/dsyc/list_5_1.html" title="欧阳修">欧阳修</a></div>
            <div class="txx"><a href="/dsyc/list_6_1.html" title="军师送胆">军师送胆</a></div>
            <div class="txx"><a href="/dsyc/list_7_1.html" title="东北人推双胆">东北人推双胆</a></div>
            <div class="txx"><a href="/dsyc/list_8_1.html" title="峰哥看胆">峰哥看胆</a></div>
            <div class="txx"><a href="/dsyc/list_9_1.html" title="算命人">算命人</a></div>
            <div class="txx"><a href="/dsyc/list_10_1.html" title="天天二码">天天二码</a></div>
            <div class="txx"><a href="/dsyc/list_11_1.html" title="老陈送胆">老陈送胆</a></div>
            <div class="txx"><a href="/dsyc/list_32_1.html" title="凌海去双码">凌海去双码</a></div>
            <div class="txx"><a href="/dsyc/list_14_1.html" title="风月双码">风月双码</a></div>
            <div class="txx"><a href="/dsyc/list_15_1.html" title="一休哥pk10">一休哥pk10</a></div>
            <div class="txx"><a href="/dsyc/list_16_1.html" title="天马送胆">天马送胆</a></div>
            <div class="txx"><a href="/dsyc/list_17_1.html" title="齐鲁双胆">齐鲁双胆</a></div>
            <div class="txx"><a href="/dsyc/list_18_1.html" title="一字并肩王">一字并肩王</a></div>
            <div class="txx"><a href="/dsyc/list_19_1.html" title="神算子送双码">神算子送双码</a></div>
            <div class="txx"><a href="/dsyc/list_20_1.html" title="对望双胆">对望双胆</a></div>
            <div class="txx"><a href="/dsyc/list_21_1.html" title="一定牛送三胆">一定牛送三胆</a></div>
            <div class="txx"><a href="/dsyc/list_22_1.html" title="神狐看三码">神狐看三码</a></div>
            <div class="txx"><a href="/dsyc/list_23_1.html" title="清秋三胆">清秋三胆</a></div>
            <div class="txx"><a href="/dsyc/list_24_1.html" title="魔力鸟">魔力鸟</a></div>
            <div class="txx"><a href="/dsyc/list_25_1.html" title="白天鹅三码">白天鹅三码</a></div>
            <div class="txx"><a href="/dsyc/list_26_1.html" title="大富杀码">大富杀码</a></div>
            <div class="txx"><a href="/dsyc/list_1_1.html" title="袍哥人家">袍哥人家</a></div>
            <div class="txx"><a href="/dsyc/list_13_1.html" title="月下老人">月下老人</a></div>
            <div class="txx"><a href="/dsyc/list_27_1.html" title="空心菜杀码">空心菜杀码</a></div>
            <div class="txx"><a href="/dsyc/list_38_1.html" title="啊牛杀码">啊牛杀码</a></div>
            <div class="txx"><a href="/dsyc/list_28_1.html" title="横财就手杀码">横财就手杀码</a></div>
            <div class="txx"><a href="/dsyc/list_33_1.html" title="粉百合杀码">粉百合杀码</a></div>
            <div class="txx"><a href="/dsyc/list_34_1.html" title="三清观杀码">三清观杀码</a></div>
            <div class="txx"><a href="/dsyc/list_35_1.html" title="三颗星杀码">三颗星杀码</a></div>
            <div class="txx"><a href="/dsyc/list_36_1.html" title="老汉杀码">老汉杀码</a></div>
            <div class="txx"><a href="/dsyc/list_37_1.html" title="神之云杀码">神之云杀码</a></div>
            <div class="txx"><a href="/dsyc/list_39_1.html" title="铁人杀码">铁人杀码</a></div>
            <div class="txx"><a href="/dsyc/list_40_1.html" title="老孙头杀码">老孙头杀码</a></div>
		</div>
		<div class="t_box"   style="display:none;">
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

    <!-- 胆码杀码类文章top显示 begin -->
    <div class="rtNews">
		<div class="rtTitle_k">
		<div class="rtTitle p14"><a href="/3ddm/list.html">胆码条件</a></div>
		<div class="rtTitle_t p12">好彩网胆码条件</div>
		</div>
        <div class="rtList">
            <asp:Repeater ID="fc3ddmlist" runat="server" EnableViewState="false"><ItemTemplate>               
            <div class="<%#GetNewIsHot(DataBinder.Eval(Container.DataItem,"ishot"),DataBinder.Eval(Container.DataItem,"isbest"),DataBinder.Eval(Container.DataItem,"istop"))%>">
                <a href="/3ddm/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime")) %>/<%#DataBinder.Eval(Container.DataItem,"nid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "title")%>" target="_blank"><%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),16)%></a></a>
            </div>
            </ItemTemplate></asp:Repeater>
        </div>
	</div>
    <div class="rtNews">
		<div class="rtTitle_k">
		<div class="rtTitle p14"><a href="/3dsm/list.html">杀码推荐</a></div>
		<div class="rtTitle_t p12">好彩网杀码推荐</div>
		</div>
        <div class="rtList">
            <asp:Repeater ID="fcsdsmlist" runat="server" EnableViewState="false"><ItemTemplate>               
            <div class="<%#GetNewIsHot(DataBinder.Eval(Container.DataItem,"ishot"),DataBinder.Eval(Container.DataItem,"isbest"),DataBinder.Eval(Container.DataItem,"istop"))%>">
                <a href="/3dsm/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime")) %>/<%#DataBinder.Eval(Container.DataItem,"nid")%>.html" title="<%#DataBinder.Eval(Container.DataItem, "title")%>" target="_blank"><%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),16)%></a></a>
            </div>
            </ItemTemplate></asp:Repeater>
        </div>
	</div>
    <!-- 胆码杀码类文章top显示 end -->

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
    <td height="22" align="center" bgcolor="#EA7B68"><a href="/sdhot/list_146_1.html">3d铁算盘</a></td>
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
    <td height="22" align="center" bgcolor="#EA7B68"><a href="/sdhot/list_149_1.html">3D布衣神算</a></td>
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
	 <div class="ylwtxt p14"><a href="http://bbs.haocw.com/showforum-22.aspx">欢迎大家给我们提意见，用户至上，我们尽量满足大家的需求，点击这里提意见！ </a></div>
</div>
</div>
 </div>



<div class="w1200">
	<div class="bd_1">

<script type="text/javascript">   /*960*60 创建于 2014-09-23*/   var cpro_id = "u1730446";</script>
<script src="https://cpro.baidustatic.com/cpro/ui/c.js" type="text/javascript"></script>

</div>
	<div class="bd_2">
<script type="text/javascript">   /*225*60 创建于 2014-09-23*/   var cpro_id = "u1730442";</script>
<script src="https://cpro.baidustatic.com/cpro/ui/c.js" type="text/javascript"></script>

</div>
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
                <%=sdycad %>
                <%=sdzmad %>		
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


<div class="w1200" style="margin-top:15px;"><a href="http://www.haocw.com/"><img src="image/haog.gif" width="1199" height="104" border="0" /></a></div>

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

<!--热点导航  begin!-->
<%=Business.Pagetj.GetPageInfo(5).context%>
<!--热点导航  end!-->

<div class="w1200 p14" style="margin-top:30px;">
<script type="text/javascript">
    /*960*60 创建于 2014-09-23*/
    var cpro_id = "u1730446";
</script>
<script src="http://cpro.baidustatic.com/cpro/ui/c.js" type="text/javascript"></script>
	<div class="hzmt">合作媒体</div>
	<div id="yq">
    	<%=friendlink%>
	</div>
</div>

<uc2:footer ID="footer1" runat="server" />

</body>
</html>