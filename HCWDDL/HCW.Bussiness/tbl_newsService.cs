using HCW.Common;
using HCW.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace HCW.Bussiness
{
    public class tbl_newsService
    {
        private DBHelper dbHelper = new DBHelper(DBHelper.CONN_Main);

        /// <summary>
        /// 获取首页导航列表
        /// </summary>
        /// <returns></returns>
        public IList<tbl_news_classInfo> M_GetNav()
        {
            return dbHelper.GetList<tbl_news_classInfo>("exec up_M_GetNav");
        }

        /// <summary>
        /// 获取首页菜单列表
        /// </summary>
        /// <returns></returns>
        public IList<M_MenuModel> M_GetMenu()
        {
            return dbHelper.GetList<M_MenuModel>("exec up_M_GetMenu");
        }
    }
}
