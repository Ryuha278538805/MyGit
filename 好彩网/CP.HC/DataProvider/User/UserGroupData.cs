using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataProvider
{
    public class UserGroupData : DataConnection
    {
        /// <summary>
        /// 得到全部用户组
        /// </summary>
        /// <returns></returns>
        public static DataTable GetUserGroupListData()
        {
            return SqlHelper.ExecuteDatatable(connstrbbs, "sp_st_usergroups");
        }
    }
}
