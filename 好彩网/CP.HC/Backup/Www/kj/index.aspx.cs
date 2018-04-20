using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Business;
using Common;

namespace Www.kjh
{
    public partial class index : Pages
    {
        protected Kjh225Info info225 = Kjh225.GetKjh225InfoTop1(true);
        protected Kjh3dInfo info3dnew = Kjh3d.GetKjh3dInfoTop1(0,true);
        protected Kjh3dInfo info3d = Kjh3d.GetKjh3dInfoTop1(1, true); 
        protected KjhDltInfo infodlt = KjhDlt.GetKjhDltInfoTop1(true);
        protected KjhQlcInfo infoqlc = KjhQlc.GetKjhQlcInfoTop1(true);
        protected KjhQxcInfo infoqxc = KjhQxc.GetKjhQxcInfoTop1(true);
        protected KjhP3Info infop3 = KjhP3.GetKjhP3InfoTop1(true);
        protected KjhSsqInfo infossq = KjhSsq.GetKjhSsqInfoTop1(true);

        protected void Page_Load(object sender, EventArgs e)
        {
            //把最新的值赋予显示的值
            if (info3dnew.kjh != null && info3dnew.kjh > 0) info3d = info3dnew;
        }
    }
}