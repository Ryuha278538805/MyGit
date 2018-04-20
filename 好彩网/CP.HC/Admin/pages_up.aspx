<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pages_up.aspx.cs" Inherits="Admin.pages_up" %>
<%@ Register src="/menus.ascx" tagname="menus" tagprefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>添加资讯</title>
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
		<link rel="stylesheet" href="KindEditor/themes/default/default.css" />
		<link rel="stylesheet" href="KindEditor/plug/code/prettify.css" />
        <script type="text/javascript" src="kindeditor/kindeditor-min.js"></script>
		<script type="text/javascript" src="js/admin.js"></script> 
        <script type="text/javascript">
            KindEditor.ready(function (K) {
                var editor1 = K.create('#context', {
                    cssPath: '/KindEditor/plug/code/prettify.css',
                    uploadJson: '/Ajax/EditorUploadFiles.aspx',
                    allowFileManager: false,
                    allowFlashUpload: false,
                    allowMediaUpload: false,
                    pasteType: 1,
                    newlineTag: 'p',
                    afterCreate: function () {
                        var self = this;
                        K.ctrl(document, 13, function () {
                            self.sync();
                            K('form[name=form1]')[0].submit();
                        });
                        K.ctrl(self.edit.doc, 13, function () {
                            self.sync();
                            K('form[name=form1]')[0].submit();
                        });
                    }
                });
            });
        </script>
	</head>
	<body>
		<form id="Form1" runat="server" name="form1">
		<div id="body-wrapper"> <!-- Wrapper for the radial gradient background -->
		   <uc1:menus ID="menus1" runat="server" />
		   <!-- End #sidebar -->
		<div id="main-content"> 
        			<h2>页面推荐管理</h2>
			<p id="page-intro">页面推荐管理</p>
	<div class="clear"></div> <!-- End .clear -->
			
			<div class="content-box"><!-- Start Content Box -->
				
				<div class="content-box-header">
					
					<h3>添加资讯</h3>
					
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
                            <td width="14%"><label>分类</label></td>
                            <td>
                                <asp:DropDownList ID="id" runat="server" AutoPostBack="True" CssClass="iselect" 
                                    onselectedindexchanged="id_SelectedIndexChanged">
                                    <asp:ListItem Text="==请选择推荐内容==" Value="0"></asp:ListItem>
                                </asp:DropDownList>
                               </td>
                            </tr>
						  
						  <tr>
                            <td valign="top"><label>内容*</label></td>
                            <td><asp:TextBox ID="context" runat="server" CssClass="context" TextMode="MultiLine"></asp:TextBox></td>
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
						© Copyright 2012  | Powered by <a href="http://www.haocw.com/">
                haocw.com</a> | <a href="#">Top</a>
				</small>
		  </div><!-- End #footer -->			
		</div> <!-- End #main-content -->		
	</div>							
	</form>
</body>
  
<!-- Download From www.exet.tk-->
</html>
