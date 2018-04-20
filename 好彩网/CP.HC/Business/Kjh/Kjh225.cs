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
    /// 22选5开奖号事务处理类
    /// </summary>
    public class Kjh225
    {
        /// <summary>
        /// 删除开奖号
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteKjh225Info(string id)
        {
            Kjh225Data.DeleteKjh225Info(id);
        }

        /// <summary>
        /// 生成/更新开奖号信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateKjh225Info(Kjh225Info info)
        {
            int i = 0;
            i = Kjh225Data.CreateKjh225Info(info);
            return i;
        }

        /// <summary>
        /// 数据库取出初始化到对象
        /// </summary>
        /// <returns></returns>
        public static List<Kjh225Info> GetKjh225ListData()
        {
            List<Kjh225Info> list = new List<Kjh225Info>();
            DataSet ds = Kjh225Data.GetPageListKjh(5000,1,"tbl_225"," qi desc","");
            if (ds != null && ds.Tables.Count>0 && ds.Tables[0].Rows.Count > 0)
            {
                int count = ds.Tables[0].Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    Kjh225Info info = new Kjh225Info();
                    DataRow dr = ds.Tables[0].Rows[i];
                    info.id = TypeConverter.ObjectToInt(dr["id"]);
                    info.qi = TypeConverter.ObjectToInt(dr["qi"]);
                    info.a = TypeConverter.ObjectToInt(dr["a"]);
                    info.b = TypeConverter.ObjectToInt(dr["b"]);
                    info.c = TypeConverter.ObjectToInt(dr["c"]);
                    info.d = TypeConverter.ObjectToInt(dr["d"]);
                    info.e = TypeConverter.ObjectToInt(dr["e"]);
                    info.hz = TypeConverter.ObjectToInt(dr["hz"]);
                    info.zj1 = TypeConverter.ObjectToInt(dr["zj1"]);
                    info.zj2 = TypeConverter.ObjectToInt(dr["zj2"]);
                    info.zj3 = TypeConverter.ObjectToInt(dr["zj3"]);
                    info.prize1 = dr["prize1"].ToString().Trim();
                    info.prize2 = dr["prize2"].ToString().Trim();
                    info.prize3 = dr["prize3"].ToString().Trim();
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
        public static List<Kjh225Info> GetKjh225List(bool IsCache)
        {
            List<Kjh225Info> list = null;
            if (IsCache)
            {
                string key = CacheKeys.KJH225;
                if (CacheUtil.IsExist(key))
                {
                    list = (List<Kjh225Info>)CacheUtil.Read(key);
                }
                else
                {
                    list = GetKjh225ListData();
                    CacheUtil.Insert(key, list, (double)CacheMin.Five);
                }
            }
            else
            {
                list = GetKjh225ListData();
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
        public static Kjh225Info GetKjh225Info(int id, int qi, bool IsCache)
        {
            List<Kjh225Info> list = GetKjh225List(IsCache);
            Kjh225Info info = new Kjh225Info();
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
        public static Kjh225Info GetKjh225InfoTop1(bool IsCache)
        {
            List<Kjh225Info> list = GetKjh225List(IsCache);
            Kjh225Info info = new Kjh225Info();
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
        public static int GetKjh225Count(bool IsCache)
        {
            return GetKjh225List(IsCache).Count;
        }

        /// <summary>
        /// 翻页获取开奖号
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="page"></param>
        /// <param name="count">返回总量</param>
        /// <param name="IsCache"></param>
        /// <returns></returns>
        public static List<Kjh225Info> GetKjh225PageList(int pagesize, int page, int count, bool IsCache)
        {
            List<Kjh225Info> list = GetKjh225List(IsCache);
            List<Kjh225Info> result = new List<Kjh225Info>();
            count = list.Count;
            int start = pagesize * (page - 1);
            int end = pagesize * page -1;
            //上标越界 直接返回空
            if (start > count) 
                return result;
            else
            {
                //下标越界 重置下标到表尾
                if (end > count)  end = count;
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
        public static List<Kjh225Info> GetKjh225QiList(int startqi, int endqi, bool IsCache)
        {
            List<Kjh225Info> list = GetKjh225List(IsCache);
            List<Kjh225Info> result = new List<Kjh225Info>();            
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
