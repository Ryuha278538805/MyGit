<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="p3.aspx.cs" Inherits="Www.kj.p3" %>
<%@ Register src="/header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="/footer.ascx" tagname="footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>体彩排列三开奖号第<%=info.qi%>期开奖结果</title>
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
    <td height="40" colspan="2" align="center" bgcolor="#FFFFFF"><h1>体彩排列三 第<span class="redtext"><%=info.qi%></span>期开奖结果</h1></td>
    <td width="208" height="300" rowspan="6" valign="top" bgcolor="#FFFFFF">
    
    	<table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#CCCCCC">
		  <tr>
			<td width="65%" height="35" align="center" bgcolor="#FFFFFF"><span style="font-size:14px; font-weight:bold">最新P3论坛贴</span></td>
			<td width="35%" align="center" bgcolor="#FFFFFF"><span class="gd"><a href="http://bbs.haocw.com/showforum-9.aspx" target="_blank">进入论坛</a></span></td>
		  </tr>
					<asp:Repeater ID="bbsp3list" runat="server" EnableViewState="false"><ItemTemplate>
					<tr><td colspan="2" bgcolor="#FFFFFF" class="Ss1" style="text-overflow:ellipsis;white-space:nowrap;overflow:hidden; line-height:20px;"><a href="http://bbs.haocw.com/showtopic-<%#DataBinder.Eval(Container.DataItem, "tid").ToString().Trim()%>.aspx" target="_blank" title="<%#DataBinder.Eval(Container.DataItem, "title").ToString().Trim()%>"> <%#GetCutString(DataBinder.Eval(Container.DataItem, "title").ToString().Trim(),28)%></a></td></tr>
					</ItemTemplate></asp:Repeater> 
		</table>
    
	</td>
  </tr>
  <tr>
    <td width="213" height="38" align="right" bgcolor="#FFFFFF">体彩排列三第
        <select id="" name="" onChange="location.replace(this.options[this.selectedIndex].value);">
       <asp:Repeater ID="list" runat="server" EnableViewState="false"><ItemTemplate>
      <option value="<%#DataBinder.Eval(Container.DataItem,"qi")%>.html" <%#GetSelect(qi,DataBinder.Eval(Container.DataItem,"qi"))%>><%#DataBinder.Eval(Container.DataItem,"qi")%></option>
      </ItemTemplate></asp:Repeater>	
    </select>
        期：	</td>
    <td width="575" bgcolor="#FFFFFF">
	<div class="kj p12">
		 <div class="red"><%=info.a%></div>
		 <div class="red"><%=info.b%></div>
		 <div class="red"><%=info.c%></div>
	</div>	</td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">直选：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zj1)%> 注 每注 <span class="redtext">1,000</span>元</div></td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">组三：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zj2)%> 注 每注 <span class="redtext">320</span>元</div></td>
  </tr>
  <tr>
    <td height="38" align="right" bgcolor="#FFFFFF">组六：</td>
    <td bgcolor="#FFFFFF"><div class="kj"><%=GetNumStr(info.zj3)%> 注 每注 <span class="redtext">160</span>元</div></td>
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
