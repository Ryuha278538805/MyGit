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
    /// 大乐透开奖号事务处理类
    /// </summary>
    public class KjhDlt
    { 
        /// <summary>
        /// 删除开奖号
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteKjhDltInfo(string id)
        {
            KjhDltData.DeleteKjhDltInfo(id);
        }

        /// <summary>
        /// 生成/更新开奖号信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateKjhDltInfo(KjhDltInfo info)
        {
            int i = 0;
            i = KjhDltData.CreateKjhDltInfo(info);
            return i;
        }

        /// <summary>
        /// 数据库取出初始化到对象
        /// </summary>
        /// <returns></returns>
        public static List<KjhDltInfo> GetKjhDltListData()
        {
            List<KjhDltInfo> list = new List<KjhDltInfo>();
            DataSet ds = KjhDltData.GetPageListKjh(5000, 1, "tbl_dlt", " qi desc", "");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int count = ds.Tables[0].Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    KjhDltInfo info = new KjhDltInfo();
                    DataRow dr = ds.Tables[0].Rows[i];
                    info.id = TypeConverter.ObjectToInt(dr["id"]);
                    info.qi = TypeConverter.ObjectToInt(dr["qi"]);
                    info.a = TypeConverter.ObjectToInt(dr["a"]);
                    info.b = TypeConverter.ObjectToInt(dr["b"]);
                    info.c = TypeConverter.ObjectToInt(dr["c"]);
                    info.d = TypeConverter.ObjectToInt(dr["d"]);
                    info.e = TypeConverter.ObjectToInt(dr["e"]);
                    info.f = TypeConverter.ObjectToInt(dr["f"]);
                    info.g = TypeConverter.ObjectToInt(dr["g"]);
                    info.qhz = TypeConverter.ObjectToInt(dr["qhz"]);
                    info.hhz = TypeConverter.ObjectToInt(dr["hhz"]);
                    info.hz = TypeConverter.ObjectToInt(dr["hz"]);
                    info.zj1 = TypeConverter.ObjectToInt(dr["zj1"]);
                    info.zj2 = TypeConverter.ObjectToInt(dr["zj2"]);
                    info.zj3 = TypeConverter.ObjectToInt(dr["zj3"]);
                    info.zj4 = TypeConverter.ObjectToInt(dr["zj4"]);
                    info.zj5 = TypeConverter.ObjectToInt(dr["zj5"]);
                    info.zj6 = TypeConverter.ObjectToInt(dr["zj6"]);
                    info.zj7 = TypeConverter.ObjectToInt(dr["zj7"]);
                    info.zj8 = TypeConverter.ObjectToInt(dr["zj8"]);
                    info.jo1 = TypeConverter.ObjectToInt(dr["jo1"]);
                    info.jo2 = TypeConverter.ObjectToInt(dr["jo2"]);
                    info.jo3 = TypeConverter.ObjectToInt(dr["jo3"]);
                    info.zzj1 = TypeConverter.ObjectToInt(dr["zzj1"]);
                    info.zzj2 = TypeConverter.ObjectToInt(dr["zzj2"]);
                    info.zzj3 = TypeConverter.ObjectToInt(dr["zzj3"]);
                    info.zzj4 = TypeConverter.ObjectToInt(dr["zzj4"]);
                    info.zzj5 = TypeConverter.ObjectToInt(dr["zzj5"]);
                    info.zzj6 = TypeConverter.ObjectToInt(dr["zzj6"]);
                    info.zzj7 = TypeConverter.ObjectToInt(dr["zzj7"]);
                    info.zjo1 = TypeConverter.ObjectToInt(dr["zjo1"]);
                    info.zjo2 = TypeConverter.ObjectToInt(dr["zjo2"]);
                    info.zjo3 = TypeConverter.ObjectToInt(dr["zjo3"]);
                    info.fjzj = TypeConverter.ObjectToInt(dr["fjzj"]);
                    info.tzmoney = dr["tzmoney"].ToString().Trim();
                    info.nextmoney = dr["nextmoney"].ToString().Trim();
                    info.fjtzmoney = dr["fjtzmoney"].ToString().Trim();
                    info.fjnextmoney = dr["fjnextmoney"].ToString().Trim();
                    info.cc = dr["cc"].ToString().Trim();
                    info.date = TypeConverter.ObjectToDateTime(dr["date"]);
                    info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
                    list.Add(info);
                }
            }

            return list;
        }

        /// <summary>
        /// 缓存中取前5000期开奖数据
        /// 默认期数倒序
        /// </summary>
        /// <param name="IsCache">是否读取缓存</param>
        /// <returns></returns>
        public static List<KjhDltInfo> GetKjhDltList(bool IsCache)
        {
            List<KjhDltInfo> list = null;
            if (IsCache)
            {
                string key = CacheKeys.KJHDLT;
                if (CacheUtil.IsExist(key))
                {
                    list = (List<KjhDltInfo>)CacheUtil.Read(key);
                }
                else
                {
                    list = GetKjhDltListData();
                    CacheUtil.Insert(key, list, (double)CacheMin.Five);
                }
            }
            else
            {
                list = GetKjhDltListData();
            }
            return list;
        }

        /// <summary>
        /// 某期的开奖信息 ，同时传入ID和Qi的时候ID优先
        /// </summary>
        /// <param name="id"></param>
        /// <param name="qi"></param>
        /// <param name="IsCache"></param>
        /// <returns></returns>
        public static KjhDltInfo GetKjhDltInfo(int id, int qi, bool IsCache)
        {
            List<KjhDltInfo> list = GetKjhDltList(IsCache);
            KjhDltInfo info = new KjhDltInfo();
            for (int i = 0; i < list.Count; i++)
            {
                if (id > 0)
                {
                    if (list[i].id == id)
                        return list[i];
                }
                if (qi > 0)
                {
                    if (list[i].qi == qi)
                        return list[i];
                }
            }
            return info;
        }

        /// <summary>
        /// 获取最新一起开奖号
        /// </summary>
        /// <param name="id"></param>
        /// <param name="qi"></param>
        /// <param name="IsCache"></param>
        /// <returns></returns>
        public static KjhDltInfo GetKjhDltInfoTop1(bool IsCache)
        {
            List<KjhDltInfo> list = GetKjhDltList(IsCache);
            KjhDltInfo info = new KjhDltInfo();
            if (list.Count > 0)
            {
                return list[0];
            }
            return info;
        }

        /// <summary>
        /// 获取开奖号数量
        /// </summary>
        /// <param name="IsCache"></param>
        /// <returns></returns>
        public static int GetKjhDltCount(bool IsCache)
        {
            return GetKjhDltList(IsCache).Count;
        }

        /// <summary>
        /// 翻页获取开奖号
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="page"></param>
        /// <param name="count">返回总量</param>
        /// <param name="IsCache"></param>
        /// <returns></returns>
        public static List<KjhDltInfo> GetKjhDltPageList(int pagesize, int page, int count, bool IsCache)
        {
            List<KjhDltInfo> list = GetKjhDltList(IsCache);
            List<KjhDltInfo> result = new List<KjhDltInfo>();
            count = list.Count;
            int start = pagesize * (page - 1);
            int end = pagesize * page - 1;
            //上标越界 直接返回空
            if (start > count)
                return result;
            else
            {
                //下标越界 重置下标到表尾
                if (end > count) end = count;
                for (int i = start; i < end; i++)
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }

        /// <summary>
        /// 根据期号段获取开奖号
        /// </summary>
        /// <returns></returns>
        public static List<KjhDltInfo> GetKjhDltQiList(int startqi, int endqi, bool IsCache)
        {
            List<KjhDltInfo> list = GetKjhDltList(IsCache);
            List<KjhDltInfo> result = new List<KjhDltInfo>();
            for (int i = 0; i < list.Count; i++)
            {
                //期号进入最大号区间
                if (list[i].qi <= endqi)
                {
                    //位于区间内
                    if (list[i].qi >= startqi)
                        result.Add(list[i]);
                    //离开区间 直接跳出循环
                    else
                        break;
                }
            }
            return result;
        }
    }
}
