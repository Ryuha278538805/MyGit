using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    // <summary>
    /// 后台用户数据库操作类
    /// simwon
    /// </summary>
    public class MasterUserData : DataConnection
    {
        /// <summary>
        /// 取后台用户的所有数据
        /// </summary>
        /// <returns></returns>
        public static DataTable GetMasterList()
        {
            return SqlHelper.ExecuteDatatable(connstr, "sp_st_masterlist");
        }

        /// <summary>
        /// 后台用户登录数据
        /// </summary>
        /// <returns></returns>
        public static DataRow GetMasterLogin(string username, string password)
        {
            return SqlHelper.ExecuteDatarow(connstr, "sp_st_masterlogin", username, password); 
        }

        /// <summary>
        /// 更新用户密码
        /// </summary>
        /// <param name="password"></param>
        public static void UpdateMasterPassword(string password, int uid)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_masterpassword", password, uid);
        }

        /// <summary>
        /// 后台生成/更新用户信息
        /// </summary>
        /// <param name="info"></param>
        public static int CreateMasterInfo(MasterUserInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteNonQuery(connstr, "sp_create_master", info.uid, info.username, info.password, info.nickname, info.groupid));
            return i;
        }

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="uid"></param>
        public static void DeleteMasterInfo(string uid)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_delete_master", uid);
        }
    }
}
