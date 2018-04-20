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
    public partial class goods_list : Pages
    {
        protected int _gcid;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowUser)
                AllowMessage("对不起，当前用户无此权限！");
            menus1.clicked = 42;   //左边menu样式选中
            _gcid = BBRequest.GetQueryInt("gcid", 0);
            if (!Page.IsPostBack)
            {
                BinderGoodsClass();
                BinderList();
            }
        }

        /// <summary>
        /// 递归绑定分类 
        /// </summary>
        private void BinderGoodsClass()
        {
            List<GoodsClassInfo> list = GoodsClass.GetGoodsClassList(false);
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    ListItem li = new ListItem(list[i].name, list[i].gcid.ToString());
                    this.gcid.Items.Add(li);
                }
            }

        }

        private void BinderList()
        {
            string where = string.Empty;
            if (TypeConverter.StrToInt(this.gcid.SelectedValue) > 0)
                where = "gcid=" + this.gcid.SelectedValue;
            else if (_gcid > 0)
                where = "gcid=" + _gcid.ToString();
            DataSet ds = GoodsData.GetPageListBbs(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "tbl_goods", "gid desc", where);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.list.DataSource = ds.Tables[0];
                list.DataBind();
                this.AspNetPager1.RecordCount = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
            }
        }

        protected string GetGcname(object gcid)
        {
            return GoodsClass.GetGoodsClassInfo(TypeConverter.ObjectToInt(gcid), false).name;
        }        

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected void gcid_SelectedIndexChanged(object sender, EventArgs e)
        {
            BinderList();
        }
       
    }
}