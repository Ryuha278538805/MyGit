using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using DataProvider;
using Common;

namespace Business
{
    /// <summary>
    /// 用户组事务处理类
    /// </summary>
    public class UserGroup
    {
        public static List<UserGroupInfo> GetUserGroupListData()
        {
            List<UserGroupInfo> list = new List<UserGroupInfo>();
            DataTable dt = UserGroupData.GetUserGroupListData();

            if (dt != null && dt.Rows.Count > 0)
            {
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    UserGroupInfo info = new UserGroupInfo();
                    DataRow dr = dt.Rows[i];
                    info.groupid = TypeConverter.ObjectToInt(dr["groupid"]);
                    info.grouptitle = dr["grouptitle"].ToString().Trim();
                    info.groupavatar = dr["groupavatar"].ToString().Trim();
                    list.Add(info);
                }
            }

            return list;
        }

        /// <summary>
        /// 缓存中取用户组数据
        /// </summary>
        /// <returns></returns>
        public static List<UserGroupInfo> GetUserGroupList(bool IsCache)
        {
            List<UserGroupInfo> list = null;
            if (IsCache)
            {
                string key = CacheKeys.USERGROUP;
                if (CacheUtil.IsExist(key))
                {
                    list = (List<UserGroupInfo>)CacheUtil.Read(key);
                }
                else
                {
                    list = GetUserGroupListData();
                    CacheUtil.Insert(key, list, (double)CacheMin.Ten);
                }
            }
            else
            {
                list = GetUserGroupListData();
            }
            return list;
        }


        /// <summary>
        /// 某用户组的信息
        /// </summary>
        /// <param name="zid"></param>
        /// <returns></returns>
        public static UserGroupInfo GetUserGroupInfo(int groupid, bool IsCache)
        {
            List<UserGroupInfo> list = GetUserGroupList(IsCache);
            UserGroupInfo info = new UserGroupInfo();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].groupid == groupid)
                    return list[i];
            }
            return info;
        }

    }
}
