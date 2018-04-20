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
    public partial class goodsclass_list : Pages
    {
        protected int gcid;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowUser)
                AllowMessage("对不起，当前用户无此权限！");
            menus1.clicked = 44;   //左边menu样式选中
            gcid = BBRequest.GetQueryInt("gcid", 0);
            if (!Page.IsPostBack)
            {
                BinderList();
                if (gcid > 0)
                    BinderGoodsClassInfo();
            }
        }

        private void BinderList()
        {
            string where = string.Empty;
            DataSet ds = GoodsClassData.GetPageListBbs(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "tbl_goods_class", "orderint asc", where);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.list.DataSource = ds.Tables[0];
                list.DataBind();
                this.AspNetPager1.RecordCount = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
            }
        }

        private void BinderGoodsClassInfo()
        {
            GoodsClassInfo info = GoodsClass.GetGoodsClassInfo(gcid, false);
            if (info != null && info.gcid > 0)
            {
                name.Text = info.name;
                orderint.Text = info.orderint.ToString();
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            GoodsClassInfo info = new GoodsClassInfo();
            info.gcid = gcid;
            info.name = this.name.Text.Trim();
            info.orderint = TypeConverter.StrToInt(orderint.Text.Trim());

            int i = GoodsClass.CreateGoodsClassInfo(info);
            if (i > 0)
            {
                if (gcid == 0)
                    AlertMessage("提示：数据添加成功! ", "goodsclass_list.aspx");
                else
                    AlertMessage("提示：数据编辑成功! ", "goodsclass_list.aspx");
            }
            else if (i < 0)
                AlertMessage("数据已经存在，请勿重复添加....");
            else
                AlertMessage("保存失败，请重试....");
        }                
    }
}