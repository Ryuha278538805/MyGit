using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using Business;
namespace Admin
{
    public partial class menus : System.Web.UI.UserControl
    {
        public int aid;
        public string ausername;
        public string nickname;
        public int groupid;
        public Allow allow;
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAUserInfo();
            allow = new Allow(aid);
        }

        /// <summary>
        /// 是否被点击
        /// </summary>
        public int clicked { get; set; }

        /// <summary>
        /// 取后台用户信息
        /// </summary>
        private void GetAUserInfo()
        {
            string cookie = CookieUtil.GetCookie("htcode");
            if (!string.IsNullOrEmpty(cookie))
            {
                string allow = XXTEA.Decode(cookie);
                if (!string.IsNullOrEmpty(allow))
                {
                    string[] strs = allow.Split(',');
                    if (strs.Length == 4)
                    {
                        aid = Convert.ToInt32(strs[0]);
                        groupid = Convert.ToInt32(strs[3]);
                        ausername = strs[1];
                        nickname = strs[2];
                    }
                    else
                    {
                        CookieUtil.ClearAllCookie();
                    }
                }
            }

        }
    }
}