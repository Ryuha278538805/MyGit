<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Admin.login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN""http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>管理登录</title>
		<link rel="stylesheet" href="resources/css/reset.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="resources/css/style.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="resources/css/invalid.css" type="text/css" media="screen" />	
		<script type="text/javascript" src="resources/scripts/jquery-1.3.2.min.js"></script>
		<script type="text/javascript" src="resources/scripts/simpla.jquery.configuration.js"></script>
		<script type="text/javascript" src="resources/scripts/facebox.js"></script>
		<script type="text/javascript" src="resources/scripts/jquery.wysiwyg.js"></script>
		<!--[if IE 6]>
			<script type="text/javascript" src="resources/scripts/DD_belatedPNG_0.0.7a.js"></script>
			<script type="text/javascript">
				DD_belatedPNG.fix('.png_bg, img, li');
			</script>
		<![endif]-->
</head>
<body id="login">
		<div id="login-wrapper" class="png_bg">
			<div id="login-top">
				<h1>管理登录</h1>
				<img id="logo" src="resources/images/logo.png" alt="管理登录" />
			</div> 
			
			<div id="login-content">
				
				<form  runat="server">
				
					<div class="notification information png_bg">
						<div>
							<asp:label id="info" runat="server" Width="550px" ToolTip="出错提示"></asp:label>
						</div>
					</div>
					
					<p>
						<label><asp:label id="user" runat="server" DESIGNTIMEDRAGDROP="42">帐号: </asp:label></label>
						<asp:textbox id="txtUserName" runat="server" CssClass="text-input" Width="180px"></asp:textbox>
					</p>
					<div class="clear"></div>
					<p>
						<label>密码</label>
						<asp:textbox id="txtPassWord" runat="server" CssClass="text-input" Width="180px" TextMode="Password"></asp:textbox>
					</p>	
					<div class="clear"></div>
					<p>
						<asp:button id="Enter" runat="server" CssClass="button" Text=" 登 录 " onclick="Enter_Click"></asp:button>
					</p>
					
				</form>
			</div>
			
		</div>
</body>
</HTML>
