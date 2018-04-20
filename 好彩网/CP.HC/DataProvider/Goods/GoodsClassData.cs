using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    /// 商品分类(GoodsClass)的数据库处理类
    /// </summary>
    public class GoodsClassData : DataConnection
    {
        /// <summary>
        /// 所有分类数据
        /// </summary>
        /// <returns></returns>
        public static DataTable GetGoodsClassListData()
        {
            return SqlHelper.ExecuteDatatable(connstrbbs, "sp_st_goods_class");
        }

        /// <summary>
        /// 删除分类
        /// </summary>
        /// <param name="cid"></param>
        public static void DeleteGoodsClassInfo(string cid)
        {
            SqlHelper.ExecuteNonQuery(connstrbbs, "sp_del_goods_class", cid);
        }

        /// <summary>
        /// 生成/更新分类信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateGoodsClassInfo(GoodsClassInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstrbbs, "sp_create_goods_class", info.gcid, info.name, info.orderint));
            return i;
        }
    }
}
