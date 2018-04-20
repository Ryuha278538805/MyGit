using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataProvider;
using Common;

namespace Admin.Ajax
{
    public partial class News : System.Web.UI.Page
    {
        protected int nid;
        protected int doit;
        protected void Page_Load(object sender, EventArgs e)
        {
            nid = BBRequest.GetFormInt("nid", 0);
            doit = BBRequest.GetFormInt("doit", 0);
            if (nid > 0 && doit == 2)
            {
                DelNews(nid);   //删除单品
            }
        }

        private void DelNews(int nid)
        {
            NewsData.DeleteNewsInfo(nid.ToString());
            Response.Write("ok");
        }
    }
}
