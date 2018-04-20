using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using DataProvider;
using Common;

namespace Business
{
    public class Yc
    {
        /// <summary>
        /// 删除预测信息
        /// </summary>
        /// <param name="yid"></param>
        public static void DeleteYcInfo(string yid)
        {
            YcData.DeleteYcInfo(yid);
        }

        /// <summary>
        /// 更新预测信息点击
        /// </summary>
        /// <param name="yid"></param>
        public static void UpdateYcInfoHits(string yid)
        {
            YcData.UpdateYcInfoHits(yid);
        }

        /// <summary>
        /// 生成/更新预测信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateYcInfo(YcInfo info)
        {
            int i = 0;
            i = YcData.CreateYcInfo(info);
            return i;
        }

        /// <summary>
        /// 根据YID获取单个预测
        /// </summary>
        /// <param name="yid"></param>
        /// <returns></returns>
        public static YcInfo GetYcInfoByYID(int yid)
        {
            DataRow dr = YcData.GetYcInfoByYidData(yid);
            YcInfo info = new YcInfo();
            if (dr != null)
            {
                info.yid = TypeConverter.ObjectToInt(dr["yid"]);
                info.yzid = TypeConverter.ObjectToInt(dr["yzid"]);
                info.qi = TypeConverter.ObjectToInt(dr["qi"]);
                info.isright = TypeConverter.ObjectToBool(dr["isright"]);
                info.info = dr["info"].ToString().Trim();
                info.kjh = dr["kjh"].ToString().Trim();
                info.title = dr["title"].ToString().Trim();
                info.context = dr["context"].ToString().Trim();
                info.hits = TypeConverter.ObjectToInt(dr["hits"]);
                info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
            }
            return info;
        }

         /// <summary>
        /// 根据YZID获取单个未验证的预测
        /// </summary>
        /// <param name="yid"></param>
        /// <returns></returns>
        public static YcInfo GetYcInfoNoChkTop1ByYzid(int yzid)
        {
            DataRow dr = YcData.GetYcInfoNoChkTop1ByYzidData(yzid);
            YcInfo info = new YcInfo();
            if (dr != null)
            {
                info.yid = TypeConverter.ObjectToInt(dr["yid"]);
                info.yzid = TypeConverter.ObjectToInt(dr["yzid"]);
                info.qi = TypeConverter.ObjectToInt(dr["qi"]);
                info.isright = TypeConverter.ObjectToBool(dr["isright"]);
                info.info = dr["info"].ToString().Trim();
                info.kjh = dr["kjh"].ToString().Trim();
                info.title = dr["title"].ToString().Trim();
                info.context = dr["context"].ToString().Trim();
                info.hits = TypeConverter.ObjectToInt(dr["hits"]);
                info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
            }
            return info;
        }

        /// <summary>
        /// 根据YZID获取最新一个已验证的预测
        /// </summary>
        /// <param name="yid"></param>
        /// <returns></returns>
        public static YcInfo GetYcInfoChkTop1ByYzid(int yzid)
        {
            DataRow dr = YcData.GetYcInfoChkTop1ByYzidData(yzid);
            YcInfo info = new YcInfo();
            if (dr != null)
            {
                info.yid = TypeConverter.ObjectToInt(dr["yid"]);
                info.yzid = TypeConverter.ObjectToInt(dr["yzid"]);
                info.qi = TypeConverter.ObjectToInt(dr["qi"]);
                info.isright = TypeConverter.ObjectToBool(dr["isright"]);
                info.info = dr["info"].ToString().Trim();
                info.kjh = dr["kjh"].ToString().Trim();
                info.title = dr["title"].ToString().Trim();
                info.context = dr["context"].ToString().Trim();
                info.hits = TypeConverter.ObjectToInt(dr["hits"]);
                info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
            }
            return info;
        }

        /// <summary>
        /// 获取某专题前15条
        /// </summary>
        /// <param name="yzid"></param>
        /// <returns></returns>
        public static List<YcInfo> GetYcInfoTop15ListByYZid(int yzid)
        {
            List<YcInfo> list = new List<YcInfo>();
            DataTable dt = YcData.GetYcInfoTop15ByYZidData(yzid);

            if (dt != null && dt.Rows.Count > 0)
            {
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    YcInfo info = new YcInfo();
                    DataRow dr = dt.Rows[i];
                    info.yid = TypeConverter.ObjectToInt(dr["yid"]);
                    info.yzid = TypeConverter.ObjectToInt(dr["yzid"]);
                    info.qi = TypeConverter.ObjectToInt(dr["qi"]);
                    info.isright = TypeConverter.ObjectToBool(dr["isright"]);
                    info.info = dr["info"].ToString().Trim();
                    info.kjh = dr["kjh"].ToString().Trim();
                    info.title = dr["title"].ToString().Trim();
                    info.context = dr["context"].ToString().Trim();
                    info.hits = TypeConverter.ObjectToInt(dr["hits"]);
                    info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
                    list.Add(info);
                }
            }
            return list;
        }

        /// <summary>
        /// 获取当前预测之前15条本专题预测
        /// </summary>
        /// <param name="yid"></param>
        /// <returns></returns>
        public static List<YcInfo> GetYcInfoTop15ListByYid(int yid)
        {
            List<YcInfo> list = new List<YcInfo>();
            DataTable dt = YcData.GetYcInfoTop15ByYidData(yid);

            if (dt != null && dt.Rows.Count > 0)
            {
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    YcInfo info = new YcInfo();
                    DataRow dr = dt.Rows[i];
                    info.yid = TypeConverter.ObjectToInt(dr["yid"]);
                    info.yzid = TypeConverter.ObjectToInt(dr["yzid"]);
                    info.qi = TypeConverter.ObjectToInt(dr["qi"]);
                    info.isright = TypeConverter.ObjectToBool(dr["isright"]);
                    info.info = dr["info"].ToString().Trim();
                    info.kjh = dr["kjh"].ToString().Trim();
                    info.title = dr["title"].ToString().Trim();
                    info.context = dr["context"].ToString().Trim();
                    info.hits = TypeConverter.ObjectToInt(dr["hits"]);
                    info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
                    list.Add(info);
                }
            }
            return list;
        }

    }
}
