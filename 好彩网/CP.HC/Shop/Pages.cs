using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Business;
using Model;
using DataProvider;
using Common;
using System.Text.RegularExpressions;

namespace Shop
{
    public class Pages : System.Web.UI.Page
    {
        public string username;
        public int uid;
        public UserInfo uinfo;         
        protected string[] PayMethod = {"威望","金钱","彩贝"};
        public string[] errormsg = {"",
                                    "您还没有登录",
                                   "您的威望不足",
                                   "您的金钱不足",
                                   "您的彩贝不足",
                                   "您今天已经购买过此商品，不能再次购买，请24小时后再试",
                                   "恭喜您，购买成功，3秒后前往查看",
                                   "修改收获地址成功，3秒后前往查看"
                                   };

        public Pages()
        {
            uid = TypeConverter.ObjectToInt(CookieUtil.GetCookie("dnt", "userid"), 0);
            if (uid > 0)
                uinfo = Users.GetUserInfo(uid);
        }

        /// <summary>
        /// 绑定商品分类列表
        /// </summary>
        public void BinderGoodsClass(Repeater relist)
        {
            List<GoodsClassInfo> list = GoodsClass.GetGoodsClassList(true);
            if (list != null && list.Count > 0)
            {
                relist.DataSource = list;
                relist.DataBind();
            }
        }

        #region 检查是否已登陆
        /// <summary>
        /// 验证是否登录 未登录跳转到错误页
        /// </summary>
        public static void ChkIsLogin()
        {
            int uid = TypeConverter.ObjectToInt(CookieUtil.GetCookie("dnt", "userid"), 0);
            if (uid == 0)
            {
                System.Web.HttpContext.Current.Response.Redirect("/error.aspx?Error=1");
            }
        }
        #endregion


        #region ASPX方法
        public string GetCutString(string str, int len)
        {
            return Utils.GetCutString(str, len);
        }

        public string GetGcName(object gcid)
        {
            return GoodsClass.GetGoodsClassInfo(TypeConverter.ObjectToInt(gcid),true).name;
        }

        public string GetAutoPost(object isautopost)
        {
            if (TypeConverter.ObjectToBool(isautopost))
                return "自动发货";
            else
                return "人工发货";
        }

        public string GetIsEveryday(object iseveryday)
        {
            if (TypeConverter.ObjectToBool(iseveryday))
                return "每人每天限购一次";
            else
                return "无限制";
        }

        public string GetShowAddress(object needpost)
        {
            if (TypeConverter.ObjectToBool(needpost))
                return "";
            else
                return "none";
        }


        public int GetNowNum(object all, object selled)
        {
            return TypeConverter.ObjectToInt(all) - TypeConverter.ObjectToInt(selled);
        }

        public string GetGcNamebyGid(object gid)
        {
            return GoodsClass.GetGoodsClassInfo(Goods.GetGoodsInfo(TypeConverter.ObjectToInt(gid)).gcid, true).name;
        }

        public string GetGName(object gid)
        {
            return Goods.GetGoodsInfo(TypeConverter.ObjectToInt(gid)).gname;
        }

        public string GetIsPostString(object isposted)
        {
            if (TypeConverter.ObjectToBool(isposted))
                return "已发货";
            else
                return "暂未发货";
        }

        public string GetCurrentClass(int gcid, object now)
        {
            if (TypeConverter.ObjectToInt(now) == gcid)
                return " class=\"current\"";
            else
                return "";
        }

        public string GetPayMethod(object method)
        {
            if (TypeConverter.ObjectToInt(method) >= 1)
                return PayMethod[TypeConverter.ObjectToInt(method) - 1];
            else
                return "";
        }

        public string PicChangeSmallUrl(object picurl)
        {
            return picurl.ToString().Substring(0, 47) + "small_" + picurl.ToString().Substring(47);
        }

        protected string GetChangeAddress(object gid, object sid, object isposted)
        {
            string result = "";
            GoodsInfo ginfo = Goods.GetGoodsInfo(TypeConverter.ObjectToInt(gid));
            if (ginfo.needpost && !TypeConverter.ObjectToBool(isposted))
                result = "<a href=\"/goods_bay.aspx?s=" + TypeConverter.ObjectToInt(sid) + "\">修改收货地址</a>";
            return result;
        }

        /// <summary>
        /// 检查金钱是否足够
        /// </summary>
        /// <param name="paymethod"></param>
        /// <param name="uinfo"></param>
        /// <param name="price"></param>
        public void ChkMoneyEnough(int paymethod, UserInfo uinfo, int price)
        {
            int money = 0;
            if (paymethod == 1) money = uinfo.extcredits1;
            if (paymethod == 2) money = uinfo.extcredits2;
            if (paymethod == 3) money = uinfo.extcredits3;
            if (paymethod == 4) money = uinfo.extcredits4;
            if (paymethod == 5) money = uinfo.extcredits5;
            if (paymethod == 6) money = uinfo.extcredits6;
            if (paymethod == 7) money = uinfo.extcredits7;
            if (paymethod == 8) money = uinfo.extcredits8;

            if (money < price)
            {
                System.Web.HttpContext.Current.Response.Redirect("/error.aspx?error=" + (paymethod+1).ToString());
            }
        }

       /// <summary>
       /// 检查是否被限购
       /// </summary>
       /// <param name="gid"></param>
       /// <param name="uinfo"></param>
        public void ChkEveryDay(int gid, UserInfo uinfo)
        {
            GoodsSellInfo sinfo = GoodsSell.GetGoodsSellInfo(gid, uinfo.username);
            TimeSpan ts = DateTime.Now - sinfo.addtime;
            if (ts.TotalDays < 1)
            {
                System.Web.HttpContext.Current.Response.Redirect("/error.aspx?Error=5");
            }
        }
        
        /// <summary>
       /// 检查是否是本人购买的商品
       /// </summary>
       /// <param name="gid"></param>
       /// <param name="uinfo"></param>
        public void ChkIsThisUsersGoods(GoodsSellInfo sinfo, UserInfo uinfo)
        {
            if (sinfo.username != uinfo.username)
            {
                System.Web.HttpContext.Current.Response.Redirect("/");
            }
        }
        #endregion
    }
}