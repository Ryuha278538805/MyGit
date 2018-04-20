<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="news_templet_add.aspx.cs" Inherits="Admin.news_templet_add" %>
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
            KindEditor.ready(function(K) {
                var editor1 = K.create('#content', {
                    cssPath : '/KindEditor/plug/code/prettify.css',
                    uploadJson : '/Ajax/EditorUploadFiles.aspx',
                    allowFileManager : false,
					allowFlashUpload : false,
					allowMediaUpload : false,
                    pasteType : 1,
                    newlineTag:'p',
                    afterCreate : function() {
                        var self = this;
                        K.ctrl(document, 13, function() {
                            self.sync();
                            K('form[name=form1]')[0].submit();
                        });
                        K.ctrl(self.edit.doc, 13, function() {
                            self.sync();
                            K('form[name=form1]')[0].submit();
                        });
                    }
                }); 

				
				var colorpicker;
                K('#colordiv').bind('click', function(e) {
                    e.stopPropagation();
                    if (colorpicker) {
                        colorpicker.remove();
                        colorpicker = null;
                        return;
                    }
                    var colorpickerPos = K('#colordiv').pos();
                    colorpicker = K.colorpicker({
                        x : colorpickerPos.x,
                        y : colorpickerPos.y + K('#colordiv').height(),
                        z : 19811214,
                        selectedColor : 'default',
                        noColor : '无颜色',
                        click : function(color) {
                            K('#color').val(color);
							K('#colordiv').css("background-color",color);
							if(color.length>0)	K('#colorpicker').hide();
							else	K('#colorpicker').show();
                            colorpicker.remove();
                            colorpicker = null;
                        }
                    });
                });
                K(document).click(function() {
                    if (colorpicker) {
                        colorpicker.remove();
                        colorpicker = null;
                    }
                });
				prettyPrint();
            });
        </script>
	</head>
	<body>
		<form runat="server" name="form1">
		<div id="body-wrapper"> <!-- Wrapper for the radial gradient background -->
		   <uc1:menus ID="menus1" runat="server" />
		   <!-- End #sidebar -->
		<div id="main-content"> 
	<div class="clear"></div> <!-- End .clear -->
			
			<div class="content-box"><!-- Start Content Box -->
				
				<div class="content-box-header">
					
					<h3>添加模板资讯</h3>
					
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
                            <td width="14%"><label>分类/属性</label></td>
                            <td>
                            	<asp:DropDownList ID="cid" runat="server" CssClass="select" AutoPostBack="True" onselectedindexchanged="cid_SelectedIndexChanged"><asp:ListItem Text="==请选择分类==" Value="0"></asp:ListItem></asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;
                            	<asp:DropDownList ID="czid" runat="server" CssClass="select" AutoPostBack="True" onselectedindexchanged="czid_SelectedIndexChanged"><asp:ListItem Text="==请选择彩种==" Value="0"></asp:ListItem></asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;
                             	<asp:TextBox ID="qi" runat="server" CssClass="text-input" style="width:100px"></asp:TextBox>&nbsp;&nbsp;期&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:CheckBox ID="istop" Text="置顶" runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:CheckBox ID="isbest" Text="精华" runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:CheckBox ID="ishot" Text="热门" runat="server"></asp:CheckBox>
                            </td>
                            </tr>
                            <tr>
                            <td><label>模板</label></td>
                            <td>                             
                                <asp:DropDownList ID="tid" runat="server" CssClass="select"><asp:ListItem Text="==请选择模板==" Value="0"></asp:ListItem></asp:DropDownList>                                
                              <asp:Button ID="craete" Text=" 随机一个 "  CssClass="button" runat="server" OnClick="craete_Click"/>                              
                              </td>
                            </tr>
						  <tr>
                            <td><label>标题*</label></td>
                            <td>
                                <span style="float:left;"><asp:TextBox ID="title" runat="server" CssClass="text-input" style="width:500px"></asp:TextBox></span>
                                <div id="colordiv" style="width:28px; height:28px;float:left; border:#999 1px solid; background-color:<%=color%>; margin-left:5px;"><img src="images/se.jpg" width="28" height="28"  style="vertical-align:top; cursor:pointer; <%if(color.Length>0){%>display:none;<%}%> " id="colorpicker"/></div>
	  <input type="hidden" id="color" name="color" value="<%=color%>" /></td>
                            </tr>
						  
						  <tr>
                            <td valign="top"><label>内容*</label></td>
                            <td><textarea name="content" cols="100" rows="8" id="content" style="width:100%;height:400px;visibility:hidden;"><%=context%></textarea></td>
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
<script type="text/javascript">
$(function(){
	//插件调用
	$('.iselect').iSimulateSelect();
})
</script>
</body>
  
<!-- Download From www.exet.tk-->
</html>
