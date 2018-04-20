using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Common;
using Model;
using DataProvider;
using Business;

namespace Admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Login()
        {
            if (txtUserName.Text.Trim().Length > 0 && txtPassWord.Text.Trim().Length > 0)
            {
                MasterUserInfo user = new MasterUserInfo();
                user.username = txtUserName.Text.Trim();
                user.password = MD5.GetMD5Smple(txtPassWord.Text.Trim());
                MasterUserInfo info = Business.MasterUser.GetMasterLogin(user);
                if (info != null & info.uid > 0)
                {
                    string code = info.uid + "," + info.username + "," + info.nickname + "," + info.groupid;
                    CookieUtil.WriteCookie("htcode", XXTEA.Encode(code), 60);                   
                    Response.Redirect("home.aspx");
                }
                else
                {
                    this.txtPassWord.Focus();
                    this.info.Text = "用户名或密码错误";
                }
            }
            else
            {
                this.info.Text = "请输入登录信息";
            }
        }

        protected void Enter_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
