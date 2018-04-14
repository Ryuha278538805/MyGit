$(function () {
   
    //回到顶部
    $('.iconfont.icon-fanhuidingbu').addClass('show');
    $('.iconfont.icon-fanhuidingbu').click(function () {
        goTop();
    });
    /*
    document.body.onscroll = function () {
        var h = document.body.scrollTop;
        if (h > 100) {
            $('.iconfont.icon-fanhuidingbu').addClass('show');
            
        } else {
            $('.iconfont.icon-fanhuidingbu').removeClass('show');
        }
    }*/
    //右侧边栏显示
    $(".hamburger").click(function () {
        $('#right-sidebar').addClass('show');
       // document.body.addEventListener("touchmove", event_f, false);
       // $('#right-sidebar').unbind('touchmove');
    });
    var event_f = function (e) { e.preventDefault(); }  
    $('#right-sidebar').click(function () {
        hideMore();
    })
    $('.sidebar').click(function (event) {
        event.stopPropagation();
    })
    //开奖切换记录
    if (localStorage.kjIndex) {
        var i = Number(localStorage.kjIndex);
        $('.tabControl').find('.con').eq(i).addClass('active').siblings().removeClass('active');
        $('.tabContainer').find('.con').eq(i).addClass("active").siblings().removeClass("active");
    } else {
        $('.tabControl').find('.con').eq(0).addClass('active').siblings().removeClass('active');
        $('.tabContainer').find('.con').eq(0).addClass("active").siblings().removeClass("active");
    }
    $('.tabControl').find('.con').click(function () {
        var i = $(this).index();
        localStorage.kjIndex = i;
        $(this).addClass("active").siblings().removeClass("active");
        $('.tabContainer').find('.con').eq(i).addClass("active").siblings().removeClass("active");
    });
    $('.moreQi').click(function () {
        $(this).removeClass('show');
    })
    $('.qi').click(function () {
        $('.moreQi').addClass('show');
    })
})


function hideMore() {
    $('#right-sidebar').removeClass('show');
    $('body').css('overflow-y', 'scroll');
}
function goTop() {
    document.body.scrollTop = 0;
}

//广告
function GetMini(url,type) {
	$.ajax({
		type: "POST",
		url: url +"?type="+type,
		data: "",
		cache: true,
		dataType: "json",
		success: function (data) {
			var str = Base64.decode(data);
			$("#Adcert-" + type).html(str);
		},
		error: function (data) {
			var a = data;
		}
	});
}