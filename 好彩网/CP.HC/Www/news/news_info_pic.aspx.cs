using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Business;
using Model;
using DataProvider;
using Common;

namespace Www.news
{
    public partial class news_info_pic : Pages
    {
        private int nid;
        public NewsInfo info, infopre, infonext;        
        public string pre, next;
        public int preid, nextid;

        protected void Page_Load(object sender, EventArgs e)
        {
            nid = BBRequest.GetQueryInt("nid", 0);
            info = News.GetNewsInfo(nid);
            if (info == null || info.nid == 0)
                Response.Redirect("/");
            else
                News.UpdateHits(nid);
            nextid = nid+1;
            preid = nid-1;
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
            infopre = News.GetNewsInfo(nid - 1);
            infonext = News.GetNewsInfo(nid + 1);
            if (infopre.title != null && infopre.title.Length > 0)
                pre = "<a href=\"/" + GetNewsClassInfo(infopre.cid).ename + "/" + Getdir(infopre.addtime) + "/" + infopre.nid + ".html\" title=\"" + infopre.title + "\"  style=\"color:" + infopre.color + "\">" + GetCutString(infopre.title, 40) + "</a>";
            else
                pre = "没有了";
            if (infonext.title != null && infonext.title.Length > 0)
                next = "<a href=\"/" + GetNewsClassInfo(infonext.cid).ename + "/" + Getdir(infonext.addtime) + "/" + infonext.nid + ".html\" title=\"" + infopre.title + "\" style=\"color:" + infonext.color + "\">" + GetCutString(infonext.title, 40) + "</a>";
            else
                next = "没有了";
        }
    }
}