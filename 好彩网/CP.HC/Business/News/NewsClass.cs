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
    /// 新闻分类的业务处理类
    /// simwon
    /// </summary>
    public class NewsClass
    {
        /// <summary>
        /// 所有分类数据
        /// </summary>
        /// <returns></returns>
        public static List<NewsClassInfo> GetNewsClassListData()
        {
            List<NewsClassInfo> list = new List<NewsClassInfo>();
            DataTable dt = NewsClassData.GetNewsClassListData();
            if (dt != null && dt.Rows.Count > 0)
            {
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    NewsClassInfo info = new NewsClassInfo();
                    info.cid = TypeConverter.ObjectToInt(dr["cid"]);
                    info.ename = dr["ename"].ToString().Trim();
                    info.name = dr["name"].ToString().Trim();
                    info.pid = TypeConverter.ObjectToInt(dr["pid"]);
                    info.rid = TypeConverter.ObjectToInt(dr["rid"]);
                    info.depth = TypeConverter.ObjectToInt(dr["depth"]);
                    info.czid = TypeConverter.ObjectToInt(dr["czid"]);
                    info.everqi = TypeConverter.ObjectToInt(dr["everqi"]);
                    info.keywords = dr["keywords"].ToString().Trim();
                    info.description = dr["description"].ToString().Trim();
                    list.Add(info);
                }
            }

            return list;
        }

        /// <summary>
        /// 从缓存中取出列表数据
        /// </summary>
        /// <returns></returns>
        public static List<NewsClassInfo> GetNewsClassList(bool IsCache)
        {           
            List<NewsClassInfo> list = null;
            if (IsCache)
            {
                string key = CacheKeys.NEWS_CLASS;
                if (CacheUtil.IsExist(key))
                {
                    list = (List<NewsClassInfo>)CacheUtil.Read(key);

                }
                else
                {
                    list = GetNewsClassListData();
                    CacheUtil.Insert(key, list, (double)CacheMin.Ninety);
                }
            }
            else
            {
                list = GetNewsClassListData();
            }
            return list;
        }

        /// <summary>
        /// 取pid=x的list
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static List<NewsClassInfo> GetNewsClassList(int pid, bool IsCache)
        {
            List<NewsClassInfo> list = GetNewsClassList(IsCache);
            List<NewsClassInfo> rlist = new List<NewsClassInfo>();
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].pid == pid)
                        rlist.Add(list[i]);
                }
            }
            return rlist;
        }

        /// <summary>
        /// 某条分类信息
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        public static NewsClassInfo GetNewsClassInfo(int cid, bool IsCache)
        {
            List<NewsClassInfo> list = GetNewsClassList(IsCache);
            NewsClassInfo info = new NewsClassInfo();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].cid == cid)
                    return list[i];
            }
            return info;
        }

        /// <summary>
        /// 按英文描述取某条分类信息
        /// </summary>
        /// <param name="ename"></param>
        /// <returns></returns>
        public static NewsClassInfo GetNewsClassInfo(string ename, bool IsCache)
        {
            List<NewsClassInfo> list = GetNewsClassList(IsCache);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ename.ToLower().Equals(ename.ToLower()))
                    return list[i];
            }
            return null;
        }

        /// <summary>
        /// 删除专题
        /// </summary>
        /// <param name="nid"></param>
        public static void DeleteNewsClassInfo(string cid)
        {
            NewsClassData.DeleteNewsClassInfo(cid);
        }

        /// <summary>
        /// 生成/更新专题信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateNewsClassInfo(NewsClassInfo info)
        {
            int i = 0;
            i = NewsClassData.CreateNewsClassInfo(info);
            return i;
        }
    }
}
