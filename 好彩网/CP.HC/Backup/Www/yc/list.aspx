<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="Www.yc.list" %>
<%@ Register src="../header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="../footer.ascx" tagname="footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title><%if(typestr!=null){%><%=typestr%> |  <%}%>好彩网胆码杀码推荐 - 好彩网</title>
<meta name="keywords" content="好彩网胆码、杀码推荐、福彩3D图谜、3D预测" />
<meta name="description" content="好彩网致力于彩票资讯,收录各大专业彩票网站上收录其精华内容,方便彩民朋友浏览。" />
<link rel="icon" href="/favicon.ico" type="image/x-icon" />
<link rel="shortcut icon" href="/favicon.ico" type="image/x-icon" />
<link href="/css/css.css" rel="stylesheet" type="text/css" />

<style type="text/css">td{padding-left:10px; padding-top:5px;}</style>
<script type="text/javascript" src="http://cbjs.baidu.com/js/m.js"></script>
<script type="text/javascript">
BAIDU_CLB_preloadSlots("948372","948373","948374","948375","642651","947179","847516","846376","793687","793686","793685","730669","686329","680180","663798");
</script>

</head>

<body>
<uc1:header ID="header1" runat="server" />

<div class="w1200" >
	<div style="margin-top:15px;"><script type="text/javascript" src="http://www.haocw.com/js/1.js"></script></div>
</div>

<div class="w1200" >
	<div id="fen" style="background:#FFF; margin-top:15px;">
		<div class="title p14"><img src="/image/weizhit.gif" border="0" align="absmiddle" /> <a href="/">好彩网首页</a> <img src="/image/weizhij.gif" border="0" align="absmiddle" /> <a href="/dsyc/index.html">胆码杀码推荐</a> <%if(type>0 && type<=5){%><img src="../image/weizhij.gif"  align="absmiddle" /> <a href="/dsyc/index_<%=type%>.html"><%=typestr%>推荐</a><%}%></div>
    </div>
</div>

<div class="w1200" >
	<div id="huizt">
    		<div class="txx1<%if(type==1){%> red1<%}%>"><a href="/dsyc/index_1.html">独胆</a></div>
            <div class="txx1<%if(type==2){%> red1<%}%>"><a href="/dsyc/index_2.html">双胆</a></div>
            <div class="txx1<%if(type==3){%> red1<%}%>"><a href="/dsyc/index_3.html">三胆</a></div>
            <div class="txx1<%if(type==4){%> red1<%}%>"><a href="/dsyc/index_4.html">杀一码</a></div>
            <div class="txx1<%if(type==5){%> red1<%}%>"><a href="/dsyc/index_5.html">杀二码</a></div>
        <asp:Repeater ID="yczonelist" runat="server" EnableViewState="false">
            <ItemTemplate>          
            <div class="txx"><a href="/dsyc/list_<%#DataBinder.Eval(Container.DataItem,"yzid")%>_1.html" title="<%#DataBinder.Eval(Container.DataItem,"name")%>"><%#GetQi(DataBinder.Eval(Container.DataItem,"lastqi"))%> 期 <%#GetCutString(DataBinder.Eval(Container.DataItem, "name").ToString().Trim(),14)%></a></div>
            </ItemTemplate>
            </asp:Repeater>	
	</div>
	<div class="pag p14"></div>
