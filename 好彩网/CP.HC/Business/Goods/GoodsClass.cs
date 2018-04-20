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
    /// 商品分类的业务处理类
    /// simwon
    /// </summary>
    public class GoodsClass
    {
        /// <summary>
        /// 所有分类数据
        /// </summary>
        /// <returns></returns>
        private static List<GoodsClassInfo> GetGoodsClassListData()
        {
            List<GoodsClassInfo> list = new List<GoodsClassInfo>();
            DataTable dt = GoodsClassData.GetGoodsClassListData();
            if (dt != null && dt.Rows.Count > 0)
            {
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    GoodsClassInfo info = new GoodsClassInfo();
                    info.gcid = TypeConverter.ObjectToInt(dr["gcid"]);
                    info.name = dr["name"].ToString().Trim();
                    info.orderint = TypeConverter.ObjectToInt(dr["orderint"]);  
                    list.Add(info);
                }
            }

            return list;
        }

        /// <summary>
        /// 从缓存中取出列表数据
        /// </summary>
        /// <returns></returns>
        public static List<GoodsClassInfo> GetGoodsClassList(bool IsCache)
        {
            List<GoodsClassInfo> list = null;
            if (IsCache)
            {
                string key = CacheKeys.GOODS_CLASS;
                if (CacheUtil.IsExist(key))
                {
                    list = (List<GoodsClassInfo>)CacheUtil.Read(key);

                }
                else
                {
                    list = GetGoodsClassListData();
                    CacheUtil.Insert(key, list, (double)CacheMin.Ninety);
                }
            }
            else
            {
                list = GetGoodsClassListData();
            }
            return list;
        }

        /// <summary>
        /// 某条分类信息
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        public static GoodsClassInfo GetGoodsClassInfo(int gcid, bool IsCache)
        {
            List<GoodsClassInfo> list = GetGoodsClassList(IsCache);
            GoodsClassInfo info = new GoodsClassInfo();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].gcid == gcid)
                    return list[i];
            }
            return info;
        }
        
        /// <summary>
        /// 删除分类
        /// </summary>
        /// <param name="nid"></param>
        public static void DeleteGoodsClassInfo(string gcid)
        {
            GoodsClassData.DeleteGoodsClassInfo(gcid);
        }

        /// <summary>
        /// 生成/更新专题信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateGoodsClassInfo(GoodsClassInfo info)
        {
            int i = 0;
            i = GoodsClassData.CreateGoodsClassInfo(info);
            return i;
        }
    }
}
