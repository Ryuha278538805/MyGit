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
    /// 商品的业务处理类
    /// simwon
    /// </summary>
    public class Goods
    {
        /// <summary>
        /// 单个商品
        /// </summary>
        /// <returns></returns>
        public static GoodsInfo GetGoodsInfo(int gid)
        {
            GoodsInfo info = new GoodsInfo();
            DataTable dt = GoodsData.GetGoodsInfoData(gid);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                info.gid = TypeConverter.ObjectToInt(dr["gid"]);
                info.about = dr["about"].ToString().Trim();
                info.aboutshort = dr["aboutshort"].ToString().Trim();
                info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
                info.codes = dr["codes"].ToString().Trim();
                info.codeslist = dr["codes"].ToString().Trim().Split('|');
                info.codesselled = dr["codesselled"].ToString().Trim();
                info.codesselledlist = dr["codesselled"].ToString().Trim().Split('|');
                info.count = TypeConverter.ObjectToInt(dr["count"]);
                info.countselled = TypeConverter.ObjectToInt(dr["countselled"]);
                info.gcid = TypeConverter.ObjectToInt(dr["gcid"]);
                info.gettime = dr["gettime"].ToString().Trim();
                info.gname = dr["gname"].ToString().Trim();
                info.hits = TypeConverter.ObjectToInt(dr["hits"]);
                info.img = dr["img"].ToString().Trim();
                info.isautopost = TypeConverter.ObjectToBool(dr["isautopost"]);
                info.iseveryday = TypeConverter.ObjectToBool(dr["iseveryday"]);
                info.issell = TypeConverter.ObjectToBool(dr["issell"]);
                info.needpost = TypeConverter.ObjectToBool(dr["needpost"]);
                info.payextcredits = TypeConverter.ObjectToInt(dr["payextcredits"]);
                info.score = TypeConverter.ObjectToInt(dr["score"]);
            }
            return info;
        }

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="gid"></param>
        public static void DeleteGoodsInfo(string gid)
        {
            GoodsData.DeleteGoodsInfo(gid);
        }

        /// <summary>
        /// 生成/更新商品信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateGoodsInfo(GoodsInfo info)
        {
            int i = 0;
            i = GoodsData.CreateGoodsInfo(info);
            return i;
        }
    }
}
