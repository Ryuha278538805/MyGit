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
    public partial class news_list : Pages
    {
        protected int _cid = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowConfig)
                AllowMessage("对不起，当前用户无此权限！");
            menus1.clicked = 2;   //左边menu样式选中
            _cid = BBRequest.GetQueryInt("cid", 0);
            if (!Page.IsPostBack)
            {
                BinderNewsClass(0);
                BinderList();
            }
        }

        /// <summary>
        /// 递归绑定分类 
        /// </summary>
        private void BinderNewsClass(int pid)
        {
            List<NewsClassInfo> list = NewsClass.GetNewsClassList(pid, false);
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].pid == 0)
                    {
                        ListItem li = new ListItem(list[i].name, list[i].cid.ToString());
                        this.cid.Items.Add(li);
                    }
                    else
                    {
                        ListItem li = new ListItem(CreateWord(list[i].depth) + list[i].name, list[i].cid.ToString());
                        this.cid.Items.Add(li);
                    }
                    BinderNewsClass(list[i].cid);
                }
            }

        }

        private void BinderList()
        {
            string where = string.Empty;
            if (TypeConverter.StrToInt(this.cid.SelectedValue) > 0)
                where = "cid=" + this.cid.SelectedValue;
            else if (_cid > 0)
                where = "cid=" + _cid.ToString();
            DataSet ds = NewsData.GetPageList(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "tbl_news", "nid desc", where);
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

        protected string GetCname(object cid)
        {
            return NewsClass.GetNewsClassInfo(TypeConverter.ObjectToInt(cid), false).name;
        }

        protected string GetCzname(object czid)
        {
            return Cz.GetCzInfo(TypeConverter.ObjectToInt(czid), false).czname;
        }

        protected string GetZonename(object zid)
        {
            return Zone.GetZoneInfo(TypeConverter.ObjectToInt(zid), false).name;
        }

        protected string GetQi(object qi)
        {
            string qistr = qi.ToString();
            if (qistr.Length > 2)
                return qi.ToString().Replace(DateTime.Now.Year.ToString(),"")+"期 —";
            else
                return "";
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected void cid_SelectedIndexChanged(object sender, EventArgs e)
        {
            BinderList();
        }
    }
}