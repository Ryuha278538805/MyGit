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
    public partial class mastergroup_list : Pages
    {
        protected int groupid;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowConfig)
                AllowMessage("对不起，当前用户无此权限！");

            menus1.clicked = 25;   //左边menu样式选中
            groupid = BBRequest.GetQueryInt("groupid", 0);
            if (!Page.IsPostBack)
            {
                BinderList();
                if (groupid > 0)
                    BinderMasterGroupInfo();
            }
        }

        private void BinderList()
        {
            string where = string.Empty;
            DataSet ds = MasterGroupData.GetPageList(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "tbl_mastergroups", "groupid desc", where);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.list.DataSource = ds.Tables[0];
                list.DataBind();
                this.AspNetPager1.RecordCount = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
            }
        }

        private void BinderMasterGroupInfo()
        {
            MasterGroupInfo info = MasterGroup.GetMasterGroupInfo(groupid, false);
            if (info != null && info.groupid > 0)
            {
                name.Text = info.name;
                if (info.allowpub > 0)
                    this.allowpub.Checked = true;
                if (info.allowpages > 0)
                    this.allowpages.Checked = true;
                if (info.allowadvert > 0)
                    this.allowadvert.Checked = true;
                if (info.allowuser > 0)
                    this.allowuser.Checked = true;
                if (info.allowconfig > 0)
                    this.allowconfig.Checked = true;
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected string GetAllow(object allow)
        {
            bool al = TypeConverter.ObjectToBool(allow);
            if (al)
                return "√";
            else
                return "×";
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            MasterGroupInfo info = new MasterGroupInfo();
            info.groupid = groupid;
            info.name = this.name.Text.Trim();
            if (this.allowpub.Checked)
                info.allowpub = 1;
            if (this.allowpages.Checked)
                info.allowpages = 1;
            if (this.allowadvert.Checked)
                info.allowadvert = 1;
            if (this.allowuser.Checked)
                info.allowuser = 1;
            if (this.allowconfig.Checked)
                info.allowconfig = 1;
            int i = MasterGroup.CreateMasterGroupInfo(info);
            if (i > 0)
            {
                if (groupid == 0)
                    AlertMessage("提示：数据添加成功! ", "mastergroup_list.aspx");
                else
                    AlertMessage("提示：数据编辑成功! ", "mastergroup_list.aspx");
            }
            else if (i < 0)
                AlertMessage("数据已经存在，请勿重复添加....");
            else
                AlertMessage("保存失败，请重试....");
        }        
    }
}