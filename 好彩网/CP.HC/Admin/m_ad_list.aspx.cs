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
    public partial class m_ad_list : Pages
    {
        protected int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowAdvert)
                AllowMessage("对不起，当前用户无此权限！");
            menus1.clicked = 33;   //左边menu样式选中
            id = BBRequest.GetQueryInt("id", 0);
            if (!Page.IsPostBack)
            {
                BinderList();
                if (id > 0)
                    BinderZoneInfo();
            }
        }

        private void BinderList()
        {
            string where = string.Empty;
            DataSet ds = AdData.GetPageList(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "tbl_ADmanager", "source,PositonType,sort desc", where);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.list.DataSource = ds.Tables[0];
                list.DataBind();
                this.AspNetPager1.RecordCount = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
            }
        }

        private void BinderZoneInfo()
        {
            ADmanagerInfo info = Ad.GetAdInfo(id);
            if (info != null && info.id > 0)
            {
                txtTitle.Text = info.title;
                txtLink.Text = info.link;
                txtSort.Text = TypeConverter.ObjectToString(info.sort);
                drpSource.SelectedValue = TypeConverter.ObjectToString(info.source);
                drpPosition.SelectedValue = TypeConverter.ObjectToString(info.PositonType);
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                AlertMessage("请输入标题。");
                return;
            }
            ADmanagerInfo info = new ADmanagerInfo();
            info.id = id;
            info.title = this.txtTitle.Text.Trim();
            info.link = this.txtLink.Text.Trim();
            info.sort = TypeConverter.StrToFloat(txtSort.Text);
            info.source = TypeConverter.ObjectToInt(drpSource.SelectedValue);
            info.PositonType = TypeConverter.ObjectToInt(drpPosition.SelectedValue);

            int i = Ad.CreateAdDataInfo(info);
            if (i > 0)
            {
                if (id == 0)
                    AlertMessage("提示：数据添加成功! ", "m_ad_list.aspx");
                else
                    AlertMessage("提示：数据编辑成功! ", "m_ad_list.aspx");
            }
            else if (i < 0)
                AlertMessage("数据已经存在，请勿重复添加....");
            else
                AlertMessage("保存失败，请重试....");
        }        
    }
}