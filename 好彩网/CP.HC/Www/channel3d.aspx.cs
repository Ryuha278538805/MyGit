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
    public partial class part3d : Pages
    {
        protected int i; //页面参数
        protected Kjh3dInfo info = new Kjh3dInfo();
        protected Kjh3dInfo infonew = new Kjh3dInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            //把最新的值赋予显示的值
            if (infonew.tzmoney != null && infonew.tzmoney.Length > 0) info = infonew;
            infonew = Kjh3d.GetKjh3dInfoTop1(0, true);
            info = Kjh3d.GetKjh3dInfoTop1(1, true);
            BinderTopKjh(10, 1, (int)KjhCz.Cz3d, kjhlist); //绑定开奖号列表
            BinderTopNews(9, 33, 0, topnewslist);   //3D头条
            BinderZoneNews(10, 26, zonelist);   //3D汇总专题
            BinderTopNews(15, 27, 0, yclist);   //3D预测8条
            BinderTopNews(15, 28, 0, zmlist);   //3D字谜8条
            BinderTopNews(6, 40, 0, jqfflist);   //3D技巧方法
            BinderTopNews(6, 43, 0, zjgzlist);   //3D中奖规则

            BinderBBSTopic(this.bbssdlist, "2,3,4", 7);   //顶部3D论坛
           
        }
    }
}