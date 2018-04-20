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
    /// 论坛用户信息处理类
    /// simwon
    /// </summary>
    public class Users
    {
        /// <summary>
        /// 某个用户的全部信息
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public static UserInfo GetUserInfo(int uid)
        {
            UserInfo info = new UserInfo();
            DataRow dr = UserData.GetUserInfoData(uid);
            if (dr != null)
            {
                info.uid = TypeConverter.ObjectToInt(dr["uid"]);
                info.username = dr["username"].ToString().Trim();
                info.nickname = dr["nickname"].ToString().Trim();
                info.password = dr["password"].ToString().Trim();
                info.secques = dr["secques"].ToString().Trim();              
                info.spaceid = TypeConverter.ObjectToInt(dr["spaceid"]);
                info.gender = TypeConverter.ObjectToInt(dr["gender"]);
                info.adminid = TypeConverter.ObjectToInt(dr["adminid"]);
                info.groupid = TypeConverter.ObjectToInt(dr["groupid"]);
                info.groupexpiry = TypeConverter.ObjectToInt(dr["groupexpiry"]);
                info.extgroupids = dr["extgroupids"].ToString().Trim();
                info.regip = dr["regip"].ToString().Trim();
                info.joindate = TypeConverter.ObjectToDateTime(dr["joindate"]);
                info.lastip = dr["lastip"].ToString().Trim();
                info.lastvisit = TypeConverter.ObjectToDateTime(dr["lastvisit"]);
                info.lastactivity = TypeConverter.ObjectToDateTime(dr["lastactivity"]);
                info.lastpost = TypeConverter.ObjectToDateTime(dr["lastpost"]);               
                info.lastpostid = TypeConverter.ObjectToInt(dr["lastpostid"]);
                info.lastposttitle = dr["lastposttitle"].ToString().Trim();
                info.posts = TypeConverter.ObjectToInt(dr["posts"]);
                info.digestposts = TypeConverter.ObjectToInt(dr["digestposts"]);
                info.oltime = TypeConverter.ObjectToInt(dr["oltime"]);
                info.pageviews = TypeConverter.ObjectToInt(dr["pageviews"]);
                info.credits = TypeConverter.ObjectToInt(dr["credits"]);
                info.extcredits1 = TypeConverter.ObjectToInt(dr["extcredits1"]);
                info.extcredits2 = TypeConverter.ObjectToInt(dr["extcredits2"]);
                info.extcredits3 = TypeConverter.ObjectToInt(dr["extcredits3"]);
                info.extcredits4 = TypeConverter.ObjectToInt(dr["extcredits4"]);
                info.extcredits5 = TypeConverter.ObjectToInt(dr["extcredits5"]);
                info.extcredits6 = TypeConverter.ObjectToInt(dr["extcredits6"]);
                info.extcredits7 = TypeConverter.ObjectToInt(dr["extcredits7"]);
                info.extcredits8 = TypeConverter.ObjectToInt(dr["extcredits8"]);
                info.avatarshowid = TypeConverter.ObjectToInt(dr["avatarshowid"]);
                info.email = dr["email"].ToString().Trim();
                info.bday = dr["bday"].ToString().Trim();
                info.sigstatus = TypeConverter.ObjectToInt(dr["sigstatus"]);
                info.tpp = TypeConverter.ObjectToInt(dr["tpp"]);
                info.ppp = TypeConverter.ObjectToInt(dr["ppp"]);
                info.templateid = TypeConverter.ObjectToInt(dr["templateid"]);
                info.pmsound = TypeConverter.ObjectToInt(dr["pmsound"]);
                info.showemail = TypeConverter.ObjectToInt(dr["showemail"]);
                info.invisible = TypeConverter.ObjectToInt(dr["invisible"]);
                info.newpm = TypeConverter.ObjectToInt(dr["newpm"]);
                info.newpmcount = TypeConverter.ObjectToInt(dr["newpmcount"]);
                info.accessmasks = TypeConverter.ObjectToInt(dr["accessmasks"]);
                info.onlinestate = TypeConverter.ObjectToInt(dr["onlinestate"]);
                info.newsletter = TypeConverter.ObjectToInt(dr["newsletter"]);
                info.salt = dr["salt"].ToString().Trim();


                info.website = dr["website"].ToString().Trim();
                info.icq = dr["icq"].ToString().Trim();
                info.qq = dr["qq"].ToString().Trim();
                info.yahoo = dr["yahoo"].ToString().Trim();
                info.msn = dr["msn"].ToString().Trim();
                info.skype = dr["skype"].ToString().Trim();
                info.location = dr["location"].ToString().Trim();
                info.customstatus = dr["customstatus"].ToString().Trim();
                info.avatar = dr["avatar"].ToString().Trim();                
                info.avatarwidth = TypeConverter.ObjectToInt(dr["avatarwidth"]);
                info.avatarheight = TypeConverter.ObjectToInt(dr["avatarheight"]);
                info.medals = dr["medals"].ToString().Trim();
                info.bio = dr["bio"].ToString().Trim();
                info.signature = dr["signature"].ToString().Trim();
                info.sightml = dr["sightml"].ToString().Trim();
                info.authstr = dr["authstr"].ToString().Trim();
                info.authtime = TypeConverter.ObjectToDateTime(dr["authtime"]);
                info.authflag = TypeConverter.ObjectToInt(dr["authflag"]);
                info.realname = dr["realname"].ToString().Trim();
                info.idcard = dr["idcard"].ToString().Trim();
                info.mobile = dr["mobile"].ToString().Trim();
                info.phone = dr["phone"].ToString().Trim();
                info.ignorepm = dr["ignorepm"].ToString().Trim();
            }
            return info;
        }
    }
}
