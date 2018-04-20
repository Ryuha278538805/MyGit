using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Model;
using DataProvider;
using Common;

namespace Www.yc
{
    public partial class yc_info : Pages
    {
        private int yid;
        public YcInfo info, infopre, infonext;
        protected YcZoneInfo yzinfo = new YcZoneInfo();
        protected CzInfo czinfo = new CzInfo();
        public string pre, next;
        public int preid, nextid;
        protected int i = 0;  //页面参数
        protected string cz = "", bbsroot = "", yctype = "";
        protected Kjh3dInfo kjh3d = new Kjh3dInfo();
        protected Kjh3dInfo kjh3dtop1 = new Kjh3dInfo();
        protected KjhP3Info kjhp3 = new KjhP3Info();
        protected KjhSsqInfo kjhssq = new KjhSsqInfo();
        protected bool KjhIsNowQi = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            yid = BBRequest.GetQueryInt("yid", 0);
            info = Yc.GetYcInfoByYID(yid);            
            if (info == null || info.yid == 0)
                Response.Redirect("/404.aspx");
            else
            {
                yzinfo = YcZone.GetYcZoneInfo(info.yzid, true);
                yctype = YcUtil.GetYcTypeName(yzinfo.type);
                if (yzinfo.czid > 0)
                    czinfo = Cz.GetCzInfo(yzinfo.czid, true);
                Yc.UpdateYcInfoHits(yid.ToString());
            }
            nextid = yid + 1;
            preid = yid - 1;
            while (true)
            {
                infopre = Yc.GetYcInfoByYID(preid--);
                if (infopre.yzid == info.yzid || infopre.title == null || infopre.title.Length == 0)
                    break;
            }
            while (true)
            {
                infonext = Yc.GetYcInfoByYID(nextid++);
                if (infonext.yzid == info.yzid || infonext.title == null || infonext.title.Length == 0)
                    break;
            }

            if (infopre.title != null && infopre.title.Length > 0)
                pre = "<a href=\"/dsyc/" + Getdir(infopre.addtime) + "/" + infopre.yid + ".html\" title=\"" + infopre.title + "\">" + GetCutString(infopre.title, 26) + "</a>";
            else
                pre = "没有了";
            if (infonext.title != null && infonext.title.Length > 0)
                next = "<a href=\"/dsyc/" + Getdir(infonext.addtime) + "/" + infonext.yid + ".html\" title=\"" + infopre.title + "\">" + GetCutString(infonext.title, 26) + "</a>";
            else
                next = "没有了";

            BinderYcInfoTop15(yid, historylist);
            BinderYcZoneList(1, 1, 4, danmalist);   //预测胆码列表4条    ok
            BinderTopNews(20, 7, 0, xglist);   //图迷文章
           // BinderXgYcInfo(czinfo.czid, yzinfo.type, 0, 8, this.xglist);   //相关预测
          //  BinderXgYcInfo(czinfo.czid, 0, 0, 30, this.zxlist);   //最新预测
            if (info.qi == czinfo.qi) { KjhIsNowQi = true; }
        }
    }
}