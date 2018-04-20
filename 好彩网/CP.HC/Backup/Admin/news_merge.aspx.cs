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
    public partial class news_merge : Pages
    {
        protected int nid = 0;  //文章ID
        public string context;
        public string color = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowPage)
                AllowMessage("对不起，当前用户无此权限！");
            menus1.clicked = 20;
            //隐藏radio控件            
            nid = BBRequest.GetQueryInt("nid", 0);
            this.qi.ReadOnly = true;
            if (!Page.IsPostBack)
            {
                this.zidrbt.Visible = false;
                BinderNewsClass(0, this.cid);
                BinderNewsClass(0, this.cid2);
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
                        BinderZone(TypeConverter.StrToInt(cid.SelectedValue), 0);
                    }
                }
                else
                {
                    BinderZone(0, 0);
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

                if (nid > 0)
                    GetNewsInfo();

            }
        }

        /// <summary>
        /// 递归绑定分类 
        /// </summary>
        private void BinderNewsClass(int pid, DropDownList dr)
        {
            List<NewsClassInfo> list = NewsClass.GetNewsClassList(pid, false);
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].pid == 0)
                    {
                        ListItem li = new ListItem(list[i].name, list[i].cid.ToString());
                        dr.Items.Add(li);
                    }
                    else
                    {
                        ListItem li = new ListItem(CreateWord(list[i].depth) + list[i].name, list[i].cid.ToString());
                        dr.Items.Add(li);
                    }
                    BinderNewsClass(list[i].cid, dr);
                }
            }

        }

        private void GetNewsInfo()
        {
            NewsInfo info = News.GetNewsInfo(nid);
            if (info != null && info.nid > 0)
            {
                BinderZone(info.cid, info.zid);
                this.cid.SelectedValue = info.cid.ToString();
                // this.zid.SelectedValue = info.zid.ToString();                
                this.czid.SelectedValue = info.czid.ToString();
                qi.Text = info.qi.ToString();
                title.Text = info.title;
                context = info.context;
                if (info.istop > 0)
                    this.istop.Checked = true;
                if (info.isbest > 0)
                    isbest.Checked = true;
                if (info.ishot > 0)
                    ishot.Checked = true;
                if (!string.IsNullOrEmpty(info.color))
                {
                    this.title.Attributes.Add("style", "width:500px;color:" + info.color);
                    color = info.color;
                }
            }
        }

        /// <summary>
        /// 绑定专题 
        /// </summary>
        private void BinderZone(int cid, int sel)
        {
            List<ZoneInfo> list = new List<ZoneInfo>();
            List<ZoneInfo> added = new List<ZoneInfo>();
            //剔除DropList数据并保留第一条
            for (int i = 1; i < this.zid.Items.Count; i++)
                this.zid.Items.RemoveAt(i--);
            //剔除RadioList数据
            this.zidrbt.Items.Clear();

            int everqi = 0;
            if (cid == 0)  //全部专题
            {
                list = Zone.GetZoneList(false);
            }
            else   //某个分类下的专题
            {
                list = Zone.GetZoneListByCid(cid, false);
                everqi = NewsClass.GetNewsClassInfo(cid, false).everqi;  //得到分类everqi数据                
            }
            if (everqi > 0)
                added = Zone.GetZoneList(cid, false);
            if (list != null && list.Count > 0)
            {
                //绑定数据
                for (int i = 0; i < list.Count; i++)
                {
                    ListItem li = new ListItem(list[i].name, list[i].zid.ToString());
                    //每日一条的分类下的专题
                    if (everqi > 0)
                    {
                        this.zidrbt.Visible = true;
                        this.zid.Visible = false;
                        this.zidrbt.Items.Add(li);
                        for (int j = 0; j < added.Count; j++)
                        {
                            //禁用已经添加的
                            if (added[j].zid == list[i].zid)
                            {
                                if (list[i].zid == sel)
                                    this.zidrbt.Items[i].Selected = true;
                                this.zidrbt.Items[i].Enabled = false;
                            }
                        }
                    }
                    //普通分类下的专题
                    else
                    {
                        this.zid.Visible = true;
                        this.zidrbt.Visible = false;
                        this.zid.Items.Add(li);
                    }
                }
            }
            else
            {
                this.zid.Visible = true;
                this.zidrbt.Visible = false;
            }
        }

        /// <summary>
        /// 自动取上一期的标题 
        /// </summary>
        private void ZoneSelect(object zid)
        {
            int count;
            List<NewsInfo> list = News.GetNewsPageList(1, 1, TypeConverter.StrToInt(this.cid.SelectedValue), TypeConverter.ObjectToInt(zid), 0, out count, TypeConverter.StrToInt(this.qi.Text.Trim()) - 1);
            if (list.Count > 0)
                this.title.Text = list[0].title.Replace((TypeConverter.StrToInt(this.qi.Text.Trim()) - 1).ToString(), TypeConverter.StrToInt(this.qi.Text.Trim()).ToString())
                    .Replace((TypeConverter.StrToInt(this.qi.Text.Trim()) - 1).ToString().Replace(DateTime.Now.Year.ToString(), ""), TypeConverter.StrToInt(this.qi.Text.Trim()).ToString().Replace(DateTime.Now.Year.ToString(), ""));
            else
                this.title.Text = "";
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
            info.nid = nid;
            info.title = this.title.Text.Trim();
            info.cid = TypeConverter.StrToInt(cid.SelectedValue);
            info.czid = TypeConverter.StrToInt(czid.SelectedValue);
            info.qi = TypeConverter.StrToInt(this.qi.Text.Trim());
            if (zid.Visible == true)
                info.zid = TypeConverter.StrToInt(zid.SelectedValue);
            else
                info.zid = TypeConverter.StrToInt(zidrbt.SelectedValue);
            if (BBRequest.GetQueryString("color") != null)
                info.color = BBRequest.GetFormString("color").Trim();
            else
                info.color = "";
            info.context = BBRequest.GetFormString("content").Replace("alt=\"\"", "alt=\"" + info.title + "\"");
            info.uid = aid;
            info.username = ausername;
            info.anthor = ausername;
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
                JsRedirect("news_merge.aspx");
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
            BinderZone(TypeConverter.StrToInt(cid.SelectedValue), 0);
        }

        protected void czid_SelectedIndexChanged(object sender, EventArgs e)
        {
            qi.Text = Cz.GetCzInfo(TypeConverter.StrToInt(czid.SelectedValue), false).qi.ToString();
        }

        protected void zid_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZoneSelect(this.zid.SelectedValue);
        }

        protected void zidrbt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZoneSelect(this.zidrbt.SelectedValue);
        }
    }
}