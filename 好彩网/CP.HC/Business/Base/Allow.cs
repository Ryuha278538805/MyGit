using System;
using System.Collections.Generic;
using System.Text;
using Common;
using Model;

namespace Business
{
    /// <summary>
    /// 后台用户权限操作类
    /// </summary>
    public class Allow
    {
        private MasterUserInfo userinfo;
        private MasterGroupInfo ug;

        public Allow(int uid)
        {
            userinfo = MasterUser.GetMasterInfo(uid,false);
            ug = MasterGroup.GetMasterGroupInfo(userinfo.groupid, false);
        }

        /// <summary>
        /// 发布权限
        /// </summary>
        public bool AllowPub
        {
            get { return ug.allowpub > 0 ? true : false; }
        }

        /// <summary>
        /// 推荐权限
        /// </summary>
        public bool AllowPage
        {
            get { return ug.allowpages > 0 ? true : false; }
        }

        /// <summary>
        /// 管理用户的权限
        /// </summary>
        public bool AllowUser
        {
            get { return ug.allowuser > 0 ? true : false; }
        }

        /// <summary>
        /// 配置数据的权限
        /// </summary>
        public bool AllowConfig
        {
            get { return ug.allowconfig > 0 ? true : false; }
        }

        /// <summary>
        /// 管理广告的权限
        /// </summary>
        public bool AllowAdvert
        {
            get { return ug.allowadvert > 0 ? true : false; }
        }
    }
}
