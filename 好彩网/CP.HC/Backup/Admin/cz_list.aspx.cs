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
    public partial class cz_list : Pages
    {
        protected int czid;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowConfig)
                AllowMessage("对不起，当前用户无此权限！");
            menus1.clicked = 28;   //左边menu样式选中
            czid = BBRequest.GetQueryInt("czid", 0);
            if (!Page.IsPostBack)
            {
                BinderList();
                if (czid > 0)
                    BinderZoneInfo();
            }
        }

        private void BinderList()
        {
            string where = string.Empty;
            DataSet ds = CzData.GetPageList(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "tbl_cz", "czid desc", where);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.list.DataSource = ds.Tables[0];
                list.DataBind();
                this.AspNetPager1.RecordCount = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
            }
        }

        private void BinderZoneInfo()
        {
            CzInfo info = Cz.GetCzInfo(czid, false);
            if (info != null && info.czid > 0)
            {
                czname.Text = info.czname;
                shortname.Text = info.shortname;
                qi.Text = (info.qi + 1).ToString();
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            CzInfo info = new CzInfo();
            info.czid = czid;
            info.czname = this.czname.Text.Trim();
            info.shortname = this.shortname.Text.Trim();
            info.qi = TypeConverter.StrToInt(this.qi.Text.Trim());

            int i = Cz.CreateCzInfo(info);
            if (i > 0)
            {
                if (czid == 0)
                    AlertMessage("提示：数据添加成功! ", "cz_list.aspx");
                else
                    AlertMessage("提示：数据编辑成功! ", "cz_list.aspx");
            }
            else if (i < 0)
                AlertMessage("数据已经存在，请勿重复添加....");
            else
                AlertMessage("保存失败，请重试....");
        }        
    }
}