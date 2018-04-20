<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="head.ascx.cs" Inherits="Shop.head" %>
<div id="append_parent"></div><div id="ajaxwaitid"></div>
<div id="hd">
	<div class="wrap">
		<div class="head cl">
			<h2><a href="/index.aspx" title="好彩论坛"><img src="http://bbs.haocw.com/templates/default/images/logo.png" alt="好彩论坛"/></a></h2>
           <%if(uid>0){%>
				<div id="um">
                    <div class="avt y">
                        <a target="_blank" href="http://bbs.haocw.com/usercp.aspx"><img src="<%=avatar%>" onerror="this.onerror=null;this.src='http://bbs.haocw.com/images/common/noavatar_small.gif';"  alt="<%=uinfo.username%>"/></a>
                     </div>
                    <p>
                        <strong><a href="http://bbs.haocw.com/userinfo.aspx?userid=<%=uinfo.uid%>" class="vwmy"><%=uinfo.username%></a></strong><span class="xg1">在线</span><span class="pipe">|</span>                    
                        <a id="pm_ntc" href="http://bbs.haocw.com/usercpinbox.aspx" title="<%if(olinfo.newpms>0){%>您有<%=olinfo.newpms%>条新短消息<%}else{%>您没有新短消息<%}%>">短消息<%if(olinfo.newpms>0){%>(<%=olinfo.newpms%>)<%}%></a><span class="pipe">|</span>
                        <a href="http://bbs.haocw.com/usercpnotice.aspx?filter=all" title="<%if(olinfo.newnotices>0){%>您有<%=olinfo.newnotices%>条新通知<%}else{%>您没有新通知<%}%>">通知<%if(olinfo.newnotices>0){%>(<%=olinfo.newnotices%>)<%}%></a><span class="pipe">|</span>
                        <a id="usercenter" class="drop" onmouseover="showMenu(this.id);" href="http://bbs.haocw.com/usercp.aspx">用户中心</a><span class="pipe">|</span>
                        <%if(olinfo.adminid==1){%> <a href="http://bbs.haocw.com/admin/index.aspx" target="_blank">系统设置</a><span class="pipe">|</span><%}%>
                        <a href="http://bbs.haocw.com/logout.aspx?userkey=<%=password%>">退出</a>
                    </p>
                    <p>
                        <a class="drop" onmouseover="showMenu(this.id);" href="http://bbs.haocw.com/usercpcreditspay.aspx" id="extcreditmenu">积分:<%=uinfo.credits%></a> <span class="pipe">|</span>
                        用户组: <a class="xi2" id="g_upmine" href="http://bbs.haocw.com/usercp.aspx"><%=uginfo.grouptitle%></a>
                     </p>
                     <ul id="extcreditmenu_menu" class="p_pop" style="display:none;"><li><a> 威望: <%=uinfo.extcredits1%></a></li><li><a> 金钱: <%=uinfo.extcredits2%>元</a></li><li><a> 彩贝: <%=uinfo.extcredits3%>枚</a></li></ul>
                </div>
        <%}else{%>
            	<form onsubmit="if ($('ls_username').value == '' || $('ls_username').value == '用户名/Email') showWindow('login', 'http://bbs.haocw.com/login.aspx');hideWindow('register');return" action="http://bbs.haocw.com/login.aspx?referer=forumindex.aspx" id="lsform" autocomplete="off" method="post">
				<div class="fastlg c1">
					<div class="y pns">
						<p>
							<label for="ls_username">帐号</label> <input type="text" tabindex="901" value="用户名/Email" id="ls_username" name="username" class="txt" onblur="if(this.value == '') this.value = '用户名/Email';" onfocus="if(this.value == '用户名/Email') this.value = '';"><a href="http://bbs.haocw.com/register.aspx" onclick="showWindow('register', 'http://bbs.haocw.com/register.aspx');hideWindow('login');" style="margin-left: 7px;" class="xg2">注册</a>							
						</p>
						<p>
							<label for="ls_password">密码</label> <input type="password" onfocus="lsShowmore();innerVcode();" tabindex="902" autocomplete="off" id="ls_password" name="password" class="txt">
							&nbsp;<input type="submit" style="width:0px;filter:alpha(opacity=0);-moz-opacity:0;opacity:0;display:none;"><button class="pn" type="submit"><span>登录</span></button>
						</p>
					</div>
				</div>
                <div id="ls_more" style="position:absolute;display:none;">
                <h3 class="cl"><em class="y"><a href="###" class="flbc" title="关闭" onclick="closeIsMore();return false;">关闭</a></em>安全选项</h3>                
                    <script type="text/javascript">
                        function innerVcode() {
                        }
                    </script>                
                <script type="text/javascript">
                    function closeIsMore() {
                        $('ls_more').style.display = 'none';
                    }
                    function displayAnswer() {
                        if ($("question").value > 0)
                            $("answer").style.display = "";
                        else
                            $("answer").style.display = "none";
                    }
                </script>
				<div class="ptm cl" style="border-top:1px dashed #CDCDCD;">
					<a class="y xg2" href="http://bbs.haocw.com/getpassword.aspx" onclick="hideWindow('register');hideWindow('login');showWindow('getpassword', this.href);">找回密码</a>
					<label class="z" for="ls_cookietime"><input type="checkbox" tabindex="906" value="2592000" id="ls_cookietime" name="expires" checked="checked"><span title="下次访问自动登录">记住我</span></label>
				</div>
            </div>
			</form>            
             <%}%>
         </div>
        
		<div id="menubar">
            <a onMouseOver="showMenu(this.id, false);" href="javascript:void(0);" id="mymenu">我的中心</a>
            <div class="popupmenu_popup headermenu_popup" id="mymenu_menu" style="display: none">       
               <%if(uid>0){%>
                <ul class="sel_my">
                    <li><a href="http://bbs.haocw.com/mytopics.aspx">我的主题</a></li>
                    <li><a href="http://bbs.haocw.com/myposts.aspx">我的帖子</a></li>
                    <li><a href="http://bbs.haocw.com/search.aspx?posterid=current&type=digest&searchsubmit=1">我的精华</a></li>
                    <li><a href="http://bbs.haocw.com/myattachment.aspx">我的附件</a></li>
                    <li><a href="http://bbs.haocw.com/usercpsubscribe.aspx">我的收藏</a></li>	
                    <li><a href="http://shop.haocw.com/goods/my.html">买到的商品</a></li>			
                </ul>       <%}else{%>           
                 <p class="reg_tip"><a href="http://bbs.haocw.com/register.aspx" class="xg2">登录或注册新用户,开通自己的个人中心</a></p>   <%}%>
               <ul class="sel_mb">
                    <li><a href="javascript:;" onclick="widthauto(this,'/templates/default')">切换到宽版</a></li>
                </ul>        
            </div>
            
			<ul id="menu" class="cl">
				<li><a id="menu_5" onMouseOver="showMenu({'ctrlid':this.id});" href="http://www.haocw.com" target="_blank">好彩</a></li>
                <li><a id="menu_1" onMouseOver="showMenu({'ctrlid':this.id});" href="http://bbs.haocw.com">太湖论坛</a></li>
                <li><a id="menu_2" onMouseOver="showMenu({'ctrlid':this.id});" href="http://www.haocw.com/kj/" target="_blank">开奖信息</a></li>
                <li><a id="menu_3" onMouseOver="showMenu({'ctrlid':this.id});" href="http://www.haocw.com/jpt/index.html" target="_blank">精品图库</a></li>
                <li><a id="menu_4" onMouseOver="showMenu({'ctrlid':this.id});" href="http://www.haocw.com/hzt/index.html" target="_blank">汇总帖子</a></li>
                <li><a id="menu_6" onMouseOver="showMenu({'ctrlid':this.id});" href="http://www.haocw.com/dyt/index.html" target="_blank">打印彩报</a></li>
                <li><a id="menu_7" onMouseOver="showMenu({'ctrlid':this.id});" href="http://www.haocw.com/jth/index.html" target="_blank">3D解太湖</a></li>
                <li><a id="menu_8" onMouseOver="showMenu({'ctrlid':this.id});" href="http://tu.haocw.com/" target="_blank">太湖图库</a></li>
                <li><a id="menu_9" onMouseOver="showMenu({'ctrlid':this.id});" href="http://shop.haocw.com/" target="_blank">社区商店</a></li>                
			</ul>
		</div>
        
	</div>
