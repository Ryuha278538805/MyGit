<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lottery_225.aspx.cs" Inherits="Admin.lottery_225" %>
<%@ Register src="menus.ascx" tagname="menus" tagprefix="uc1" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>福彩22选5开奖号管理</title>
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
			
			<h2>添加/编辑22选5开奖号
			  <asp:Button ID="autoget2" Text=" 更新最后开奖号 "  CssClass="button" runat="server" OnClick="autoget2_Click"/>               
              &nbsp;<asp:Button ID="autoget" Text=" 收录最新一期开奖号 "  CssClass="button" runat="server" OnClick="autoget_Click"/>              			</h2>
            <div class="content-box"><!-- Start Content Box -->
				
				<div class="content-box-header">
					
				  <h3>添加/编辑框</h3>
					
					<ul class="content-box-tabs">
						<li><a href="#tab1" class="default-tab">22选5开奖号添加/编辑</a></li> <!-- href must be unique and match the id of target div -->
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
                                      <label>期号*</label></p></td>
                                   <td width="63%"><asp:TextBox ID="qi" runat="server" CssClass="text-input" Width="100px"></asp:TextBox></td>
                                    <td width="22%"><span class="tip">(期号)</span></td>
                                 </tr>
                                 <tr>
                                    <td><p>
                                      <label>开奖号*</label></p></td>
                                   <td><asp:TextBox ID="a" runat="server" CssClass="text-input" Width="20px"></asp:TextBox>
                                    <asp:TextBox ID="b" runat="server" CssClass="text-input" Width="20px"></asp:TextBox>
              <asp:TextBox ID="c" runat="server" CssClass="text-input" Width="20px"></asp:TextBox> <asp:TextBox ID="d" runat="server" CssClass="text-input" Width="20px"></asp:TextBox>
              <asp:TextBox ID="e" runat="server" CssClass="text-input" Width="20px"></asp:TextBox></td>
                                    <td><span class="tip">(开奖号)</span></td>
                                  </tr>
                                  <tr>
                                    <td><p>
                                      <label>中奖数*</label></p></td>
                                    <td>一等：
                                      <asp:TextBox ID="zj1" runat="server" CssClass="text-input" Width="100px"></asp:TextBox>
                                      二等：
                                      <asp:TextBox ID="zj2" runat="server" CssClass="text-input" Width="100px"></asp:TextBox>
                                      三等：
                                      <asp:TextBox ID="zj3" runat="server" CssClass="text-input" Width="100px"></asp:TextBox></td>
                                    <td><span class="tip">(依次为直选，组3，组6)</span></td>
                                  </tr>
                                   <tr>
                                    <td><p>
                                      <label>奖金金额*</label></p></td>
                                    <td>一等：
                                      <asp:TextBox ID="prize1" runat="server" CssClass="text-input" Width="100px"></asp:TextBox>
                                      二等：
                                      <asp:TextBox ID="prize2" runat="server" CssClass="text-input" Width="100px"></asp:TextBox>
                                      三等：
                                      <asp:TextBox ID="prize3" runat="server" CssClass="text-input" Width="100px"></asp:TextBox></td>
                                    <td><span class="tip">(试机号和类型)</span></td>
                                  </tr>
                                   <tr>
                                    <td><p>
                                      <label>投注额</label></p></td>
                                    <td><asp:TextBox ID="tzmoney" runat="server" CssClass="text-input" Width="220px"></asp:TextBox></td>
                                    <td><span class="tip">(总投注额)</span></td>
                                  </tr>
                                  <tr>
                                    <td><p>
                                      <label>奖池基金</label></p></td>
                                    <td><asp:TextBox ID="nextmoney" runat="server" CssClass="text-input" Width="220px"></asp:TextBox></td>
                                    <td><span class="tip">(奖池基金)</span></td>
                                  </tr>                                  
                                   <tr>
                                    <td><p>
                                      <label>开奖日期*</label></p></td>
                                    <td><asp:TextBox ID="date" runat="server" CssClass="text-input" Width="220px"></asp:TextBox></td>
                                    <td><span class="tip">(开奖日期)</span></td>
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
	  <h2>22选5开奖号列表   	    </h2>
	  <!-- End .shortcut-buttons-set -->
	<div class="clear"></div> <!-- End .clear -->
			
	  <div class="content-box"><!-- Start Content Box -->
				
				<div class="content-box-header">
					
				  <h3>列表框</h3>
					
					<ul class="content-box-tabs">
						<li><a href="#tab1" class="default-tab">22选5开奖号</a></li> <!-- href must be unique and match the id of target div -->
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
							        <th width="3%"><input class="check-all" type="checkbox" /></th>
							        <th width="12%">期号</th>
							        <th width="25%">开奖号</th>
                                    <th width="15%">一等奖 [金额]</th>
                                    <th width="12%">投注额</th>
                                    <th width="12%">奖池基金</th>
                                    <th width="12%">开奖日期</th>
							        <th width="9%">操作</th>
						          </tr>
						        </thead>
							    <tfoot>
							      <tr>
							        <td colspan="10"><div class="bulk-actions align-left">
							          <select name="dropdown" id="dropdown">
							            <option value="0">请选择操作...</option>
							            <option value="2">删除</option>
						              </select>
							          <a class="button" href="javascript:void(0);" onclick="delall(<%=CzMode%>);">确认</a> </div>
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
							            <td><input type="checkbox" name="ids" value="<%#DataBinder.Eval(Container.DataItem,"id").ToString().Trim()%>"/></td>
							            <td><a href="#"><%#DataBinder.Eval(Container.DataItem,"qi").ToString().Trim()%></a></td>
							            <td><span class="red"><%#GetKjh(DataBinder.Eval(Container.DataItem,"a"))%>,&nbsp;<%#GetKjh(DataBinder.Eval(Container.DataItem,"b"))%>,&nbsp;<%#GetKjh(DataBinder.Eval(Container.DataItem,"c"))%>,&nbsp;<%#GetKjh(DataBinder.Eval(Container.DataItem,"d"))%>,&nbsp;<%#GetKjh(DataBinder.Eval(Container.DataItem,"e"))%></span></td>
                                        <td><%#DataBinder.Eval(Container.DataItem,"zj1")%> 注 &nbsp;【<%#DataBinder.Eval(Container.DataItem,"prize1")%>】</td>
							            <td><%#DataBinder.Eval(Container.DataItem,"tzmoney")%></td>
                                        <td><%#DataBinder.Eval(Container.DataItem,"nextmoney")%></td>
                                        <td><%#GetDateStr(DataBinder.Eval(Container.DataItem,"date"))%></td>
							            <td><!-- Icons -->
							              <a href="?id=<%#DataBinder.Eval(Container.DataItem,"id")%>" title="编辑"><img src="resources/images/icons/pencil.png" alt="编辑" /></a>&nbsp;&nbsp;&nbsp;&nbsp; <a href="javascript:void(0);" onclick="del(<%=CzMode%>,<%#DataBinder.Eval(Container.DataItem,"id")%>);" title="删除"><img src="resources/images/icons/cross.png" alt="删除" /></a></td>
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
						&#169; Copyright 2012  | Powered by <a href="http://www.haocw.com/">haocw.com</a> | <a href="#">Top</a>
				</small>
		  </div><!-- End #footer -->
			

	  </div> <!-- End #main-content -->
		
  </div>
  <script type="text/javascript">
//后台删除数据
function del(mo,id){
	if(confirm("注意：此操作不可还原，是否继续？")){
		if(delmethodkjh(mo,id)=="ok"){
			alert("删除成功...");
			self.location.reload();
		}
	}		
}

//后台群删数据
function delall(mo){
	if(confirm("注意：此操作不可还原，是否继续？")){
		if(delallmethodkjh(mo)=="ok"){
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