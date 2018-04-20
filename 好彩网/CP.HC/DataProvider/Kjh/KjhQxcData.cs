using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    ///  开奖号七星彩数据操作
    ///  对应表tgl_qxc
    /// </summary>
    public class KjhQxcData : DataConnection
    {
        /// <summary>
        /// 删除七星彩开奖号
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteKjhQxcInfo(string id)
        {
            SqlHelper.ExecuteNonQuery(connstrkjh, "sp_delete_qxc", id);
        }

        /// <summary>
        /// 生成/更新七星彩信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateKjhQxcInfo(KjhQxcInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstrkjh, "sp_create_qxc", info.id, info.qi, info.a, info.b, info.c, info.d, info.e, info.f, info.g,
                info.zj1, info.jo1, info.zj2,info.jo2, info.zj3, info.zj4, info.zj5, info.zjt, info.jot,info.tzmoney, info.nextmoney,info.date));
            return i;
        }
    }
}
