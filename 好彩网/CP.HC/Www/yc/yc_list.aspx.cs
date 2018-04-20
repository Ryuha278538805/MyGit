using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Common;
using Business;
using DataProvider;

namespace Www.yc
{
    public partial class yc_list : Pages
    {
        protected int yzid, czid, page, i = 0;
        protected YcZoneInfo yzinfo;
        protected CzInfo czinfo;
        protected string[] YcType = YcUtil.YcType;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                czid = BBRequest.GetQueryInt("czid");
                page = BBRequest.GetQueryInt("page", 1);
                yzid = BBRequest.GetQueryInt("yzid", 0);
            }
            catch { }
            if (page < 1)
                page = 1;
            if (yzid > 0)
            {
                yzinfo = YcZone.GetYcZoneInfo(yzid, true);
                if (yzinfo == null)
                    Response.Redirect("/404.htm");
                else
                {
                    czid = yzinfo.czid;
                    czinfo = Cz.GetCzInfo(czid, true);
                    BinderList();
                    //BinderYcZoneList(czid, yzinfo.type, yclist);
                }
                BinderYcZoneList(1, 1, 4, danmalist);   //预测胆码列表4条    ok
                BinderYcZoneList(1, 3, 4, shamalist);   //预测杀码列表4条    ok
            }
        }

        private void BinderList()
        {
            string where = string.Empty;
            string order = "czid desc";
            if (czid > 0)
            {
                where = "czid =" + czid.ToString();
            }
            if (yzid > 0)
            {
                where = " yzid =" + yzid.ToString();
            }
            order = "yid desc";
            DataSet ds = YcData.GetPageList(AspNetPager1.PageSize, page, "vv_ycinfo", order, where);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.yclist.DataSource = ds.Tables[0];
                yclist.DataBind();
                this.AspNetPager1.RecordCount = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
            }
            else
            {
                this.yclist.DataSource = null;
                yclist.DataBind();
                this.AspNetPager1.RecordCount = 0;
            }

            if (yzid > 0)
            {
                AspNetPager1.UrlRewritePattern = "/dsyc/list_" + yzid.ToString() + "_{0}.html";
            }
            else
            {
                AspNetPager1.UrlRewritePattern = "/dsyc/index_" + yzinfo.type + ".html";
            }
        }


        public string GetPage()
        {
            return page > 1 ? "-第" + page + "页" : "";
        }
    }
}