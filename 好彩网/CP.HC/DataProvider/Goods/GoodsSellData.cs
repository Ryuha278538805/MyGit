using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    /// 商品销售记录(GoodsSelled)的数据库处理类
    /// </summary>
    public class GoodsSellData : DataConnection
    {
        /// <summary>
        /// 单个商品销售记录
        /// </summary>
        /// <returns></returns>
        public static DataTable GetGoodsSellInfoData(int sid)
        {
            return SqlHelper.ExecuteDatatable(connstrbbs, "sp_st_goods_sell", sid);
        }


        /// <summary>
        /// 某个商品 某个用户的最新购买记录
        /// </summary>
        /// <returns></returns>
        public static DataRow GetGoodsSellInfoData(int gid, string username)
        {
            return SqlHelper.ExecuteDatarow(connstrbbs, "sp_st_goods_sell_user", gid, username);
        }

        /// <summary>
        /// 某个用户的全部记录
        /// </summary>
        /// <returns></returns>
        public static DataTable GetGoodsSellInfoData(string username)
        {
            return SqlHelper.ExecuteDatatable(connstrbbs, "sp_st_goods_sell_userall", username);
        }
        

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="cid"></param>
        public static void DeleteGoodsSellInfo(string sid)
        {
            SqlHelper.ExecuteNonQuery(connstrbbs, "sp_del_goods_sell", sid);
        }


        /// <summary>
        /// 生成/更新商品信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateGoodsSellInfo(GoodsSellInfo info, GoodsInfo ginfo)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstrbbs, "sp_create_goods_sell", info.sid, info.gid, info.username, info.codes, info.postaddress, info.postno, info.postname, info.posttel, info.isposted, info.postmethod, info.postcode, ginfo.payextcredits, ginfo.score, ginfo.codes, ginfo.codesselled));
            return i;
        }
    }
}
