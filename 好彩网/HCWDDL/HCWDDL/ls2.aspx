<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="ls2.aspx.cs" Inherits="HCWDDL.M.ls2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">

    <section class="bg-fff mb-10">
        <div class="mainTitle clearfix bb-1">
            <i class="iconfont icon-123"></i>
            <a><b class="text-16"><%=Request["cn"] %></b></a>
        </div>
        <ul id="ulArea" class="commenList">
        </ul>
    </section>

    <script type="text/javascript">
        var pageSize = 10;
        var pageIndex = 1;
        var zid = "<%=Request["zid"]??"0"%>";
        var cid = "<%=Request["cid"]%>";

        search();
        function search() {
            $.ajax({
                url: "/handler/NewsHandler.ashx", //处理页面的路径
                data: { pagesize: pageSize, pageindex: pageIndex, zid: zid, cid: cid }, //要提交的数据是一个JSON
                type: "POST", //提交方式
                dataType: "json", //返回数据的类型
                success: function (data) { //回调函数 ,成功时返回的数据存在形参data里
                    if (data && data.length > 0) {
                        for (var i = 0; i < data.length; i++) {
                            var row = data[i];
                            $("#ulArea").append('<li><a href="/newdetail.aspx?id=' + row.nid + '">'+row.title+'</a></li>');
                        }
                        if (pageIndex == 1)
                        {
                            //更新每页为5条
                            pageSize = 5;
                        }
                        pageIndex++;
                    }
                }
            });
        }

        $(document).bind("scroll", srcollEvent);
        $(document).bind("touchstart", startEvent).bind("touchmove", moveEvent).bind("touchcancel", stopEvent).bind("touchend", stopEvent);
        var isScrollStop = true;  //页面是否停止滚动 防止屏幕有滑动但还没到底部就开始加载数据
        var isMoveDown = false;  //防止手指向上滑动屏幕开始加载数据
        var isLoading = false;   //防止异步请求数据未返回到前端的时候重复提交请求
        var isMoved = false;   //手指是否在滑动屏幕 防止出现手指触摸屏幕而没有滑动就加载数据
        var startY = 0;
        var startX = 0;
        function srcollEvent() {
            if ($(document).scrollTop() > 0) {
                isScrollStop = false;
            }
        }
        function startEvent() {
            startY = event.targetTouches[0].clientY;
            isScrollStop = true;
            isMoved = false;
            isMoveDown = false;
        }
        function moveEvent() {
            var Y = event.targetTouches[0].clientY;
            if (startY > Y) {
                isMoveDown = true;
            } else {
                isMoveDown = false;
            }
          
            isMoved = true;

        }

        //isScrollStop && isMoved && !isLoading && isMoveDown
        function stopEvent() {
            if (isScrollStop && isMoved && !isLoading && isMoveDown) {
                search();
            }
        }
    </script>
</asp:Content>
