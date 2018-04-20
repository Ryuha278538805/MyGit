<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="menus.ascx.cs" Inherits="Admin.menus" %>
<div id="sidebar"><div id="sidebar-wrapper"> <!-- Sidebar with logo and menu -->			
			<h1 id="sidebar-title"><a href="http://www.haocw.com/">管理后台</a></h1>		  
			<!-- Logo (221px wide) -->
			<a href="#"><img id="logo" src="resources/images/logo.png" alt="Simpla Admin logo" /></a>	  
			<!-- Sidebar Profile links -->
			<div id="profile-links">
            您好, <a href="#"><%=ausername%></a>, 欢迎登录<br /><br />
            	<a href="http://www.haocw.com/ajax/makepage.aspx" target="_blank">生成页面</a><br /><br />				
				<a href="http://www.haocw.com">网站首页</a> | <a href="logout.aspx" title="退出登录">退出登录</a>
			</div>        			
			<ul id="main-nav">  				
				<li>
					<a href="/home.aspx" class="nav-top-item no-submenu">面板首页</a>       
				</li>
				<%if (allow.AllowPub)      { %>
				<li> 
					<a href="#" class="nav-top-item<%if(clicked==1||clicked==2||(clicked>16&&clicked<=20)){%> current<%}%>">资讯管理</a>
					<ul>
						<li><a href="news_add.aspx"<%if(clicked==1){%> class="current"<%}%>>添加资讯</a></li>
                        <%if (allow.AllowPage)      { %>
                        <li><a  href="news_templet_add.aspx"<%if(clicked==17){%> class="current"<%}%>>添加模板资讯</a></li>
                        <li><a href="news_merge.aspx"<%if(clicked==20){%> class="current"<%}%>>添加汇总</a></li><%}%>
	  				    <li><a  href="news_list.aspx"<%if(clicked==2){%> class="current"<%}%>>资讯列表</a></li>
                        <%if (allow.AllowPage)      { %>
                        <li><a  href="templet_list.aspx"<%if(clicked==18){%> class="current"<%}%>>模板列表</a></li>
                        <li><a  href="templet_add.aspx"<%if(clicked==19){%> class="current"<%}%>>添加模板</a></li><%}%>
					</ul>
				</li>		
                <%if (allow.AllowPage) { %>
                <li>
					<a href="#" class="nav-top-item<%if(clicked==46 || clicked==47){%> current<%}%>">预测管理</a>
					<ul>
						<li><a href="yc_list.aspx"<%if(clicked==46){%> class="current"<%}%>>预测列表</a></li>
						<li><a href="yczone_list.aspx"<%if(clicked==47){%> class="current"<%}%>>预测专题列表</a></li>
					</ul>
				</li>	
				<li>
					<a href="#" class="nav-top-item<%if(clicked>=3&&clicked<=16){%> current<%}%>">开奖号管理</a>
					<ul>
						<li><a href="lottery_sd.aspx"<%if(clicked==3){%> class="current"<%}%>>福彩3D</a></li>
						<li><a href="lottery_ssq.aspx"<%if(clicked==4){%> class="current"<%}%>>福彩双色球</a></li>
						<li><a href="lottery_qlc.aspx"<%if(clicked==5){%> class="current"<%}%>>福彩七乐彩</a></li>
						<li><a href="lottery_225.aspx"<%if(clicked==6){%> class="current"<%}%>>福彩22选5</a></li>
						<li><a href="lottery_p3.aspx"<%if(clicked==7){%> class="current"<%}%>>体彩P3 / P5</a></li>
						<li><a href="lottery_dlt.aspx"<%if(clicked==8){%> class="current"<%}%>>体彩大乐透</a></li>
						<li><a href="lottery_qxc.aspx"<%if(clicked==9){%> class="current"<%}%>>体彩七星彩</a></li>
					</ul>
				</li>
				<%} } %>				
    			<%if (allow.AllowUser)
              { %>
               <li>
					<a href="#" class="nav-top-item<%if(clicked>=41&&clicked<=45){%> current<%}%>">社区商店管理</a>
					<ul>
                        <li><a href="goods_add.aspx"<%if(clicked==41){%> class="current"<%}%>>添加商品</a></li>		
						<li><a href="goods_list.aspx"<%if(clicked==42){%> class="current"<%}%>>商品列表</a></li>												
						<li><a href="goodssell_list.aspx"<%if(clicked==43){%> class="current"<%}%>>销售记录</a></li>
                        <li><a href="goodssell_add.aspx"<%if(clicked==45){%> class="current"<%}%>>销售记录更新</a></li>
                        <li><a href="goodsclass_list.aspx"<%if(clicked==44){%> class="current"<%}%>>商品分类</a></li>
					</ul>
				</li>              
				<li>
					<a href="#" class="nav-top-item<%if(clicked==21||clicked==22||clicked==23||clicked==35){%> current<%}%>">注册用户管理</a>
					<ul>
						<li><a href="#"<%if(clicked==21){%> class="current"<%}%>>用户列表</a></li>
						<li><a href="#"<%if(clicked==22){%> class="current"<%}%>>预留功能</a></li>
						<li><a href="#"<%if(clicked==23){%> class="current"<%}%>>预留功能</a></li>
                        <li><a href="#"<%if(clicked==35){%> class="current"<%}%>>生成成绩</a></li>
					</ul>
				</li>	
				<%} %>				
				<%if (allow.AllowConfig)
                 { %>
				<li>
					<a href="#" class="nav-top-item<%if(clicked==24||clicked==25){%> current<%}%>">	后台管理者</a>
					<ul>
						<li><a href="master_list.aspx"<%if(clicked==24){%> class="current"<%}%>>管理者列表</a></li>
						<li><a href="mastergroup_list.aspx"<%if(clicked==25){%> class="current"<%}%>>管理者分组</a></li>
					</ul>
				</li>                			
				<li>
					<a href="#" class="nav-top-item<%if(clicked==26||clicked==27||clicked==28){%> current<%}%>">基本配置</a>
					<ul>
						<li><a href="newsclass_list.aspx"<%if(clicked==26){%> class="current"<%}%>>分类管理</a></li>
						<li><a href="zone_list.aspx"<%if(clicked==27){%> class="current"<%}%>>专题管理</a></li>
						<li><a href="cz_list.aspx"<%if(clicked==28){%> class="current"<%}%>>彩种管理</a></li>
					</ul>
				</li>
				<%} %>
                <%if (allow.AllowAdvert)
                 { %>
                 <li>
                 <a href="#" class="nav-top-item<%if(clicked>=30&&clicked<=34){%> current<%}%>">广告管理</a>
					<ul>
						<li><a href="#"<%if(clicked==31){%> class="current"<%}%>>广告管理</a></li>
						<li><a href="#"<%if(clicked==32){%> class="current"<%}%>>广告位管理</a></li>
                        <li><a href="m_ad_list.aspx"<%if(clicked==33){%> class="current"<%}%>>手机广告管理</a></li>
					</ul>
                 <%}%>
				<li>
					<a href="#" class="nav-top-item<%if(clicked>=36&&clicked<=40){%> current<%}%>">系统应用	</a>
					<ul>
                    	 <%if (allow.AllowPage){ %><li><a href="pages_up.aspx?pageid=1"<%if(clicked==36){%> class="current"<%}%>>手动推荐</a></li><%}%>
						<li><a href="logout.aspx"<%if(clicked==38){%> class="current"<%}%>>退出登录</a></li>
					</ul>
				</li>
				
			</ul> <!-- End #main-nav -->
			
	
			
		</div></div>