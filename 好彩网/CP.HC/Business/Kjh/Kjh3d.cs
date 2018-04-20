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
    /// 福彩3D开奖号事务处理类
    /// </summary>
    public class Kjh3d
    {        
        /// <summary>
        /// 删除开奖号
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteKjh3dInfo(string id)
        {
            Kjh3dData.DeleteKjh3dInfo(id);
        }

        /// <summary>
        /// 生成开奖号 开机号信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateKjh3dInfo(Kjh3dInfo info)
        {
            int i = 0;
            i = Kjh3dData.CreateKjh3dInfo(info);
            return i;
        }

         /// <summary>
        /// 生成/更新开奖号完整信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateKjh3dAllInfo(Kjh3dInfo info)
        {
            int i = 0;
            i = Kjh3dData.CreateKjh3dAllInfo(info);
            return i;
        }

        /// <summary>
        /// 数据库取出初始化到对象
        /// </summary>
        /// <returns></returns>
        public static List<Kjh3dInfo> GetKjh3dListData()
        {
            List<Kjh3dInfo> list = new List<Kjh3dInfo>();
            DataSet ds = Kjh3dData.GetPageListKjh(5000, 1, "tbl_3d", " qi desc", "");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int count = ds.Tables[0].Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    Kjh3dInfo info = new Kjh3dInfo();
                    DataRow dr = ds.Tables[0].Rows[i];
                    info.id = TypeConverter.ObjectToInt(dr["id"]);
                    info.qi = TypeConverter.ObjectToInt(dr["qi"]);
                    info.a = TypeConverter.ObjectToInt(dr["a"]);
                    info.b = TypeConverter.ObjectToInt(dr["b"]);
                    info.c = TypeConverter.ObjectToInt(dr["c"]);
                    info.zj1 = TypeConverter.ObjectToInt(dr["zj1"]);
                    info.zj2 = TypeConverter.ObjectToInt(dr["zj2"]);
                    info.zj3 = TypeConverter.ObjectToInt(dr["zj3"]);
                    info.sjh = TypeConverter.ObjectToInt(dr["sjh"]);
                    info.sjx = dr["sjx"].ToString().Trim();
                    info.tzmoney = dr["tzmoney"].ToString().Trim();
                    info.hz = TypeConverter.ObjectToInt(dr["hz"]);
                    info.kjh = TypeConverter.ObjectToInt(dr["kjh"]);
                    info.kjih = TypeConverter.ObjectToInt(dr["kjih"]);
                    info.kjh_zu = TypeConverter.ObjectToInt(dr["kjh_zu"]);
                    info.kjh_jo = TypeConverter.ObjectToInt(dr["kjh_jo"]);
                    info.kjh_dx = TypeConverter.ObjectToInt(dr["kjh_dx"]);
                    info.kjh_zh = TypeConverter.ObjectToInt(dr["kjh_zh"]);
                    info.kjh_hz_dx = TypeConverter.ObjectToInt(dr["kjh_hz_dx"]);
                    info.kjh_hz_jo = TypeConverter.ObjectToInt(dr["kjh_hz_jo"]);
                    info.sjh_zu = TypeConverter.ObjectToInt(dr["sjh_zu"]);
                    info.sjh_dx = TypeConverter.ObjectToInt(dr["sjh_dx"]);
                    info.sjh_jo = TypeConverter.ObjectToInt(dr["sjh_jo"]);
                    info.sjh_zh = TypeConverter.ObjectToInt(dr["sjh_zh"]);
                    info.sjh_hz = TypeConverter.ObjectToInt(dr["sjh_hz"]);
                    info.sjh_hz_jo = TypeConverter.ObjectToInt(dr["sjh_hz_jo"]);
                    info.sjh_hz_dx = TypeConverter.ObjectToInt(dr["sjh_hz_dx"]);
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
        public static List<Kjh3dInfo> GetKjh3dList(bool IsCache)
        {
            List<Kjh3dInfo> list = null;
            if (IsCache)
            {
                string key = CacheKeys.KJH3D;
                if (CacheUtil.IsExist(key))
                {
                    list = (List<Kjh3dInfo>)CacheUtil.Read(key);
                }
                else
                {
                    list = GetKjh3dListData();
                    CacheUtil.Insert(key, list, (double)CacheMin.Five);
                }
            }
            else
            {
                list = GetKjh3dListData();
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
        public static Kjh3dInfo GetKjh3dInfo(int id, int qi, bool IsCache)
        {
            List<Kjh3dInfo> list = GetKjh3dList(IsCache);
            Kjh3dInfo info = new Kjh3dInfo();
            for (int i = 0; i < list.Count; i++)
            {
                if (id > 0)
                {
                    if (list[i].id == id)
                        return list[i];
                }
                if(qi>0)
                {
                    if (list[i].qi == qi)
                        return list[i];
                }
            }
            return info;
        }

        /// <summary>
        /// 获取开奖号数量
        /// </summary>
        /// <param name="IsCache"></param>
        /// <returns></returns>
        public static int GetKjh3dCount(bool IsCache)
        {
            return GetKjh3dList(IsCache).Count;    
        }

        /// <summary>
        /// 获取最新一起开奖号
        /// </summary>
        /// <param name="i"></param>
        /// <param name="qi"></param>
        /// <param name="IsCache"></param>
        /// <returns></returns>
        public static Kjh3dInfo GetKjh3dInfoTop1(int i,bool IsCache)
        {
            List<Kjh3dInfo> list = GetKjh3dList(IsCache);
            Kjh3dInfo info = new Kjh3dInfo();
            if (list.Count > 0)
            {
                return list[i];
            }
            return info;
        }

        /// <summary>
        /// 翻页获取开奖号
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="page"></param>
        /// <param name="count">返回总量</param>
        /// <param name="IsCache"></param>
        /// <returns></returns>
        public static List<Kjh3dInfo> GetKjh3dPageList(int pagesize, int page, int count, bool IsCache)
        {
            List<Kjh3dInfo> list = GetKjh3dList(IsCache);
            List<Kjh3dInfo> result = new List<Kjh3dInfo>();
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
        public static List<Kjh3dInfo> GetKjh3dQiList(int startqi, int endqi, bool IsCache)
        {
            List<Kjh3dInfo> list = GetKjh3dList(IsCache);
            List<Kjh3dInfo> result = new List<Kjh3dInfo>();
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
