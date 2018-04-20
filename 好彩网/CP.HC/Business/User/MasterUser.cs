using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using DataProvider;
using Common;

namespace Business
{
    public class MasterUser
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static MasterUserInfo GetMasterLogin(MasterUserInfo user)
        {
            DataRow dr = MasterUserData.GetMasterLogin(user.username,user.password);
            MasterUserInfo info = new MasterUserInfo();
            if (dr != null)
            {
                info.uid = TypeConverter.ObjectToInt(dr["uid"]);
                info.username = dr["username"].ToString().Trim();
                info.nickname = dr["nickname"].ToString().Trim();
                info.groupid = TypeConverter.ObjectToInt(dr["groupid"]);
            }
            return info;
        }

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        public static List<MasterUserInfo> GetMasterListData()
        {
            DataTable dt = MasterUserData.GetMasterList();
            List<MasterUserInfo> list = new List<MasterUserInfo>();
            if (dt != null && dt.Rows.Count > 0)
            {
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    MasterUserInfo info = new MasterUserInfo();
                    info.uid = TypeConverter.ObjectToInt(dr["uid"]);
                    info.username = dr["username"].ToString().Trim();
                    info.nickname = dr["nickname"].ToString().Trim();
                    info.password = dr["password"].ToString().Trim();
                    info.groupid = TypeConverter.ObjectToInt(dr["groupid"]);
                    info.logintimes = TypeConverter.ObjectToInt(dr["logintimes"]);
                    info.lastlogintime = TypeConverter.ObjectToDateTime(dr["lastlogintime"]);
                    info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
                    list.Add(info);
                }

            }
            return list;
        }
        

        /// <summary>
        /// 从缓存中取数据
        /// </summary>
        /// <returns></returns>
        public static List<MasterUserInfo> GetMasterList(bool IsCache)
        {            
            List<MasterUserInfo> list = new List<MasterUserInfo>();
            if (IsCache)
            {
                string key = CacheKeys.MASTER;
                if (CacheUtil.IsExist(key))
                {
                    list = (List<MasterUserInfo>)CacheUtil.Read(key);
                }
                else
                {
                    list = GetMasterListData();
                    if (list.Count > 0)
                        CacheUtil.Insert(key, list, (double)CacheMin.Sixty);
                }
            }
            else
            {
                list = GetMasterListData();
            }
            return list;
        }

        /// <summary>
        /// 根据aid，取某个用户的信息
        /// </summary>
        /// <param name="aid"></param>
        /// <returns></returns>
        public static MasterUserInfo GetMasterInfo(int uid, bool IsCache)
        {
            List<MasterUserInfo> list = GetMasterList(IsCache);
            MasterUserInfo info = new MasterUserInfo();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].uid == uid)
                {
                    info = list[i];
                    break;
                }
            }
            return info;
        }

        /// <summary>
        /// 根据Aid取管理员名字
        /// </summary>
        /// <param name="aid"></param>
        /// <returns></returns>
        public static string GetMasterName(int uid, bool IsCache)
        {
            if (uid > 0)
            {
                MasterUserInfo info = GetMasterInfo(uid, IsCache);
                if (!string.IsNullOrEmpty(info.username))
                {
                    return info.username;
                }
                else
                {
                    return "找不到Master";
                }
            }
            else
            {
                return "uid = 0";
            }
        }

        /// <summary>
        /// 方法重载
        /// </summary>
        /// <param name="aid"></param>
        /// <returns></returns>
        public static string GetMasterName(object uid)
        {
            int _uid = Common.TypeConverter.ObjectToInt(uid);
            return GetMasterName(_uid);
        }


        /// <summary>
        /// 删除管理人员
        /// </summary>
        /// <param name="uid"></param>
        public static void DeleteMasterInfo(string uid)
        {
            MasterUserData.DeleteMasterInfo(uid);
        }

        /// <summary>
        /// 生成/更新管理人员信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateMasterInfo(MasterUserInfo info)
        {
            int i = 0;
            i = MasterUserData.CreateMasterInfo(info);
            return i;
        }

        //end

    }
}
