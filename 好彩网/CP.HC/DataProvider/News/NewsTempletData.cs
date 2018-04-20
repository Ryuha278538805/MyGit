using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;


namespace DataProvider
{
    /// <summary>
    /// 资讯模板相类的数据为操作类
    /// 对应表tgl_news_templet
    /// simwon
    /// </summary>
    public class NewsTempletData:DataConnection
    {
        

        /// <summary>
        /// 删除资讯模板
        /// </summary>
        /// <param name="nid"></param>
        public static void DeleteNewsTempletInfo(string tid)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_delete_news_templetinfo", tid);
        }


        /// <summary>
        /// 生成/更新资讯模板
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateNewsTempletInfo(NewsTempletInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstr, "sp_create_news_templetinfo", info.tid, info.title, info.cid, info.zid, info.context, info.anthor,
                                    info.isbest, info.ishot, info.istop, info.color, info.czid));
            return i;
        }

        /// <summary>
        /// 资讯模板翻页页表
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="page"></param>
        /// <param name="cid"></param>
        /// <param name="zid"></param>
        /// <returns></returns>
        public static DataSet GetNewsPageListData(int pagesize, int page, int cid, int zid, int istop)
        {
            return SqlHelper.ExecuteDataset(connstr, "sp_st_templet_list", pagesize, page, cid, zid, istop);
        }

        /// <summary>
        /// 某条资讯模板的内容
        /// </summary>
        /// <param name="nid"></param>
        /// <returns></returns>
        public static DataRow GetNewsTempletInfoData(int tid)
        {
            return SqlHelper.ExecuteDatarow(connstr, "sp_st_news_templetinfo", tid);
        }
    }
}
