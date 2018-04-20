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
    public partial class goodssell_my : Pages
    {
        protected int sid;
        protected GoodsInfo ginfo = new GoodsInfo();
        protected GoodsSellInfo sinfo = new GoodsSellInfo();

        protected void Page_Load(object sender, EventArgs e)
        {
            ChkIsLogin();   //验证是否登录
            sid = BBRequest.GetQueryInt("sid");
            if (sid > 0)
            {
                sinfo = GoodsSell.GetGoodsSellInfo(sid);
                ginfo = Goods.GetGoodsInfo(sinfo.gid);
                ChkIsThisUsersGoods(sinfo, uinfo);
            }
        }       
    }
}