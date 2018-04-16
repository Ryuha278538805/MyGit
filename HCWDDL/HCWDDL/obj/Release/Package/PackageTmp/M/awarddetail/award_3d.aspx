﻿<%@ Page Title="" Language="C#" MasterPageFile="~/M/Index.Master" AutoEventWireup="true" CodeBehind="award_3d.aspx.cs" Inherits="HCWDDL.M.awarddetail.award_3d" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <section class="moreQi" title="请选择您想要看的期数">
        <div class="content">
            <div class="bb-1 ub ub-ac">
                <p class="p-10 ub-f1 text-18">请选择期数</p>
                <i class="iconfont icon-guanbi text-18 mr-10"></i>
            </div>
            <div class="chooseQi clearfix">
                <%foreach (var qi in DIC_QI)
                  { %>
                <div class="con">
                    <a target="_self" href="award_3d.aspx?id=<%=qi.id %>"><%=qi.qi %></a>
                </div>
                <%} %>
            </div>
        </div>
    </section>

    <section class="bg-fff mb-10">
        <div class="kjList bb-1">
            <div class="ticket">
                <div>
                    <div class="name ub ub-ac">
                        <div class="ub-f1">
                            <b class="text-16 mr-10">3D <%=Model.qi.HasValue?Model.qi.Value.ToString().Substring(4,3):"" %> 期开奖</b>
                            <time class="small-font"><%=Model.date.HasValue? Model.date.Value.ToString("yyyy-MM-dd"):"" %>(<%=Model.GetWeekName(Model.date) %>)</time>
                        </div>
                        <span class="qi"><%=Model.qi.HasValue? Model.qi.Value.ToString():"" %> <i class="iconfont icon-arrow-down"></i></span>
                    </div>
                    <div class="ub ub-ac">
                        <div class="ballBox ub-f1">
                            <span class="ball red"><%=Model.a.HasValue? Model.a.Value.ToString():"" %></span>
                            <span class="ball red"><%=Model.b.HasValue? Model.b.Value.ToString():"" %></span>
                            <span class="ball red"><%=Model.c.HasValue? Model.c.Value.ToString():"" %></span>
                        </div>
                        <div>
                            <span class="t_info"></span>
                            <span class="t_info"><%=Model.qi.HasValue?Model.qi.Value.ToString().Substring(4,3):"" %>期开机号
                                <b class="text-red"><%=Model.kjh %></b>
                            </span>

                        </div>
                    </div>
                    <div class="ub mb-10">
                        <p class="ub-f1 text-14">
                            <%=Model.qi.HasValue?Model.qi.Value.ToString().Substring(4,3):"" %>试机号 :
                            <%=Model.sjh %>
                        </p>
                        <p class="ub-f1 text-12 mb-10">本期销量：<%=Model.GetJCMoney(Model.tzmoney).ToString("N0") %> </p>
                    </div>
                </div>
            </div>
        </div>
        <div class="p-10">
            <table class="kjTable">
                <thead>
                    <tr>
                        <th>奖项</th>
                        <th>中奖注数</th>
                        <th>单注金额</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>直选</td>
                        <td><%=Model.GetJCMoney(Model.zj1).ToString("N0") %></td>
                        <td>1040</td>
                    </tr>
                    <tr>
                        <td>组三</td>
                        <td><%=Model.GetJCMoney(Model.zj2).ToString("N0") %></td>
                        <td>346</td>
                    </tr>
                    <tr>
                        <td>组六</td>
                        <td><%=Model.GetJCMoney(Model.zj3).ToString("N0") %></td>
                        <td>173</td>
                    </tr>
                </tbody>
            </table>
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
