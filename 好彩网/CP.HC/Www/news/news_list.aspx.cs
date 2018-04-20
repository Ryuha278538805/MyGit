using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using Business;
using Model;
using DataProvider;
using Common;
using System.Text.RegularExpressions;

namespace Www.news
{
    public partial class news_list : Pages
    {
        public int count = 0, zonecount =0;
        public int cid=0, zid=0, i=0;
        private string ename;
        protected NewsClassInfo newsclassinfo = new NewsClassInfo();
        protected ZoneInfo zoneinfo = new ZoneInfo();
        int page;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ename = BBRequest.GetQueryString("ename");
                page = BBRequest.GetQueryInt("page", 1);
                zid = BBRequest.GetQueryInt("zid", 0);
            }
            catch{}
            if (page < 1)
                page = 1;
            if (!string.IsNullOrEmpty(ename))
            {
                cid = NewsClass.GetNewsClassInfo(ename, true).cid;
            }
            if (cid > 0)
            {  
                newsclassinfo = NewsClass.GetNewsClassInfo(cid, true);
                if (zid>0)
                {
                    zoneinfo = Zone.GetZoneInfo(zid, true);
                }
                binderList();
                BinderYcZoneList(1, 1, 4, danmalist);   //预测胆码列表4条    ok
                BinderYcZoneList(1, 3, 4, shamalist);   //预测杀码列表4条    ok
            }
            else
                Response.Redirect("/");
        }

        private void binderList()
        {          
            DataSet ds = NewsData.GetNewsPageListData(AspNetPager1.PageSize, page, cid, zid, 0, 0);
            List<ZoneInfo> zlist = Zone.GetZoneListByCid(cid, true);
            zonecount = zlist.Count;
            if (zlist != null && zlist.Count > 0)
            {
                if (zlist.Count > 28)
                    zlist.RemoveRange(28, zlist.Count - 28);
                zonelist.DataSource = zlist;
                zonelist.DataBind();
            }
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                count = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
                this.list.DataSource = ds;
                list.DataBind();
                this.AspNetPager1.RecordCount = count;          
                if (zid > 0)
                {
                    AspNetPager1.UrlRewritePattern = "/" + ename + "/list_" + zid.ToString() + "_{0}.html";
                }
                else
                {
                    AspNetPager1.UrlRewritePattern = "/" + ename + "/list_{0}.html";
                }
            }
        }

        public string GetPage()
        {
            return page > 1 ? "-第" + page + "页" : "";
        }

        protected string GetIsZone(object zid, int now)
        {
            if (TypeConverter.ObjectToInt(zid) == now)
                return  " on";
            else
                return "";
        }
    }
}