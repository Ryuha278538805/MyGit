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
    public partial class p3 : Pages
    {
        protected int qi;
        protected KjhP3Info info = new KjhP3Info();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                qi = BBRequest.GetQueryInt("qi", 0);
            }
            catch { }
            if (qi > 0)
                info = KjhP3.GetKjhP3Info(0, qi, true);

            List<KjhP3Info> listkjh = KjhP3.GetKjhP3PageList(10, 1, 0, true);
            if (listkjh != null && listkjh.Count > 0)
            {
                list.DataSource = listkjh;
                list.DataBind();
            }
            BinderBBSTopic(bbsp3list, "9,10", 15);   
        }

        protected string GetSelect(int qi, object now)
        {
            if (qi == TypeConverter.ObjectToInt(now))
                return "selected=\"selected\"";
            else
                return "";
        }
    }
}