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
    public partial class channelssq : Pages
    {
        protected int i; //页面参数
        protected KjhSsqInfo info = new KjhSsqInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            info = KjhSsq.GetKjhSsqInfoTop1(true);
            BinderTopKjh(10, 1, (int)KjhCz.Czssq, kjhlist); //绑定开奖号列表
            BinderTopNews(9, 35, 0, topnewslist);   //双色球头条
            BinderZoneNews(10, 32, zonelist);   //双色球汇总专题
            BinderTopNews(15, 31, 0, yclist);   //双色球预测8条
            BinderTopNews(15, 32, 0, zmlist);   //双色球字谜8条
            BinderTopNews(6, 42, 0, jqfflist);   //双色球技巧方法
            BinderTopNews(6, 43, 0, zjgzlist);   //双色球中奖规则
            BinderBBSTopic(this.bbsssqlist, "7,8", 7); 
        }
    }
}