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
    /// 七星彩开奖号事务处理类
    /// </summary>
    public class KjhQxc
    { 
        /// <summary>
        /// 删除开奖号
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteKjhQxcInfo(string id)
        {
            KjhQxcData.DeleteKjhQxcInfo(id);
        }

        /// <summary>
        /// 生成/更新开奖号信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateKjhQxcInfo(KjhQxcInfo info)
        {
            int i = 0;
            i = KjhQxcData.CreateKjhQxcInfo(info);
            return i;
        }

        /// <summary>
        /// 数据库取出初始化到对象
        /// </summary>
        /// <returns></returns>
        public static List<KjhQxcInfo> GetKjhQxcListData()
        {
            List<KjhQxcInfo> list = new List<KjhQxcInfo>();
            DataSet ds = KjhQxcData.GetPageListKjh(5000, 1, "tbl_Qxc", " qi desc", "");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int count = ds.Tables[0].Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    KjhQxcInfo info = new KjhQxcInfo();
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
                    info.zj1 = dr["zj1"].ToString().Trim();
                    info.zj2 = dr["zj2"].ToString().Trim();
                    info.zj3 = dr["zj3"].ToString().Trim();
                    info.zj4 = dr["zj4"].ToString().Trim();
                    info.zj5 = dr["zj5"].ToString().Trim();
                    info.zjt = dr["zjt"].ToString().Trim();
                    info.jo1 = dr["jo1"].ToString().Trim();
                    info.jo2 = dr["jo2"].ToString().Trim();
                    info.jot = dr["jot"].ToString().Trim();
                    info.tzmoney = dr["tzmoney"].ToString().Trim();
                    info.nextmoney = dr["nextmoney"].ToString().Trim();
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
        public static List<KjhQxcInfo> GetKjhQxcList(bool IsCache)
        {
            List<KjhQxcInfo> list = null;
            if (IsCache)
            {
                string key = CacheKeys.KJHQXC;
                if (CacheUtil.IsExist(key))
                {
                    list = (List<KjhQxcInfo>)CacheUtil.Read(key);
                }
                else
                {
                    list = GetKjhQxcListData();
                    CacheUtil.Insert(key, list, (double)CacheMin.Five);
                }
            }
            else
            {
                list = GetKjhQxcListData();
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
        public static KjhQxcInfo GetKjhQxcInfo(int id, int qi, bool IsCache)
        {
            List<KjhQxcInfo> list = GetKjhQxcList(IsCache);
            KjhQxcInfo info = new KjhQxcInfo();
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
        public static KjhQxcInfo GetKjhQxcInfoTop1(bool IsCache)
        {
            List<KjhQxcInfo> list = GetKjhQxcList(IsCache);
            KjhQxcInfo info = new KjhQxcInfo();
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
        public static int GetKjhQxcCount(bool IsCache)
        {
            return GetKjhQxcList(IsCache).Count;
        }

        /// <summary>
        /// 翻页获取开奖号
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="page"></param>
        /// <param name="count">返回总量</param>
        /// <param name="IsCache"></param>
        /// <returns></returns>
        public static List<KjhQxcInfo> GetKjhQxcPageList(int pagesize, int page, int count, bool IsCache)
        {
            List<KjhQxcInfo> list = GetKjhQxcList(IsCache);
            List<KjhQxcInfo> result = new List<KjhQxcInfo>();
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
        public static List<KjhQxcInfo> GetKjhQxcQiList(int startqi, int endqi, bool IsCache)
        {
            List<KjhQxcInfo> list = GetKjhQxcList(IsCache);
            List<KjhQxcInfo> result = new List<KjhQxcInfo>();
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
