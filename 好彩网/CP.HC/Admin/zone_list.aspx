<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zone_list.aspx.cs" Inherits="Admin.zone_list" %>
<%@ Register src="menus.ascx" tagname="menus" tagprefix="uc1" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>专题列表</title>
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
			<h2>专题列表</h2>
			<p id="page-intro">各个彩种分类的专题列表</p>
			
			<!-- End .shortcut-buttons-set -->
	<div class="clear"></div> <!-- End .clear -->
			
			<div class="content-box"><!-- Start Content Box -->
				
				<div class="content-box-header">
					
					<h3>列表框</h3>
					
					<ul class="content-box-tabs">
						<li><a href="#tab1" class="default-tab">专题列表</a></li> <!-- href must be unique and match the id of target div -->
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
                                    <th width="10%"><input class="check-all" type="checkbox" /> [排序]</th>
                                    <th width="60%"><asp:DropDownList ID="cidsel" runat="server" CssClass="select" AutoPostBack="True" onselectedindexchanged="cidsel_SelectedIndexChanged"><asp:ListItem Text="==请选择分类==" Value="0"></asp:ListItem></asp:DropDownList>专题名</th>
                                    <th width="30%">操作</th>
                                  </tr>
                                </thead>
                                <tfoot>
                                  <tr>
                                    <td colspan="4">
                                    <div class="bulk-actions align-left">
                                      <select name="dropdown" id="dropdown">
                                        <option value="0">请选择操作...</option>
                                        <option value="0">删除</option>
                                      </select>
                                      <a class="button" href="javascript:void(0);" onclick="delall(2);">确认</a>	
                                 </div>
                                        <div class="pagination"><webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="第一页" 
    LastPageText="尾页" NextPageText="下一页" PageSize="10" PagingButtonSpacing="10px" 
    PrevPageText="上一页" ShowInputBox="Never" onpagechanged="AspNetPager1_PageChanged">
</webdiyer:AspNetPager></div>
                                      <!-- End .pagination -->
                                        <div class="clear"></div></td>
                                  </tr>
                                </tfoot>
                                <tbody>
                                  <asp:Repeater ID="list" runat="server" EnableViewState="true">
                                  <itemtemplate>
                                  <tr>
                                    <td><input type="checkbox" name="ids" value="<%#DataBinder.Eval(Container.DataItem,"zid").ToString().Trim()%>"/> [<%#DataBinder.Eval(Container.DataItem,"orderint")%>]</td>
                                    <td>【<%#GetCname(DataBinder.Eval(Container.DataItem,"cid"))%>】<a href="http://www.haocw.com/<%#GetCename(DataBinder.Eval(Container.DataItem,"cid"))%>/list_<%#DataBinder.Eval(Container.DataItem,"zid")%>_1.html" target="_blank"><%#DataBinder.Eval(Container.DataItem,"name").ToString().Trim()%></a></td>
                                    <td><!-- Icons -->
                                      <a href="?zid=<%#DataBinder.Eval(Container.DataItem,"zid")%>" title="编辑"><img src="resources/images/icons/pencil.png" alt="编辑" /></a>&nbsp;&nbsp;&nbsp;&nbsp;
									  <a href="javascript:void(0);" onclick="del(2,<%#DataBinder.Eval(Container.DataItem,"zid")%>);" title="删除" style="display:none;"><img src="resources/images/icons/cross.png" alt="删除" /></a> 
                                      </td>
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
			<h2>添加专题</h2>
			<p id="page-intro">添加专题</p>				
			
            <div class="content-box"><!-- Start Content Box -->
				
				<div class="content-box-header">
					
					<h3>添加/编辑框</h3>
					
					<ul class="content-box-tabs">
						<li><a href="#tab1" class="default-tab">专题添加</a></li> <!-- href must be unique and match the id of target div -->
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
                              <label>专题名*</label>
                            </p></td>
                                    <td width="63%"><asp:TextBox ID="zname" runat="server" CssClass="text-input" Width="220px"></asp:TextBox></td>
                                    <td width="22%"><span class="tip">(文字中不要有空格)</span></td>
                                 </tr>
                                  <tr>
                                    <td><p>
                              <label>所属分类*</label>
                            </p></td>
                                    <td><asp:DropDownList ID="cid" runat="server" CssClass="select">
                                    <asp:ListItem Text="==请选择分类==" Value="0"></asp:ListItem>
                                </asp:DropDownList></td>
                                    <td><span class="tip">(请选择一个“子”分类)</span></td>
                                  </tr>
                                  <tr>
                                    <td><p><label>排序*</label></p></td>
                                    <td><asp:TextBox ID="orderint" runat="server" CssClass="text-input" Width="220px"></asp:TextBox></td>
                                    <td><span class="tip">(默认从小到大排序)</span></td>
                                 </tr>
                                 <tr>
                                    <td><p><label>SEO关键字*</label></p></td>
                                    <td><asp:TextBox ID="keywords" runat="server" CssClass="text-input" Width="800px"></asp:TextBox></td>
                                    <td><span class="tip">(SEO关键字 keywords)</span></td>
                                 </tr>
                                 <tr>
                                    <td><p><label>SEO描述*</label></p></td>
                                    <td><asp:TextBox ID="description" runat="server" CssClass="text-input" Width="800px"></asp:TextBox></td>
                                    <td><span class="tip">(SEO描述 description)</span></td>
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
			alert("删除成功...");
			self.location.reload();
		}
	}		
}
</script>	
</form>
</body>

<!-- Download From www.exet.tk-->
</html>

