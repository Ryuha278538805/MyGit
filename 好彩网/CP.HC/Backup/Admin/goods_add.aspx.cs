using System;
using System.Collections.Generic;
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
    public partial class goods_add : Pages
    {
        protected int gid = 0;  //商品ID
        public string about;
        protected int width = UpPicConfig.GOODSIMG_TH_WIDTH;
        protected int height = UpPicConfig.GOODSIMG_TH_HEIGHT;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowUser)
                AllowMessage("对不起，当前用户无此权限！");
            menus1.clicked = 41;
            //隐藏radio控件            
            gid = BBRequest.GetQueryInt("gid", 0);
            this.codesselled.ReadOnly = true;
            this.countselled.ReadOnly = true;
            if (!Page.IsPostBack)
            {
                BinderGoodsClass();
                BinderPayExtcredits();

                #region 设置上次添加的分类
                string cookiegcid = CookieUtil.GetCookie("gcid");
                string cookiepayextcredits = CookieUtil.GetCookie("payextcredits");
                if (!string.IsNullOrEmpty(cookiegcid))
                {
                    int _gcid = TypeConverter.StrToInt(cookiegcid);
                    if (_gcid > 0)
                    {
                        this.gcid.SelectedValue = _gcid.ToString();
                    }
                }
                if (!string.IsNullOrEmpty(cookiepayextcredits))
                {
                    int _payextcredits = TypeConverter.StrToInt(cookiepayextcredits);
                    if (_payextcredits > 0)
                        this.payextcredits.SelectedValue = _payextcredits.ToString();
                }
                #endregion

                if (gid > 0)
                    BinderGoodsInfo();
            }
        }

        /// <summary>
        /// 绑定分类 
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
        
        /// <summary>
        /// 绑定支付方式
        /// </summary>
        private void BinderPayExtcredits()
        {
            for (int i = 0; i < PayMethod.Length; i++)
                {
                    ListItem li = new ListItem(PayMethod[i], (i+1).ToString().Trim());
                    this.payextcredits.Items.Add(li);
                }            
        }

        private void BinderGoodsInfo()
        {
            GoodsInfo info = Goods.GetGoodsInfo(gid);
            if (info != null && info.gid > 0)
            {
                this.gcid.SelectedValue = info.gcid.ToString();
                this.payextcredits.SelectedValue = info.payextcredits.ToString();
                this.gname.Text = info.gname.ToString();
                this.count.Text = info.count.ToString();
                this.countselled.Text = info.countselled.ToString();
                this.score.Text = info.score.ToString();
                this.codes.Text = info.codes.Replace("|", "\n"); ;
                this.codesselled.Text = info.codesselled.Replace("|", "\n");
                this.aboutshort.Text = info.aboutshort;                
                this.isautopost.Checked = info.isautopost;
                this.needpost.Checked = info.needpost;
                this.issell.Checked = info.iseveryday;
                this.iseveryday.Checked = info.iseveryday;
                if (info.gettime.Length > 0)
                {
                    try
                    {
                        this.gettime.SelectedValue = info.gettime;
                    }
                    catch { }
                }
                about = info.about;
                if (info.img != null && info.img.Length >10)
                {
                    this.sphoto.Text = "已传图片";
                    this.sphoto.NavigateUrl = info.img;
                    this.sphoto.Target = "_balnk";
                }
            }
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            this.save.Enabled = false;
            int i = CreateGoodsInfo();
            if (i > 0)
            {
                JsRedirect("goods_add.aspx");
                //if (nid == 0)
                //    AlertMessage("提示：数据添加成功!", "news_add.aspx");
                //else
                //    AlertMessage("提示：数据编辑成功!", "news_add.aspx");
            }
            else if (i < 0)
                AlertMessage("数据已经存在，请勿重复添加....");
            else
                AlertMessage("保存失败，请重试....");
            this.save.Enabled = true;
        }

         /// <summary>
        /// 生成数据
        /// </summary>
        private int CreateGoodsInfo()
        {
            GoodsInfo info = new GoodsInfo();
            info.gid = gid;
            info.gname = gname.Text.ToString().Trim();
            info.gcid = TypeConverter.StrToInt(gcid.SelectedValue);
            info.payextcredits = TypeConverter.StrToInt(payextcredits.SelectedValue);
            info.count = TypeConverter.StrToInt(count.Text);
            info.countselled = TypeConverter.StrToInt(countselled.Text);
            info.score = TypeConverter.StrToInt(score.Text);
            info.codes = codes.Text.ToString().Trim().Replace("\n", "|");
            info.codesselled = codesselled.Text.ToString().Trim().Replace("\n", "|");
            info.aboutshort = aboutshort.Text.ToString().Trim();
            info.about = BBRequest.GetFormString("about").Replace("alt=\"\"", "alt=\"" + info.gname + "\"");
            info.isautopost = isautopost.Checked;
            info.needpost = needpost.Checked;
            info.issell = issell.Checked;
            info.iseveryday = iseveryday.Checked;
            info.gettime = gettime.SelectedValue.Trim();

            /////处理上传
            if (this.File1.PostedFile != null)
            {
                UpLoadFileV2.Up upload = new Up();
                upload.UpPhotoFile(UpPicConfig.GOODSIMG_PATH, true, UpPicConfig.GOODSIMG_TH_WIDTH, UpPicConfig.GOODSIMG_TH_HEIGHT, "CUT");
                info.img = upload.FileUrl;
            }
            if (string.IsNullOrEmpty(info.img))
                info.img = this.sphoto.NavigateUrl;

            //记录分类cookie
            CookieUtil.WriteCookie("gcid", info.gcid.ToString());
            CookieUtil.WriteCookie("payextcredits", info.payextcredits.ToString());

            return Goods.CreateGoodsInfo(info);
        }
    }
}