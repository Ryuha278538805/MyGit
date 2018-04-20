using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using DataProvider;
using Common;

namespace Business
{
    public class YcZone
    {
        /// <summary>
        /// 删除专题
        /// </summary>
        /// <param name="nid"></param>
        public static void DeleteYcZoneInfo(string yzid)
        {            
            YcZoneData.DeleteYcZoneInfo(yzid);
        }

        /// <summary>
        /// 生成/更新专题信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateYcZoneInfo(YcZoneInfo info)
        {
            int i = 0;
            i = YcZoneData.CreateYcZoneInfo(info);
            return i;
        }

        public static List<YcZoneInfo> GetYcZoneListData()
        {
            List<YcZoneInfo> list = new List<YcZoneInfo>();
            DataTable dt = YcZoneData.GetYcZoneListData();

            if (dt != null && dt.Rows.Count > 0)
            {
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    YcZoneInfo info = new YcZoneInfo();
                    DataRow dr = dt.Rows[i];
                    info.yzid = TypeConverter.ObjectToInt(dr["yzid"]);
                    info.name = dr["name"].ToString().Trim();
                    info.czid = TypeConverter.ObjectToInt(dr["czid"]);
                    info.type = TypeConverter.ObjectToInt(dr["type"]);
                    info.isautowrite = TypeConverter.ObjectToBool(dr["isautowrite"]);
                    info.orderint = TypeConverter.ObjectToInt(dr["orderint"]);
                    info.lastqi = TypeConverter.ObjectToInt(dr["lastqi"]);
                    info.keywords = dr["keywords"].ToString().Trim();
                    info.description = dr["description"].ToString().Trim();
                    info.titlemodel = dr["titlemodel"].ToString().Trim();
                    info.contextmodel = dr["contextmodel"].ToString().Trim();
                    info.contexthead = dr["contexthead"].ToString().Trim();
                    info.contextend = dr["contextend"].ToString().Trim();
                    info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
                    list.Add(info);
                }
            }

            return list;
        }

        /// <summary>
        /// 根据YZID获取单个预测专题
        /// </summary>
        /// <param name="yzid"></param>
        /// <returns></returns>
        public static YcZoneInfo GetYcZoneByYzID(int yzid)
        {
            DataRow dr = YcZoneData.GetYcZoneInfoData(yzid);
            YcZoneInfo info = new YcZoneInfo();
            if (dr != null)
            {
                    info.yzid = TypeConverter.ObjectToInt(dr["yzid"]);
                    info.name = dr["name"].ToString().Trim();
                    info.czid = TypeConverter.ObjectToInt(dr["czid"]);
                    info.type = TypeConverter.ObjectToInt(dr["type"]);
                    info.isautowrite = TypeConverter.ObjectToBool(dr["isautowrite"]);
                    info.orderint = TypeConverter.ObjectToInt(dr["orderint"]);
                    info.lastqi = TypeConverter.ObjectToInt(dr["lastqi"]);
                    info.keywords = dr["keywords"].ToString().Trim();
                    info.description = dr["description"].ToString().Trim();
                    info.titlemodel = dr["titlemodel"].ToString().Trim();
                    info.contextmodel = dr["contextmodel"].ToString().Trim();
                    info.contexthead = dr["contexthead"].ToString().Trim();
                    info.contextend = dr["contextend"].ToString().Trim();
                    info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);                
            }
            return info;
        }

        /// <summary>
        /// 根据YZID获取单个预测专题
        /// </summary>
        /// <param name="yzid"></param>
        /// <returns></returns>
        public static List<YcZoneInfo> GetYcZoneList(int czid, int type, bool IsCache)
        {
            List<YcZoneInfo> list = GetZoneList(IsCache);
            List<YcZoneInfo> rlist = new List<YcZoneInfo>();
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if(czid>0 && type ==0)
                        if (list[i].czid == czid)
                        { rlist.Add(list[i]); continue; }
                    if(czid>0 && type>0)
                        if (list[i].czid == czid && list[i].type == type)
                        { rlist.Add(list[i]); continue; }
                    if (czid == 0 && type > 0)
                        if (list[i].type == type)
                        { rlist.Add(list[i]); continue; }
                }
            }
            return rlist;
        }

        /// <summary>
        /// 缓存中取zone数据
        /// </summary>
        /// <returns></returns>
        public static List<YcZoneInfo> GetZoneList(bool IsCache)
        {
            List<YcZoneInfo> list = null;
            if (IsCache)
            {
                string key = CacheKeys.YCZONE;
                if (CacheUtil.IsExist(key))
                {
                    list = (List<YcZoneInfo>)CacheUtil.Read(key);
                }
                else
                {
                    list = GetYcZoneListData();
                    CacheUtil.Insert(key, list, (double)CacheMin.Two);
                }
            }
            else
            {
                list = GetYcZoneListData();
            }
            return list;
        }

        /// <summary>
        /// 某专题的信息
        /// </summary>
        /// <param name="zid"></param>
        /// <returns></returns>
        public static YcZoneInfo GetYcZoneInfo(int yzid, bool IsCache)
        {
            List<YcZoneInfo> list = GetZoneList(IsCache);
            YcZoneInfo info = new YcZoneInfo();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].yzid == yzid)
                    return list[i];
            }
            return info;
        }  
    }
}
