using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;

namespace Shop
{
    public partial class error : Pages
    {
        protected string msg;
        protected int er;
        protected string refresh, url;
        protected void Page_Load(object sender, EventArgs e)
        {
            er = BBRequest.GetQueryInt("error");
            if (er > 0 && er < 8)
                msg = errormsg[er];
            switch (er)
            {
                case 6: url = "/goods/my.html";
                    break;
                case 7: url = "/goods/my.html";
                    break;
                default:
                    break;
            }
            if (er == 6 || er == 7)
                refresh = "<meta http-equiv=\"refresh\" content=\"3;url="+url+"\">";
        }
    }
}