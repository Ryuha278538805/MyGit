using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using Model;
using Business;

namespace Shop
{
    public partial class head : System.Web.UI.UserControl
    {
        protected int uid = 0;
        protected string password;
        protected UserOnlineInfo olinfo = new UserOnlineInfo();
        protected UserInfo uinfo = new UserInfo();
        protected UserGroupInfo uginfo = new UserGroupInfo();
        protected string avatar;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                uid = TypeConverter.ObjectToInt(CookieUtil.GetCookie("dnt", "userid"));
            }
            catch { }
            if (uid > 0)
            {               
                uinfo = Users.GetUserInfo(uid);
                if (uinfo.uid > 0 && uinfo.password.Length > 0)
                {
                    password = uinfo.password.Substring(4, 8).Trim();
                    olinfo = UserOnline.GetUserOnlineInfo(uid, uinfo.password);
                    uginfo = UserGroup.GetUserGroupInfo(uinfo.groupid, true);
                    avatar = Avatars.GetAvatarUrl(uid, AvatarSize.Small);
                }
            }
        }
    }
}