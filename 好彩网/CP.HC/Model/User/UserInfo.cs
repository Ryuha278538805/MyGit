using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 用户简单模型类
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int uid { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string username { get; set; }


        /// <summary>
        /// 昵称
        /// </summary>
        public string nickname { get; set; }


        /// <summary>
        /// MD5密码
        /// </summary>
        public string password { get; set; }


        /// <summary>
        /// 安全提示问题(独立加密)
        /// </summary>
        public string secques { get; set; }

        /// <summary>
        /// spaceid
        /// </summary>
        public int spaceid { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int gender { get; set; }

        /// <summary>
        /// 管理组ID
        /// </summary>
        public int adminid { get; set; }

        /// <summary>
        /// 用户组ID
        /// </summary>
        public int groupid { get; set; }

        /// <summary>
        /// 用户组有效期
        /// </summary>
        public int groupexpiry { get; set; }

        /// <summary>
        /// 扩展用户组
        /// </summary>
        public string extgroupids { get; set; }

        /// <summary>
        /// 注册IP
        /// </summary>
        public string regip { get; set; }

        /// <summary>
        /// 注册日期
        /// </summary>
        public DateTime joindate { get; set; }

        /// <summary>
        /// 上次访问IP 
        /// </summary>
        public string lastip { get; set; }

        /// <summary>
        /// 上次访问时间
        /// </summary>
        public DateTime lastvisit { get; set; }

        /// <summary>
        /// 最后操作时间 
        /// </summary>
        public DateTime lastactivity { get; set; }

        /// <summary>
        /// 最后发贴时间 
        /// </summary>
        public DateTime lastpost { get; set; }

        /// <summary>
        /// 最后发贴ID 
        /// </summary>
        public int lastpostid { get; set; }

        /// <summary>
        /// 最后发贴标题 
        /// </summary>
        public string lastposttitle { get; set; }

        /// <summary>
        /// 发贴数 
        /// </summary>
        public int posts { get; set; }

        /// <summary>
        /// 精华贴数 
        /// </summary>
        public int digestposts { get; set; }

        /// <summary>
        /// 在线时间 
        /// </summary>
        public int oltime { get; set; }

        /// <summary>
        /// 页面浏览量 
        /// </summary>
        public int pageviews { get; set; }

        /// <summary>
        /// 积分数 
        /// </summary>
        public int credits { get; set; }

        /// <summary>
        /// 扩展积分1 
        /// </summary>
        public int extcredits1 { get; set; }

        /// <summary>
        /// 扩展积分2 
        /// </summary>
        public int extcredits2 { get; set; }

        /// <summary>
        /// 扩展积分3
        /// </summary>
        public int extcredits3 { get; set; }

        /// <summary>
        /// 扩展积分4 
        /// </summary>
        public int extcredits4 { get; set; }

        /// <summary>
        /// 扩展积分5
        /// </summary>
        public int extcredits5 { get; set; }

        /// <summary>
        /// 扩展积分6
        /// </summary>
        public int extcredits6 { get; set; }

        /// <summary>
        /// 扩展积分7 
        /// </summary>
        public int extcredits7 { get; set; }

        /// <summary>
        /// 扩展积分8 
        /// </summary>
        public int extcredits8 { get; set; }

        /// <summary>
        /// 头像ID 
        /// </summary>
        public int avatarshowid { get; set; }

        /// <summary>
        /// 邮件地址 
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 生日 
        /// </summary>
        public string bday { get; set; }

        /// <summary>
        /// 签名 
        /// </summary>
        public int sigstatus { get; set; }

        /// <summary>
        /// 每页主题数 
        /// </summary>
        public int tpp { get; set; }

        /// <summary>
        /// 每页贴数 
        /// </summary>
        public int ppp { get; set; }

        /// <summary>
        /// 风格ID 
        /// </summary>
        public int templateid { get; set; }

        /// <summary>
        /// 短消息铃声 
        /// </summary>
        public int pmsound { get; set; }

        /// <summary>
        /// 是否显示邮箱 
        /// </summary>
        public int showemail { get; set; }

        /// <summary>
        /// 是否隐身 
        /// </summary>
        public int invisible { get; set; }

        /// <summary>
        /// 是否有新消息 
        /// </summary>
        public int newpm { get; set; }

        /// <summary>
        /// 新短消息数量 
        /// </summary>
        public int newpmcount { get; set; }

        /// <summary>
        /// 是否使用特殊权限 
        /// </summary>
        public int accessmasks { get; set; }

        /// <summary>
        /// 在线状态, 1为在线, 0为不在线 
        /// </summary>
        public int onlinestate { get; set; }

        /// <summary>
        /// 新短消息 
        /// </summary>
        public int newsletter { get; set; }

        /// <summary>
        /// 二次MD5加密时用到的随机值 
        /// </summary>
        public string salt { get; set; }



        //以下为扩展数据

         /// <summary>
        /// 个人网站
        /// </summary>
        public string website { get; set; }

         /// <summary>
        /// Icq号码
        /// </summary>
        public string icq { get; set; }

         /// <summary>
        /// QQ号码 
        /// </summary>
        public string qq { get; set; }

         /// <summary>
        /// Yahoo通地址
        /// </summary>
        public string yahoo { get; set; }

         /// <summary>
        /// MSN地址
        /// </summary>
        public string msn { get; set; }

         /// <summary>
        /// Skype地址
        /// </summary>
        public string skype { get; set; }

         /// <summary>
        /// 来自
        /// </summary>
        public string location { get; set; }

         /// <summary>
        ///自定义头衔
        /// </summary>
        public string customstatus { get; set; }

         /// <summary>
        /// 用户头像
        /// </summary>
        public string avatar { get; set; }

        /// <summary>
        /// 头像宽度
        /// </summary>
        public int avatarwidth { get; set; }

        /// <summary>
        /// 头像高度
        /// </summary>
        public int avatarheight { get; set; }

        /// <summary>
        /// 所获勋章
        /// </summary>
        public string medals { get; set; }

        /// <summary>
        /// 个人简介
        /// </summary>
        public string bio { get; set; }

        /// <summary>
        /// 个人签名
        /// </summary>
        public string signature { get; set; }

        /// <summary>
        /// 解析后的签名
        /// </summary>
        public string sightml { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public string authstr { get; set; }

        /// <summary>
        /// 验证码生成日期
        /// </summary>
        public DateTime authtime { get; set; }

        /// <summary>
        /// 验证码使用标志(0 未使用,1 用户邮箱验证及用户信息激活, 2 用户密码找回)
        /// </summary>
        public int authflag { get; set; }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string realname { get; set; }

        /// <summary>
        /// 用户身份证
        /// </summary>
        public string idcard { get; set; }

        /// <summary>
        /// 移动电话
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 固定电话
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// 短消息忽略列表
        /// </summary>
        public string ignorepm { get; set; }

    }
}
