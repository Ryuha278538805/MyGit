using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using Common;
using Business;
using Model;
using DataProvider;


namespace Admin
{
    public partial class master_list : Pages
    {
        protected int uid;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowConfig)
                AllowMessage("对不起，当前用户无此权限！");

            menus1.clicked = 24;   //左边menu样式选中
            uid = BBRequest.GetQueryInt("uid", 0);
            if (!Page.IsPostBack)
            {
                BinderMasterGroup();
                BinderList();
                if (uid > 0)
                    BinderMasterUserInfo();
            }
        }

        private void BinderList()
        {
            string where = string.Empty;
            DataSet ds = MasterUserData.GetPageList(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "tbl_masters", "uid desc", where);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.list.DataSource = ds.Tables[0];
                list.DataBind();
                this.AspNetPager1.RecordCount = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
            }
        }

        private void BinderMasterUserInfo()
        {
            MasterUserInfo info = MasterUser.GetMasterInfo(uid, false);
            if (info != null && info.uid > 0)
            {
                name.Text = info.username;
                nickname.Text = info.nickname;
                groupid.SelectedValue = info.groupid.ToString().Trim();
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected string GetGroupName(object grouopid)
        {
            return MasterGroup.GetMasterGroupInfo(TypeConverter.ObjectToInt(grouopid), false).name;
        }

        /// <summary>
        /// 绑定管理组 
        /// </summary>
        private void BinderMasterGroup()
        {
            List<MasterGroupInfo> list = MasterGroup.GetMasterGroupList(false);
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    ListItem li = new ListItem(list[i].name, list[i].groupid.ToString());
                    this.groupid.Items.Add(li); 
                }
            }
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            MasterUserInfo info = new MasterUserInfo();
            MasterUserInfo oldinfo = MasterUser.GetMasterInfo(uid, false);

            info.uid = uid;
            info.username = this.name.Text.Trim();
            info.nickname = this.nickname.Text.Trim();
            info.groupid = TypeConverter.StrToInt(groupid.SelectedValue);
            info.password = this.password.Text.Trim();
            
            //新密码
            if (info.password.Length > 0)    
            {
                info.password = MD5.GetMD5Smple(info.password);
            }
             //不改密码
            else
            {
                info.password = oldinfo.password;
            }
            
            int i = MasterUser.CreateMasterInfo(info);
            if (i > 0)
            {
                if (uid == 0)
                    AlertMessage("提示：数据添加成功! ", "master_list.aspx");
                else
                    AlertMessage("提示：数据编辑成功! ", "master_list.aspx");
            }
            else if (i < 0)
                AlertMessage("数据已经存在，请勿重复添加....");
            else
                AlertMessage("保存失败，请重试....");
        }        
    }
}