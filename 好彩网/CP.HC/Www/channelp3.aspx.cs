using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Model;

namespace Www
{
    public partial class channelp3 : Pages
    {
        protected int i; //页面参数
        protected KjhP3Info info = new KjhP3Info();
        protected void Page_Load(object sender, EventArgs e)
        {
            info = KjhP3.GetKjhP3InfoTop1(true);
            BinderTopKjh(10, 1, (int)KjhCz.Czp3, kjhlist); //绑定开奖号列表
            BinderTopNews(9, 34, 0, topnewslist);   //P3头条
            BinderZoneNews(10, 30, zonelist);   //P3字谜专题
            BinderTopNews(15, 29, 0, yclist);   //P3预测10条
            BinderTopNews(15, 30, 0, zmlist);   //P3字谜10条
            BinderTopNews(6, 41, 0, jqfflist);   //P3技巧方法
            BinderTopNews(6, 43, 0, zjgzlist);   //P3中奖规则
            BinderBBSTopic(bbsp3list, "9,10", 7);            
        }
    }
}