<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="newdetail.aspx.cs" Inherits="HCWDDL.M.newdetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <section class="bg-fff mb-10">
        <div class="mainTitle title ub ub-ac bb-1">
            <i class="iconfont icon-dianping text-green mr-5"></i>
            <b class="text-18 mr-5 ub-f1"><%=Model.title %></b>
        </div>
        <p class="article text-grey" style="text-align:center;font-size:1.3rem">
                发布时间：<time>
                    <%=Model.addtime.HasValue?Model.addtime.Value.ToString("M月d日 HH:mm"):"" %>
                    &nbsp;
                   作者： <%=Model.anthor%>
                </time>
            </p>
        <article class="article">
            <%=Model.context %>
        </article>
    </section>

    <%if (lstHots.Count > 0)
        { %>
    <section class="bg-fff mb-10">
        <div class="mainTitle clearfix bb-1">
            <i class="iconfont icon-hot text-orange-red"></i>
            <b class="text-16">热门文章</b>
        </div>
        <ul class="commenList">
            <%foreach (var info in lstHots)
                { %>
            <li><a data-title="<%=info.title %>" href="/newdetail.aspx?id=<%=info.nid %>"><%=info.title %></a></li>
            <%} %>
        </ul>
    </section>
    <%} %>
</asp:Content>
