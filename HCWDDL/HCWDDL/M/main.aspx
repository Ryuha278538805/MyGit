<%@ Page Title="" Language="C#" MasterPageFile="~/M/Index.Master" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="HCWDDL.M.main" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">

    <section class="tabContainer">
        <div class="con kjList bg-fff active">
            <a class="ticket ub ub-ac" href="awarddetail/award_ssq.aspx?id=<%=SSQInfo.id %>">
                <div class="ub-f1 mr-10">
                    <h6 class="name"><span class="text-16 mr-10">双色球</span><span class="small-font">-第<%=SSQInfo.qi.HasValue? SSQInfo.qi.Value.ToString():"" %>期</span></h6>
                    <div class="ub ub-ac">
                        <div class="ballBox">
                            <span class="ball red"><%=SSQInfo.a.HasValue? SSQInfo.a.Value.ToString().PadLeft(2,'0'):"" %></span>
                            <span class="ball red"><%=SSQInfo.b.HasValue? SSQInfo.b.Value.ToString().PadLeft(2,'0'):"" %></span>
                            <span class="ball red"><%=SSQInfo.c.HasValue? SSQInfo.c.Value.ToString().PadLeft(2,'0'):"" %></span>
                            <span class="ball red"><%=SSQInfo.d.HasValue? SSQInfo.d.Value.ToString().PadLeft(2,'0'):"" %></span>
                            <span class="ball red"><%=SSQInfo.e.HasValue? SSQInfo.e.Value.ToString().PadLeft(2,'0'):"" %></span>
                            <span class="ball red"><%=SSQInfo.f.HasValue? SSQInfo.f.Value.ToString().PadLeft(2,'0'):"" %></span>
                            <span class="ball blue"><%=SSQInfo.g.HasValue? SSQInfo.g.Value.ToString().PadLeft(2,'0'):"" %></span>
                        </div>
                    </div>
                    <p class="small-font w-100"><time><%=SSQInfo.date.HasValue? SSQInfo.date.Value.ToString("yyyy-MM-dd"):"" %>(<%=SSQInfo.GetWeekName(SSQInfo.date) %>)</time> 奖池：<%=SSQInfo.GetJCMoney(SSQInfo.nextmoney).ToString("N0") %></p>
                </div> <i class="iconfont icon-arrow"></i>
            </a>
            
            <a class="ticket ub ub-ac" href="awarddetail/award_3d.aspx?id=<%=SDInfo.id %>">
                <div class="ub-f1 mr-10">
                    <h6 class="name"><span class="text-16 mr-10">3D</span><span class="small-font">-第<%=SDInfo.qi.HasValue? SSQInfo.qi.Value.ToString():"" %>期</span></h6>
                    <div class="ub ub-ac">
                        <div class="ballBox">
                            <span class="ball red"><%=SDInfo.a.HasValue? SDInfo.a.Value.ToString():"" %></span>
                            <span class="ball red"><%=SDInfo.b.HasValue? SDInfo.b.Value.ToString():"" %></span>
                            <span class="ball red"><%=SDInfo.c.HasValue? SDInfo.c.Value.ToString():"" %></span>
                        </div>
                        <div class="ub-f1">
                            <span class="t_info">试机号:<b><%=SDInfo.sjh %></b></span>
                        </div>
                    </div>
                    <p class="small-font w-100"><time><%=SDInfo.date.HasValue? SDInfo.date.Value.ToString("yyyy-MM-dd"):"" %>(<%=SDInfo.GetWeekName(SDInfo.date) %>)</time></p>
                </div> <i class="iconfont icon-arrow"></i>
            </a>
        </div>
    </section>
    
    <section class="bg-fff mb-10">
        <div class="mainTitle clearfix bb-1">
            <i class="iconfont icon-123"></i>
            <a href="ls2.html">
                <b class="text-16">3D预测</b>
            </a>
            <img class="qipa" src="Content/images/qipa.svg">
            <a class="text-16" href="ls2.html">3D字谜</a>
        </div>
        <ul class="commenList">
            <li> <a href="news.html">好彩网17067期乾坤解码3D图谜!</a></li>
            <li> <a href="news.html">好彩网17067期太湖出航3D图谜</a></li>
            <li> <a href="news.html">好彩网167067期太湖天机3D图谜!</a></li>
            <li> <a href="news.html">好彩网167067期太湖转盘3D图谜</a></li>
            <li> <a href="news.html">好彩网167067期四宝莲灯3D图谜</a></li>
        </ul>
        <div class="ubnderListMore ub">
            <div class="ub-f1">
                <a class="" href="ls2.html">相关术语</a>
                <a class="" href="ls2.html">技巧方法</a>
                <a class="" href="ls2.html">中奖规则</a>
            </div>
        </div>
    </section>

    <section class="bg-fff mb-10">
        <div class="mainTitle clearfix bb-1">
            <i class="iconfont icon-123"></i>
            <a href="ls2.html">
                <b class="text-16">P3预测</b>
            </a>
            <img class="qipa" src="Content/images/qipa.svg">
            <a class="text-16" href="ls2.html">P3字谜</a>
        </div>
        <ul class="commenList">
            <li> <a href="news.html">2017067期P3晚秋(和值)谜好彩网发布</a></li>
            <li> <a href="news.html">体彩P32017067期 乾坤一句定三码好彩网发布</a></li>
            <li> <a href="news.html">体彩P32017067期 天师排列3字谜好彩网发布</a></li>
            <li> <a href="news.html">体彩P32017067期 P3冰寒字谜好彩网发布</a></li>
            <li> <a href="news.html">体彩P32017067期 晓乐排列3字谜好彩网发布</a></li>
        </ul>
        <div class="ubnderListMore ub">
            <div class="ub-f1">
                <a class="" href="ls2.html">相关术语</a>
                <a class="" href="ls2.html">技巧方法</a>
                <a class="" href="ls2.html">中奖规则</a>
            </div>
        </div>
    </section>

    <section class="bg-fff mb-10">
        <div class="mainTitle clearfix bb-1">
            <i class="iconfont icon-123"></i>
            <a href="ls2.html">
                <b class="text-16">双色球预测</b>
            </a>
            <img class="qipa" src="Content/images/qipa.svg">
            <a class="text-16" href="ls2.html">双色球字谜</a>
        </div>
        <ul class="commenList">
            <li> <a href="news.html">2017年030期双色球欧阳纤红球篮球预测分析好彩网发布</a></li>
            <li> <a href="news.html">2017年030期双色球清影重点号码推荐好彩网发布</a></li>
            <li> <a href="news.html">双色球2017030期八仙过海蓝球及尾数预测好彩网发布</a></li>
            <li> <a href="news.html">2017年030期双色球风行者下期六位奖号预测好彩网发布</a></li>
            <li> <a href="news.html">2017年030期双色球千山红叶复式8+2实战推荐好彩网发布</a></li>
        </ul>
        <div class="ubnderListMore ub">
            <div class="ub-f1">
                <a class="" href="ls2.html">相关术语</a>
                <a class="" href="ls2.html">技巧方法</a>
                <a class="" href="ls2.html">中奖规则</a>
            </div>
        </div>
    </section>

    <section class="bg-fff mb-10">
        <div class="mainTitle clearfix bb-1">
            <i class="iconfont icon-123"></i>
            <a href="ls2.html"><b class="text-16">太湖钓叟三字诀</b></a>
            <img class="qipa" src="Content/images/qipa.svg">
            <a class="text-16" href="ls2.html">3D藏机图</a>
        </div>
        <ul class="commenList">
            <li> <a href="news.html">17067期太湖钓叟三字诀图迷发布</a></li>
            <li> <a href="news.html">17066期太湖钓叟三字诀图迷发布</a></li>
            <li> <a href="news.html">17065期太湖钓叟三字诀图迷发布</a></li>
            <li> <a href="news.html">17064期太湖钓叟三字诀图迷发布</a></li>
            <li> <a href="news.html">17063期太湖钓叟三字诀图迷发布</a></li>
        </ul>
        <div class="ubnderListMore ub">
            <div class="ub-f1">
                <a class="" href="ls2.html">东北王+晚秋图</a>
                <a class="" href="ls2.html">黑圣手3D图谜</a>
                <a class="" href="ls2.html">真精华布衣+早报</a>
            </div>
        </div>
    </section>

    <section class="bg-fff mb-10">
        <div class="mainTitle clearfix bb-1">
            <i class="iconfont icon-123"></i>
            <a href="ls2.html"><b class="text-16">三毛系列全图</b></a>
            <img class="qipa" src="Content/images/qipa.svg">
            <a class="text-16" href="ls2.html">三毛追奖+藏机</a>
        </div>
        <ul class="commenList">
            <li> <a href="news.html">17067期三毛系列图迷发布</a></li>
            <li> <a href="news.html">17066期三毛系列图迷发布</a></li>
            <li> <a href="news.html">17065期三毛系列图迷发布</a></li>
            <li> <a href="news.html">17064期三毛系列图迷发布</a></li>
            <li> <a href="news.html">17063期三毛系列图迷发布</a></li>
        </ul>
        <div class="ubnderListMore ub">
            <div class="ub-f1">
                <a class="" href="ls2.html">真三毛代理</a>
                <a class="" href="ls2.html">三强系列</a>
                <a class="" href="ls2.html">福娃看彩</a>
            </div>
        </div>
    </section>

    <section class="bg-fff mb-10">
        <div class="mainTitle clearfix bb-1">
            <i class="iconfont icon-123"></i>
            <a href="ls2.html"><b class="text-16">好彩网3D藏机图</b></a>
            <img class="qipa" src="Content/images/qipa.svg">
            <a class="text-16" href="ls2.html">黄历看彩3D图谜</a>
        </div>
        <ul class="commenList">
            <li> <a href="news.html">好彩网17067期好彩网3D藏机图</a></li>
            <li> <a href="news.html">好彩网17066期好彩网3D藏机图</a></li>
            <li> <a href="news.html">好彩网17065期好彩网3D藏机图</a></li>
            <li> <a href="news.html">好彩网17064期好彩网3D藏机图</a></li>
            <li> <a href="news.html">好彩网17063期好彩网3D藏机图</a></li>
        </ul>
        <div class="ubnderListMore ub">
            <div class="ub-f1">
                <a class="" href="ls2.html">金胆图3D图谜</a>
                <a class="" href="ls2.html">观音送胆3D图谜</a>
                <a class="" href="ls2.html">玄机图3D图谜</a>
            </div>
        </div>
    </section>

</asp:Content>