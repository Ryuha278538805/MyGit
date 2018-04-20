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
    public partial class _3d : Pages
    {
        protected int qi;
        protected Kjh3dInfo info = new Kjh3dInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                qi = BBRequest.GetQueryInt("qi", 0);
            }
            catch { }
            if (qi > 0)
               info = Kjh3d.GetKjh3dInfo(0, qi, true);

            List<Kjh3dInfo> listkjh = Kjh3d.GetKjh3dPageList(10, 1, 0, true);
            if (listkjh != null && listkjh.Count > 0)
            {
                list.DataSource = listkjh;
                list.DataBind();
            }
            BinderBBSTopic(this.bbssdlist, "2,3,4", 15);   //顶部3D论坛
        }

        protected string GetSelect(int qi,object now)
        {
            if (qi == TypeConverter.ObjectToInt(now))
                return "selected=\"selected\"";
            else
                return "";
        }
    }   
}