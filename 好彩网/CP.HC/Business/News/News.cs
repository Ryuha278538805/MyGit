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
    /// 商品事务处理类
    /// simwon
    /// </summary>
    public class News
    {

        /// <summary>
        /// 群置顶/取消置顶
        /// </summary>
        /// <param name="nids"></param>
        /// <param name="istop">=0时，取消置顶/=1时，置顶</param>
        public static void UpdateMoreIstop(string nids, int istop)
        {
            NewsData.UpdateMoreIstop(nids, istop);
        }


        /// <summary>
        /// 更新文章点击
        /// </summary>
        /// <param name="nid"></param>
        public static void UpdateHits(int nid)
        {
            NewsData.UpdateHits(nid);
        }

        /// <summary>
        /// 删除资讯内容
        /// </summary>
        /// <param name="nid"></param>
        public static void DeleteNewsInfo(string nid)
        {
            NewsData.DeleteNewsInfo(nid);
        }


        /// <summary>
        /// 生成/更新资讯信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateNewsInfo(NewsInfo info)
        {
            int i = 0;
            i = NewsData.CreateNewsInfo(info);
            return i;
        }

        /// <summary>
        /// 按专题列表
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="zid"></param>
        /// <returns></returns>
        /// 
        public static List<NewsInfo> GetNewsListByZid(int pagesize, int zid)
        {
            return GetNewsList(pagesize, 0, zid);
        }


        /// <summary>
        /// 按分类列表
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="cid"></param>
        /// <returns></returns>
        public static List<NewsInfo> GetNewsListByCid(int pagesize, int cid)
        {
            return GetNewsList(pagesize, cid, 0);
        }

        /// <summary>
        /// 按分类,专题列表
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="cid"></param>
        /// <param name="zid"></param>
        /// <returns></returns>
        public static List<NewsInfo> GetNewsList(int pagesize, int cid, int zid)
        {
            List<NewsInfo> list = new List<NewsInfo>();
            DataTable dt = NewsData.GetNewsListData(pagesize, cid, zid);
            if (dt != null)
            {
                int rcount = dt.Rows.Count;
                for (int i = 0; i < rcount; i++)
                {
                    DataRow dr = dt.Rows[i];
                    NewsInfo info = new NewsInfo();
                    info.nid = TypeConverter.ObjectToInt(dr["nid"]);
                    info.title = dr["title"].ToString().Trim();
                    info.cid = TypeConverter.ObjectToInt(dr["cid"]);
                    info.zid = TypeConverter.ObjectToInt(dr["zid"]);
                    info.czid = TypeConverter.ObjectToInt(dr["czid"]);
                    info.qi = TypeConverter.ObjectToInt(dr["qi"]);
                    info.anthor = dr["anthor"].ToString().Trim();
                    if (dr["color"] != null)
                        info.color = dr["color"].ToString().Trim();
                    info.isbest = TypeConverter.ObjectToInt(dr["isbest"]);
                    info.ishot = TypeConverter.ObjectToInt(dr["ishot"]);
                    info.istop = TypeConverter.ObjectToInt(dr["istop"]);
                    info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
                    info.updatetime = TypeConverter.ObjectToDateTime(dr["updatetime"]);
                    list.Add(info);
                }
            }

            return list;
        }

        /// <summary>
        /// 获取某条新闻前N条新闻
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="nid"></param>
        /// <returns></returns>
        public static List<NewsInfo> GetNewsPreList(int pagesize, int nid)
        {
            List<NewsInfo> list = new List<NewsInfo>();
            DataTable dt = NewsData.GetNewsPreListData(pagesize, nid);
            if (dt != null)
            {
                int rcount = dt.Rows.Count;
                for (int i = 0; i < rcount; i++)
                {
                    DataRow dr = dt.Rows[i];
                    NewsInfo info = new NewsInfo();
                    info.nid = TypeConverter.ObjectToInt(dr["nid"]);
                    info.title = dr["title"].ToString().Trim();
                    info.cid = TypeConverter.ObjectToInt(dr["cid"]);
                    info.zid = TypeConverter.ObjectToInt(dr["zid"]);
                    info.czid = TypeConverter.ObjectToInt(dr["czid"]);
                    info.qi = TypeConverter.ObjectToInt(dr["qi"]);
                    info.anthor = dr["anthor"].ToString().Trim();
                    if (dr["color"] != null)
                        info.color = dr["color"].ToString().Trim();
                    info.isbest = TypeConverter.ObjectToInt(dr["isbest"]);
                    info.ishot = TypeConverter.ObjectToInt(dr["ishot"]);
                    info.istop = TypeConverter.ObjectToInt(dr["istop"]);
                    info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
                    info.updatetime = TypeConverter.ObjectToDateTime(dr["updatetime"]);
                    list.Add(info);
                }
            }

            return list;
        }

        /// <summary>
        /// 资讯内容翻页页表   不包含文章内容等详情
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="page"></param>
        /// <param name="cid"></param>
        /// <param name="zid"></param>
        /// <param name="qi"></param>
        /// <returns></returns>
        public static List<NewsInfo> GetNewsPageList(int pagesize, int page, int cid, int zid, int istop, out int count, int qi)
        {
            List<NewsInfo> list = new List<NewsInfo>();
            DataSet ds = NewsData.GetNewsPageListData(pagesize, page, cid, zid, istop, qi);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                int rcount = ds.Tables[0].Rows.Count;
                for (int i = 0; i < rcount; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];
                    NewsInfo info = new NewsInfo();
                    info.nid = TypeConverter.ObjectToInt(dr["nid"]);
                    info.title = dr["title"].ToString().Trim();
                    info.cid = TypeConverter.ObjectToInt(dr["cid"]);
                    info.zid = TypeConverter.ObjectToInt(dr["zid"]);
                    info.czid = TypeConverter.ObjectToInt(dr["czid"]);
                    info.qi = TypeConverter.ObjectToInt(dr["qi"]);
                    info.anthor = dr["anthor"].ToString().Trim();
                    if (dr["color"] != null)
                        info.color = dr["color"].ToString().Trim();
                    info.isbest = TypeConverter.ObjectToInt(dr["isbest"]);
                    info.ishot = TypeConverter.ObjectToInt(dr["ishot"]);
                    info.istop = TypeConverter.ObjectToInt(dr["istop"]);
                    info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
                    info.updatetime = TypeConverter.ObjectToDateTime(dr["updatetime"]);
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
        /// 取某条专题的最新数据..
        /// </summary>
        /// <param name="zid"></param>
        /// <returns></returns>
        public static NewsInfo GetNewsInfoByZid(int zid)
        {
            NewsInfo info = new NewsInfo();
            DataRow dr = NewsData.GetNewsInfoByZidData(zid);
            if (dr != null)
            {
                info.nid = TypeConverter.ObjectToInt(dr["nid"]);
                info.title = dr["title"].ToString().Trim();
                info.cid = TypeConverter.ObjectToInt(dr["cid"]);
                info.zid = TypeConverter.ObjectToInt(dr["zid"]);
                info.czid = TypeConverter.ObjectToInt(dr["czid"]);
                info.qi = TypeConverter.ObjectToInt(dr["qi"]);
                info.anthor = dr["anthor"].ToString().Trim();
                if (dr["color"] != null)
                    info.color = dr["color"].ToString().Trim();
                info.isbest = TypeConverter.ObjectToInt(dr["isbest"]);
                info.ishot = TypeConverter.ObjectToInt(dr["ishot"]);
                info.istop = TypeConverter.ObjectToInt(dr["istop"]);
                info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
                info.updatetime = TypeConverter.ObjectToDateTime(dr["updatetime"]);
            }
            return info;
        }

        /// <summary>
        /// 某条信息的内容
        /// </summary>
        /// <param name="nid"></param>
        /// <returns></returns>
        public static NewsInfo GetNewsInfo(int nid)
        {
            NewsInfo info = new NewsInfo();
            DataRow dr = NewsData.GetNewsInfoData(nid);
            if (dr != null)
            {
                info.nid = TypeConverter.ObjectToInt(dr["nid"]);
                info.title = dr["title"].ToString().Trim();
                info.cid = TypeConverter.ObjectToInt(dr["cid"]);
                info.zid = TypeConverter.ObjectToInt(dr["zid"]);
                info.czid = TypeConverter.ObjectToInt(dr["czid"]);
                info.qi = TypeConverter.ObjectToInt(dr["qi"]);
                info.anthor = dr["anthor"].ToString().Trim();
                if (dr["color"] != null)
                    info.color = dr["color"].ToString().Trim();
                info.isbest = TypeConverter.ObjectToInt(dr["isbest"]);
                info.ishot = TypeConverter.ObjectToInt(dr["ishot"]);
                info.istop = TypeConverter.ObjectToInt(dr["istop"]);
                info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
                info.updatetime = TypeConverter.ObjectToDateTime(dr["updatetime"]);

                info.context = dr["context"].ToString().Trim();
                info.hits = TypeConverter.ObjectToInt(dr["hits"]);
                info.username = dr["username"].ToString().Trim();
                info.uid = TypeConverter.ObjectToInt(dr["uid"]);
            }
            return info;
        }

         /// <summary>
        /// 新闻内容
        /// </summary>
        /// <param name="nid"></param>
        /// <returns></returns>
        public static int GetNewsUI()
        {
            int newsui = 0;
            DataRow dr = NewsData.GetNewsUIData(1);
            string key = CacheKeys.NEWSUI;
            if (CacheUtil.IsExist(key))
            {
                newsui = (int)CacheUtil.Read(key);
            }
            else
            {
                newsui = TypeConverter.ObjectToInt(dr["lk"]);
                if (newsui == 0)
                    CacheUtil.Insert(key, newsui, (double)CacheMin.Nih);
                else
                    CacheUtil.Insert(key, newsui, (double)CacheMin.Twt);
            }
            return newsui;
        }        
    }

    public class Config
    {
        public const string domain = "haocw.com";
        public const string developer = "sam@32yx.com";
        public const string cmsname = "CPCMS Ver 2.0 for " + domain;
        public const string sitename = "CPCMSV2";
    }
}
