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
    public partial class goods : Pages
    {
        protected int gid;
        protected GoodsInfo ginfo = new GoodsInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            gid = BBRequest.GetQueryInt("gid");
            if (gid > 0)
            {
                ginfo = Goods.GetGoodsInfo(gid);                
            }
        }
    }
}