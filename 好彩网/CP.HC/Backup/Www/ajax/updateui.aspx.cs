using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataProvider;
using Common;

namespace Www.ajax
{
    public partial class updateui : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string u = BBRequest.GetQueryString("u");
            string p = BBRequest.GetQueryString("p");
            int lk = BBRequest.GetInt("lk", 0);

            if (u == "haocw" && p == "D722D03E8E3DB0CA")
                NewsData.UpdateNewsUi(lk);
        }
    }
}