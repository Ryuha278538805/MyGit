using HCW.Bussiness;
using HCW.Common;
using HCW.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace HCW.Master
{
    public class NewsClassManager
    {
        private static tbl_newsService s = new tbl_newsService();
        private static int timespan = Int32.Parse(ConfigurationManager.AppSettings["cache_news"]);

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
                    menus = s.M_GetMenu();
                }
                return menus;
            }
        }

        /// <summary>
        /// 手机端首页新闻类
        /// </summary>
        private static string cacheindexnews = "cacheindexnews";
        public static IList<tbl_news_Model> IndexNews
        {
            get
            {
                IList<tbl_news_Model> lst = CacheHelper.GetCache<IList<tbl_news_Model>>(cacheindexnews);
                if (lst == null)
                {
                    lst = s.M_GetIndexNews();
                    CacheHelper.SetCache(cacheindexnews, lst, DateTime.Now.AddMinutes(timespan), new TimeSpan());
                }
                return lst;
            }
        }

        /// <summary>
        /// 手机端广告
        /// </summary>
        private static IList<tbl_ADmanagerInfo> adsM = null;
        public static IList<tbl_ADmanagerInfo> ADsM
        {
            get
            {
                if (adsM == null)
                {
                    adsM = s.M_GetADs(6, 0);
                }
                return adsM;
            }
        }
    }
}
