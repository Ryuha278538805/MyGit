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
    public partial class ssq : Pages
    {
        protected int qi;
        protected KjhSsqInfo info = new KjhSsqInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                qi = BBRequest.GetQueryInt("qi", 0);
            }
            catch { }
            if (qi > 0)
                info = KjhSsq.GetKjhSsqInfo(0, qi, true);

            List<KjhSsqInfo> listkjh = KjhSsq.GetKjhSsqPageList(10, 1, 0, true);
            if (listkjh != null && listkjh.Count > 0)
            {
                list.DataSource = listkjh;
                list.DataBind();
            }
            BinderBBSTopic(this.bbsssqlist, "7,8", 15); 
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