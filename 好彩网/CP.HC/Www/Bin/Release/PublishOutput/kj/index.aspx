<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Www.kjh.index" %>
<%@ Register src="/header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="/footer.ascx" tagname="footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>三d开奖号码/三d开奖结果/双色球开奖结果/彩票开奖公告_好彩网</title>
<meta name="description" content="彩票开奖公告-福彩3D开奖结果-双色球开奖结果" /> 
<link href="/css/css.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="/js/jquery-1.8.0.min.js"></script>
</head>
<style type="text/css">
<!--
.tkt a{ font-size:14px; font-weight:bold; color:#FF0000;line-height:40px; margin-left:10px;}
.tk { width:370px;}
.tk a{ font-size:12px; margin-left:10px; color:#000000; line-height:25px;}
.tk div{width:116px;float:left;margin: 2px;border: 1px solid #666666;background-color: #FEF8C2;}
-->
</style>
<body>
<uc1:header ID="header1" runat="server" />
<div class="dhbg"></div>
<div class="w1200" >
	<div style="margin-top:15px;"><script type="text/javascript" src="http://www.haocw.com/js/1.js"></script></div>
	<div id="kaij1">
		<div style="height:50px;"><h1>好彩网开奖数据公告 <span style="font-size:12px; font-weight:normal;">直播开奖： <a href="live_3d.html">福彩3d</a> <a href="live_p3.html">排列三</a> <a href="live_ssq.html">双色球</a></span></h1></div>
		<table width="100%" border="0" cellpadding="0" cellspacing="0"><tr><td height="40" bgcolor="FFECD0" style="line-height:40px;">
		<div class="kaijian_sjh p14">        
        		 <%if(info3dnew.kjh!=null&&info3dnew.kjh > 0){%>
                 		<div style="float:left; font-weight:normal; margin:0px 0px 0px 20px;">福彩3D 第<%=GetQi(info3dnew.qi+1)%>期 试机号：每日18.35-18.40更新</div>				
                 <%}else{%>      
                 <div style="float:left; font-weight:normal; margin:0px 0px 0px 20px;">福彩3D 第<%=GetQi(info3dnew.qi)%>期 试机号：</div>				 
				 <div class="org"><%=info3dnew.sjh.ToString("000").Substring(0,1)%></div>
				 <div class="org"><%=info3dnew.sjh.ToString("000").Substring(1,1)%></div>
                 <div class="org"><%=info3dnew.sjh.ToString("000").Substring(2,1)%></div>
                 <%}%>
		</div>
        <div style="float:right; margin-right:10px;">
        <select name="cz" id="cz">
          <option value="3d">福彩3D</option>
          <option value="ssq">双色球</option>
          <option value="qlc">七乐彩</option>
          <option value="p3">排列三</option>
          <option value="p5">排列五</option>
          <option value="dlt">大乐透</option>
          <option value="qxc">七星彩</option>
          <option value="225">22选5</option>
        </select> 
        <input name="qi" id="qi" type="text" /> 
        <input name="show" id="show" type="button" value="查看"/>
        <script type="text/javascript">
		$("#show").click(function(){
								  var cz = $("#cz").val();
								  var qi = $("#qi").val();
								  var myDate = new Date();
								  if(qi.length==3)	
								  	qi=myDate.getFullYear()+qi;
								  location.href='/kj/'+cz+'/'+qi+'.html';
								  })
		</script>
        </div>
        </td></tr></table>
		<div class="top p14">
			<div class="w40">&nbsp;</div>
			<div class="w150">彩种</div>
			<div class="w250">开奖结果</div>
			<div class="w100">奖期</div>
			<div class="w150">开奖日期</div>
			<div class="w100">奖池滚存</div>
			<div class="w100">开奖时间</div>
			<div class="w60">历史</div>
		</div>
		<div class="lin p14">
			<div class="w40"><img src="/image/lindan<%=ChkIsToday("1234567")%>.png" alt="是否开奖" /></div>
			<div class="w150 cen">福彩3d</div>
			<div class="w250">
				 <div class="red"><%=info3d.a%></div>
				 <div class="red"><%=info3d.b%></div>
				 <div class="red"><%=info3d.c%></div>
			</div>
			<div class="w100 cen"><%=info3d.qi%>期</div>
			<div class="w150 cen"><%=GetDate(info3d.date)%></div>
			<div class="w100 tright"><%=GetNumStr(info3d.tzmoney)%> 元</div>
			<div class="w100 cen">每天</div>
			<div class="w60 cen"><a href="3d/list.html" target="_blank"><img src="/image/gongju.jpg" alt="历史"  border="0"/></a></div>
		</div>
        <div class="lin p14 bg">
			<div class="w40"><img src="/image/lindan<%=ChkIsToday("247")%>.png" alt="是否开奖" /></div>
			<div class="w150 cen">双色球</div>
			<div class="w250">
				 <div class="red"><%=GetKjh(infossq.a)%></div>
				 <div class="red"><%=GetKjh(infossq.b)%></div>
				 <div class="red"><%=GetKjh(infossq.c)%></div>
				 <div class="red"><%=GetKjh(infossq.d)%></div>
				 <div class="red"><%=GetKjh(infossq.e)%></div>
				 <div class="red"><%=GetKjh(infossq.f)%></div>
				 <div class="blue"><%=GetKjh(infossq.g)%></div>
			</div>
			<div class="w100 cen"><%=infossq.qi%>期</div>
			<div class="w150 cen"><%=GetDate(infossq.date)%></div>
			<div class="w100 tright"><%=GetNumStr(infossq.tzmoney)%> 元</div>
			<div class="w100 cen">二 四 日</div>
			<div class="w60 cen"><a href="ssq/list.html" target="_blank"><img src="/image/gongju.jpg" alt="历史"  border="0"/></a></div>
		</div>
        <div class="lin p14">
			<div class="w40"><img src="/image/lindan<%=ChkIsToday("135")%>.png" alt="是否开奖" /></div>
			<div class="w150 cen">七乐彩</div>
			<div class="w250">
				 <div class="red"><%=GetKjh(infoqlc.a)%></div>
				 <div class="red"><%=GetKjh(infoqlc.b)%></div>
				 <div class="red"><%=GetKjh(infoqlc.c)%></div>
				 <div class="red"><%=GetKjh(infoqlc.d)%></div>
				 <div class="red"><%=GetKjh(infoqlc.e)%></div>
				 <div class="red"><%=GetKjh(infoqlc.f)%></div>
				 <div class="red"><%=GetKjh(infoqlc.g)%></div>
                 <div class="blue"><%=GetKjh(infoqlc.h)%></div>
			</div>
			<div class="w100 cen"><%=infoqlc.qi%>期</div>
			<div class="w150 cen"><%=GetDate(infoqlc.date)%></div>
			<div class="w100 tright"><%=GetNumStr(infoqlc.tzmoney)%> 元</div>
			<div class="w100 cen">一 三 五</div>
			<div class="w60 cen"><a href="qlc/list.html" target="_blank"><img src="/image/gongju.jpg" alt="历史"  border="0"/></a></div>
		</div>
		<div class="lin p14 bg">
			<div class="w40"><img src="/image/lindan<%=ChkIsToday("1234567")%>.png" alt="是否开奖" /></div>
			<div class="w150 cen">体彩P3</div>
			<div class="w250">
				 <div class="red"><%=infop3.a%></div>
				 <div class="red"><%=infop3.b%></div>
				<div class="red"> <%=infop3.c%></div>
			</div>
			<div class="w100 cen"><%=infop3.qi%>期</div>
			<div class="w150 cen"><%=GetDate(infop3.date)%></div>
			<div class="w100 tright"><%=GetNumStr(infop3.tzmoney)%> 元</div>
			<div class="w100 cen">每天</div>
			<div class="w60 cen"><a href="p3/list.html" target="_blank"><img src="/image/gongju.jpg" alt="历史"  border="0"/></a></div>
		</div>
        <div class="lin p14">
			<div class="w40"><img src="/image/lindan<%=ChkIsToday("1234567")%>.png" alt="是否开奖" /></div>
			<div class="w150 cen">体彩P5</div>
			<div class="w250">
				 <div class="red"><%=infop3.a%></div>
				 <div class="red"><%=infop3.b%></div>
				<div class="red"> <%=infop3.c%></div>
                <div class="red"> <%=infop3.d%></div>
                <div class="red"> <%=infop3.e%></div>
			</div>
			<div class="w100 cen"><%=infop3.qi%>期</div>
			<div class="w150 cen"><%=GetDate(infop3.date)%></div>
			<div class="w100 tright"><%=GetNumStr(infop3.tzmoneyp5)%> 元</div>
			<div class="w100 cen">每天</div>
			<div class="w60 cen"><a href="p5/list.html" target="_blank"><img src="/image/gongju.jpg" alt="历史"  border="0"/></a></div>
		</div>		
        <div class="lin p14 bg">
			<div class="w40"><img src="/image/lindan<%=ChkIsToday("136")%>.png" alt="是否开奖" /></div>
			<div class="w150 cen">大乐透</div>
			<div class="w250">
				 <div class="red"><%=GetKjh(infodlt.a)%></div>
				 <div class="red"><%=GetKjh(infodlt.b)%></div>
				 <div class="red"><%=GetKjh(infodlt.c)%></div>
				 <div class="red"><%=GetKjh(infodlt.d)%></div>
				 <div class="red"><%=GetKjh(infodlt.e)%></div>
				 <div class="blue"><%=GetKjh(infodlt.f)%></div>
				 <div class="blue"><%=GetKjh(infodlt.g)%></div>
			</div>
			<div class="w100 cen"><%=infodlt.qi%>期</div>
			<div class="w150 cen"><%=GetDate(infodlt.date)%></div>
			<div class="w100 tright"><%=GetNumStr(infodlt.tzmoney)%> 元</div>
			<div class="w100 cen">一 三 六</div>
			<div class="w60 cen"><a href="dlt/list.html" target="_blank"><img src="/image/gongju.jpg" alt="历史"  border="0"/></a></div>
		</div>
		<div class="lin p14">
			<div class="w40"><img src="/image/lindan<%=ChkIsToday("257")%>.png" alt="是否开奖" /></div>
			<div class="w150 cen">七星彩</div>
			<div class="w250">
				 <div class="red"><%=infoqxc.a%></div>
				 <div class="red"><%=infoqxc.b%></div>
				 <div class="red"><%=infoqxc.c%></div>
				 <div class="red"><%=infoqxc.d%></div>
				 <div class="red"><%=infoqxc.e%></div>
				 <div class="red"><%=infoqxc.f%></div>
				 <div class="red"><%=infoqxc.g%></div>
			</div>
			<div class="w100 cen"><%=infoqxc.qi%>期</div>
			<div class="w150 cen"><%=GetDate(infoqxc.date)%></div>
			<div class="w100 tright"><%=GetNumStr(infoqxc.tzmoney)%> 元</div>
			<div class="w100 cen">二 五 日</div>
			<div class="w60 cen"><a href="qxc/list.html" target="_blank"><img src="/image/gongju.jpg" alt="历史"  border="0"/></a></div>
		</div>
		<div class="lin p14 bg">
			<div class="w40"><img src="/image/lindan<%=ChkIsToday("1234567")%>.png" alt="是否开奖" /></div>
			<div class="w150 cen">22选5</div>
			<div class="w250">
				 <div class="red"><%=GetKjh(info225.a)%></div>
				 <div class="red"><%=GetKjh(info225.b)%></div>
				 <div class="red"><%=GetKjh(info225.c)%></div>
				 <div class="red"><%=GetKjh(info225.d)%></div>
				 <div class="red"><%=GetKjh(info225.e)%></div>
			</div>
			<div class="w100 cen"><%=info225.qi%>期</div>
			<div class="w150 cen"><%=GetDate(info225.date)%></div>
			<div class="w100 tright"><%=GetNumStr(info225.tzmoney)%> 元</div>
			<div class="w100 cen">每天</div>
			<div class="w60 cen"><a href="225/list.html" target="_blank"><img src="/image/gongju.jpg" alt="历史" border="0"/></a></div>
		</div>

	</div>
<table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr class="tkt"><td width="400" colspan="2" bgcolor="#FFEEDD" style="font-size:14px"><a href="http://www.haocw.com/jpt/list.html" target="_blank">布衣图库</a></td>
        <td width="400" colspan="2" bgcolor="#FFEEDD"><a href="http://www.haocw.com/sanmaotuku/list.html" target="_blank">三毛图库</a></td>
        <td width="400" colspan="2" bgcolor="#FFEEDD"><a href="http://www.haocw.com/hongwutuku/list.html" target="_blank">红五图库</a></td></tr>
      <tr>
        <td class="tk"> 
		<div><a href="/jpt/list_125_1.html" class=""  title="太湖钓叟三字诀">太湖钓叟三字诀</a></div>
		
		<div><a href="/jpt/list_159_1.html" class=""  title="3D藏机图">3D藏机图</a></div>
		
		<div><a href="/jpt/list_63_1.html" class=""  title="东北王">东北王</a></div>
		
		<div><a href="/jpt/list_80_1.html" class=""  title="黑圣手">黑圣手</a></div>
		
		<div><a href="/jpt/list_184_1.html" class=""  title="真精华布衣+早报">真精华布衣+早报</a></div>
		
		<div><a href="/jpt/list_62_1.html" class=""  title="丹东全图">丹东全图</a></div>
		
		<div><a href="/jpt/list_286_1.html" class=""  title="另版真精华布衣">另版真精华布衣</a></div>
		
		<div><a href="/jpt/list_186_1.html" class=""  title="小军系列">小军系列</a></div>
		
		<div><a href="/jpt/list_61_1.html" class=""  title="山东真言山东一句">山东真言山东一句</a></div>
		
		<div><a href="/jpt/list_163_1.html" class=""  title="鬼六神算">鬼六神算</a></div>
		
		<div><a href="/jpt/list_85_1.html" class=""  title="晚秋图">晚秋图</a></div>
		
		<div><a href="/jpt/list_60_1.html" class=""  title="新彩吧系列">新彩吧系列</a></div>
		
		<div><a href="/jpt/list_116_1.html" class=""  title="天宇一句定三码">天宇一句定三码</a></div>
		
		<div><a href="/jpt/list_119_1.html" class=""  title="白老系列">白老系列</a></div>
		
		<div><a href="/jpt/list_232_1.html" class=""  title="布衣千元报">布衣千元报</a></div>
		
		<div><a href="/jpt/list_194_1.html" class=""  title="网络收集包">网络收集包</a></div>
		
		<div><a href="/jpt/list_76_1.html" class=""  title="绝对布衣1234">绝对布衣1234</a></div>
		
		<div><a href="/jpt/list_132_1.html" class=""  title="鸿铄图谜">鸿铄图谜</a></div>
		
		<div><a href="/jpt/list_162_1.html" class=""  title="泓铄制作系列">泓铄制作系列</a></div>
		
		<div><a href="/jpt/list_185_1.html" class=""  title="正版鬼魂3D图谜">正版鬼魂3D图谜</a></div>
		
		<div><a href="/jpt/list_67_1.html" class=""  title="早版布衣1 2">早版布衣1 2</a></div>
		
		<div><a href="/jpt/list_75_1.html" class=""  title="佐罗代理">佐罗代理</a></div>
		
		<div><a href="/jpt/list_77_1.html" class=""  title="天宇多字和值谜">天宇多字和值谜</a></div>
		
		<div><a href="/jpt/list_70_1.html" class=""  title="蓝仙子一句定三码">蓝仙子一句定三码</a></div>
		
		<div><a href="/jpt/list_79_1.html" class=""  title="精品太湖系列">精品太湖系列</a></div>
		
		<div><a href="/jpt/list_193_1.html" class=""  title="才子图谜另版">才子图谜另版</a></div>
		
		<div><a href="/jpt/list_224_1.html" class="gray"  title="好心人布衣2合1">好心人布衣2合1</a></div>
		
		<div><a href="/jpt/list_209_1.html" class="gray"  title="乐彩解太湖">乐彩解太湖</a></div>
         
        </td>
        <td width="30">&nbsp;</td>
        <td class="tk"> 
                                <div><a href="/sanmaotuku/list_233_1.html"  class="" title="三毛系列全图">三毛系列全图</a></div>
                                
                                <div><a href="/sanmaotuku/list_234_1.html"  class="" title="三毛追奖+藏机">三毛追奖+藏机</a></div>
                                
                                <div><a href="/sanmaotuku/list_235_1.html"  class="gray" title="真三毛代理">真三毛代理</a></div>
                                
                                <div><a href="/sanmaotuku/list_236_1.html"  class="" title="三强系列">三强系列</a></div>
                                
                                <div><a href="/sanmaotuku/list_237_1.html"  class="" title="五大名吃系列">五大名吃系列</a></div>
                                
                                <div><a href="/sanmaotuku/list_238_1.html"  class="" title="一点通系列图谜">一点通系列图谜</a></div>
                                
                                <div><a href="/sanmaotuku/list_239_1.html"  class="" title="蓝版小夜猫">蓝版小夜猫</a></div>
                                
                                <div><a href="/sanmaotuku/list_240_1.html"  class="" title="华夏专家说彩">华夏专家说彩</a></div>
                                
                                <div><a href="/sanmaotuku/list_241_1.html"  class="" title="天吉系列">天吉系列</a></div>
                                
                                <div><a href="/sanmaotuku/list_242_1.html"  class="gray" title="北盟天机3D图迷">北盟天机3D图迷</a></div>
                                
                                <div><a href="/sanmaotuku/list_243_1.html"  class="" title="流星工作室图迷">流星工作室图迷</a></div>
                                
                                <div><a href="/sanmaotuku/list_244_1.html"  class="" title="凤凰快报AB版">凤凰快报AB版</a></div>
                                
                                <div><a href="/sanmaotuku/list_245_1.html"  class="" title="打击黑市胆码">打击黑市胆码</a></div>
                                
                                <div><a href="/sanmaotuku/list_246_1.html"  class="" title="3D香港彩报AB版">3D香港彩报AB版</a></div>
                                
                                <div><a href="/sanmaotuku/list_247_1.html"  class="" title="好的系列图迷">好的系列图迷</a></div>
                                
                                <div><a href="/sanmaotuku/list_249_1.html"  class="" title="小军新图1234版">小军新图1234版</a></div>
                                
                                <div><a href="/sanmaotuku/list_250_1.html"  class="" title="东哥说彩系列">东哥说彩系列</a></div>
                                
                                <div><a href="/sanmaotuku/list_251_1.html"  class="" title="大兵系列">大兵系列</a></div>
                                
                                <div><a href="/sanmaotuku/list_252_1.html"  class="" title="蝴蝶世家系列">蝴蝶世家系列</a></div>
                                
                                <div><a href="/sanmaotuku/list_253_1.html"  class="" title="乐知专家版">乐知专家版</a></div>
                                
                                <div><a href="/sanmaotuku/list_254_1.html"  class="" title="大兵鬼魂系列">大兵鬼魂系列</a></div>
                                
                                <div><a href="/sanmaotuku/list_255_1.html"  class="" title="中龙系列">中龙系列</a></div>
                                
                                <div><a href="/sanmaotuku/list_256_1.html"  class="" title="诸葛神通A B版">诸葛神通A B版</a></div>
                                
                                <div><a href="/sanmaotuku/list_257_1.html"  class="" title="真天天工作室">真天天工作室</a></div>
                                
                                <div><a href="/sanmaotuku/list_258_1.html"  class="" title="钱庄快报">钱庄快报</a></div>
                                
                                <div><a href="/sanmaotuku/list_259_1.html"  class="" title="孔老图说天下">孔老图说天下</a></div>
                                
                                <div><a href="/sanmaotuku/list_260_1.html"  class="" title="真心意系列">真心意系列</a></div>
                                
                                <div><a href="/sanmaotuku/list_68_1.html"  class="" title="九宝图">九宝图</a></div>

         
        </td>
        <td width="30">&nbsp;</td>
        <td valign="top" class="tk"> 
                                <div><a href="/hongwutuku/list_261_1.html"  class="" title="好彩网3D藏机图">好彩网3D藏机图</a></div>
                                
                                <div><a href="/hongwutuku/list_262_1.html"  class="" title="黄历看彩3D图谜">黄历看彩3D图谜</a></div>
                                
                                <div><a href="/hongwutuku/list_263_1.html"  class="" title="金胆图3D图谜">金胆图3D图谜</a></div>
                                
                                <div><a href="/hongwutuku/list_264_1.html"  class="" title="观音送胆3D图谜">观音送胆3D图谜</a></div>
                                
                                <div><a href="/hongwutuku/list_265_1.html"  class="" title="玄机图3D图谜">玄机图3D图谜</a></div>
                                
                                <div><a href="/hongwutuku/list_266_1.html"  class="" title="水晶胆码3D图谜">水晶胆码3D图谜</a></div>
                                
                                <div><a href="/hongwutuku/list_267_1.html"  class="" title="四宝莲灯3D图谜">四宝莲灯3D图谜</a></div>
                                
                                <div><a href="/hongwutuku/list_268_1.html"  class="" title="好彩一句定三码">好彩一句定三码</a></div>
                                
                                <div><a href="/hongwutuku/list_269_1.html"  class="" title="太湖转盘3D图谜">太湖转盘3D图谜</a></div>
                                
                                <div><a href="/hongwutuku/list_270_1.html"  class="" title="太湖天机3D图谜">太湖天机3D图谜</a></div>
                                
                                <div><a href="/hongwutuku/list_271_1.html"  class="" title="太湖出航3D图谜">太湖出航3D图谜</a></div>
                                
                                <div><a href="/hongwutuku/list_272_1.html"  class="" title="乾坤解码3D图谜">乾坤解码3D图谜</a></div>
                                
                                <div><a href="/hongwutuku/list_273_1.html"  class="" title="5188">5188</a></div>
                                
                                <div><a href="/hongwutuku/list_275_1.html"  class="" title="丹东彩吧联盟1">丹东彩吧联盟1</a></div>
                                
                                <div><a href="/hongwutuku/list_276_1.html"  class="" title="丹东彩吧联盟2">丹东彩吧联盟2</a></div>
                                
                                <div><a href="/hongwutuku/list_277_1.html"  class="" title="丹东彩吧联盟3">丹东彩吧联盟3</a></div>
                                
                                <div><a href="/hongwutuku/list_278_1.html"  class="" title="丹东彩吧联盟4">丹东彩吧联盟4</a></div>
                                
                                <div><a href="/hongwutuku/list_279_1.html"  class="" title="丹东彩吧联盟5">丹东彩吧联盟5</a></div>
                                
                                <div><a href="/hongwutuku/list_280_1.html"  class="gray" title="村长粮库系列">村长粮库系列</a></div>
                                
                                <div><a href="/hongwutuku/list_281_1.html"  class="" title="真小小虎">真小小虎</a></div>
                                
                                <div><a href="/hongwutuku/list_282_1.html"  class="" title="黑白系列">黑白系列</a></div>
                                
                                <div><a href="/hongwutuku/list_283_1.html"  class="" title="89系列">89系列</a></div>
                                
                                <div><a href="/hongwutuku/list_284_1.html"  class="" title="真5188系列">真5188系列</a></div>
                                
                                <div><a href="/hongwutuku/list_285_1.html"  class="gray" title="虎虎生威">虎虎生威</a></div>
                                
                                <div><a href="/hongwutuku/list_223_1.html"  class="" title="于海滨专家点评">于海滨专家点评</a></div>
                                
                                <div><a href="/hongwutuku/list_161_1.html"  class="" title="5188代理">5188代理</a></div>
                                
                                <div><a href="/hongwutuku/list_74_1.html"  class="" title="3D阳光探码">3D阳光探码</a></div>
                                
                                <div><a href="/hongwutuku/list_187_1.html"  class="" title="原始绝对布衣1234">原始绝对布衣1234</a></div>

         
        </td>
        <td width="30">&nbsp;</td>
      </tr>
    </table>


</div>


<div class="w1000 h8" >
<uc2:footer ID="footer1" runat="server" />
</div>
</body>
</html>
