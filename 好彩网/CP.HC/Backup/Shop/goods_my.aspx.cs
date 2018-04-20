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
    public partial class goods_my : Pages
    {
        protected int gid;
        protected GoodsInfo ginfo = new GoodsInfo();

        protected void Page_Load(object sender, EventArgs e)
        {
            ChkIsLogin();   //验证是否登录
            BinderList();
        }

        protected void BinderList()
        {
            List<GoodsSellInfo> gslist = GoodsSell.GetUserGoodsSellList(uinfo.username);
            if (gslist.Count>0)
            {
                list.DataSource = gslist;
                list.DataBind();
            }
            else
            {
                list.DataSource = null;
                list.DataBind();
            }
        }        
    }
}