using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    ///  开奖号双色球数据操作
    ///  对应表tgl_ssq
    /// </summary>
    public class KjhSsqData : DataConnection
    {
        /// <summary>
        /// 删除双色球开奖号
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteKjhSsqInfo(string id)
        {
            SqlHelper.ExecuteNonQuery(connstrkjh, "sp_delete_ssq", id);
        }

        /// <summary>
        /// 生成/更新双色球信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateKjhSsqInfo(KjhSsqInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstrkjh, "sp_create_ssq", info.id, info.qi, info.a, info.b, info.c, info.d, info.e, info.f, info.g,info.h,
                info.zj1, info.zj2, info.zj3, info.zj4, info.zj5, info.zj6, info.zj7, info.jo1, info.jo2, info.cc, info.tzmoney, info.nextmoney, info.date));
            return i;
        }
    }
}
