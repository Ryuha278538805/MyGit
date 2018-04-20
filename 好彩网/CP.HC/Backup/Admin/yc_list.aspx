<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="yc_list.aspx.cs" Inherits="Admin.yc_list" %>
<%@ Register src="menus.ascx" tagname="menus" tagprefix="uc1" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>预测列表</title>
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
			<h2>预测列表</h2>
			<p id="page-intro">预测的列表</p>			
			<!-- End .shortcut-buttons-set -->
	   <div class="clear"></div> <!-- End .clear -->			
			<div class="content-box"><!-- Start Content Box -->				
				<div class="content-box-header">					
					<h3>列表框</h3>					
					<ul class="content-box-tabs">
						<li><a href="#tab1" class="default-tab">预测列表</a></li> <!-- href must be unique and match the id of target div -->
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
                                    <th width="5%"><input class="check-all" type="checkbox" /></th>
                                    <th width="33%">                                     
                                     <asp:DropDownList ID="type" runat="server" CssClass="select" AutoPostBack="True" onselectedindexchanged="type_SelectedIndexChanged"><asp:ListItem Text="==请选择类型==" Value="0"></asp:ListItem></asp:DropDownList>
                                     <asp:DropDownList ID="yzidsel" runat="server" CssClass="select" AutoPostBack="True" onselectedindexchanged="yzidsel_SelectedIndexChanged"><asp:ListItem Text="==请选择专题==" Value="0"></asp:ListItem></asp:DropDownList>
                                     标题</th>
                                    <th width="10%">期数</th>
                                    <th width="12%">预测内容</th>
                                    <th width="10%">开奖号</th>
                                    <th width="10%">正误</th>
                                    <th width="10%">点击</th>
                                    <th width="10%">操作</th>
                                  </tr>
                                </thead>
                                <tfoot>
                                  <tr>
                                    <td colspan="6">
                                    <div class="bulk-actions align-left">
                                      <select name="dropdown" id="dropdown">
                                        <option value="0">请选择操作...</option>
                                        <option value="2">删除</option>
                                      </select>
                                      <a class="button" href="javascript:void(0);" onclick="delall(11);">确认</a>	
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
                                    <td><input type="checkbox" name="ids" value="<%#DataBinder.Eval(Container.DataItem,"yid").ToString().Trim()%>"/></td>
                                    <td>
                                    【<%#GetYcTypeName(DataBinder.Eval(Container.DataItem,"type"))%><a href="http://www.haocw.com/yc_<%#DataBinder.Eval(Container.DataItem,"czid")%>/list_<%#DataBinder.Eval(Container.DataItem,"yzid")%>_1.html" target="_blank"><%#GetYzName(DataBinder.Eval(Container.DataItem,"yzid"))%></a>】
                                    <a href="http://www.haocw.com/yc_<%#DataBinder.Eval(Container.DataItem,"czid")%>/<%#Getdir(DataBinder.Eval(Container.DataItem,"addtime"))%>/<%#DataBinder.Eval(Container.DataItem,"yid").ToString().Trim()%>.html" target="_blank"><%#DataBinder.Eval(Container.DataItem,"title").ToString().Trim()%></a></td>
                                    <td><%#DataBinder.Eval(Container.DataItem,"qi").ToString().Trim()%></td>
                                    <td><%#DataBinder.Eval(Container.DataItem,"info").ToString().Trim()%></td>
                                    <td><%#DataBinder.Eval(Container.DataItem,"kjh").ToString().Trim()%></td>
                                    <td><%#GetIs(DataBinder.Eval(Container.DataItem,"isright"))%></td>
                                    <td><%#DataBinder.Eval(Container.DataItem,"hits").ToString().Trim()%></td>
                                    <td><!-- Icons -->
                                      <a href="yc_add.aspx?yid=<%#DataBinder.Eval(Container.DataItem,"yid")%>" title="编辑"><img src="resources/images/icons/pencil.png" alt="编辑" /></a>&nbsp;&nbsp;&nbsp;&nbsp;
                                      <a href="javascript:void(0);" onclick="dome(11,1,<%#DataBinder.Eval(Container.DataItem,"yid")%>);" title="重新生成"><img src="resources/images/icons/reflash.png" alt="重新生成" /></a>&nbsp;&nbsp;&nbsp;&nbsp;
                                      <a href="javascript:void(0);" onclick="del(11,<%#DataBinder.Eval(Container.DataItem,"yid")%>);" title="删除" style="display:none;"><img src="resources/images/icons/cross.png" alt="删除" /></a> 
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
          
			<div id="footer">
				<small> <!-- Remove this notice or replace it with whatever you want -->
						&#169; Copyright 2013-2014  | Powered by <a href="http://www.haocw.com/">haocw.com</a> | <a href="#">Top</a>
				</small>
		  </div><!-- End #footer -->
			
		</div> <!-- End #main-content -->
		
	</div>
  <script type="text/javascript">
      //后台删除数据
      function del(mo, id) {
          if (confirm("注意：此操作不可还原，是否继续？")) {
              if (delmethod(mo, id) == "ok") {
                  alert(delmethod(mo, id)+"操作成功...");
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
              }
          }
      }

      //后台处理数据
      function dome(mo, me, id) {		  
          if (domethod(mo, me, id) == "ok") {
             // alert("更新成功...");
              self.location.reload();
          }
      }  
</script>	
</form>
</body>

<!-- Download From www.exet.tk-->
</html>
