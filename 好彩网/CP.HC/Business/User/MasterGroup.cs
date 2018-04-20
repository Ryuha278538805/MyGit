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
    /// 后台管理员用户组
    /// 事务类
    /// </summary>
    public class MasterGroup
    {
        /// <summary>
        /// 用户组数据
        /// </summary>
        /// <returns></returns>
        private static List<MasterGroupInfo> GetMasterGroupData()
        {
            List<MasterGroupInfo> list = new List<MasterGroupInfo>();
            DataTable dt = MasterGroupData.GetMasterGroupList();
            if (dt != null && dt.Rows.Count > 0)
            {
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    MasterGroupInfo info = new MasterGroupInfo();

                    DataRow dr = dt.Rows[i];
                    info.groupid = Convert.ToInt32(dr["groupid"]);
                    info.name = dr["name"].ToString().Trim();
                    info.allowpub = Convert.ToInt32(dr["allowpub"]);
                    info.allowpages = Convert.ToInt32(dr["allowpages"]);
                    info.allowuser = Convert.ToInt32(dr["allowuser"]);
                    info.allowconfig = Convert.ToInt32(dr["allowconfig"]);
                    info.allowadvert = Convert.ToInt32(dr["allowadvert"]);
                    list.Add(info);
                }
            }

            return list;
        }


        /// <summary>
        /// 缓存中取数据
        /// </summary>
        /// <returns></returns>
        public static List<MasterGroupInfo> GetMasterGroupList(bool IsCache)
        {
            List<MasterGroupInfo> list = new List<MasterGroupInfo>();
            if (IsCache)
            {
                string key = CacheKeys.MASTERGROUP;
                if (CacheUtil.IsExist(key))
                {
                    list = (List<MasterGroupInfo>)CacheUtil.Read(key);
                }
                else
                {
                    list = GetMasterGroupData();
                    CacheUtil.Insert(key, list, (double)CacheMin.Sixty);
                }
            }
            else
            {
                list = GetMasterGroupData();
            }
            return list;
        }


        /// <summary>
        /// 取某一用户组的数据
        /// </summary>
        /// <param name="groupid"></param>
        /// <returns></returns>
        public static MasterGroupInfo GetMasterGroupInfo(int groupid, bool IsCache)
        {
            MasterGroupInfo info = new MasterGroupInfo();
            List<MasterGroupInfo> list = GetMasterGroupList(IsCache);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].groupid == groupid)
                {
                    info = list[i];
                    break;
                }

            }
            return info;

        }

        /// <summary>
        /// 删除管理组信息
        /// </summary>
        /// <param name="groupid"></param>
        public static void DeleteMasterGroupInfo(string groupid)
        {
            MasterGroupData.DeleteMasterGroupInfo(groupid);
        }

        /// <summary>
        /// 生成/更新管理组信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateMasterGroupInfo(MasterGroupInfo info)
        {
            int i = 0;
            i = MasterGroupData.CreateMasterGroupInfo(info);
            return i;
        }
    }
}
