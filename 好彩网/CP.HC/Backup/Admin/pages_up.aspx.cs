using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using Model;
using Business;

namespace Admin
{
    public partial class pages_up : Pages
    {
        private int pageid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowPage)
                AllowMessage("对不起，当前用户无此权限！");

            menus1.clicked = 36;
            pageid = BBRequest.GetQueryInt("pageid", 0);

            if (!Page.IsPostBack)
                binderClass();
        }

        private void binderClass()
        {
            List<PageInfo> list = Pagetj.GetPageList(pageid);
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    ListItem li = new ListItem(list[i].title, list[i].id.ToString());
                    this.id.Items.Add(li);
                }
            }
        }



        protected void enter_Click(object sender, EventArgs e)
        {
            PageInfo info = new PageInfo();
            info.id = TypeConverter.StrToInt(id.SelectedValue);
            info.context = this.context.Text;
            if (info.id > 0)
            {
                Pagetj.UpdatePageInfo(info);
            }
            AlertMessage("保存成功...");
        }

        protected void id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _id = TypeConverter.StrToInt(id.SelectedValue);
            if (_id > 0)
            {
                this.context.Text = Pagetj.GetPageInfo(_id).context;
            }
        }
    }
}