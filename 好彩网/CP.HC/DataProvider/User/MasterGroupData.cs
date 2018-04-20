using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    /// 后台用户组数据库操作类
    /// simwon
    /// </summary>
    public  class MasterGroupData:DataConnection
    {
        /// <summary>
        /// 取后台用户组的所有数据
        /// </summary>
        /// <returns></returns>
        public static DataTable GetMasterGroupList()
        {
            return SqlHelper.ExecuteDatatable(connstr, "sp_st_mastergroup");
        }

        /// <summary>
        /// 后台生成/更新管理组信息
        /// </summary>
        /// <param name="info"></param>
        public static int CreateMasterGroupInfo(MasterGroupInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteNonQuery(connstr, "sp_create_mastergroup", info.groupid, info.name, info.allowpub, info.allowpages, info.allowadvert, info.allowuser, info.allowconfig));
            return i;
        }

        /// <summary>
        /// 删除管理组信息
        /// </summary>
        /// <param name="uid"></param>
        public static void DeleteMasterGroupInfo(string groupid)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_delete_mastergroup", groupid);
        }
    }
}
