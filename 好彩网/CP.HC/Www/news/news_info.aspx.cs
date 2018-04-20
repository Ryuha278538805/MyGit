using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Text.RegularExpressions;
using Business;
using Model;
using DataProvider;
using Common;

namespace Www.news
{
    public partial class news_info : Pages
    {
        private int nid;
        public NewsInfo info,infopre,infonext;
        protected NewsClassInfo newsclassinfo = new NewsClassInfo();
        protected ZoneInfo zoneinfo = new ZoneInfo();
        public string pre, next;
        public int preid, nextid;
        protected int i = 0;  //页面参数
        protected string qqimgs = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            nid = BBRequest.GetQueryInt("nid", 0);
            info = News.GetNewsInfo(nid);            
            if (info == null || info.nid == 0)
                Response.Redirect("/");
            else
            {
                newsclassinfo = NewsClass.GetNewsClassInfo(info.cid, true);
                if (info.zid > 0)
                    zoneinfo = Zone.GetZoneInfo(info.zid, true);
                News.UpdateHits(nid);
                Regex regex = new Regex(@"src=.[a-zA-z]+://[^\s]*");
                MatchCollection matches = regex.Matches(info.context);
                try
                {
                    for(int i = 0; i<matches.Count; i++)
                    {
                        if (i < matches.Count - 1)
                            qqimgs += matches[i].Groups[0].ToString().Replace("src=", "").Replace("\"", "") + "|";
                        else
                            qqimgs += matches[i].Groups[0].ToString().Replace("src=", "").Replace("\"", "");
                    }
                }
                catch { }

            }
            nextid = nid + 1;
            preid = nid - 1;
            while (true)
            {
                infopre = News.GetNewsInfo(preid--);
                if (infopre.cid == info.cid || infopre.title == null || infopre.title.Length == 0)
                    break;
            }
            while (true)
            {
                infonext = News.GetNewsInfo(nextid++);
                if (infonext.cid == info.cid || infonext.title == null || infonext.title.Length == 0)
                    break;
            }

            if (infopre.title != null && infopre.title.Length > 0)
                pre = "<a href=\"/" + GetNewsClassInfo(infopre.cid).ename + "/" + Getdir(infopre.addtime) + "/" + infopre.nid + ".html\" title=\"" + infopre.title + "\"  style=\"color:" + infopre.color + "\">" + GetCutString(infopre.title, 26) + "</a>";
            else
                pre = "没有了";
            if (infonext.title != null && infonext.title.Length > 0)
                next = "<a href=\"/" + GetNewsClassInfo(infonext.cid).ename + "/" + Getdir(infonext.addtime) + "/" + infonext.nid + ".html\" title=\"" + infopre.title + "\" style=\"color:" + infonext.color + "\">" + GetCutString(infonext.title, 26) + "</a>";
             else
                next = "没有了";
          
            BinderZoneList(xgzonelist, newsclassinfo.cid, 12);  //相关专题
            BinderTopNews(20, info.cid, 0, xglist);   //相关文章
            BinderYcZoneList(1, 1, 4, danmalist);   //预测胆码列表4条    ok
        }
    }
}