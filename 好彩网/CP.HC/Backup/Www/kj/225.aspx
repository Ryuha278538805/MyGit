<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="225.aspx.cs" Inherits="Www.kaijiang._225" %>
<%@ Register src="/header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="/footer.ascx" tagname="footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>体彩22选5第<%=info.qi%>期开奖结果</title>
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
    <td height="40" colspan="2" align="center" bgcolor="#FFFFFF"><h1>体彩22选5 第<span class="redtext"><%=info.qi%></span>期开奖结果</h1></td>
    <td width="208" height="300" rowspan="9" valign="top" bgcolor="#FFFFFF">

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
    <td width="213" height="38" align="right" bgcolor="#FFFFFF">体彩22选5第
        <select id="" name="" onChange="location.replace(this.options[this.selectedIndex].value);">
       <asp:Repeater ID="list" runat="server" EnableViewState="false"><ItemTemplate>
      <option value="<%#DataBinder.Eval(Container.DataItem,"qi")%>.html" <%#GetSelect(qi,DataBinder.Eval(Container.DataItem,"qi"))%>><%#DataBinder.Eval(Container.DataItem,"qi")%></option>
      </ItemTemplate></asp:Repeater>	
    </select>
        期：	</td>
    <td width="575" bgcolor="#FFFFFF">
	<div class="kj p12">
		 <div class="red"><%=GetKjh(info.a)%></div>
		 <div class="red"><%=GetKjh(info.b)%></div>
		 <div class="red"><%=GetKjh(info.c)%></div>
         <div class="red"><%=GetKjh(info.d)%></div>
         <div class="red"><%=GetKjh(info.e)%></div>		 
	</div>	</td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">一等奖：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zj1)%> 注 每注 <span class="redtext"><%=GetNumStr(info.prize1)%></span>元</div></td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">二等奖：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zj2)%> 注 每注 <span class="redtext"><%=GetNumStr(info.prize2)%></span>元</div></td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">三等奖：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zj3)%> 注 每注 <span class="redtext"><%=GetNumStr(info.prize3)%></span>元</div></td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">投注金额：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.tzmoney)%> 元</div></td>
  </tr>
</table>
	</div>
</div>


<div class="w1000 h8" >
<uc2:footer ID="footer1" runat="server" />
</div>
</body>
</html>
