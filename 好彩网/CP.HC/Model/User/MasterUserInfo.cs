using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 后台用户
    ///  信息描述类
    /// </summary>
    public class MasterUserInfo
    {
        /// <summary>
        /// 用户uid
        /// </summary>
        public int uid { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string nickname { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// 用户组id
        /// </summary>
        public int groupid { get; set; }


        /// <summary>
        /// 登录次数
        /// </summary>
        public int logintimes { get; set; }

        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime lastlogintime { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime addtime { get; set; }
    }
}
