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
    public partial class live_p3 : Pages
    {
        protected KjhP3Info info = new KjhP3Info();

        protected void Page_Load(object sender, EventArgs e)
        {
            info = KjhP3.GetKjhP3InfoTop1(true);
        }
    }
}