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
    /// 论坛在线用户信息处理类
    /// simwon
    /// </summary>
    public class UserOnline
    {
        /// <summary>
        /// 某个用户的全部信息
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public static UserOnlineInfo GetUserOnlineInfo(int uid, string password)
        {
            UserOnlineInfo info = new UserOnlineInfo();
            DataRow dr = UserOnlineData.GetUserOnlineInfoData(uid, password);
            if (dr != null)
            {
                info.olid = TypeConverter.ObjectToInt(dr["olid"]);
                info.userid = TypeConverter.ObjectToInt(dr["userid"]);
                info.ip = dr["ip"].ToString().Trim();
                info.username = dr["username"].ToString().Trim();
                info.nickname = dr["nickname"].ToString().Trim();
                info.password = dr["password"].ToString().Trim();
                info.groupid = TypeConverter.ObjectToInt(dr["groupid"]);
                info.olimg = dr["olimg"].ToString().Trim();
                info.adminid = TypeConverter.ObjectToInt(dr["adminid"]);
                info.invisible = TypeConverter.ObjectToInt(dr["invisible"]);
                info.action = TypeConverter.ObjectToInt(dr["action"]);
                info.lastactivity = TypeConverter.ObjectToInt(dr["lastactivity"]);
                info.lastposttime = TypeConverter.ObjectToDateTime(dr["lastposttime"]);
                 info.lastpostpmtime = TypeConverter.ObjectToDateTime(dr["lastpostpmtime"]);
                 info.lastsearchtime = TypeConverter.ObjectToDateTime(dr["lastsearchtime"]);
                 info.lastupdatetime = TypeConverter.ObjectToDateTime(dr["lastupdatetime"]);                
                info.forumid = TypeConverter.ObjectToInt(dr["forumid"]);
                info.forumname = dr["forumname"].ToString().Trim();
                info.titleid = TypeConverter.ObjectToInt(dr["titleid"]);
                info.title= dr["title"].ToString().Trim();
                info.verifycode = dr["verifycode"].ToString().Trim();
                info.newpms = TypeConverter.ObjectToInt(dr["newpms"]);
                info.newnotices = TypeConverter.ObjectToInt(dr["newnotices"]);
            }
            return info;
        }
    }
}
