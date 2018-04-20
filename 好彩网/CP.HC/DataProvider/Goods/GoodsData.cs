using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    /// 商品(Goods)的数据库处理类
    /// </summary>
    public class GoodsData : DataConnection
    {
        /// <summary>
        /// 单个商品数据
        /// </summary>
        /// <returns></returns>
        public static DataTable GetGoodsInfoData(int gid)
        {
                return SqlHelper.ExecuteDatatable(connstrbbs, "sp_st_goods", gid);
        }

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="cid"></param>
        public static void DeleteGoodsInfo(string gid)
        {
            SqlHelper.ExecuteNonQuery(connstrbbs, "sp_del_goods", gid);
        }

        /// <summary>
        /// 生成/更新商品信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateGoodsInfo(GoodsInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstrbbs, "sp_create_goods", info.gid, info.gcid, info.gname, info.img, info.codes, info.codesselled, info.aboutshort, info.about, info.count, info.countselled, info.payextcredits, info.score, info.issell, info.isautopost, info.iseveryday, info.needpost, info.gettime));
            return i;
        }
    }
}
