using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using Business;

namespace Admin.Ajax
{
    public partial class KjhMode : Pages
    {
        protected int Mode;  
        protected int Method;
        protected string id = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (allow.AllowPub)
            {
                Mode = BBRequest.GetFormInt("mo", 0);
                Method = BBRequest.GetFormInt("me", 0);
                id = BBRequest.GetFormString("id", false);
                id = id.Replace("on,", "").Replace(",0", "");  //剔除无效数据
                if (Mode >= 0 && Method > 0 && id != null && id.Length > 0)
                {
                    Action();
                }
            }
        }

        private void Action()
        {
            switch (Mode)
            {
                case (int)KjhCz.Cz225:
                    if (Method == 2)
                        Kjh225.DeleteKjh225Info(id);
                    break;
                case (int)KjhCz.Cz3d:
                    if (Method == 2)
                        Kjh3d.DeleteKjh3dInfo(id);
                    break;
                case (int)KjhCz.Czdlt:
                    if (Method == 2)
                        KjhDlt.DeleteKjhDltInfo(id);
                    break;
                case (int)KjhCz.Czp3:
                    if (Method == 2)
                        KjhP3.DeleteKjhP3Info(id);
                    break;
                case (int)KjhCz.Czqlc:
                    if (Method == 2)
                        KjhQlc.DeleteKjhQlcInfo(id);
                    break;
                case (int)KjhCz.Czqxc:
                    if (Method == 2)
                        KjhQxc.DeleteKjhQxcInfo(id);
                    break;
                case (int)KjhCz.Czssq:
                    if (Method == 2)
                        KjhSsq.DeleteKjhSsqInfo(id);
                    break;
                default:
                    break;
            }
            Response.Write("ok");
        }
    }
}