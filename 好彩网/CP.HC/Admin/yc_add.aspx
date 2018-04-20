<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="yc_add.aspx.cs" Inherits="Admin.yc_add" %>
<%@ Register src="/menus.ascx" tagname="menus" tagprefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>编辑预测信息</title>
		<link rel="stylesheet" href="resources/scripts/ui-lightness/jquery-ui-1.8.9.custom.css">        
		<link rel="stylesheet" href="resources/css/reset.css" type="text/css" media="screen" />	  
		<link rel="stylesheet" href="resources/css/style.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="resources/css/invalid.css" type="text/css" media="screen" />	
		<link rel="stylesheet" href="resources/css/jquery.autocomplete.css" type="text/css" media="screen" />	
		<link rel="stylesheet" href="resources/scripts/thickbox.css" type="text/css" media="screen" />			
		<link rel="stylesheet" href="resources/css/select.css" type="text/css" media="screen" />
		<!-- Colour Schemes
		Default colour scheme is green. Uncomment prefered stylesheet to use it.
		<link rel="stylesheet" href="resources/css/blue.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="resources/css/red.css" type="text/css" media="screen" />  
		-->
		<!-- Internet Explorer Fixes Stylesheet -->
		
		<!--[if lte IE 7]>
			<link rel="stylesheet" href="resources/css/ie.css" type="text/css" media="screen" />
		<![endif]-->

		<script type="text/javascript" src="resources/scripts/jquery-1.3.2.min.js"></script>
		<script type="text/javascript" src="resources/scripts/jquery.autocomplete.js"></script>	
		<!-- jQuery Configuration -->
		<script type="text/javascript" src="resources/scripts/simpla.jquery.configuration.js"></script>	
		<script type="text/javascript" src="resources/scripts/admin.js"></script>
		<script type="text/javascript" src="resources/scripts/thickbox-compressed.js"></script>		
		<script type="text/javascript" src="resources/scripts/jQueryCookiePlugin.js"></script>
		<script type="text/javascript" src="js/admin.js"></script> 
	</head>
	<body>
		<form id="Form1" runat="server" name="form1">
		<div id="body-wrapper"> <!-- Wrapper for the radial gradient background -->
		   <uc1:menus ID="menus1" runat="server" />
		   <!-- End #sidebar -->
		<div id="main-content"> 
	<div class="clear"></div> <!-- End .clear -->
			
			<div class="content-box"><!-- Start Content Box -->
				
				<div class="content-box-header">
					
					<h3>编辑预测信息</h3>
					
					<ul class="content-box-tabs">
						<li><a href="#tab1" class="default-tab">提交表单</a></li> <!-- href must be unique and match the id of target div -->
					</ul>
					
					<div class="clear"></div>
					
				</div> <!-- End .content-box-header -->
				
				<div class="content-box-content">
					
				  <div class="tab-content default-tab" id="tab1">
							<fieldset>
						   <table width="100%" border="0" cellspacing="0" cellpadding="0" align="center">
						   <tr>
                            <td width="14%"><label>期数/专题*</label></td>
                            <td><span style="float:left;"><asp:TextBox ID="qi" runat="server" CssClass="text-input" style="width:100px"></asp:TextBox></span>&nbsp;期
                            	<%=yzinfo.name%>
                            </td>
                            </tr>                            
						  <tr>
                            <td><label>预测内容*</label></td>
                            <td>
                                <span style="float:left;"><asp:TextBox ID="info" runat="server" CssClass="text-input" style="width:100px"></asp:TextBox></span></td>
                            </tr>
                            <tr>
                            <td><label>标题*</label></td>
                            <td><span style="float:left;">
                              <asp:TextBox ID="title" runat="server" CssClass="text-input" style="width:500px"></asp:TextBox>
                            </span></td>
                            </tr>
						   <tr>
                            <td><label>显示内容*</label></td>
                            <td>
                                <span style="float:left;"><asp:TextBox ID="context1" runat="server" CssClass="text-input" style="width:500px"></asp:TextBox></span></td>
                            </tr>
						  <tr>
                            <td valign="top"><label>开奖号/结果*</label></td>
                            <td><span style="float:left;">
                              <asp:TextBox ID="kjh" runat="server" CssClass="text-input" style="width:100px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;                            
                            <asp:CheckBox ID="isright" Text="正确" runat="server"></asp:CheckBox></span></td>
                            </tr>
                          <tr>
                            <td><p></td>
                            <td>&nbsp;</td>
                            </tr>
                        </table>
						<p style="text-align:center;padding:10px;">
						  <asp:Button ID="save" Text=" 保存 "  CssClass="button" runat="server" OnClick="enter_Click"/>						
						</p>
							</fieldset>
							
							<div class="clear"></div><!-- End .clear -->
							
				  </div> <!-- End #tab2 -->        
					
				</div> <!-- End .content-box-content -->
				
			</div> <!-- End .content-box -->
			<!-- End .content-box -->
			<!-- End .content-box --><!-- Start Notifications -->
			<!-- End Notifications -->
			<div id="footer">
				<small> <!-- Remove this notice or replace it with whatever you want -->
						© Copyright 2013-2014  | Powered by <a href="http://www.haocw.com/">haocw.com</a> | <a href="#">Top</a>
				</small>
		  </div><!-- End #footer -->			
		</div> <!-- End #main-content -->		
	</div>							
	</form>
<script type="text/javascript">
    $(function () {
        //插件调用
        $('.iselect').iSimulateSelect();
    })
</script>
</body>
  
<!-- Download From www.exet.tk-->
</html>
