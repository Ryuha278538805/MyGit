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
    public partial class zone_list : Pages
    {
        protected int zid;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowConfig)
                AllowMessage("对不起，当前用户无此权限！");
            menus1.clicked = 27;   //左边menu样式选中
            zid = BBRequest.GetQueryInt("zid", 0);
            if (!Page.IsPostBack)
            {
                BinderNewsClass(0, this.cidsel);
                BinderNewsClass(0,this.cid);
                BinderList();
                string cookie = CookieUtil.GetCookie("cid");
                if (!string.IsNullOrEmpty(cookie))
                {
                    int _cid = TypeConverter.StrToInt(cookie);
                    if (_cid > 0)
                        this.cid.SelectedValue = _cid.ToString();
                }

                if (zid > 0)
                    BinderZoneInfo();
            }
        }

        private void BinderList()
        {
            string where = string.Empty;
            string order = "zid desc";
            if (TypeConverter.StrToInt(this.cidsel.SelectedValue) > 0)
            {
                where = "cid =" + this.cidsel.SelectedValue.ToString().Trim();
                order = "orderint asc";
            }
            DataSet ds = ZoneData.GetPageList(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "tbl_zone", order, where);
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
            ZoneInfo info = Zone.GetZoneInfo(zid, false);
            if (info != null && info.zid > 0)
            {
                this.cid.SelectedValue = info.cid.ToString();
                zname.Text = info.name;
                orderint.Text = info.orderint.ToString();
                keywords.Text = info.keywords;
                description.Text = info.description;
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected string GetCname(object cid)
        {
            return NewsClass.GetNewsClassInfo(TypeConverter.ObjectToInt(cid),false).name;
        }

        protected string GetCename(object cid)
        {
            return NewsClass.GetNewsClassInfo(TypeConverter.ObjectToInt(cid),false).ename;
        }

        /// <summary>
        /// 递归绑定分类 
        /// </summary>
        private void BinderNewsClass(int pid, DropDownList dp)
        {
            List<NewsClassInfo> list = NewsClass.GetNewsClassList(pid,false);
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].pid == 0)
                    {
                        ListItem li = new ListItem(list[i].name, list[i].cid.ToString());
                        dp.Items.Add(li);
                    }
                    else
                    {
                        ListItem li = new ListItem(CreateWord(list[i].depth) + list[i].name, list[i].cid.ToString());
                        dp.Items.Add(li);
                    }
                    BinderNewsClass(list[i].cid, dp);
                }
            }
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            ZoneInfo info = new ZoneInfo();
            info.zid = zid;
            info.name = this.zname.Text.Trim();
            info.cid = TypeConverter.StrToInt(cid.SelectedValue);
            info.orderint = TypeConverter.StrToInt(this.orderint.Text);
            info.keywords = this.keywords.Text;
            info.description = this.description.Text;

            //记录分类cookie
            CookieUtil.WriteCookie("cid", info.cid.ToString());

            int i = Zone.CreateZoneInfo(info);
            if (i > 0)
            {
                if (zid == 0)
                    AlertMessage("提示：数据添加成功! ", "zone_list.aspx");
                else
                    AlertMessage("提示：数据编辑成功! ", "zone_list.aspx");
            }
            else if(i<0)
                AlertMessage("数据已经存在，请勿重复添加....");
            else
                AlertMessage("保存失败，请重试....");
        }

        protected void cidsel_SelectedIndexChanged(object sender, EventArgs e)
        {
            BinderList();
        }        
    }
}