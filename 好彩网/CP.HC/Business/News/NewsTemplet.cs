using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using DataProvider;
using Common;


namespace Business
{
    /// <summary>
    /// 资讯模板
    /// </summary>
    public class NewsTemplet
    {
        /// <summary>
        /// 删除资讯模板
        /// </summary>
        /// <param name="nid"></param>
        public static void DeleteNewsTempletInfo(string tid)
        {
            NewsTempletData.DeleteNewsTempletInfo(tid);
        }


        /// <summary>
        /// 生成/更新资讯模板
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateNewsTempletInfo(NewsTempletInfo info)
        {
            int i = 0;
            i = NewsTempletData.CreateNewsTempletInfo(info);
            return i;
        }

        /// <summary>
        /// 资讯内容模板翻页页表   不包含文章模板内容等详情
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="page"></param>
        /// <param name="cid"></param>
        /// <param name="zid"></param>
        /// <param name="qi"></param>
        /// <returns></returns>
        public static List<NewsTempletInfo> GetNewsTempletPageList(int pagesize, int page, int cid, int zid, int istop, out int count)
        {
            List<NewsTempletInfo> list = new List<NewsTempletInfo>();
            DataSet ds = NewsTempletData.GetNewsPageListData(pagesize, page, cid, zid, istop);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                int rcount = ds.Tables[0].Rows.Count;
                for (int i = 0; i < rcount; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];
                    NewsTempletInfo info = new NewsTempletInfo();
                    info.tid = TypeConverter.ObjectToInt(dr["tid"]);
                    info.title = dr["title"].ToString().Trim();                    
                    list.Add(info);
                }
                count = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
            }
            else
            {
                count = 0;
            }

            return list;
        }

        /// <summary>
        /// 某条信息模板的内容
        /// </summary>
        /// <param name="nid"></param>
        /// <returns></returns>
        public static NewsTempletInfo GetNewsTempletInfo(int nid)
        {
            NewsTempletInfo info = new NewsTempletInfo();
            DataRow dr = NewsTempletData.GetNewsTempletInfoData(nid);
            if (dr != null)
            {
                info.tid = TypeConverter.ObjectToInt(dr["tid"]);
                info.title = dr["title"].ToString().Trim();
                info.cid = TypeConverter.ObjectToInt(dr["cid"]);
                info.zid = TypeConverter.ObjectToInt(dr["zid"]);
                info.czid = TypeConverter.ObjectToInt(dr["czid"]);
                info.anthor = dr["anthor"].ToString().Trim();
                if (dr["color"] != null)
                    info.color = dr["color"].ToString().Trim();
                info.isbest = TypeConverter.ObjectToInt(dr["isbest"]);
                info.ishot = TypeConverter.ObjectToInt(dr["ishot"]);
                info.istop = TypeConverter.ObjectToInt(dr["istop"]);
                info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
                info.updatetime = TypeConverter.ObjectToDateTime(dr["updatetime"]);
                info.context = dr["context"].ToString().Trim();
            }
            return info;
        }
    }
}