<div id="zjtjs">
        <div class="lbright" >
            <div class="lbtop p14" >
                <div class="lanmm bh" >&nbsp;&nbsp;<a href="/p3sy/list.html">3D相关术语 </a> </div>
                <div class="lanmm bh" >&nbsp;&nbsp;<a href="/p3jiq/list.html">P3相关术语 </a></div>
                <div class="lanmm" >&nbsp;&nbsp;<a href="/sdgz/list.html">双色球相关术语</a></div>
            </div>
            <div class="xiak">
			
                <div class="lbtxt p12" >
                    <div class="tk"><a href="/sdsy/1120/113.html" title="福彩3D什么是大小号名词解释-大小号是什么意思" target="_blank">大小</a></div>
                    <div class="tk"><a href="/sdsy/1120/110.html" title="福彩3D什么是区间名词解释-区间是什么意思" target="_blank">区间</a></div>
                    <div class="tk"><a href="/sdsy/1120/100.html" title="福彩3D什么是九宫八卦名词解释-九宫八卦是什么意思" target="_blank">九宫八卦</a></div>
                    <div class="tk"><a href="/sdsy/1120/97.html" title="福彩3D什么是垃圾复式名词解释-垃圾复式是什么意思" target="_blank">垃圾复式</a></div>
                    <div class="tk"><a href="/sdsy/1120/95.html" title="福彩3D什么是组三组六名词解释-组三组六是什么意思" target="_blank">组三组六</a></div>
                    <div class="tk"><a href="/sdsy/1120/93.html" title="福彩3D什么是五行阴阳名词解释-五行阴阳是什么意思" target="_blank">五行阴阳</a></div>
                    <div class="tk"><a href="/sdsy/1120/92.html" title="福彩3D什么是胆拖名词解释-胆拖是什么意思" target="_blank">胆拖</a></div>
                    <div class="tk"><a href="/sdsy/1120/90.html" title="福彩3D什么是独一包二名词解释-独一包二是什么意思" target="_blank">独一包二</a></div>
                    <div class="tk"><a href="/sdsy/1120/89.html" title="福彩3D什么是热温冷号名词解释-热温冷号是什么意思" target="_blank">热温冷号</a></div>
                    <div class="tk"><a href="/sdsy/1120/87.html" title="福彩3D什么是邻孤传名词解释-邻孤传是什么意思" target="_blank">邻孤传</a></div>
                    <div class="tk"><a href="/sdsy/1120/86.html" title="福彩3D什么是重斜边名词解释-重斜边是什么意思" target="_blank">重斜边</a></div>
                    <div class="tk"><a href="/sdsy/1120/85.html" title="福彩3D什么是复隔中名词解释-复隔中是什么意思" target="_blank">复隔中</a></div>
                    <div class="tk"><a href="/sdsy/1120/84.html" title="福彩3D什么是号码跨度名词解释-号码跨度是什么意思" target="_blank">号码跨度</a></div>
                    <div class="tk"><a href="/sdsy/1120/82.html" title="福彩3D什么是俩码名词解释-俩码是什么意思" target="_blank">俩码</a></div>
                    <div class="tk"><a href="/sdsy/1120/81.html" title="福彩3D什么是遗漏名词解释-遗漏是什么意思" target="_blank">遗漏</a></div>
                    <div class="tk"><a href="/sdsy/1120/80.html" title="福彩3D什么是跟随号名词解释-跟随号是什么意思" target="_blank">跟随号</a></div>
                    <div class="tk"><a href="/sdsy/1120/78.html" title="福彩3D什么是三道全杀名词解释-三道全杀是什么意思" target="_blank">三道全杀</a></div>
                    <div class="tk"><a href="/sdsy/1120/77.html" title="福彩3D什么是五行合值名词解释-五行合值是什么意思" target="_blank">五行合值</a></div>
                    <div class="tk"><a href="/sdsy/1120/75.html" title="福彩3D什么是直连斜连名词解释-直连斜连是什么意思" target="_blank">直连斜连</a></div>
                    <div class="tk"><a href="/sdsy/1120/73.html" title="福彩3D什么是三撇原理名词解释-三撇原理是什么意思" target="_blank">三撇原理</a></div>
                    <div class="tk"><a href="/sdsy/1120/72.html" title="福彩3D什么是K线图名词解释-K线图是什么意思" target="_blank">K线图</a></div>
                    <div class="tk"><a href="/sdsy/1120/71.html" title="福彩3D什么是和值与合尾名词解释-和值与合尾是什么意思" target="_blank">和值与合尾</a></div>
                    <div class="tk"><a href="/sdsy/1120/69.html" title="福彩3D什么是杀和尾名词解释-杀和尾是什么意思" target="_blank">杀和尾</a></div>
                    <div class="tk"><a href="/sdsy/1120/68.html" title="福彩3D什么是八尾候选名词解释-八尾候选是什么意思" target="_blank">八尾候选</a></div>
                </div>

                <div class="lbtxt p12" >
                    <div class="tk"><A title="排列三什么是<形态>名词解释-<形态>值是什么意思?" href="/p3sy/1130/1751.html" target="_blank">形态</A></div>
                    <div class="tk"><A title="排列三什么是<两码>名词解释-<两码>值是什么意思?" href="/p3sy/1130/1750.html" target="_blank">两码</A></div>
                    <div class="tk"><A title="排列三什么是<大小奇偶>名词解释-<大小奇偶>值是什么意思?" href="/p3sy/1130/1749.html" target="_blank">大小奇偶</A></div>
                    <div class="tk"><A title="排列三什么是<合数>名词解释-<合数>值是什么意思?" href="/p3sy/1130/1748.html" target="_blank">合数</A></div>
                    <div class="tk"><A title="排列三什么是<和值>名词解释-<和值>值是什么意思?" href="/p3sy/1130/1747.html" target="_blank">和值</A></div>
                    <div class="tk"><A title="排列三什么是<定位>名词解释-<定位>值是什么意思?" href="/p3sy/1130/1746.html" target="_blank">定位</A></div>
                    <div class="tk"><A title="排列三什么是<传递、加减>名词解释-<传递、加减>值是什么意思?" href="/p3sy/1130/1745.html" target="_blank">传递、加减</A></div>
                    <div class="tk"><A title="排列三什么是<码>名词解释-<码>值是什么意思?" href="/p3sy/1130/1744.html" target="_blank">码 值</A></div>
                    <div class="tk"><A title="排列三什么是遗漏值名词解释-遗漏值是什么意思?" href="/p3sy/1130/1743.html" target="_blank">遗漏值</A></div>
                    <div class="tk"><A title="排列三什么是邻孤传名词解释-邻孤传是什么意思?" href="/p3sy/1130/1742.html" target="_blank">邻孤传</A></div>
                    <div class="tk"><A title="排列三什么是热温冷名词解释-热温冷是什么意思?" href="/p3sy/1130/1741.html" target="_blank">热温冷</A></div>
                    <div class="tk"><A title="排列三什么是号码特性名词解释-号码特性是什么意思?" href="/p3sy/1130/1740.html" target="_blank">号码特性</A></div>
                    <div class="tk"><A title="排列三什么是跨度名词解释-跨度是什么意思?" href="/p3sy/1130/1739.html" target="_blank">跨度</A></div>
                    <div class="tk"><A title="排列三什么是合值、和值名词解释-合值、和值是什么意思?" href="/p3sy/1130/1738.html" target="_blank">合值、和值</A></div>
                    <div class="tk"><A title="排列三什么是组三、组六、豹子名词解释-组三、组六、豹子是什么意思?" href="/p3sy/1130/1737.html" target="_blank">组三组六豹子</A></div>
                    <div class="tk"><A title="排列三什么是复合跨度名词解释-复合跨度是什么意思?" href="/p3sy/1130/1736.html" target="_blank">复合跨度</A></div>
                    <div class="tk"><A title="排列三什么是余数和名词解释-余数和是什么意思?" href="/p3sy/1130/1735.html" target="_blank">余数和</A></div>
                    <div class="tk"><A title="排列三什么是聪明组六名词解释-聪明组六是什么意思?" href="/p3sy/1130/1734.html" target="_blank">聪明组六</A></div>
                    <div class="tk"><A title="排列三什么是位差位和名词解释-位差位和是什么意思?" href="/p3sy/1130/1733.html" target="_blank">位差位和</A></div>
                    <div class="tk"><A title="排列三什么是排三合值名词解释-排三合值是什么意思?" href="/p3sy/1130/1732.html" target="_blank">排三合值</A></div>       
                </div>
                <div class="lbtxt p12" >
                    <div class="tk"><A title="双色球什么是5行相生相克码解释-5行相生相克码是什么意思？" href="/ssqsy/1129/1517.html" target="_blank">5行相生相克</A></div>
                    <div class="tk"><A title="双色球什么是五行取数解释-五行取数是什么意思？" href="/ssqsy/1129/1516.html" target="_blank">五行取数</A></div>
                    <div class="tk"><A title="双色球什么是相关性解释-相关性是什么意思？" href="/ssqsy/1129/1515.html" target="_blank">相关性</A></div>
                    <div class="tk"><A title="双色球什么是整体走势解释-整体走势是什么意思？" href="/ssqsy/1129/1514.html" target="_blank">整体走势</A></div>
                    <div class="tk"><A title="双色球什么是概率守恒定律解释-概率守恒定律是什么意思？" href="/ssqsy/1129/1513.html" target="_blank">概率守恒定律</A></div>
                    <div class="tk"><A title="双色球什么是随出有缘性解释-随出有缘性是什么意思？" href="/ssqsy/1129/1512.html" target="_blank">随出有缘性</A></div>
                    <div class="tk"><A title="双色球什么是聚集和远距解释-聚集和远距是什么意思？" href="/ssqsy/1129/1511.html" target="_blank">聚集和远距</A></div>
                    <div class="tk"><A title="双色球什么是万能23红球解释-万能23红球是什么意思？" href="/ssqsy/1129/1510.html" target="_blank">万能23红球</A></div>
                    <div class="tk"><A title="双色球什么是和值分析解释-和值分析是什么意思？" href="/ssqsy/1129/1509.html" target="_blank">和值分析</A></div>
                    <div class="tk"><A title="双色球什么是旋转矩阵解释-旋转矩阵是什么意思？" href="/ssqsy/1129/1508.html" target="_blank">旋转矩阵</A></div>
                    <div class="tk"><A title="双色球什么是黄金分割解释-黄金分割是什么意思？" href="/ssqsy/1129/1507.html" target="_blank">黄金分割</A></div>
                    <div class="tk"><A title="双色球什么是连码组数解释-连码组数是什么意思？" href="/ssqsy/1129/1506.html" target="_blank">连码组数</A></div>
                    <div class="tk"><A title="双色球什么是连码解释-连码是什么意思？" href="/ssqsy/1129/1505.html" target="_blank">连码</A></div>
                    <div class="tk"><A title="双色球什么是除三、除五、除七名词解释-除三、除五、除七是什么意思？" href="/ssqsy/1129/1504.html" target="_blank">除三、除五</A></div>
                    <div class="tk"><A title="双色球什么是中奖号码模式名词解释-中奖号码模式是什么意思？" href="/ssqsy/1129/1503.html" target="_blank">中奖号码模式</A></div>
                    <div class="tk"><A title="双色球什么是质数名词解释-质数是什么意思？" href="/ssqsy/1129/1502.html" target="_blank">质数</A></div>
                    <div class="tk"><A title="双色球什么是缩水公式名词解释-缩水公式是什么意思？" href="/ssqsy/1129/1501.html" target="_blank">缩水公式</A></div>
                    <div class="tk"><A title="双色球什么是首尾间距名词解释-首尾间距是什么意思？" href="/ssqsy/1129/1500.html" target="_blank">首尾间距</A></div>
                    <div class="tk"><A title="双色球什么是最大间距名词解释-最大间距是什么意思？" href="/ssqsy/1129/1499.html" target="_blank">最大间距</A></div>
                    <div class="tk"><A title="双色球什么是号码间距名词解释-号码间距是什么意思？" href="/ssqsy/1129/1498.html" target="_blank">号码间距</A></div>
                    <div class="tk"><A title="双色球什么是数据密度名词解释-数据密度是什么意思？" href="/ssqsy/1129/1497.html" target="_blank">数据密度</A></div>
                    <div class="tk"><A title="双色球什么是间距密度名词解释-间距密度是什么意思？" href="/ssqsy/1129/1496.html" target="_blank">间距密度</A></div>
                    <div class="tk"><A title="双色球什么是右斜码名词解释-右斜码是什么意思？" href="/ssqsy/1129/1495.html" target="_blank">右斜码</A></div>
                    <div class="tk"><A title="双色球什么是左斜码名词解释-左斜码是什么意思？" href="/ssqsy/1129/1494.html" target="_blank">左斜码</A></div>
            
                </div>
            </div>
        </div>
    </div>
</div>

<div class="w1000 h8" >
<uc2:footer ID="footer1" runat="server" />
</div>
</body>
</html>