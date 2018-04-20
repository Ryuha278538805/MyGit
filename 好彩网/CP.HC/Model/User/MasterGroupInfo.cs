using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   /// <summary>
   /// 后台用户组
   /// 描述类
   /// </summary>
    public class MasterGroupInfo
    {

        /// <summary>
        /// 用户组id
        /// </summary>
        public int groupid { get; set; }

        /// <summary>
        /// 用户组名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 发布权限
        /// </summary>
        public int allowpub { get; set; }


        /// <summary>
        /// 推荐的权限
        /// </summary>
        public int allowpages { get; set; }


        /// <summary>
        /// 广告管理的权限
        /// </summary>
        public int allowadvert { get; set; }


        /// <summary>
        /// 管理用户的权限
        /// </summary>
        public int allowuser { get; set; }


        /// <summary>
        /// 系统配置的权限
        /// 如分类调整,Cache管理,专题调整等...
        /// </summary>
        public int allowconfig { get; set; }

    }
}
