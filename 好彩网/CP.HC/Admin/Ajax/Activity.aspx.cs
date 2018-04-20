using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataProvider;
using Common;

namespace Admin.Ajax
{
    public partial class Activity : System.Web.UI.Page
    {
        protected int actid;
        protected int doit;
        protected void Page_Load(object sender, EventArgs e)
        {
            actid = BBRequest.GetFormInt("actid", 0);
            doit = BBRequest.GetFormInt("doit", 0);
            if (actid > 0 && doit == 2)
            {
                DelActivity(actid);   //删除单品
            }
        }

        private void DelActivity(int actid)
        {
            //if (ActivityData.DeleteActivity(actid))
            //    Response.Write("ok");
        }
    }
}
