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
    public partial class yczone_list : Pages
    {
        int yzid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowConfig)
                AllowMessage("对不起，当前用户无此权限！");
            menus1.clicked = 47;   //左边menu样式选中
            yzid = BBRequest.GetQueryInt("yzid", 0);
            if (!Page.IsPostBack)
            {
                BinderCzDrp(this.czidsel);
                BinderCzDrp(this.czid); 
                BinderYcType(this.typesel);
                BinderYcType(this.type);
                BinderList();
                string cookie1 = CookieUtil.GetCookie("yczoneczid");
                string cookie2 = CookieUtil.GetCookie("yczonetype");
                if (!string.IsNullOrEmpty(cookie1))
                {
                    int _czid = TypeConverter.StrToInt(cookie1, 0);
                    if (_czid > 0)
                        this.czid.SelectedValue = _czid.ToString();
                }
                if (!string.IsNullOrEmpty(cookie2))
                {
                    int _type = TypeConverter.StrToInt(cookie2, 0);
                    if (_type > 0)
                        this.type.SelectedValue = _type.ToString();
                }

                if (yzid > 0)
                    BinderZoneInfo();
            }
        }

        private void BinderList()
        {
            string where = string.Empty;
            string order = "orderint asc";
            if (TypeConverter.StrToInt(this.czidsel.SelectedValue) > 0)
            {
                where = "czid =" + this.czidsel.SelectedValue.ToString().Trim();
                order = "orderint asc";
            }
            if (TypeConverter.StrToInt(this.typesel.SelectedValue) > 0)
            {
                if (string.IsNullOrEmpty(where))
                    where = "type =" + this.typesel.SelectedValue.ToString().Trim();
                else
                    where += " and type =" + this.typesel.SelectedValue.ToString().Trim();
                order = "orderint asc";
            }
            DataSet ds = YcZoneData.GetPageList(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "tbl_yczone", order, where);
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

        private void BinderZoneInfo()
        {
            YcZoneInfo info = YcZone.GetYcZoneByYzID(yzid);
            if (info != null && info.yzid > 0)
            {
                this.czid.SelectedValue = info.czid.ToString();
                zname.Text = info.name;
                this.type.SelectedValue = info.type.ToString();
                orderint.Text = info.orderint.ToString();               
                keywords.Text = info.keywords;
                description.Text = info.description;
                titlemodel.Text = info.titlemodel;
                contextmodel.Text = info.contextmodel;
                contexthead.Text = info.contexthead;
                contextend.Text = info.contextend;
                isautowrite.Checked = info.isautowrite;
            }
        }

        protected void czidsel_SelectedIndexChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected void typesel_SelectedIndexChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            YcZoneInfo info = new YcZoneInfo();
            info.yzid = yzid;
            if (yzid > 0)
                info = YcZone.GetYcZoneByYzID(yzid);
            info.name = this.zname.Text.Trim();
            info.czid = TypeConverter.StrToInt(this.czid.SelectedValue);
            info.orderint = TypeConverter.StrToInt(this.orderint.Text);
            info.type = TypeConverter.StrToInt(this.type.SelectedValue);           
            info.keywords = this.keywords.Text.Trim();
            info.description = this.description.Text.Trim();
            info.titlemodel = this.titlemodel.Text.Trim();
            info.contextmodel = this.contextmodel.Text.Trim();
            info.contexthead = this.contexthead.Text.Trim();
            info.contextend = this.contextend.Text.Trim();
            info.isautowrite = this.isautowrite.Checked;

            //记录分类cookie
            CookieUtil.WriteCookie("yczoneczid", info.czid.ToString());
            CookieUtil.WriteCookie("yczonetype", info.type.ToString());

            int i = YcZone.CreateYcZoneInfo(info);
            if (i > 0)
            {
                if (yzid == 0)
                    AlertMessage("提示：数据添加成功! ", "yczone_list.aspx");
                else
                    AlertMessage("提示：数据编辑成功! ", "yczone_list.aspx");
            }
            else if (i < 0)
                AlertMessage("数据已经存在，请勿重复添加....");
            else
                AlertMessage("保存失败，请重试....");
        }     
    }
}