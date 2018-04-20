using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    ///  开奖号大乐透数据操作
    ///  对应表tgl_dlt
    /// </summary>
    public class KjhDltData : DataConnection
    {
        /// <summary>
        /// 删除大乐透开奖号
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteKjhDltInfo(string id)
        {
            SqlHelper.ExecuteNonQuery(connstrkjh, "sp_delete_dlt", id);
        }

        /// <summary>
        /// 生成/更新大乐透信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateKjhDltInfo(KjhDltInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstrkjh, "sp_create_dlt", info.id, info.qi, info.a, info.b, info.c, info.d, info.e, info.f, info.g,
                info.zj1, info.zj2, info.zj3,info.zj4,info.zj5,info.zj6,info.zj7,info.zj8, info.jo1, info.jo2, info.jo3, 
                info.zzj1,info.zzj2,info.zzj3,info.zzj4,info.zzj5,info.zzj6,info.zzj7,info.zjo1,info.zjo2,info.zjo3,info.fjzj,info.tzmoney,info.nextmoney,info.fjtzmoney,info.fjnextmoney,
                info.cc, info.date));
            return i;
        }
    }
}
