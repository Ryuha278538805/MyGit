using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 在线用户模型类
    /// </summary>
    public class UserOnlineInfo
    { 
        /// <summary>
        /// 编号
        /// </summary>
        public int olid { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int userid { get; set; }


        /// <summary>
        /// IP地址
        /// </summary>
        public string ip { get; set; }


        /// <summary>
        /// 用户登录名
        /// </summary>
        public string username { get; set; }


        /// <summary>
        /// 用户昵称
        /// </summary>
        public string nickname { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// 用户组ID
        /// </summary>
        public int groupid { get; set; }

        /// <summary>
        /// 对应的在线图例
        /// </summary>
        public string olimg { get; set; }

        /// <summary>
        /// 管理组ID
        /// </summary>
        public int adminid { get; set; }

        /// <summary>
        /// 用户是否隐身
        /// </summary>
        public int invisible { get; set; }

        /// <summary>
        /// 操作
        /// </summary>
        public int action { get; set; }

        /// <summary>
        /// 上一次所在的位置或所做的动作
        /// </summary>
        public int lastactivity { get; set; }

        /// <summary>
        /// 最后一次发帖时间（日期型）
        /// </summary>
        public DateTime lastposttime { get; set; }

        /// <summary>
        /// 最后一次发送短消息时间（日期型）
        /// </summary>
        public DateTime lastpostpmtime { get; set; }

        /// <summary>
        /// 最后一次搜索时间（日期型）
        /// </summary>
        public DateTime lastsearchtime { get; set; }

        /// <summary>
        /// 最后一次修改时间（日期型） 
        /// </summary>
        public DateTime lastupdatetime { get; set; }

        /// <summary>
        /// 最后一次所在的论坛主题ID
        /// </summary>
        public int forumid { get; set; }

        /// <summary>
        /// 最后一次所在论坛名称
        /// </summary>
        public string forumname { get; set; }

        /// <summary>
        /// 最后一次所在的论坛主题ID 
        /// </summary>
        public int titleid { get; set; }

        /// <summary>
        /// 最后一次所在的论坛帖子名称 
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 验证码 
        /// </summary>
        public string verifycode { get; set; }

        /// <summary>
        /// 新短消息数 
        /// </summary>
        public int newpms { get; set; }

        /// <summary>
        /// 新通知数 
        /// </summary>
        public int newnotices { get; set; }
    }
}
