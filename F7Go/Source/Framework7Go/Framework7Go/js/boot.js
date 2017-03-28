__CreateJSPath = function (js) {
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

//弹出消息展示
function showMessage(imgName, msgText, btnText, subText,callBack) {
    if (subText && subText!="") {
        subText = '<div style="width:100%;text-align:center;margin-top:10px;">' + subText + '</div>';
    }
    else {
        subText = "";
    }
    var modal = myApp.modal({
        title: '',
        text: '',
        afterText: '<div style="height:90px;width:100%;text-align:center">'
                    + '<img src="../img/' + imgName + '" style="width:70px;height:70px;" />'
                + '</div>'
        + '<div style="width:100%;text-align:center;margin-top:-10px;font-size:16px">' + msgText + '</div>' + subText,
        buttons: [
          {
              text: btnText,
              onClick: function () {
                  if (callBack)
                  {
                      callBack();
                  }
              }
          }
        ]
    });
    return modal;
}

function goBack(url) {
    location.href = url;
}