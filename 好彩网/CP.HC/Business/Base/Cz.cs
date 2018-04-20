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
    /// 彩种事务处理类
    /// </summary>
    public class Cz
    {

        /// <summary>
        /// 删除彩种
        /// </summary>
        /// <param name="nid"></param>
        public static void DeleteCzInfo(string czid)
        {
            CzData.DeleteCzInfo(czid);
        }

        /// <summary>
        /// 生成/更新彩种信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateCzInfo(CzInfo info)
        {
            int i = 0;
            i = CzData.CreateCzInfo(info);
            return i;
        }

        public static List<CzInfo> GetCzListData()
        {
            List<CzInfo> list = new List<CzInfo>();
            DataTable dt = CzData.GetCzListData();

            if (dt != null && dt.Rows.Count > 0)
            {
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    CzInfo info = new CzInfo();
                    DataRow dr = dt.Rows[i];
                    info.czid = TypeConverter.ObjectToInt(dr["czid"]);
                    info.czname = dr["czname"].ToString().Trim();
                    info.shortname = dr["shortname"].ToString().Trim();
                    info.qi = TypeConverter.ObjectToInt(dr["qi"]);
                    list.Add(info);
                }
            }

            return list;
        }

        /// <summary>
        /// 缓存中取彩种数据
        /// </summary>
        /// <returns></returns>
        public static List<CzInfo> GetCzList(bool IsCache)
        {            
            List<CzInfo> list = null;
            if (IsCache)
            {
                string key = CacheKeys.CZ;
                if (CacheUtil.IsExist(key))
                {
                    list = (List<CzInfo>)CacheUtil.Read(key);
                }
                else
                {
                    list = GetCzListData();
                    CacheUtil.Insert(key, list, (double)CacheMin.Ten);
                }
            }
            else
            {
                list = GetCzListData();
            }
            return list;
        }


        /// <summary>
        /// 某彩种的信息
        /// </summary>
        /// <param name="zid"></param>
        /// <returns></returns>
        public static CzInfo GetCzInfo(int czid, bool IsCache)
        {
            List<CzInfo> list = GetCzList(IsCache);
            CzInfo info = new CzInfo();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].czid == czid)
                    return list[i];
            }
            return info;
        }

        /// <summary>
        /// 批量更新期数
        /// </summary>
        /// <param name="czids"></param>
        public static void UpdateCzQi(string czids)
        {
            CzData.UpdateCzQi(czids);
        }
        
        /// <summary>
        /// 开奖号库获取最新一期期号
        /// </summary>
        /// <param name="czids"></param>
        public static int GetNewQi(int cz)
        {
            return CzData.GetNewQi(cz);
        }

           /// <summary>
        /// 开奖号库获取当前最大期号
        /// </summary>
        /// <param name="czids"></param>
        public static int GetMaxQi(int cz)
        {
            return CzData.GetMaxQi(cz);
        }
    }

    /// <summary>
    /// 开奖号库获取彩种信息对应编号
    /// </summary>
    public enum KjhCz : int
    {
        Cz225 = 0,
        Cz3d = 1,
        Czssq = 2,
        Czqlc = 3,
        Czp3 = 4,
        Czqxc = 5,
        Czdlt = 6
    }
}