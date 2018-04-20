<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Www.kjh.index" %>
<%@ Register src="/header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="/footer.ascx" tagname="footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>彩票开奖公告-福彩3D开奖结果-双色球开奖结果 - 好彩网</title>
<meta name="description" content="彩票开奖公告-福彩3D开奖结果-双色球开奖结果" /> 
<link href="/css/css.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="/js/jquery-1.8.0.min.js"></script>
</head>
<body>
<uc1:header ID="header1" runat="server" />
<div class="dhbg"></div>
<div class="w1200" >
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
</div>


<div class="w1000 h8" >
<uc2:footer ID="footer1" runat="server" />
</div>
</body>
</html>
