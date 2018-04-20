<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="yczone_list.aspx.cs" Inherits="Admin.yczone_list" %>
<%@ Register src="menus.ascx" tagname="menus" tagprefix="uc1" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>预测专题列表</title>
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
			<h2>预测专题列表</h2>
			<p id="page-intro">预测专题列表</p>			
			<!-- End .shortcut-buttons-set -->
	   <div class="clear"></div> <!-- End .clear -->			
			<div class="content-box"><!-- Start Content Box -->				
				<div class="content-box-header">					
					<h3>列表框</h3>					
					<ul class="content-box-tabs">
						<li><a href="#tab1" class="default-tab">预测专题列表</a></li> <!-- href must be unique and match the id of target div -->
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
                                    <th width="25%">
                                    <asp:DropDownList ID="czidsel" runat="server" CssClass="select" AutoPostBack="True" onselectedindexchanged="czidsel_SelectedIndexChanged"><asp:ListItem Text="==请选择彩种==" Value="0"></asp:ListItem></asp:DropDownList>
                                    <asp:DropDownList ID="typesel" runat="server" CssClass="select" AutoPostBack="True" onselectedindexchanged="typesel_SelectedIndexChanged"><asp:ListItem Text="==请选择类型==" Value="0"></asp:ListItem></asp:DropDownList>
                                    专题名</th>
                                    <th width="35%">标题模板</th>
                                    <th width="10%">最新期数</th>
                                    <th width="10%">自动生成</th>
                                    <th width="10%">操作</th>
                                  </tr>
                                </thead>
                                <tfoot>
                                  <tr>
                                    <td colspan="3">
                                    <div class="bulk-actions align-left">
                                      <select name="dropdown" id="dropdown">
                                        <option value="0">请选择操作...</option>
                                        <option value="1">生成最新一期</option>
                                        <option value="0">删除</option>
                                      </select>
                                      <a class="button" href="javascript:void(0);" onclick="delall(12);">确认</a>	
                                 </div>
                                        <div class="pagination"><webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="第一页" 
    LastPageText="尾页" NextPageText="下一页" PageSize="40" PagingButtonSpacing="10px" 
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
                                    <td><input type="checkbox" name="ids" value="<%#DataBinder.Eval(Container.DataItem,"yzid").ToString().Trim()%>"/> [<%#DataBinder.Eval(Container.DataItem,"orderint")%>]</td>
                                    <td>【<%#GetCzname(DataBinder.Eval(Container.DataItem,"czid"))%> <%#GetYcTypeName(DataBinder.Eval(Container.DataItem,"type"))%>】<a href="http://www.caiu8.com/yc/list_<%#DataBinder.Eval(Container.DataItem,"yzid")%>_1.html" target="_blank"><%#DataBinder.Eval(Container.DataItem,"name").ToString().Trim()%></a></td>
                                    <td><%#DataBinder.Eval(Container.DataItem,"titlemodel").ToString().Trim()%></td>
                                     <td><%#DataBinder.Eval(Container.DataItem,"lastqi").ToString().Trim()%></td>
                                    <td><%#GetIs(DataBinder.Eval(Container.DataItem,"isautowrite"))%></td>
                                    <td><!-- Icons -->
                                      <a href="?yzid=<%#DataBinder.Eval(Container.DataItem,"yzid")%>" title="编辑"><img src="resources/images/icons/pencil.png" alt="编辑" /></a>&nbsp;&nbsp;&nbsp;&nbsp;
									  <a href="javascript:void(0);" onclick="del(12,<%#DataBinder.Eval(Container.DataItem,"yzid")%>);" title="删除" style="display:none;"><img src="resources/images/icons/cross.png" alt="删除" /></a> 
                                      </td>
                                  </tr>
                                  </itemtemplate>
                                  </asp:Repeater>
                                </tbody>
                              </table>
						    </div>
							<p style="text-align:center;padding:10px;">
                            
                            </p>
							</fieldset
							
							><div class="clear"></div><!-- End .clear -->
				  </div> <!-- End #tab2 -->        
					
				</div> <!-- End .content-box-content -->
			</div> <!-- End .content-box -->
			<!-- End .content-box -->
			<!-- End .content-box --><!-- Start Notifications -->
			<!-- End Notifications -->
			<h2>添加预测专题</h2>
			<p id="page-intro">添加预测专题</p>				
			
            <div class="content-box"><!-- Start Content Box -->
				
				<div class="content-box-header">
					
					<h3>添加/编辑框框</h3>
					
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
                                    <td><p><label>所属彩种*</label></p></td>
                                    <td><asp:DropDownList ID="czid" runat="server" CssClass="select">
                                    		<asp:ListItem Text="==请选择彩种==" Value="0"></asp:ListItem>
                                        </asp:DropDownList></td>
                                    <td><span class="tip">(请选择一个彩种)</span></td>
                                  </tr>
                                   <tr>
                                    <td><p><label>预测类型*</label></p></td>
                                    <td><asp:DropDownList ID="type" runat="server" CssClass="select">
                                    		<asp:ListItem Text="==请选择预测类型==" Value="0"></asp:ListItem>
                                        </asp:DropDownList> 
                                        <asp:CheckBox ID="isautowrite" runat="server" Text="是否自动生成" />
                                       </td>
                                    <td><span class="tip">(请选择一个预测类型))</span></td>
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
                                 <tr>
                                    <td><p><label>预测标题模板*</label></p></td>
                                    <td><p>期数：{qi},专题名：{zonename},预测类型：{typename},预测内容：{info},对错：{rightwrong}，开奖号：{kjh}</p>
                                    <p style="margin-top:10px;"><asp:TextBox ID="titlemodel" runat="server" CssClass="text-input" Width="800px"></asp:TextBox></p></td>
                                    <td><span class="tip">(预测标题模板)</span></td>
                                 </tr>
                                 <tr>
                                    <td><p><label>预测内容模板*</label></p></td>
                                    <td><asp:TextBox ID="contextmodel" runat="server" CssClass="text-input" Width="800px"></asp:TextBox></td>
                                    <td><span class="tip">(预测内容模板)</span></td>
                                 </tr>
                                 <tr>
                                    <td><p><label>预测内容头*</label></p></td>
                                    <td><asp:TextBox ID="contexthead" runat="server" CssClass="text-input" Width="800px"></asp:TextBox></td>
                                    <td><span class="tip">(预测内容头)</span></td>
                                 </tr>
                                 <tr>
                                    <td><p><label>预测内容尾*</label></p></td>
                                    <td><asp:TextBox ID="contextend" runat="server" CssClass="text-input" Width="800px"></asp:TextBox></td>
                                    <td><span class="tip">(预测内容尾)</span></td>
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
						&#169; Copyright 2013-2014  | Powered by <a href="http://www.caiu8.com/">caiu8.com</a> | <a href="#">Top</a>
				</small>
		  </div><!-- End #footer -->
			
		</div> <!-- End #main-content -->
		
	</div>
  <script type="text/javascript">
      //后台删除数据
      function del(mo, id) {
          if (confirm("注意：此操作不可还原，是否继续？")) {
              if (delmethod(mo, id) == "ok") {
                  alert("操作成功...");
                  self.location.reload();
              }
          }
      }

      //后台群删数据
      function delall(mo) {
          if (confirm("注意：此操作不可还原，是否继续？")) {			
          	if (delallmethod(mo) == "ok") {
				 alert("操作成功...");		
            	 self.location.reload();
			}else{
			    alert("操作失败...");
		  	}
          }
      }
</script>	
</form>
</body>

</html>
