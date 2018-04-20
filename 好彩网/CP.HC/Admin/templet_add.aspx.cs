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
    public partial class templet_add : Pages
    {
        protected int tid = 0;  //文章模板ID
        public string context;
        public string color="";
        public string templetabout = "";
        string[,] temp;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowConfig)
                AllowMessage("对不起，当前用户无此权限！");
            menus1.clicked = 19;
            //隐藏radio控件            
            tid = BBRequest.GetQueryInt("tid", 0);
            temp = Templet.CraeteVoidTemplet();
            templetabout += "<li>期号 {qi}</li>";
            for (int i = 0; i < 66; i++)
            {
                templetabout += "<li>"+temp[i, 0] + " " + temp[i, 1] + "</li>";
            }

            if (!Page.IsPostBack)
            {
                this.zidrbt.Visible = false;
                BinderNewsClass(0);
                BinderCz();
                
                #region 设置上次添加的分类
                string cookiecid = CookieUtil.GetCookie("tcid");
                string cookieczid = CookieUtil.GetCookie("tczid");
                if (!string.IsNullOrEmpty(cookiecid))
                {
                    int _cid = TypeConverter.StrToInt(cookiecid);
                    if (_cid > 0)
                    {
                        this.cid.SelectedValue = _cid.ToString();
                        BinderZone(TypeConverter.StrToInt(cid.SelectedValue),0);
                    }
                }
                else
                {
                    BinderZone(0,0);
                }
                if (!string.IsNullOrEmpty(cookieczid))
                {
                    int _czid = TypeConverter.StrToInt(cookieczid);                  
                    if (_czid > 0)
                        this.czid.SelectedValue = _czid.ToString();
                }
                #endregion
                
                if (tid > 0)
                        GetNewsInfo();
                
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

        private void GetNewsInfo()
        {
            NewsTempletInfo info = NewsTemplet.GetNewsTempletInfo(tid);
            if (info != null && info.tid > 0)
            {
                BinderZone(info.cid, info.zid);
                this.cid.SelectedValue = info.cid.ToString();
                this.czid.SelectedValue = info.czid.ToString();
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
                added = Zone.GetZoneTempAddedList(cid, false);
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
            NewsTempletInfo info = new NewsTempletInfo();
            info.tid = tid;
            info.title = this.title.Text.Trim();
            info.cid = TypeConverter.StrToInt(cid.SelectedValue);            
            info.czid = TypeConverter.StrToInt(czid.SelectedValue);
            if(zid.Visible==true)
                info.zid = TypeConverter.StrToInt(zid.SelectedValue);
            else
                info.zid = TypeConverter.StrToInt(zidrbt.SelectedValue);
            if (BBRequest.GetQueryString("color") != null)
                info.color = BBRequest.GetFormString("color").Trim();
            else
                info.color = "";
            info.context = BBRequest.GetFormString("content").Replace("alt=\"\"", "alt=\"" + info.title + "\"");
            info.anthor = anickname;
            if (this.isbest.Checked)
                info.isbest = 1;
            if (this.ishot.Checked)
                info.ishot = 1;
            if (this.istop.Checked)
                info.istop = 1;

            //记录分类cookie
            CookieUtil.WriteCookie("tcid", info.cid.ToString());
            CookieUtil.WriteCookie("tczid", info.czid.ToString());

            int i = NewsTemplet.CreateNewsTempletInfo(info);
            if (i > 0)
            {
                JsRedirect("templet_add.aspx");
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
            BinderZone(TypeConverter.StrToInt(cid.SelectedValue),0);
        }

    }
}