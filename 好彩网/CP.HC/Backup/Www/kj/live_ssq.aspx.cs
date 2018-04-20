using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Business;

namespace Www.kj
{
    public partial class live_ssq : Pages
    {
        protected KjhSsqInfo info = new KjhSsqInfo();

        protected void Page_Load(object sender, EventArgs e)
        {
            info = KjhSsq.GetKjhSsqInfoTop1(true);
        }
    }
}