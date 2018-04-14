using HCW.Bussiness;
using HCW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCW.Master
{
    public class NewsClassManager
    {
        /// <summary>
        /// 手机端首页导航
        /// </summary>
        private static IList<tbl_news_classInfo> navs = null;
        public static IList<tbl_news_classInfo> Navs
        {
            get
            {
                if (navs == null)
                {
                    tbl_newsService s = new tbl_newsService();
                    navs = s.M_GetNav();
                }
                return navs;
            }
        }

        /// <summary>
        /// 手机端首页菜单
        /// </summary>
        private static IList<M_MenuModel> menus = null;
        public static IList<M_MenuModel> Menus
        {
            get
            {
                if (menus == null)
                {
                    tbl_newsService s = new tbl_newsService();
                    menus = s.M_GetMenu();
                }
                return menus;
            }
        }
    }
}
