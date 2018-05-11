using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    public class AdData : DataConnection
    {

        /// <summary>
        /// 得到全部广告
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAdDataListData()
        {
            return SqlHelper.ExecuteDatatable(connstr, "sp_st_ad");
        }

        /// <summary>
        /// 删除广告
        /// </summary>
        /// <param name="zid"></param>
        public static void DeleteAdDataInfo(string id)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_delete_adinfo", id);
        }

        /// <summary>
        /// 生成/更新广告信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateAdDataInfo(ADmanagerInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstr, "sp_create_adinfo", info.id, info.title, info.link, info.source,info.PositonType, info.sort));
            return i;
        }
    }
}
