using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Business;
using Common;

namespace Admin
{
    public partial class yc_add : Pages
    {
        protected int yid;
        protected YcInfo ycinfo = new YcInfo();
        protected YcZoneInfo yzinfo = new YcZoneInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowConfig)
                AllowMessage("对不起，当前用户无此权限！");
            menus1.clicked = 46;   //左边menu样式选中
            yid = BBRequest.GetQueryInt("yid", 0);
            if (!Page.IsPostBack)
            {
                if (yid > 0)
                {
                    BinderYcInfo();
                }
            }
        }

        private void BinderYcInfo()
        {
            ycinfo = Yc.GetYcInfoByYID(yid);
            yzinfo = YcZone.GetYcZoneByYzID(ycinfo.yzid);
            qi.Text = ycinfo.qi.ToString();
            info.Text = ycinfo.info;
            title.Text = ycinfo.title;
            context1.Text = ycinfo.context;
            kjh.Text = ycinfo.kjh;
            context1.Text = ycinfo.context;
            isright.Checked = ycinfo.isright;
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            if (yid > 0)
            {
                ycinfo = Yc.GetYcInfoByYID(yid);

                ycinfo.qi = TypeConverter.StrToInt(qi.Text);
                ycinfo.info = info.Text.Trim();
                ycinfo.title = title.Text.Trim();
                ycinfo.context = context1.Text.Trim();
                ycinfo.kjh = kjh.Text.Trim();
                ycinfo.context = context1.Text.Trim();
                ycinfo.isright = isright.Checked;

                int i = Yc.CreateYcInfo(ycinfo);
                if (i > 0)
                {                   
                        AlertMessage("提示：数据编辑成功! ", "yc_list.aspx");
                }
                else if (i < 0)
                    AlertMessage("数据已经存在，请勿重复添加....");
                else
                    AlertMessage("保存失败，请重试....");
            }
        }
    }
}