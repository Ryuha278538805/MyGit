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
    /// 双色球开奖号事务处理类
    /// </summary>
    public class KjhSsq
    {
        /// <summary>
        /// 删除开奖号
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteKjhSsqInfo(string id)
        {
            KjhSsqData.DeleteKjhSsqInfo(id);
        }

        /// <summary>
        /// 生成/更新开奖号信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateKjhSsqInfo(KjhSsqInfo info)
        {
            int i = 0;
            i = KjhSsqData.CreateKjhSsqInfo(info);
            return i;
        }

        /// <summary>
        /// 数据库取出初始化到对象
        /// </summary>
        /// <returns></returns>
        public static List<KjhSsqInfo> GetKjhSsqListData()
        {
            List<KjhSsqInfo> list = new List<KjhSsqInfo>();
            DataSet ds = KjhSsqData.GetPageListKjh(5000, 1, "tbl_ssq", " qi desc", "");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int count = ds.Tables[0].Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    KjhSsqInfo info = new KjhSsqInfo();
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
                    info.h = dr["h"].ToString().Trim();
                    info.zj1 = dr["zj1"].ToString().Trim();
                    info.zj2 = dr["zj2"].ToString().Trim();
                    info.zj3 = dr["zj3"].ToString().Trim();
                    info.zj4 = dr["zj4"].ToString().Trim();
                    info.zj5 = dr["zj5"].ToString().Trim();
                    info.zj6 = dr["zj6"].ToString().Trim();
                    info.zj7 = dr["zj7"].ToString().Trim();
                    info.jo1 = dr["jo1"].ToString().Trim();
                    info.jo2 = dr["jo2"].ToString().Trim();
                    info.hz = TypeConverter.ObjectToInt(dr["hz"]);                   
                    info.tzmoney = dr["tzmoney"].ToString().Trim();
                    info.nextmoney = dr["nextmoney"].ToString().Trim();
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
        public static List<KjhSsqInfo> GetKjhSsqList(bool IsCache)
        {
            List<KjhSsqInfo> list = null;
            if (IsCache)
            {
                string key = CacheKeys.KJHSSQ;
                if (CacheUtil.IsExist(key))
                {
                    list = (List<KjhSsqInfo>)CacheUtil.Read(key);
                }
                else
                {
                    list = GetKjhSsqListData();
                    CacheUtil.Insert(key, list, (double)CacheMin.Five);
                }
            }
            else
            {
                list = GetKjhSsqListData();
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
        public static KjhSsqInfo GetKjhSsqInfo(int id, int qi, bool IsCache)
        {
            List<KjhSsqInfo> list = GetKjhSsqList(IsCache);
            KjhSsqInfo info = new KjhSsqInfo();
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
        public static KjhSsqInfo GetKjhSsqInfoTop1(bool IsCache)
        {
            List<KjhSsqInfo> list = GetKjhSsqList(IsCache);
            KjhSsqInfo info = new KjhSsqInfo();
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
        public static int GetKjhSsqCount(bool IsCache)
        {
            return GetKjhSsqList(IsCache).Count;
        }

        /// <summary>
        /// 翻页获取开奖号
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="page"></param>
        /// <param name="count">返回总量</param>
        /// <param name="IsCache"></param>
        /// <returns></returns>
        public static List<KjhSsqInfo> GetKjhSsqPageList(int pagesize, int page, int count, bool IsCache)
        {
            List<KjhSsqInfo> list = GetKjhSsqList(IsCache);
            List<KjhSsqInfo> result = new List<KjhSsqInfo>();
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
        public static List<KjhSsqInfo> GetKjhSsqQiList(int startqi, int endqi, bool IsCache)
        {
            List<KjhSsqInfo> list = GetKjhSsqList(IsCache);
            List<KjhSsqInfo> result = new List<KjhSsqInfo>();
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
