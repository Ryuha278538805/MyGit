using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    ///  开奖号七乐彩数据操作
    ///  对应表tgl_qlc
    /// </summary>
    public class KjhQlcData : DataConnection
    {
        /// <summary>
        /// 删除七乐彩开奖号
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteKjhQlcInfo(string id)
        {
            SqlHelper.ExecuteNonQuery(connstrkjh, "sp_delete_qlc", id);
        }

        /// <summary>
        /// 生成/更新七乐彩信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateKjhQlcInfo(KjhQlcInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstrkjh, "sp_create_qlc", info.id, info.qi, info.a, info.b, info.c, info.d, info.e, info.f, info.g,info.h,
                info.zjt, info.zj1, info.zj2, info.zj3, info.zj4, info.zj5, info.zj6, info.zj7, info.jot, info.jo1, info.jo2, info.jo3,
                info.tzmoney, info.nextmoney, info.date));
            return i;
        }
    }
}
