using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;


namespace DataProvider
{
    /// <summary>
    /// 商品(Goods)的数据库处理类
    /// </summary>
    public class UserData : DataConnection
    {
        /// <summary>
        /// 单个用户论坛数据
        /// </summary>
        /// <returns></returns>
        public static DataRow GetUserInfoData(int uid)
        {
            return SqlHelper.ExecuteDatarow(connstrbbs, "dnt_getuserinfo", uid);
        }
    }
}
