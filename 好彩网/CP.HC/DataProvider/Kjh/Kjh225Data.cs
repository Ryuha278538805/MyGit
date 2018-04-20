using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    ///  开奖号225数据操作
    ///  对应表tgl_225
    /// </summary>
    public class Kjh225Data : DataConnection
    {
        /// <summary>
        /// 删除开奖号
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteKjh225Info(string id)
        {
            SqlHelper.ExecuteNonQuery(connstrkjh, "sp_delete_225", id);
        }

        /// <summary>
        /// 生成/更新专题信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateKjh225Info(Kjh225Info info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstrkjh, "sp_create_225", info.id, info.qi, info.a, info.b, info.c, info.d, info.e, info.zj1,info.zj2, info.zj3,info.prize1, info.prize2, info.prize3, info.tzmoney, info.nextmoney, info.date ));
            return i;
        }
    }
}
