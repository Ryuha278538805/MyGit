using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    /// 预测内容数据操作类
    /// </summary>
    public class YcZoneData : DataConnection
    {
        /// <summary>
        /// 得到全部专题
        /// </summary>
        /// <returns></returns>
        public static DataTable GetYcZoneListData()
        {
            return SqlHelper.ExecuteDatatable(connstr, "sp_st_yczonelist");
        }

        /// <summary>
        /// 获取单一专题
        /// </summary>
        /// <returns></returns>
        public static DataRow GetYcZoneInfoData(int yzid)
        {
            return SqlHelper.ExecuteDatarow(connstr, "sp_st_yczoneinfo", yzid);
        }

        /// <summary>
        /// 删除专题
        /// </summary>
        /// <param name="zid"></param>
        public static void DeleteYcZoneInfo(string yzid)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_delete_yczone", yzid);
        }

        /// <summary>
        /// 生成/更新专题信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateYcZoneInfo(YcZoneInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstr, "sp_create_yczoneinfo", info.yzid, info.name, info.czid, info.type, info.isautowrite, info.keywords,info.description, info.titlemodel, info.contextmodel, info.contexthead, info.contextend, info.orderint, info.lastqi));
            return i;
        }
    }
}
