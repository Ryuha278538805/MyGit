using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    /// 论坛在线用户的数据库处理类
    /// </summary>
    public class UserOnlineData : DataConnection
    {
        /// <summary>
        /// 单个在线用户论坛数据
        /// </summary>
        /// <returns></returns>
        public static DataRow GetUserOnlineInfoData(int uid, string password)
        {
            return SqlHelper.ExecuteDatarow(connstrbbs, "dnt_getonlineuser", uid , password);
        }
    }
}
