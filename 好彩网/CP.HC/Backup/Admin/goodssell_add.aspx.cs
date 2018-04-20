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

namespace Admin
{
    public partial class goodssell_add : Pages
    {
        protected int sid = 0;  //商品ID
        protected GoodsInfo ginfo = new GoodsInfo();
        protected GoodsSellInfo sinfo = new GoodsSellInfo();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowUser)
                AllowMessage("对不起，当前用户无此权限！");
            menus1.clicked = 45;
            sid = BBRequest.GetQueryInt("sid", 0);
            if (!Page.IsPostBack)
            {
                if (sid > 0)
                    BinderGoodsSellInfo();
                else
                {
                    this.username.ReadOnly = true;
                    this.codes.ReadOnly = true;
                    this.postaddress.ReadOnly = true;
                    this.postno.ReadOnly = true;
                    this.posttel.ReadOnly = true;
                    this.postname.ReadOnly = true;
                    this.postmethod.Visible = false;
                    this.postcode.ReadOnly = true;
                    this.save.Enabled = false;
                }
            }
        }

        private void BinderGoodsSellInfo()
        {
            sinfo = GoodsSell.GetGoodsSellInfo(sid);
            if (sinfo != null && sinfo.gid > 0)
            {
                ginfo = Goods.GetGoodsInfo(sinfo.gid);
                this.username.Text = sinfo.username.ToString();
                this.codes.Text = sinfo.codes;
                this.postaddress.Text = sinfo.postaddress;
                this.postno.Text = sinfo.postno;
                this.postname.Text = sinfo.postname;
                this.posttel.Text = sinfo.posttel;
                if (sinfo.postmethod.Length > 0)
                    this.postmethod.SelectedValue = sinfo.postmethod.ToString();
                this.postcode.Text = sinfo.postcode;
                this.isposted.Checked = sinfo.isposted;
            }           
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            this.save.Enabled = false;
            int i = CreateGoodsInfo();
            if (i > 0)
            {
                JsRedirect("goodssell_list.aspx");
                //if (nid == 0)
                //    AlertMessage("提示：数据添加成功!", "goodssell_list.aspx");
                //else
                //    AlertMessage("提示：数据编辑成功!", "goodssell_list.aspx");
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
            GoodsSellInfo info = GoodsSell.GetGoodsSellInfo(sid);
            if (info.sid > 0 && info.gid > 0)
            {
                ginfo = Goods.GetGoodsInfo(info.gid);
                info.username = username.Text.ToString().Trim();
                info.codes = codes.Text.ToString().Trim();
                info.postaddress = postaddress.Text.ToString().Trim();
                info.postcode = postcode.Text.ToString().Trim();
                info.postmethod = postmethod.SelectedValue.Trim();
                info.postname = postname.Text.ToString().Trim();
                info.postno = postno.Text.ToString().Trim();
                info.posttel = posttel.Text.ToString().Trim();
                if (info.postmethod.Length > 0 && info.postcode.Length > 0)
                    info.isposted = true;
                return GoodsSell.CreateGoodsSellInfo(info, ginfo);
            }
            else
            {
                return 0;
            }
        }
    }
}