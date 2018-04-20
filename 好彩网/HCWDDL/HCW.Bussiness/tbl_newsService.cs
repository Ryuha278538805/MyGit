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

        /// <summary>
        /// 获取首页信息类
        /// </summary>
        /// <returns></returns>
        public IList<tbl_news_Model> M_GetIndexNews()
        {
            return dbHelper.GetList<tbl_news_Model>("exec up_M_GetIndexNews");
        }


        /// <summary>
        /// 获取新闻详情
        /// </summary>
        /// <returns></returns>
        public tbl_news_Model M_GetNewsDetail(int id)
        {
            string sql = @"SELECT  n.*,ex.context FROM dbo.tbl_news n
                            LEFT JOIN dbo.tbl_news_ex ex ON n.nid = ex.nid
                            WHERE n.nid={0}";
            return dbHelper.GetEntity<tbl_news_Model>(string.Format(sql, id));
        }

        /// <summary>
        /// 获取分类下的热文章
        /// </summary>
        /// <returns></returns>
        public IList<tbl_news_Model> M_GetHots(int cid)
        {
            return dbHelper.GetList<tbl_news_Model>("exec up_M_GetHots " + cid.ToString());
        }

        /// <summary>
        /// 获取广告
        /// </summary>
        /// <param name="top">条数</param>
        /// <param name="source">来源：0：手机，1：PC</param>
        /// <returns></returns>
        public IList<tbl_ADmanagerInfo> M_GetADs(int top, int source)
        {
            return dbHelper.GetList<tbl_ADmanagerInfo>("exec up_M_GetADs " + top.ToString() + " ," + source.ToString());
        }

        /// <summary>
        /// 获取新闻列表数据
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="cid"></param>
        /// <param name="zid"></param>
        /// <param name="istop"></param>
        /// <param name="qi"></param>
        /// <returns></returns>
        public IList<tbl_news_Model> M_GetNewsList(int pageSize, int pageIndex, int cid, int zid, int istop = 0, int qi = 0)
        {
            string sql = "exec sp_st_page_list {0},{1},{2},{3},{4},{5}";
            sql = string.Format(sql, pageSize, pageIndex, cid, zid, istop, qi);
            return dbHelper.GetList<tbl_news_Model>(sql);
        }
    }
}
