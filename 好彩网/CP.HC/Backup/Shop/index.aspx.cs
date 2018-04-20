using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Common;
using Model;
using Business;
using DataProvider;

namespace Shop
{
    public partial class index : Pages
    {
        protected int order;
        protected int direct;
        protected int gcid;
        protected int page;
        protected int count;

        protected void Page_Load(object sender, EventArgs e)
        {
            gcid = BBRequest.GetQueryInt("gcid");
            order = BBRequest.GetQueryInt("order");
            direct = BBRequest.GetQueryInt("direct");
            page = BBRequest.GetQueryInt("page",1);
            BinderGoodsClass(goodsclasslist);
            BinderGoods();
        }

        protected void BinderGoods()
        {
            string url = "&gcid=" + gcid + "&order=" + order + "&direct=" + direct;
            string where="", orderstr="";
            if (gcid > 0)
                where += "gcid=" + gcid;
            if (order == 3) orderstr += "addtime ";
            else if (order == 2) orderstr += "countselled ";
            else orderstr += "hits ";
            
            if (direct == 0) orderstr += "asc";
            else orderstr += "desc";

            DataSet ds = GoodsData.GetPageListBbs(this.AspNetPager1.PageSize, page, "tbl_goods", orderstr, where);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                list.DataSource = ds.Tables[0];
                list.DataBind();
                AspNetPager1.RecordCount = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
                AspNetPager2.RecordCount = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
                count = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);      
            }
            else
            {
                list.DataSource = null;
                list.DataBind();
                AspNetPager1.RecordCount = 0;
                AspNetPager2.RecordCount = 0;
                count = 0;
            }
            AspNetPager1.UrlRewritePattern = "/goods/list.html?page={0}" + url;
            AspNetPager2.UrlRewritePattern = "/goods/list.html?page={0}" + url;
        }
    }
}
