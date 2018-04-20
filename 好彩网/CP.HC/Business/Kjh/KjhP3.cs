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
    /// 排列三开奖号事务处理类
    /// </summary>
    public class KjhP3
    {
        /// <summary>
        /// 删除开奖号
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteKjhP3Info(string id)
        {
            KjhP3Data.DeleteKjhP3Info(id);
        }

        /// <summary>
        /// 生成/更新开奖号信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateKjhP3Info(KjhP3Info info)
        {
            int i = 0;
            i = KjhP3Data.CreateKjhP3Info(info);
            return i;
        }

        /// <summary>
        /// 数据库取出初始化到对象
        /// </summary>
        /// <returns></returns>
        public static List<KjhP3Info> GetKjhP3ListData()
        {
            List<KjhP3Info> list = new List<KjhP3Info>();
            DataSet ds = KjhP3Data.GetPageListKjh(5000, 1, "tbl_p3", " qi desc", "");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int count = ds.Tables[0].Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    KjhP3Info info = new KjhP3Info();
                    DataRow dr = ds.Tables[0].Rows[i];
                    info.id = TypeConverter.ObjectToInt(dr["id"]);
                    info.qi = TypeConverter.ObjectToInt(dr["qi"]);
                    info.a = TypeConverter.ObjectToInt(dr["a"]);
                    info.b = TypeConverter.ObjectToInt(dr["b"]);
                    info.c = TypeConverter.ObjectToInt(dr["c"]);
                    info.d = TypeConverter.ObjectToInt(dr["d"]);
                    info.e = TypeConverter.ObjectToInt(dr["e"]);                  
                    info.zj1 = TypeConverter.ObjectToInt(dr["zj1"]);
                    info.zj2 = TypeConverter.ObjectToInt(dr["zj2"]);
                    info.zj3 = TypeConverter.ObjectToInt(dr["zj3"]);
                    info.zjp5 = TypeConverter.ObjectToInt(dr["zjp5"]);
                    info.hz = TypeConverter.ObjectToInt(dr["hz"]);
                    info.tzmoney = dr["tzmoney"].ToString().Trim();
                    info.tzmoneyp5 = dr["tzmoneyp5"].ToString().Trim();
                    info.kjh = dr["kjh"].ToString().Trim();
                    info.sjh = dr["sjh"].ToString().Trim();
                    info.sjhtype = dr["sjhtype"].ToString().Trim();
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
        public static List<KjhP3Info> GetKjhP3List(bool IsCache)
        {
            List<KjhP3Info> list = null;
            if (IsCache)
            {
                string key = CacheKeys.KJHP3;
                if (CacheUtil.IsExist(key))
                {
                    list = (List<KjhP3Info>)CacheUtil.Read(key);
                }
                else
                {
                    list = GetKjhP3ListData();
                    CacheUtil.Insert(key, list, (double)CacheMin.Five);
                }
            }
            else
            {
                list = GetKjhP3ListData();
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
        public static KjhP3Info GetKjhP3Info(int id, int qi, bool IsCache)
        {
            List<KjhP3Info> list = GetKjhP3List(IsCache);
            KjhP3Info info = new KjhP3Info();
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
        public static KjhP3Info GetKjhP3InfoTop1(bool IsCache)
        {
            List<KjhP3Info> list = GetKjhP3List(IsCache);
            KjhP3Info info = new KjhP3Info();
            if(list.Count>0)
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
        public static int GetKjhP3Count(bool IsCache)
        {
            return GetKjhP3List(IsCache).Count;
        }

        /// <summary>
        /// 翻页获取开奖号
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="page"></param>
        /// <param name="count">返回总量</param>
        /// <param name="IsCache"></param>
        /// <returns></returns>
        public static List<KjhP3Info> GetKjhP3PageList(int pagesize, int page, int count, bool IsCache)
        {
            List<KjhP3Info> list = GetKjhP3List(IsCache);
            List<KjhP3Info> result = new List<KjhP3Info>();
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
        public static List<KjhP3Info> GetKjhP3QiList(int startqi, int endqi, bool IsCache)
        {
            List<KjhP3Info> list = GetKjhP3List(IsCache);
            List<KjhP3Info> result = new List<KjhP3Info>();
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

