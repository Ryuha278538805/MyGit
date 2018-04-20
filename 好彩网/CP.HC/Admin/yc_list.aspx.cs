using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Common;
using Business;
using DataProvider;

namespace Admin
{
    public partial class yc_list : Pages
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowConfig)
                AllowMessage("对不起，当前用户无此权限！");
            menus1.clicked = 46;   //左边menu样式选中
            if (!Page.IsPostBack)
            {
                //BinderCzDrp(this.cz);
                BinderYcType(this.type);
                BinderYcZone(0, 0, this.yzidsel);
                BinderList();
            }
        }

        private void BinderList()
        {
            string where = string.Empty;
            string order = "orderint asc";
            if (TypeConverter.StrToInt(this.type.SelectedValue) > 0)
            {
                if (string.IsNullOrEmpty(where))
                    where = "type =" + this.type.SelectedValue.ToString().Trim();
                else
                    where += " and type =" + this.type.SelectedValue.ToString().Trim();                
            }
            if (TypeConverter.StrToInt(this.yzidsel.SelectedValue) > 0)
                where = "yzid = " + this.yzidsel.SelectedValue.ToString().Trim();
            order = "qi desc";
            DataSet ds = YcData.GetPageList(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "vv_ycinfo", order, where);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.list.DataSource = ds.Tables[0];
                list.DataBind();
                this.AspNetPager1.RecordCount = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
            }
            else
            {
                this.list.DataSource = null;
                list.DataBind();
                this.AspNetPager1.RecordCount = 0;
            }
        }

        protected void BinderYcZone(object cz, object yctype, DropDownList drp)
        {
            int _cz = TypeConverter.ObjectToInt(cz,0);
            int _yctype = TypeConverter.ObjectToInt(yctype, 0);
            string where="";
            string order = "orderint asc";
            if (_cz > 0)
                where = "czid=" + _cz.ToString();
            if (_yctype > 0)
            {
                if (string.IsNullOrEmpty(where))
                    where = "type=" + _yctype.ToString();
                else
                    where += " and type=" + _yctype.ToString();
            }
            drp.Items.Clear();
            ListItem li = new ListItem("==请选择专题==", "0");
            drp.Items.Add(li);
            
            DataSet ds = YcZoneData.GetPageList(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "tbl_yczone", order, where);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {   
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ListItem _li = new ListItem(ds.Tables[0].Rows[i]["name"].ToString().Trim(), ds.Tables[0].Rows[i]["yzid"].ToString().Trim());
                    drp.Items.Add(_li);
                }
            }
        }

        protected void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            BinderYcZone(0, this.type.SelectedValue, this.yzidsel);
            BinderList();
        }

        protected void yzidsel_SelectedIndexChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BinderList();
        }
    }
}