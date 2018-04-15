<%@ Page Title="" Language="C#" MasterPageFile="~/M/Index.Master" AutoEventWireup="true" CodeBehind="awards.aspx.cs" Inherits="HCWDDL.M.awards" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">

    <section class="tabContainer">
        <div class="con kjList bg-fff active">
            <a class="ticket ub ub-ac" href="/M/awarddetail/award_ssq.aspx?id=<%=SSQInfo.id %>">
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
                </div>
                <i class="iconfont icon-arrow"></i>
            </a>

            <a class="ticket ub ub-ac" href="/M/awarddetail/award_3d.aspx?id=<%=SDInfo.id %>">
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
                </div>
                <i class="iconfont icon-arrow"></i>
            </a>

            <a class="ticket ub ub-ac" href="award_dlt.html?id=<%=DLTInfo.id %>">
                <div class="ub-f1 mr-10">
                    <h6 class="name"><span class="text-16 mr-10">大乐透</span><span class="small-font">-第<%=DLTInfo.qi.HasValue? DLTInfo.qi.Value.ToString():"" %>期</span></h6>
                    <div class="ub ub-ac">
                        <div class="ballBox">
                            <span class="ball red"><%=DLTInfo.a.HasValue? DLTInfo.a.Value.ToString():"" %></span>
                            <span class="ball red"><%=DLTInfo.b.HasValue? DLTInfo.b.Value.ToString():"" %></span>
                            <span class="ball red"><%=DLTInfo.c.HasValue? DLTInfo.c.Value.ToString():"" %></span>
                            <span class="ball red"><%=DLTInfo.d.HasValue? DLTInfo.d.Value.ToString():"" %></span>
                            <span class="ball red"><%=DLTInfo.e.HasValue? DLTInfo.e.Value.ToString():"" %></span>
                            <span class="ball blue"><%=DLTInfo.f.HasValue? DLTInfo.f.Value.ToString():"" %></span>
                            <span class="ball blue"><%=DLTInfo.g.HasValue? DLTInfo.g.Value.ToString():"" %></span>
                        </div>
                    </div>
                    <p class="small-font w-100"><time><%=DLTInfo.date.HasValue? DLTInfo.date.Value.ToString("yyyy-MM-dd"):"" %>(<%=DLTInfo.GetWeekName(DLTInfo.date) %>)</time> 奖池：<%=DLTInfo.GetJCMoney(DLTInfo.nextmoney).ToString("N0") %></p>
                </div>
                <i class="iconfont icon-arrow"></i>
            </a>

            <a class="ticket ub ub-ac" href="award_dlt.html?id=<%=P3Info.id %>">
                <div class="ub-f1 mr-10">
                    <h6 class="name"><span class="text-16 mr-10">排列3</span><span class="small-font">-第<%=P3Info.qi.HasValue? P3Info.qi.Value.ToString():"" %>期</span></h6>
                    <div class="ub ub-ac">
                        <div class="ballBox">
                            <span class="ball red"><%=P3Info.a.HasValue? P3Info.a.Value.ToString():"" %></span>
                            <span class="ball red"><%=P3Info.b.HasValue? P3Info.b.Value.ToString():"" %></span>
                            <span class="ball red"><%=P3Info.c.HasValue? P3Info.c.Value.ToString():"" %></span>
                        </div>
                    </div>
                    <p class="small-font w-100"><time><%=P3Info.date.HasValue? P3Info.date.Value.ToString("yyyy-MM-dd"):"" %>(<%=P3Info.GetWeekName(P3Info.date) %>)</time></p>
                </div>
                <i class="iconfont icon-arrow"></i>
            </a>
            <a class="ticket ub ub-ac" href="award.html">
                <div class="ub-f1 mr-10">
                    <h6 class="name"><span class="text-16 mr-10">七星彩</span><span class="small-font">-第<%=QXCInfo.qi.HasValue? QXCInfo.qi.Value.ToString():"" %>期</span></h6>
                    <div class="ub ub-ac">
                        <div class="ballBox">
                            <span class="ball red"><%=QXCInfo.a.HasValue? QXCInfo.a.Value.ToString():"" %></span>
                            <span class="ball red"><%=QXCInfo.b.HasValue? QXCInfo.b.Value.ToString():"" %></span>
                            <span class="ball red"><%=QXCInfo.c.HasValue? QXCInfo.c.Value.ToString():"" %></span>
                            <span class="ball red"><%=QXCInfo.d.HasValue? QXCInfo.d.Value.ToString():"" %></span>
                            <span class="ball red"><%=QXCInfo.e.HasValue? QXCInfo.e.Value.ToString():"" %></span>
                            <span class="ball red"><%=QXCInfo.f.HasValue? QXCInfo.f.Value.ToString():"" %></span>
                            <span class="ball red"><%=QXCInfo.g.HasValue? QXCInfo.g.Value.ToString():"" %></span>
                        </div>
                    </div>
                    <p class="small-font w-100"><time><%=QXCInfo.date.HasValue? QXCInfo.date.Value.ToString("yyyy-MM-dd"):"" %>(<%=QXCInfo.GetWeekName(QXCInfo.date) %>)</time></p>
                </div>
                <i class="iconfont icon-arrow"></i>
            </a>
            <a class="ticket ub ub-ac" href="award.html">
                <div class="ub-f1 mr-10">
                    <h6 class="name"><span class="text-16 mr-10">七乐彩</span><span class="small-font">-第2018041期</span></h6>
                    <div class="ub ub-ac">
                        <div class="ballBox">
                            <span class="ball red">05</span>
                            <span class="ball red">13</span>
                            <span class="ball red">15</span>
                            <span class="ball red">17</span>
                            <span class="ball red">18</span>
                            <span class="ball red">22</span>
                            <span class="ball red">29</span>
                            <span class="ball blue">09</span>
                        </div>
                    </div>
                    <p class="small-font w-100"><time>2018-04-11(周三)</time></p>
                </div>
                <i class="iconfont icon-arrow"></i>
            </a>
        </div>
    </section>

    <section class="bg-fff mb-10">
        <div class="mainTitle clearfix bb-1">
            <i class="iconfont icon-zoushi text-orange-red"></i>
            <a href="https://www.cz98.com/"><b class="text-16">双色球手机走势图</b></a>
        </div>
        <div class="typeLinkBox grey-border col3 bg-fff clearfix mb-10">
            <div class="col">
                <a href="https://m.8200.cn/zs_ssq/chzs.htm">出号走势图</a>
            </div>
            <div class="col">
                <a href="https://m.8200.cn/zs_ssq/aczs.htm">AC值走势</a>
            </div>
            <div class="col">
                <a href="https://m.8200.cn/zs_ssq/hqzs.htm">红球走势图</a>
            </div>
            <div class="col">
                <a href="https://m.8200.cn/zs_ssq/lqzs.htm">蓝球走势图</a>
            </div>
            <div class="col">
                <a href="https://m.8200.cn/zs_ssq/qjzs.htm">区间走势图</a>
            </div>
            <div class="col">
                <a href="https://m.8200.cn/zs_ssq/2.htm">周二走势图</a>
            </div>
            <div class="col">
                <a href="https://m.8200.cn/zs_ssq/4.htm">周四走势图</a>
            </div>
            <div class="col">
                <a href="https://m.8200.cn/zs_ssq/7.htm">周日走势图</a>
            </div>
        </div>
    </section>
</asp:Content>
