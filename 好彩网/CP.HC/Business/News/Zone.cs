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
    /// 专题事务处理类
    /// </summary>
    public class Zone
    {

        /// <summary>
        /// 删除专题
        /// </summary>
        /// <param name="nid"></param>
        public static void DeleteZoneInfo(string zid)
        {
            ZoneData.DeleteZoneInfo(zid);
        }

        /// <summary>
        /// 生成/更新专题信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateZoneInfo(ZoneInfo info)
        {
            int i = 0;
            i = ZoneData.CreateZoneInfo(info);
            return i;
        }

        public static List<ZoneInfo> GetZoneListData()
        {
            List<ZoneInfo> list = new List<ZoneInfo>();
            DataTable dt = ZoneData.GetZoneListData();

            if (dt != null && dt.Rows.Count > 0)
            {
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    ZoneInfo info = new ZoneInfo();
                    DataRow dr = dt.Rows[i];
                    info.zid = TypeConverter.ObjectToInt(dr["zid"]);
                    info.name = dr["name"].ToString().Trim();
                    info.cid = TypeConverter.ObjectToInt(dr["cid"]);
                    info.orderint = TypeConverter.ObjectToInt(dr["orderint"]);
                    info.keywords = dr["keywords"].ToString().Trim();
                    info.description = dr["description"].ToString().Trim();
                    list.Add(info);
                }
            }

            return list;
        }

        /// <summary>
        /// 缓存中取zone数据
        /// </summary>
        /// <returns></returns>
        public static List<ZoneInfo> GetZoneList(bool IsCache)
        {            
            List<ZoneInfo> list = null;
            if (IsCache)
            {
                string key = CacheKeys.ZONE;
                if (CacheUtil.IsExist(key))
                {
                    list = (List<ZoneInfo>)CacheUtil.Read(key);
                }
                else
                {
                    list = GetZoneListData();
                    CacheUtil.Insert(key, list, (double)CacheMin.Ten);
                }
            }
            else
            {
                list = GetZoneListData();
            }
            return list;
        }


        /// <summary>
        /// 某专题的信息
        /// </summary>
        /// <param name="zid"></param>
        /// <returns></returns>
        public static ZoneInfo GetZoneInfo(int zid, bool IsCache)
        {
            List<ZoneInfo> list = GetZoneList(IsCache);
            ZoneInfo info = new ZoneInfo();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].zid == zid)
                    return list[i];

            }
            return info;

        }

        /// <summary>
        /// 某分类下最新期已经添加的专题
        /// </summary>
        /// <param name="zid"></param>
        /// <returns></returns>
        public static List<ZoneInfo> GetZoneList(int cid, bool IsCache)
        {
            List<ZoneInfo> list = GetZoneList(IsCache);
            List<ZoneInfo> result = new List<ZoneInfo>();
            DataTable dt = ZoneData.GetZoneListData(cid);
            if (dt != null && dt.Rows.Count > 0)
            {
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j].zid == TypeConverter.ObjectToInt(dr["zid"]))
                            result.Add(list[j]);
                    }
                }
            }
            return result;
        }

         /// <summary>
        /// 某分类下已经添加模板的专题
        /// </summary>
        /// <param name="zid"></param>
        /// <returns></returns>
        public static List<ZoneInfo> GetZoneTempAddedList(int cid, bool IsCache)
        {
            List<ZoneInfo> list = GetZoneList(IsCache);
            List<ZoneInfo> result = new List<ZoneInfo>();
            DataTable dt = ZoneData.GetZoneListTempAddedData(cid);
            if (dt != null && dt.Rows.Count > 0)
            {
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j].zid == TypeConverter.ObjectToInt(dr["zid"]))
                            result.Add(list[j]);
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 某分类下的全部专题
        /// </summary>
        /// <param name="cid">资讯分类</param>
        /// <returns></returns>
        public static List<ZoneInfo> GetZoneListByCid(int cid, bool IsCache)
        {
            List<ZoneInfo> list = GetZoneList(IsCache);
            List<ZoneInfo> result = new List<ZoneInfo>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].cid == cid)
                    result.Add(list[i]);
            }
            return result;
        }
    }
}
