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
    public partial class newsclass_list : Pages
    {
        protected int cid;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowConfig)
                AllowMessage("对不起，当前用户无此权限！");
            menus1.clicked = 26;   //左边menu样式选中
            cid = BBRequest.GetQueryInt("cid", 0);
            if (!Page.IsPostBack)
            {
                BinderNewsClass(0);
                BinderCz();
                BinderList();
                 if (cid > 0)
                    BinderNewsClassInfo();
            }
        }

        private void BinderList()
        {
            string where = string.Empty;
            DataSet ds = NewsClassData.GetPageList(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "tbl_news_class", "cid desc", where);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.list.DataSource = ds.Tables[0];
                list.DataBind();
                this.AspNetPager1.RecordCount = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
            }          
        }

        private void BinderNewsClassInfo()
        {
            NewsClassInfo info = NewsClass.GetNewsClassInfo(cid, false);
            if (info != null && info.cid > 0)
            {
                cname.Text = info.name;
                ename.Text = info.ename;
                keywords.Text = info.keywords;
                description.Text = info.description;
                this.pid.SelectedValue = info.pid.ToString();
                this.czid.SelectedValue = info.czid.ToString();                
                if (info.everqi>0)
                    this.everqi.Checked = true;
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
                        ListItem li = new ListItem(list[i].name, list[i].cid.ToString().Trim());
                        this.pid.Items.Add(li);
                    }
                    else
                    {
                        ListItem li = new ListItem(CreateWord(list[i].depth) + list[i].name, list[i].cid.ToString());
                        this.pid.Items.Add(li);
                    }
                    BinderNewsClass(list[i].cid);
                }
            }
        }

        /// <summary>
        /// 绑定彩种
        /// </summary>
        private void BinderCz()
        {
            List<CzInfo> list = Cz.GetCzList(false);
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    ListItem li = new ListItem(list[i].czname, list[i].czid.ToString().Trim());
                     this.czid.Items.Add(li);
                }
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

        protected string GetIs(object isok)
        {
            bool al = TypeConverter.ObjectToBool(isok);
            if (al)
                return "√";
            else
                return "×";
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            NewsClassInfo info = new NewsClassInfo();
            info.cid = cid;
            info.name = this.cname.Text.Trim();
            info.ename = this.ename.Text.Trim();
            info.pid = TypeConverter.StrToInt(pid.SelectedValue);
            info.czid = TypeConverter.StrToInt(czid.SelectedValue);
            info.keywords = this.keywords.Text;
            info.description = this.description.Text;
            if (this.everqi.Checked)
                info.everqi = 1;
            if(info.pid==0)
            {
                info.rid=0;
                info.depth = 0;
            }
            else
            {
                NewsClassInfo pinfo = NewsClass.GetNewsClassInfo(info.pid, false);
                info.depth = pinfo.depth+1;
                if(info.depth>1)
                      info.rid = pinfo.rid;
                else
                      info.rid = pinfo.cid;
            }

            int i = NewsClass.CreateNewsClassInfo(info);
            if (i > 0) 
            {
                if (cid == 0)
                    AlertMessage("提示：数据添加成功! ", "newsclass_list.aspx");
                else
                    AlertMessage("提示：数据编辑成功! ", "newsclass_list.aspx");
            }
            else if(i<0)
                AlertMessage("数据已经存在，请勿重复添加....");
            else
                AlertMessage("保存失败，请重试....");
        }                
    }
}