</div>

<div class="wrap cl pageinfo">
	<div id="nav">
		<form method="post" action="/index.aspx" target="_blank" onsubmit="bind_keyword(this);" class="y">
            <input type="hidden" name="poster" />
            <input type="hidden" name="keyword" />
            <input type="hidden" name="type" value="" />
            <input id="keywordtype" type="hidden" name="keywordtype" value="0" />
            <a href="javascript:void(0);" class="drop s_type" id="quicksearch" onclick="showMenu(this.id, false);" onmouseover="MouseCursor(this);">快速搜索</a>
            <input type="text" name="keywordf" value="输入搜索关键字" onblur="if(this.value=='')this.value=defaultValue" onclick="if(this.value==this.defaultValue)this.value = ''" onkeydown="if(this.value==this.defaultValue)this.value = ''" class="txt"/>
            <input name="searchsubmit" type="submit" value="" class="btnsearch"/>
		</form>
        <ul id="quicksearch_menu" class="p_pop" style="display: none;">
            <li><a href="###" onclick="$('keywordtype').value='0';$('quicksearch').innerHTML='商品名';$('quicksearch_menu').style.display='none';" onmouseover="MouseCursor(this);">商品名</a></li>
        </ul>
		<script type="text/javascript">
            function bind_keyword(form) {
                if (form.keywordtype.value == '9') {
                    form.action = '/index.aspx?q=' + escape(form.keywordf.value);
                } else if (form.keywordtype.value == '8') {
                    form.keyword.value = '';
                    form.poster.value = form.keywordf.value != form.keywordf.defaultValue ? form.keywordf.value : '';
                } else {
                    form.poster.value = '';
                    form.keyword.value = form.keywordf.value != form.keywordf.defaultValue ? form.keywordf.value : '';
                    if (form.keywordtype.value == '2')
                        form.type.value = 'spacepost';
                    if (form.keywordtype.value == '3')
                        form.type.value = 'album';
                }
            }
        </script>
		<a id="forumlist" href="http://bbs.haocw.com" onmouseover="showMenu(this.id);" onmouseout="showMenu(this.id);" class="title">好彩论坛</a> &raquo; <a href="http://shop.haocw.com">社区商店</a> 
	</div>
</div>