<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="yc_info.aspx.cs" Inherits="Www.yc.yc_info" %>
<%@ Register src="../header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="../footer.ascx" tagname="footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title><%=info.title%> - <%=yzinfo.name%> - 好彩网</title>
<meta name="keywords" content="好彩网胆码、杀码推荐、福彩3D图谜、3D预测" />
<meta name="description" content="好彩网致力于彩票资讯,收录各大专业彩票网站上收录其精华内容,方便彩民朋友浏览。" />
<meta name="description" content="<%=info.title%>" /> 
<link rel="icon" href="/favicon.ico" type="image/x-icon" />
<link rel="shortcut icon" href="/favicon.ico" type="image/x-icon" />
<link href="/css/css.css" rel="stylesheet" type="text/css" />
<style type="text/css">td{padding-left:10px; padding-top:5px;}</style>
<script type="text/javascript" src="http://cbjs.baidu.com/js/m.js"></script>
<script type="text/javascript">
BAIDU_CLB_preloadSlots("731256","642651","730669","663798","680180","663798","632248","632247");
</script>
</head>
<body>
<uc1:header ID="header1" runat="server" />
<div class="w1200" >
<div style="margin-top:15px;"><script type="text/javascript" src="http://www.haocw.com/js/1.js"></script></div>
</div>
<div class="w1200" >
	<div id="lry">
	<div class="left">
    	<div class="title p14"><img src="/image/weizhit.gif" border="0" align="absmiddle" /><a href="/">好彩网首页</a><img src="/image/weizhij.gif" border="0" align="absmiddle" /><a href="/dsyc/index.html">胆码杀码推荐</a><img src="/image/weizhij.gif" border="0" align="absmiddle" /><a href="/dsyc/list_<%=info.yzid%>_1.html"><%=yzinfo.name%></a><img src="/image/weizhij.gif" /><%=info.title%></div>
		<div class="title1"><h1><%=info.title%></h1></div>
		<div class="tim p12"><%=info.addtime.ToString("MM月dd日  HH:mm")%> 作者：<%=yzinfo.name%></div>
		<div class="lry_gg"><script type="text/javascript" src="http://www.haocw.com/js/2.js"></script></div>
		<div class="lry_t">
		标签：<a href="/dsyc/list_<%=info.yzid%>_1.html"><%=yzinfo.name%></a><br />
		<%=yzinfo.contexthead%><br />
        <asp:Repeater ID="historylist" runat="server" EnableViewState="false"><ItemTemplate>
        <%#DataBinder.Eval(Container.DataItem, "context")%><br />           
        </ItemTemplate></asp:Repeater>
		<%=yzinfo.contextend%>
        
		</div>
		<div class="lry_t">
			<div class="lry_shan">上一篇: <%=pre%></div>
			<div class="lry_xia">下一篇: <%=next%></div>
		</div>
    <div class="lry_xiabox p14">
        	<asp:Repeater ID="xgzonelist" runat="server" EnableViewState="false"><ItemTemplate>
            <a href="/dsyc/list_<%#DataBinder.Eval(Container.DataItem,"zid")%>_1.html" <%#GetIsNewZone(DataBinder.Eval(Container.DataItem,"zid"))%>  title="<%#DataBinder.Eval(Container.DataItem,"name")%>" target="_blank"><%#GetCutString(DataBinder.Eval(Container.DataItem, "name").ToString().Trim(),14)%></a>
            </ItemTemplate></asp:Repeater>         
			<a href="/dsyc/index_<%=yzinfo.type%>.html" style="color:#FF0000; font-weight:bold;">查看更多<%=yctype%>...</a>
		</div>
		<div class="lry_gg"><script type="text/javascript" src="http://www.haocw.com/js/3.js"></script></div>
		<table style=" float:left;margin-top:15px;" width="90%" border="0" cellspacing="0" cellpadding="0">
		<tr>
		<td height="30" align="center"><a href="http://www.8200.cn/zs_3d/chzs.htm" style="font-size:12px;" target="_blank">福彩3D基本走势图</a></td>
		<td align="center"><a href="http://www.8200.cn/zs_3d/hzhwzs.htm" style="font-size:12px;" target="_blank">福彩3D和值走势图</a></td>
		<td align="center"><a href="http://www.8200.cn/zs_3d/zhxt.htm" style="font-size:12px;" target="_blank">福彩3D质合走势图</a></td>
		</tr>
		<tr>
		<td height="30" align="center"><a href="http://www.8200.cn/zs_3d/hzhwzs.htm" style="font-size:12px;" target="_blank">3D和值和尾走势图</a></td>
		<td align="center"><a href="http://www.8200.cn/zs_3d/zhizs.htm" style="font-size:12px;" target="_blank">福彩3D综合走势图</a></td>
		<td align="center"><a href="http://www.8200.cn/zs_3d/kdzs.htm" style="font-size:12px;" target="_blank">福彩3D跨度走势图</a></td>
		</tr>
		</table>
		
	</div>
</div>

	<div id="lry_dm" style="margin-left:15px;">
		<div class="title_k p14">
		<div class="title"><a href="/dsyc/index.html">胆码推荐</a></div>
		<div class="title_tbox"><a href="/dsyc/index.html">杀码推荐</a></div>
		<div class="title_tbox"><a href="/jpt/list.html">好彩图库</a></div>
		</div>
		<div class="t_box">
		<asp:Repeater ID="danmalist" runat="server" EnableViewState="false"><ItemTemplate>
             <%#GetTop2YcInfoStrByYZID(DataBinder.Eval(Container.DataItem,"yzid"))%>
            </ItemTemplate></asp:Repeater>
		</div>

	</div>	
	
	<div id="lry_gd" style="margin-left:15px;">
		<div class="title_k">
		<div class="title p14">重点关注</div>
		</div>
		<div class="list">
		 		<%i=1;%>
            	<asp:Repeater ID="xglist" runat="server" EnableViewState="false"><ItemTemplate>
                <div class="pm3 p12" style="text-align:center;"><%=i%></div>
				<div class="txt p12"><a href="/<%#GetNewsClassInfo(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"cid"))).ename %>/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime")) %>/<%#DataBinder.Eval(Container.DataItem,"nid")%>.html" target="_blank" title="<%#DataBinder.Eval(Container.DataItem, "title").ToString().Trim()%>" style='color:<%#DataBinder.Eval(Container.DataItem,"color")%>'> <%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),22)%></a></div>
				<div class="tim p12"><%#GetDate(DataBinder.Eval(Container.DataItem, "addtime"))%></div>                
         <%i++;%></ItemTemplate></asp:Repeater>
			</div>
	</div>
</div>

<uc2:footer ID="footer1" runat="server" />
</body>
</html>