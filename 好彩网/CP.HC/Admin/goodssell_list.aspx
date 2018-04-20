﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="goodssell_list.aspx.cs" Inherits="Admin.goodssell_list" %>
<%@ Register src="menus.ascx" tagname="menus" tagprefix="uc1" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>销售记录列表</title>
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
	  <h2>销售记录列表</h2>
			<p id="page-intro">销售记录列表</p>
			
			<!-- End .shortcut-buttons-set -->
	<div class="clear"></div> <!-- End .clear -->
			
	  <div class="content-box"><!-- Start Content Box -->
				
				<div class="content-box-header">
					
				  <h3>列表框</h3>
					
					<ul class="content-box-tabs">
						<li><a href="#tab1" class="default-tab">销售记录列表</a></li> <!-- href must be unique and match the id of target div -->
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
							        <th width="2%"><input class="check-all" type="checkbox" /></th>
							        <th width="30%">商品名</th>
							        <th width="20%">用户名</th>
							        <th width="10%">邮寄</th>
                                    <th width="12%">是否发货</th>
                                    <th width="16%">购买时间</th>
							        <th width="10%">操作</th>
						          </tr>
						        </thead>
							    <tfoot>
							      <tr>
							        <td colspan="10"><div class="bulk-actions align-left">
							          <select name="dropdown" id="dropdown">
							            <option value="0">请选择操作...</option>
							            <option value="2">删除</option>
						              </select>
							          <a class="button" href="javascript:void(0);" onclick="delall(9);">确认</a> </div>
							          <div class="pagination">
							            <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="第一页" 
    LastPageText="尾页" NextPageText="下一页" PageSize="15" PagingButtonSpacing="10px" 
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
							            <td><input type="checkbox" name="ids" value="<%#DataBinder.Eval(Container.DataItem,"sid").ToString().Trim()%>"/></td>
							            <td><a href="http://shop.haocw.com/goods/<%#DataBinder.Eval(Container.DataItem,"gid").ToString().Trim()%>.html" target="_blank" ><%#GetGoodsName(DataBinder.Eval(Container.DataItem,"gid"))%></a></td>
							            <td><%#DataBinder.Eval(Container.DataItem,"username")%></td>
							            <td><%#GetIs(GetNeedPost(DataBinder.Eval(Container.DataItem,"gid")))%></td>
                                        <td><%#GetIs(DataBinder.Eval(Container.DataItem,"isposted"))%></td>
                                        <td><%#GetTime(DataBinder.Eval(Container.DataItem,"addtime"))%></td>
							            <td><a href="goodssell_add.aspx?sid=<%#DataBinder.Eval(Container.DataItem,"sid")%>" title="发货" target="_blank"><img src="resources/images/icons/post.png" alt="发货"/></a> &nbsp;&nbsp;&nbsp;&nbsp;<a href="javascript:void(0);" onclick="del(9,<%#DataBinder.Eval(Container.DataItem,"sid")%>);" title="删除"><img src="resources/images/icons/cross.png" alt="删除" /></a></td>
						              </tr>
						            </itemtemplate>
						          </asp:Repeater>
						        </tbody>
						      </table>
							</div>
							<p style="text-align:center;padding:10px;">&nbsp;
                            
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