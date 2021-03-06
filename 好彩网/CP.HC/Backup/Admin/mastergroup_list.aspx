﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mastergroup_list.aspx.cs" Inherits="Admin.mastergroup_list" %>
<%@ Register src="menus.ascx" tagname="menus" tagprefix="uc1" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>资讯分类列表</title>
		<link rel="stylesheet" href="resources/scripts/ui-lightness/jquery-ui-1.8.9.custom.css">
		<link rel="stylesheet" href="resources/css/reset.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="resources/css/style.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="resources/css/invalid.css" type="text/css" media="screen" />	
		<link rel="stylesheet" href="resources/css/jquery.autocomplete.css" type="text/css" media="screen" />	
		<link rel="stylesheet" href="resources/scripts/thickbox.css" type="text/css" media="screen" />	
		<!-- Colour Schemes
		<link rel="stylesheet" href="resources/css/blue.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="resources/css/red.css" type="text/css" media="screen" />  
		-->
		<!-- Internet Explorer Fixes Stylesheet -->
		<!--[if lte IE 7]>
			<link rel="stylesheet" href="resources/css/ie.css" type="text/css" media="screen" />
		<![endif]-->
		<script type="text/javascript" src="resources/scripts/jquery-1.3.2.min.js"></script>
		<script type="text/javascript" src="resources/scripts/jquery.autocomplete.js"></script>	
		<script type="text/javascript" src="resources/scripts/simpla.jquery.configuration.js"></script>			
		<script type="text/javascript" src="resources/scripts/thickbox-compressed.js"></script>
		<script type="text/javascript" src="resources/scripts/admin.js"></script>
	</head>
<body>
<form id="form1" runat="server">
    <div id="body-wrapper"> <!-- Wrapper for the radial gradient background -->
		   <uc1:menus ID="menus1" runat="server" />
		   <!-- End #sidebar -->
