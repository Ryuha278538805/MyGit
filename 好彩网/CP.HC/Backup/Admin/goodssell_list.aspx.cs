using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using Common;
using Business;
using Model;
using DataProvider;

namespace Admin
{
    public partial class goodssell_list : Pages
    {
        protected int gid = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowUser)
                AllowMessage("对不起，当前用户无此权限！");
            menus1.clicked = 43;   //左边menu样式选中
            gid = BBRequest.GetQueryInt("gid", 0);
            if (!Page.IsPostBack)
            {
                BinderList();
            }
        }

        private void BinderList()
        {
            string where = string.Empty;
            if (gid > 0)
                where = "gid=" + gid.ToString();
            DataSet ds = GoodsSellData.GetPageListBbs(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "tbl_goods_sell", "sid desc", where);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.list.DataSource = ds.Tables[0];
                list.DataBind();
                this.AspNetPager1.RecordCount = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
            }
            else
            {
                this.list.DataSource = null;
                list.DataBind();
                this.AspNetPager1.RecordCount = 0;
            }
        }

        protected string GetGoodsName(object gid)
        {
            return Goods.GetGoodsInfo(TypeConverter.ObjectToInt(gid)).gname;
        }

        protected bool GetNeedPost(object gid)
        {
            return Goods.GetGoodsInfo(TypeConverter.ObjectToInt(gid)).needpost;
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BinderList();
        }
    }
}