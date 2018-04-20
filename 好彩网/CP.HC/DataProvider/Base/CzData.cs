using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    public class CzData:DataConnection
    {

        /// <summary>
        /// 得到全部彩种
        /// </summary>
        /// <returns></returns>
        public static DataTable GetCzListData()
        {
            return SqlHelper.ExecuteDatatable(connstr, "sp_st_cz");
        }

        /// <summary>
        /// 删除彩种
        /// </summary>
        /// <param name="zid"></param>
        public static void DeleteCzInfo(string czid)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_delete_czinfo", czid);
        }

        /// <summary>
        /// 生成/更新彩种信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateCzInfo(CzInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstr, "sp_create_czinfo", info.czid, info.czname, info.shortname, info.qi));
            return i;
        }

        /// <summary>
        /// 批量更新彩种期数 +1
        /// </summary>
        /// <param name="czids"></param>
        public static void UpdateCzQi(string czids)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_czqi", czids);
        }

        /// <summary>
        /// 开奖号获取最新一期期号
        /// </summary>
        /// <param name="cz"></param>
        public static int GetNewQi(int cz)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstrkjh, "sp_st_getnewqi", cz));
            return i;
        }

          /// <summary>
        /// 开奖号获取当前最大期号
        /// </summary>
        /// <param name="cz"></param>
        public static int GetMaxQi(int cz)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstrkjh, "sp_st_getmaxqi", cz));
            return i;
        } 

    }
}
