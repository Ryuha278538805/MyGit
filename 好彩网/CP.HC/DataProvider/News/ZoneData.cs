using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    /// 专题相类的数据为操作类
    /// 对应表tbl_zone
    /// </summary>
    public class ZoneData : DataConnection
    { 
        /// <summary>
        /// 得到全部专题
        /// </summary>
        /// <returns></returns>
        public static DataTable GetZoneListData()
        {
            return   SqlHelper.ExecuteDatatable(connstr, "sp_st_zone");
        }

        /// <summary>
        /// 某分类最新期添加过的专题
        /// </summary>
        /// <returns></returns>
        public static DataTable GetZoneListData(int cid)
        {
            return SqlHelper.ExecuteDatatable(connstr, "sp_st_zone_everqi", cid);
        }

        /// <summary>
        /// 某分类添加过模板的专题
        /// </summary>
        /// <returns></returns>
        public static DataTable GetZoneListTempAddedData(int cid)
        {
            return SqlHelper.ExecuteDatatable(connstr, "sp_st_zone_templet", cid);
        }

        /// <summary>
        /// 删除专题
        /// </summary>
        /// <param name="zid"></param>
        public static void DeleteZoneInfo(string zid)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_delete_zoneinfo", zid);
        }

        /// <summary>
        /// 生成/更新专题信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateZoneInfo(ZoneInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstr, "sp_create_zoneinfo", info.zid, info.name, info.cid, info.orderint, info.keywords, info.description));
            return i;
        }
    }
}
