using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    ///  开奖号P3数据操作
    ///  对应表tgl_p3
    /// </summary>
   public class KjhP3Data:DataConnection
   { 
       /// <summary>
       /// 删除P3开奖号
       /// </summary>
       /// <param name="id"></param>
       public static void DeleteKjhP3Info(string id)
       {
           SqlHelper.ExecuteNonQuery(connstrkjh, "sp_delete_p3", id);
       }

       /// <summary>
       /// 生成/更新P3信息
       /// </summary>
       /// <param name="info"></param>
       /// <returns></returns>
       public static int CreateKjhP3Info(KjhP3Info info)
       {
           int i = 0;
           i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstrkjh, "sp_create_p3", info.id, info.qi, info.a, info.b, info.c, info.d, info.e, 
               info.zj1, info.zj2, info.zj3, info.zjp5, info.sjh, info.sjhtype, info.tzmoney, info.tzmoneyp5, info.date));
           return i;
       }
   }
}
