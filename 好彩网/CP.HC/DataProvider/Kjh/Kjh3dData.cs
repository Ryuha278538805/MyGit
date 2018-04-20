using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    ///  开奖号3D数据操作
    ///  对应表tgl_3d
    /// </summary>
    public class Kjh3dData : DataConnection
    {
        /// <summary>
        /// 删除开奖号
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteKjh3dInfo(string id)
        {
            SqlHelper.ExecuteNonQuery(connstrkjh, "sp_delete_3d", id);
        }

        /// <summary>
        /// 生成3D开奖号信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateKjh3dInfo(Kjh3dInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstrkjh, "sp_create_3d", info.qi, info.kjih, info.date));
            return i;
        }

        /// <summary>
        /// 生成/更新3D开奖号全部信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateKjh3dAllInfo(Kjh3dInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstrkjh, "sp_create_3dall", info.id, info.qi, info.a, info.b, info.c,info.zj1, info.zj2, info.zj3,info.sjh,
                info.sjx,info.kjih,info.tzmoney, info.date));
            return i;
        }
    }
}
