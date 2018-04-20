using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Common;
using Business;

namespace Www.yc
{
    public partial class list : Pages
    {
        protected int czid, type;
        protected CzInfo czinfo = new CzInfo();
        protected string[] YcType = YcUtil.YcType;
        protected string typestr = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                czid = BBRequest.GetQueryInt("czid", 0);
                type = BBRequest.GetQueryInt("type", 0);
                if (czid == 0)
                    czid = 1;
            }
            catch { }
            if (czid > 0)
            {
                czinfo = Cz.GetCzInfo(czid, true);
                if (czinfo == null)
                    Response.Redirect("/404.aspx");
                else
                {
                    if (type > 0 && type <= YcType.Length)
                    {
                        typestr = YcType[type - 1];
                    }
                    BinderYcZoneList(czid, type, yczonelist);
                }
            }
        } 
    }
}