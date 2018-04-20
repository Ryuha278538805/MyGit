<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="goods_add.aspx.cs" Inherits="Admin.goods_add" %>
<%@ Register src="/menus.ascx" tagname="menus" tagprefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>添加社区商店商品</title>
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
                var editor1 = K.create('#about', {
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
					
					<h3>添加社区商店商品</h3>
					
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
                            	<asp:DropDownList ID="gcid" runat="server" CssClass="select"><asp:ListItem Text="==请选择分类==" Value="0"></asp:ListItem></asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;                            	
                                <asp:CheckBox ID="isautopost" Text="自动发货" runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:CheckBox ID="needpost" Text="邮寄" runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:CheckBox ID="issell" Text="在售" runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:CheckBox ID="iseveryday" Text="每天限购一次" runat="server"></asp:CheckBox>
                            </td>
                            </tr>                           
						  <tr>
                            <td><label>商品名*</label></td>
                            <td>
                                <span style="float:left;"><asp:TextBox ID="gname" runat="server" CssClass="text-input" style="width:500px"></asp:TextBox></span>
                             </td>
                            </tr>
                             <tr>
                            <td>
                              <label>图片*</label>
                            </td>
                            <td>
                            <asp:FileUpload ID="File1" runat="server" CssClass="text-input"/>  <asp:HyperLink ID="sphoto" runat="server"></asp:HyperLink>
                            <span class="tip">(上传原图 同时 自动另存一张 <%=width%>*<%=height%> 的缩略图) </span></td>
                          </tr>
                            <tr>
                            <td><label>总量 / 已售*</label></td>
                            <td><span style="float:left;"><asp:TextBox ID="count" runat="server" CssClass="text-input" style="width:100px"></asp:TextBox> / <asp:TextBox ID="countselled" runat="server" CssClass="text-input" style="width:100px"></asp:TextBox></span></td>
                            </tr>
                             <tr>
                            <td><label>价格*</label></td>
                            <td><span style="float:left;"><asp:TextBox ID="score" runat="server" CssClass="text-input" style="width:100px"></asp:TextBox>
                                <asp:DropDownList ID="payextcredits" runat="server" CssClass="select"> </asp:DropDownList>
                            </span></td>
                            </tr>
                             <tr>
                            <td><label>购买后收到货时间*</label></td>
                            <td><span style="float:left;">
                             <asp:DropDownList ID="gettime" runat="server" CssClass="select">
                                  <asp:ListItem>马上到货</asp:ListItem>
                                  <asp:ListItem>1天以内</asp:ListItem>
                                  <asp:ListItem>1-3天</asp:ListItem>
                                  <asp:ListItem>3天左右</asp:ListItem>
                                  <asp:ListItem>4-6天</asp:ListItem>
                                  <asp:ListItem>一周左右</asp:ListItem>
                                  <asp:ListItem>半个月</asp:ListItem>
                                  <asp:ListItem>未定</asp:ListItem>                                  
                                </asp:DropDownList>
                            </span></td>
                            </tr>
						   <tr>
                            <td><label>卡密/已售：(一个一行)</label></td>
                            <td>
                                <asp:TextBox ID="codes" runat="server" Height="100px" TextMode="MultiLine" CssClass="small-input"  Width="350px"></asp:TextBox>
                                <asp:TextBox ID="codesselled" runat="server" Height="100px" TextMode="MultiLine"  CssClass="small-input" Width="350px"></asp:TextBox>
                               </td>
                            </tr>    
                            <td><label>简介*</label></td>
                            <td>
                                <asp:TextBox ID="aboutshort" runat="server" Height="60px" TextMode="MultiLine" Width="100%"></asp:TextBox>
                               </td>
                            </tr>                           
						  <tr>
                            <td valign="top"><label>详细介绍*</label></td>
                            <td><textarea name="about" cols="100" rows="8" id="about" style="width:100%;height:400px;visibility:hidden;"><%=about%></textarea></td>
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
