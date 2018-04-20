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
    public partial class live_3d : Pages
    {
        protected Kjh3dInfo info = new Kjh3dInfo();

        protected void Page_Load(object sender, EventArgs e)
        {
            info = Kjh3d.GetKjh3dInfoTop1(1, true);
        }
    }
}