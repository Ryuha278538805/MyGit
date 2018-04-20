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
    public partial class goods_buy : Pages
    {
        protected int gid;
        protected int sid;
        protected GoodsInfo ginfo = new GoodsInfo();
        protected GoodsSellInfo sinfo = new GoodsSellInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            ChkIsLogin();   //验证是否登录
            sid = BBRequest.GetQueryInt("s");
            gid = BBRequest.GetQueryInt("gid");
            if (sid > 0)
            {
                sinfo = GoodsSell.GetGoodsSellInfo(sid);
                ginfo = Goods.GetGoodsInfo(sinfo.gid);
                ChkIsThisUsersGoods(sinfo, uinfo);
                if (ginfo.needpost && !sinfo.isposted)
                {
                    if (!Page.IsPostBack)
                    {
                        this.postaddress.Text = sinfo.postaddress;
                        this.postname.Text = sinfo.postname;
                        this.postno.Text = sinfo.postno;
                        this.posttel.Text = sinfo.posttel;
                    }
                }
                else
                {
                    Response.Redirect("/goods/my_"+sid+".html");
                }
            }
            else if (gid > 0)
            {
                ginfo = Goods.GetGoodsInfo(gid);
                ChkMoneyEnough(ginfo.payextcredits, uinfo, ginfo.score);   //验证钱够不
                if (ginfo.iseveryday)
                    ChkEveryDay(ginfo.gid, uinfo);   //验证是否被限购
            }
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            int newsid = CreateGoodSellInfo();
            if (newsid > 0)
            {
                if (sid > 0)
                    System.Web.HttpContext.Current.Response.Redirect("/error.aspx?Error=7");
                else
                    System.Web.HttpContext.Current.Response.Redirect("/error.aspx?Error=6");
            }
        }

        protected int CreateGoodSellInfo()
        {
            sinfo.sid = sid;
            if(!(sid>0)) sinfo.gid = gid;
            sinfo.postaddress = this.postaddress.Text.Trim();
            sinfo.postname = this.postname.Text.Trim();
            sinfo.postno = this.postno.Text.Trim();
            sinfo.posttel = this.posttel.Text.Trim();
            sinfo.username = uinfo.username;
            return GoodsSell.CreateGoodsSellInfo(sinfo, ginfo);
        }
    }
}