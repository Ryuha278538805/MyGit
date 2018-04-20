using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using Common;
using Business;
using Model;
using UpLoadFileV2;

namespace Admin
{
    public partial class news_templet_add : Pages
    {
        public string context;
        public string color="";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowConfig)
                AllowMessage("对不起，当前用户无此权限！");
            menus1.clicked = 17;
            //隐藏radio控件            
            this.qi.ReadOnly = true;
            if (!Page.IsPostBack)
            {
                BinderNewsClass(0);
                BinderCz();
                
                #region 设置上次添加的分类
                string cookiecid = CookieUtil.GetCookie("cid");
                string cookieczid = CookieUtil.GetCookie("czid");
                string cookieqi = CookieUtil.GetCookie("qi");
                if (!string.IsNullOrEmpty(cookiecid))
                {
                    int _cid = TypeConverter.StrToInt(cookiecid);
                    if (_cid > 0)
                    {
                        this.cid.SelectedValue = _cid.ToString();
                        BinderTemplet(TypeConverter.StrToInt(cid.SelectedValue), 0);
                    }
                }
                else
                {
                    BinderTemplet(0, 0);
                }
                if (!string.IsNullOrEmpty(cookieczid))
                {
                    int _czid = TypeConverter.StrToInt(cookieczid);
                    int _qi = TypeConverter.StrToInt(cookieqi);
                    if (_czid > 0)
                        this.czid.SelectedValue = _czid.ToString();
                    if (_qi > 0)
                        this.qi.Text = _qi.ToString();
                }
                #endregion
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
                    else {
                        ListItem li = new ListItem(CreateWord(list[i].depth)+list[i].name, list[i].cid.ToString());
                        this.cid.Items.Add(li);
                    }
                    BinderNewsClass(list[i].cid);
                }
            }

        }

        /// <summary>
        /// 绑定专题 
        /// </summary>
        private void BinderTemplet(int cid, int sel)
        {
            List<NewsTempletInfo> list = new List<NewsTempletInfo>();
            int count;
            //剔除数据
            this.tid.Items.Clear();

            list = NewsTemplet.GetNewsTempletPageList(500, 1, cid, 0, 0, out count);
            if (list != null && list.Count > 0)
            {
                //绑定数据
                for (int i = 0; i < list.Count; i++)
                {
                    ListItem li = new ListItem(list[i].title, list[i].tid.ToString());
                    this.tid.Items.Add(li);                       
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

        protected void enter_Click(object sender, EventArgs e)
        {
            NewsInfo info = new NewsInfo();
            NewsTempletInfo tinfo = new NewsTempletInfo();
            if (TypeConverter.StrToInt(tid.SelectedValue) > 0)
                tinfo = NewsTemplet.GetNewsTempletInfo(TypeConverter.StrToInt(tid.SelectedValue));
            info.nid = 0;
            info.title = this.title.Text.Trim();
            info.cid = tinfo.cid;
            info.czid = tinfo.czid;
            info.qi = TypeConverter.StrToInt(this.qi.Text.Trim());
            info.zid = tinfo.zid;
            if (BBRequest.GetQueryString("color") != null)
                info.color = BBRequest.GetFormString("color").Trim();
            else
                info.color = "";
            info.context = BBRequest.GetFormString("content").Replace("alt=\"\"", "alt=\"" + info.title + "\"");
            info.uid = aid;
            info.username = ausername;
            info.anthor = anickname;
            if (this.isbest.Checked)
                info.isbest = 1;
            if (this.ishot.Checked)
                info.ishot = 1;
            if (this.istop.Checked)
                info.istop = 1;

            //记录分类cookie
            CookieUtil.WriteCookie("cid", info.cid.ToString());
            CookieUtil.WriteCookie("czid", info.czid.ToString());
            CookieUtil.WriteCookie("qi", info.qi.ToString());

            int i = News.CreateNewsInfo(info);
            if (i > 0)
            {
                JsRedirect("news_templet_add.aspx");
                //if (nid == 0)
                //    AlertMessage("提示：数据添加成功!", "news_add.aspx");
                //else
                //    AlertMessage("提示：数据编辑成功!", "news_add.aspx");
            }
            else if (i < 0)
                AlertMessage("数据已经存在，请勿重复添加....");
            else
                AlertMessage("保存失败，请重试....");
        }

        protected void cid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _czid = NewsClass.GetNewsClassInfo(TypeConverter.StrToInt(cid.SelectedValue), false).czid;
            czid.SelectedValue = _czid.ToString();
            czid.Enabled = false;
            qi.Text = Cz.GetCzInfo(_czid, false).qi.ToString();
            BinderTemplet(TypeConverter.StrToInt(cid.SelectedValue), 0);
        }

        protected void czid_SelectedIndexChanged(object sender, EventArgs e)
        {
            qi.Text = Cz.GetCzInfo(TypeConverter.StrToInt(czid.SelectedValue), false).qi.ToString();
        }

        protected void craete_Click(object sender, EventArgs e)
        {
            int _tid = TypeConverter.ObjectToInt(tid.SelectedValue);
            NewsTempletInfo tinfo = new NewsTempletInfo();
            CzInfo czinfo = new CzInfo();
            string[,] temp = Templet.CraeteTemplet();

            if (_tid > 0)
                tinfo = NewsTemplet.GetNewsTempletInfo(_tid);

            if (tinfo.title.Length > 0)
            {
                this.cid.SelectedValue = tinfo.cid.ToString();
                // this.zid.SelectedValue = info.zid.ToString();                
                this.czid.SelectedValue = tinfo.czid.ToString();
                czinfo = Cz.GetCzInfo(tinfo.czid, false);
                qi.Text = czinfo.qi.ToString();
                title.Text = tinfo.title.Replace("{qi}",czinfo.qi.ToString());
                context = tinfo.context;
                for (int i = 0; i < 66; i++)
                     context = context.Replace(temp[i,1],temp[i,2]);
                context = context.Replace("{qi}", czinfo.qi.ToString());
                if (tinfo.istop > 0)
                    this.istop.Checked = true;
                if (tinfo.isbest > 0)
                    isbest.Checked = true;
                if (tinfo.ishot > 0)
                    ishot.Checked = true;
                if (!string.IsNullOrEmpty(tinfo.color))
                {
                    this.title.Attributes.Add("style", "width:500px;color:" + tinfo.color);
                    color = tinfo.color;
                }
            }
        }
    }
}