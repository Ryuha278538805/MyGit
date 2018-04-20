using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Business;
using Common;

namespace Www.kj
{
    public partial class p3_list : Pages
    {
        protected int page = 1;
        public static int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                page = BBRequest.GetQueryInt("page", 1);
            }
            catch { }
            if (page < 1)
                page = 1;
            BinderList();
        }

        private void BinderList()
        {
            List<KjhP3Info> list = KjhP3.GetKjhP3PageList(AspNetPager1.PageSize, page, count, true);
            count = KjhP3.GetKjhP3Count(true);
            if (list != null && list.Count > 0)
            {
                this.kjhlist.DataSource = list;
                kjhlist.DataBind();
                this.AspNetPager1.RecordCount = count;
                AspNetPager1.UrlRewritePattern = "/kj/p3/list_{0}.html";
            }
        }

        public string GetPage()
        {
            return page > 1 ? "-第" + page + "页" : "";
        }
    }
}