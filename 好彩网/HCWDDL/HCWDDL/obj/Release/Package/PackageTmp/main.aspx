<%@ Page Title="" Language="C#" MasterPageFile="Index.Master" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="HCWDDL.M.main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">

    <section class="tabContainer">
        <div class="con kjList bg-fff active">
            <a class="ticket ub ub-ac" href="/awarddetail/award_ssq.aspx?id=<%=SSQInfo.id %>">
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

            <a class="ticket ub ub-ac" href="/awarddetail/award_3d.aspx?id=<%=SDInfo.id %>">
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
        </div>
    </section>

    <%foreach (var pname in ParentNames)
      {
          var news = IndexNews.Where(p => p.PName == pname).ToList();
    %>
    <section class="bg-fff mb-10">
        <div class="mainTitle clearfix bb-1">
            <i class="iconfont icon-123"></i>
            <a href="/ls2.aspx?zid=0&cid=<%=news[0].cid %>&cn=<%=pname %>">
                <b class="text-16"><%=pname %></b>
            </a>
        </div>
        <ul class="commenList">
            <%foreach (var info in news)
              { %>
            <li><a href="/newdetail.aspx?id=<%=info.nid %>"><%=info.title %></a></li>
            <%} %>
        </ul>
    </section>
    <%} %>
</asp:Content>
