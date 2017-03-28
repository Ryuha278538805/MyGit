__CreateJSPath = function(js) {
    var scripts = document.getElementsByTagName("script");
    var path = "";
    for (var i = 0,
        l = scripts.length; i < l; i++) {
        var src = scripts[i].src;
        if (src.indexOf(js) != -1) {
            var ss = src.split(js);
            path = ss[0];
            break;
        }
    }

    return path;
};
//获取资源文件根目录
bootPATH = __CreateJSPath("boot.js");
//f7资源文件引用
f7PATH = bootPATH + "framework7/";

document.write('<link rel="stylesheet" href="' + f7PATH + 'css/framework7.ios.min.css?v=2"/>');
document.write('<link rel="stylesheet" href="' + f7PATH + 'css/framework7.ios.colors.min.css"/>');
document.write('<link rel="stylesheet" href="' + f7PATH + 'css/my-app.css?o=' + Math.random() + '"/>');
document.write('<script type="text/javascript" src="' + f7PATH + 'js/framework7.min.js"></sc' + 'ript>');

//返回系统首页
function goHome(url) {
    location.href = document.getElementById("aBack").getAttribute("backurl");
}