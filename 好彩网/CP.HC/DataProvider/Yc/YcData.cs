using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    /// 预测专题数据操作类
    /// </summary>
    public class YcData : DataConnection
    {
        /// <summary>
        /// 获取单一预测信息
        /// </summary>
        /// <returns></returns>
        public static DataRow GetYcInfoByYidData(int yid)
        {
            return SqlHelper.ExecuteDatarow(connstr, "sp_st_ycinfo", yid);
        }

        /// <summary>
        /// 获取单一未验证的预测信息
        /// </summary>
        /// <returns></returns>
        public static DataRow GetYcInfoNoChkTop1ByYzidData(int yzid)
        {
            return SqlHelper.ExecuteDatarow(connstr, "sp_st_ycinfo_nochk_top1_yzid", yzid);
        }


        /// <summary>
        /// 获取最新已验证的预测信息
        /// </summary>
        /// <returns></returns>
        public static DataRow GetYcInfoChkTop1ByYzidData(int yzid)
        {
            return SqlHelper.ExecuteDatarow(connstr, "sp_st_ycinfo_chk_top1_yzid", yzid);
        }

        /// <summary>
        /// 得到某专题前15个预测信息
        /// </summary>
        /// <returns></returns>
        public static DataTable GetYcInfoTop15ByYZidData(int yzid)
        {
            return SqlHelper.ExecuteDatatable(connstr, "sp_st_ycinfo_top15_yzid", yzid);
        }

        /// <summary>
        /// 得到当前期的前15个预测信息
        /// </summary>
        /// <returns></returns>
        public static DataTable GetYcInfoTop15ByYidData(int yid)
        {
            return SqlHelper.ExecuteDatatable(connstr, "sp_st_ycinfo_top15", yid);
        }

        /// <summary>
        /// 删除预测信息
        /// </summary>
        /// <param name="zid"></param>
        public static void DeleteYcInfo(string yid)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_delete_ycinfo", yid);
        }

        /// <summary>
        /// 更新预测信息点击
        /// </summary>
        /// <param name="zid"></param>
        public static void UpdateYcInfoHits(string yid)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_ychits", yid);
        }

        /// <summary>
        /// 生成/更新预测信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateYcInfo(YcInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstr, "sp_create_ycinfo", info.yid, info.yzid, info.qi, info.info, info.kjh, info.isright, info.title, info.context));
            return i;
        }
    }
}
