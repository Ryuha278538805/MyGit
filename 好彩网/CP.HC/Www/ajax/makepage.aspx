<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="makepage.aspx.cs" Inherits="Www.makepage" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>生成静态</title>
	</head>
	<body>
		<form id="Form1" runat="server" name="form1">
        			<h2>生成静态页面</h2>
						   <table width="100%" border="0" cellspacing="0" cellpadding="0" align="center">
						   <tr>
                            <td>
                                <asp:Button ID="enter" runat="server" CssClass="button" onclick="enter_Click" 
                                    Text="生成静态首页" Width="150" />
                               &nbsp;
                                <asp:Label ID="Text" runat="server" ></asp:Label>
                               </td>
                            </tr>
						  
						  <tr>
                            <td>&nbsp;</td>
                            </tr>
                          <tr>
                            <td>&nbsp;</td>
                            </tr>
                        </table>
	</form>
</body>
</html>
