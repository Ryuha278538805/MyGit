using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    /// 商品相类的数据为操作类
    /// 对应表tgl_goods
    /// simwon
    /// </summary>
    public class NewsData:DataConnection
    {

        /// <summary>
        /// 群置顶/取消置顶
        /// </summary>
        /// <param name="nids"></param>
        /// <param name="istop">=0时，取消置顶/=1时，置顶</param>
        public static void UpdateMoreIstop(string nids, int istop)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_newstop", nids, istop);
        }
        
        /// <summary>
        /// 更新文章点击
        /// </summary>
        /// <param name="nid"></param>
        public static void UpdateHits(int nid)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_newshits", nid);
        }

        /// <summary>
        /// 删除资讯内容
        /// </summary>
        /// <param name="nid"></param>
        public static void DeleteNewsInfo(string nid)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_delete_newsinfo", nid);
        }


        /// <summary>
        /// 生成/更新资讯信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateNewsInfo(NewsInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstr, "sp_create_newsinfo", info.nid, info.title, info.cid, info.zid, info.context, info.anthor,
                                    info.isbest, info.ishot, info.istop, info.uid, info.username, info.color,info.czid,info.qi));
            return i;
        }

        /// <summary>
        /// 按分类,专题列表
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="cid"></param>
        /// <param name="zid"></param>
        /// <returns></returns>
        public static DataTable GetNewsListData(int pagesize, int cid, int zid)
        {
             return SqlHelper.ExecuteDatatable(connstr, "sp_st_newslist", pagesize, cid, zid);
        }

        /// <summary>
        /// 获取某条新闻前N条新闻
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="nid"></param>
        /// <returns></returns>
        public static DataTable GetNewsPreListData(int pagesize, int nid)
        {
            return SqlHelper.ExecuteDatatable(connstr, "sp_st_newslist_pre", pagesize, nid);
        }
        
        /// <summary>
        /// 资讯内容翻页页表
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="page"></param>
        /// <param name="cid"></param>
        /// <param name="zid"></param>
        /// <returns></returns>
        public static DataSet GetNewsPageListData(int pagesize, int page, int cid, int zid, int istop,int qi)
        {
            return SqlHelper.ExecuteDataset(connstr, "sp_st_page_list", pagesize, page, cid, zid, istop, qi);
        }

        /// <summary>
        /// 取某条专题的最新数据..
        /// </summary>
        /// <param name="zid"></param>
        /// <returns></returns>
        public static DataRow GetNewsInfoByZidData(int zid)
        {
            return SqlHelper.ExecuteDatarow(connstr, "sp_st_newsinfo_zid", zid);
        }

        /// <summary>
        /// 某条信息的内容
        /// </summary>
        /// <param name="nid"></param>
        /// <returns></returns>
        public static DataRow GetNewsInfoData(int nid)
        {
            return SqlHelper.ExecuteDatarow(connstr, "sp_st_newsinfo", nid);
        }

        /// <summary>
        /// 新闻内容
        /// </summary>
        /// <param name="nid"></param>
        /// <returns></returns>
        public static DataRow GetNewsUIData(int uiid)
        {
            return SqlHelper.ExecuteDatarow(connstr, "sp_st_newsui");
        }

        /// <summary>
        /// 更新新闻状态
        /// </summary>
        /// <param name="nid"></param>
        public static void UpdateNewsUi(int lk)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_newsui", lk);
        }
    }
}
