using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;

namespace Www
{
    public partial class footer : System.Web.UI.UserControl
    {
        /// <summary>
        /// 热点导航
        /// </summary>
        public string HotNavStr = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            HotNavStr = Business.Pagetj.GetPageInfo(5).context;
        }
    }
}