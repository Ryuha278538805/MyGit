﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dlt.aspx.cs" Inherits="Www.kj.dlt" %>
<%@ Register src="/header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="/footer.ascx" tagname="footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>大乐透第<%=info.qi%>期开奖结果</title>
<meta http-equiv="X-UA-Compatible" content="IE=7" />
<link href="/css/css.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="/js/jquery-1.8.0.min.js"></script>
</head>

<body>
<uc1:header ID="header1" runat="server" />
<div class="w1200" >
	<div id="kaij3">

	<table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#CCCCCC">
  <tr>
    <td height="40" colspan="4" align="center" bgcolor="#FFFFFF"><h1>大乐透 第<span class="redtext"><%=info.qi%></span>期开奖结果</h1></td>
    <td width="208" height="300" rowspan="12" valign="top" bgcolor="#FFFFFF">

		<table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#CCCCCC">
		  <tr>
			<td width="65%" height="35" align="center" bgcolor="#FFFFFF"><span style="font-size:14px; font-weight:bold">论坛最新贴</span></td>
			<td width="35%" align="center" bgcolor="#FFFFFF"><span class="gd"><a href="http://bbs.haocw.com" target="_blank">进入论坛</a></span></td>
		  </tr>		
					<asp:Repeater ID="bbslist" runat="server" EnableViewState="false"><ItemTemplate>
					<tr><td colspan="2" bgcolor="#FFFFFF" class="Ss1" style="text-overflow:ellipsis;white-space:nowrap;overflow:hidden; line-height:20px;"><a href="http://bbs.haocw.com/showtopic-<%#DataBinder.Eval(Container.DataItem, "tid").ToString().Trim()%>.aspx" target="_blank" title="<%#DataBinder.Eval(Container.DataItem, "title").ToString().Trim()%>"> <%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),28)%></a></td></tr>
					</ItemTemplate></asp:Repeater> 
		</table>
	

	</td>
  </tr>
  <tr>
    <td width="219" height="38" align="right" bgcolor="#FFFFFF">大乐透第
        <select id="" name="" onChange="location.replace(this.options[this.selectedIndex].value);">
       <asp:Repeater ID="list" runat="server" EnableViewState="false"><ItemTemplate>
      <option value="<%#DataBinder.Eval(Container.DataItem,"qi")%>.html" <%#GetSelect(qi,DataBinder.Eval(Container.DataItem,"qi"))%>><%#DataBinder.Eval(Container.DataItem,"qi")%></option>
      </ItemTemplate></asp:Repeater>	
    </select>
        期：	</td>
    <td colspan="3" bgcolor="#FFFFFF">
	<div class="kj p12">
		 <div class="red"><%=GetKjh(info.a)%></div>
		 <div class="red"><%=GetKjh(info.b)%></div>
		 <div class="red"><%=GetKjh(info.c)%></div>
		 <div class="red"><%=GetKjh(info.d)%></div>
         <div class="red"><%=GetKjh(info.e)%></div>
         <div class="blue"><%=GetKjh(info.f)%></div>
         <div class="blue"><%=GetKjh(info.g)%></div>
	</div>	</td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">一等奖：</td>
    <td width="339" bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zj1)%> 注 每注 <span class="redtext"><%=GetNumStr(info.jo1)%></span>元</div></td>
    <td width="187" align="right" bgcolor="#FFFFFF">追加一等奖：</td>
    <td width="377" bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zzj1)%> 注 每注 <span class="redtext"><%=GetNumStr(info.zjo1)%></span>元</div></td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">二等奖：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zj2)%> 注 每注 <span class="redtext"><%=GetNumStr(info.jo2)%></span>元</div></td>
    <td align="right" bgcolor="#FFFFFF">追加二等奖：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zzj2)%> 注 每注 <span class="redtext"><%=GetNumStr(info.zjo2)%></span>元</div></td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">三等奖：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zj3)%> 注 每注 <span class="redtext"><%=GetNumStr(info.jo3)%></span>元</div></td>
    <td align="right" bgcolor="#FFFFFF">追加三等奖：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zzj3)%> 注 每注 <span class="redtext"><%=GetNumStr(info.zjo3)%></span>元</div></td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">四等奖：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zj4)%> 注 每注<span class="redtext"><%=GetNumStr("3000")%></span>元</div></td>
    <td align="right" bgcolor="#FFFFFF">追加四等奖：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zzj4)%> 注 每注 <span class="redtext"><%=GetNumStr("1500")%></span>元</div></td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">五等奖：</td>
    <td bgcolor="#FFFFFF"><span class="kj"><%=GetNumStr(info.zj5)%> 注 每注 <span class="redtext">600</span>元</span></td>
    <td align="right" bgcolor="#FFFFFF">追加五等奖：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zzj5)%> 注 每注 <span class="redtext">300</span>元</div></td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">六等奖：</td>
    <td bgcolor="#FFFFFF"><span class="kj"><%=GetNumStr(info.zj6)%> 注 每注 <span class="redtext">100</span>元</span></td>
    <td align="right" bgcolor="#FFFFFF">追加六等奖：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zzj6)%> 注 每注 <span class="redtext">50</span>元</div></td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">七等奖：</td>
    <td bgcolor="#FFFFFF"><span class="kj"><%=GetNumStr(info.zj7)%> 注 每注 <span class="redtext">10</span>元</span></td>
    <td align="right" bgcolor="#FFFFFF">追加七等奖：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zzj7)%> 注 每注 <span class="redtext">5</span>元</div></td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">八等奖：</td>
    <td bgcolor="#FFFFFF"><span class="kj"><%=GetNumStr(info.zj8)%> 注 每注 <span class="redtext">5</span>元</span></td>
    <td align="right" bgcolor="#FFFFFF"> 幸运奖 ：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.fjzj)%> 注 每注 <span class="redtext">60</span>元</div></td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">投注金额：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.tzmoney)%> 元</div></td>
    <td align="right" bgcolor="#FFFFFF">追加投注金额：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.fjtzmoney)%> 元</div></td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">奖池基金：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.nextmoney)%> 元</div></td>
    <td align="right" bgcolor="#FFFFFF">&nbsp;</td>
    <td bgcolor="#FFFFFF">&nbsp;</td>
  </tr>
</table>
	</div>
</div>


<div class="w1000 h8" >
<uc2:footer ID="footer1" runat="server" />
</div>
</body>
</html>