<div id="main-content"> <!-- Main Content Section with everything -->
			
			<!-- Page Head -->
	  <h2>管理组列表</h2>
			<p id="page-intro">管理组列表</p>
			
			<!-- End .shortcut-buttons-set -->
	<div class="clear"></div> <!-- End .clear -->
			
	  <div class="content-box"><!-- Start Content Box -->
				
				<div class="content-box-header">
					
				  <h3>列表框</h3>
					
					<ul class="content-box-tabs">
						<li><a href="#tab1" class="default-tab">管理组列表</a></li> <!-- href must be unique and match the id of target div -->
					</ul>
					
					<div class="clear"></div>
					
				</div> <!-- End .content-box-header -->
				
				<div class="content-box-content">
				  <div class="tab-content default-tab" id="tab1">
							<fieldset>
							<div class="tab-content default-tab" id="tab1">
                              <!-- This is the target div. id must match the href of this div's tab -->
							  <table>
							    <thead>
							      <tr>
							        <th width="10%"><input class="check-all" type="checkbox" /></th>
							        <th width="20%">管理组</th>
							        <th width="12%">发布权</th>
							        <th width="12%">推荐权</th>
                                    <th width="12%">广告权</th>
                                    <th width="12%">用户管理</th>
                                    <th width="12%">系统配置</th>
							        <th width="15%">操作</th>
						          </tr>
						        </thead>
							    <tfoot>
							      <tr>
							        <td colspan="8"><div class="bulk-actions align-left">
							          <select name="dropdown" id="dropdown">
							            <option value="0">请选择操作...</option>
							            <option value="2">删除</option>
						              </select>
							          <a class="button" href="javascript:void(0);" onclick="delall(5);">确认</a> </div>
							          <div class="pagination">
							            <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="第一页" 
    LastPageText="尾页" NextPageText="下一页" PageSize="10" PagingButtonSpacing="10px" 
    PrevPageText="上一页" ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged"> </webdiyer:AspNetPager>
						              </div>
							          <!-- End .pagination -->
							          <div class="clear"></div></td>
						          </tr>
						        </tfoot>
							    <tbody>
							      <asp:Repeater ID="list" runat="server" EnableViewState="true">
							        <itemtemplate>
							          <tr>
							            <td><input type="checkbox" name="ids" value="<%#DataBinder.Eval(Container.DataItem,"groupid").ToString().Trim()%>"/></td>
							            <td><a href="#"><%#DataBinder.Eval(Container.DataItem,"name").ToString().Trim()%></a></td>
							            <td><%#GetAllow(DataBinder.Eval(Container.DataItem,"allowpub"))%></td>
                                        <td><%#GetAllow(DataBinder.Eval(Container.DataItem,"allowpages"))%></td>
                                        <td><%#GetAllow(DataBinder.Eval(Container.DataItem,"allowadvert"))%></td>
                                        <td><%#GetAllow(DataBinder.Eval(Container.DataItem,"allowuser"))%></td>
                                        <td><%#GetAllow(DataBinder.Eval(Container.DataItem,"allowconfig"))%></td>
							            <td><!-- Icons -->
							              <a href="?groupid=<%#DataBinder.Eval(Container.DataItem,"groupid")%>" title="编辑"><img src="resources/images/icons/pencil.png" alt="编辑" /></a>&nbsp;&nbsp;&nbsp;&nbsp; <a href="javascript:void(0);" onclick="del(5,<%#DataBinder.Eval(Container.DataItem,"groupid")%>);" title="删除"><img src="resources/images/icons/cross.png" alt="删除" /></a></td>
						              </tr>
						            </itemtemplate>
						          </asp:Repeater>
						        </tbody>
						      </table>
							</div>
							<p style="text-align:center;padding:10px;">
                            
                            </p>
							</fieldset>							
							<div class="clear"></div><!-- End .clear -->
				  </div> <!-- End #tab2 -->
				</div> <!-- End .content-box-content -->
	  </div> <!-- End .content-box -->
			<!-- End .content-box -->
			<!-- End .content-box --><!-- Start Notifications -->
			<!-- End Notifications -->
			<h2>添加管理组</h2>
			<p id="page-intro">添加管理组</p>				
			
            <div class="content-box"><!-- Start Content Box -->
				
				<div class="content-box-header">
					
				  <h3>添加/编辑框</h3>
					
					<ul class="content-box-tabs">
						<li><a href="#tab1" class="default-tab">管理组添加</a></li> <!-- href must be unique and match the id of target div -->
					</ul>
					
					<div class="clear"></div>
					
			  </div> <!-- End .content-box-header -->
				
				<div class="content-box-content">
				  <div class="tab-content default-tab" id="tab1">
							<fieldset>
							<div class="tab-content default-tab" id="tab1">
                              <!-- This is the target div. id must match the href of this div's tab -->
							  <table>
                                <tbody>
                                 <tr>
                                    <td width="15%"><p>
                                      <label>管理组名*</label></p></td>
                                    <td width="63%"><asp:TextBox ID="name" runat="server" CssClass="text-input" Width="220px"></asp:TextBox></td>
                                    <td width="22%"><span class="tip">(管理组名)</span></td>
                                 </tr>
                                 <tr>
                                    <td><p>
                                      <label>权限选择*</label></p></td>
                                    <td><asp:CheckBox ID="allowpub" Text="发布" runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="allowpages" Text="推荐" runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="allowadvert" Text="广告" runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="allowuser" Text="用户" runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="allowconfig" Text="系统" runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                    <td><span class="tip">(请勾选允许的操作)</span></td>
                                  </tr>
                                </tbody>
                              </table>
						    </div>
							<p style="text-align:center;padding:10px;">
            						<asp:Button ID="enter" Text=" 保 存 "  CssClass="button" runat="server" OnClick="enter_Click"/>
                            </p>
							</fieldset>
							
							<div class="clear"></div><!-- End .clear -->
							
				  </div> <!-- End #tab2 -->        
					
				</div> <!-- End .content-box-content -->
	  </div>
			<div id="footer">
				<small> <!-- Remove this notice or replace it with whatever you want -->
						&#169; Copyright 2012  | Powered by <a href="http://www.haocw.com/">haocw.com</a> | <a href="#">Top</a>
				</small>
		  </div><!-- End #footer -->
			
	  </div> <!-- End #main-content -->
		
  </div>
  <script type="text/javascript">
//后台删除数据
function del(mo,id){
	if(confirm("注意：此操作不可还原，是否继续？")){
		if(delmethod(mo,id)=="ok"){
			alert("删除成功...");
			self.location.reload();
		}
	}		
}

//后台群删数据
function delall(mo){
	if(confirm("注意：此操作不可还原，是否继续？")){
		if(delallmethod(mo)=="ok"){
			alert("操作成功...");
			self.location.reload();
		}
	}		
}
</script>	
</form>
</body>

<!-- Download From www.exet.tk-->
</html>



