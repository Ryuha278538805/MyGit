﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Business;
using Common;

namespace Www.kaijiang
{
    public partial class _225 : Pages
    {
        protected int qi;
        protected Kjh225Info info = new Kjh225Info();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                qi = BBRequest.GetQueryInt("qi", 0);
            }
            catch { }
            if (qi > 0)
                info = Kjh225.GetKjh225Info(0, qi, true);

            List<Kjh225Info> listkjh = Kjh225.GetKjh225PageList(10, 1, 0, true);
            if (listkjh != null && listkjh.Count > 0)
            {
                list.DataSource = listkjh;
                list.DataBind();
            }

            BinderBBSTopic(this.bbslist, "2,3,4,7,8,9,10", 15);  
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