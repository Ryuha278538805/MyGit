using HCW.Bussiness;
using HCW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HCWDDL.M.awarddetail
{
    public partial class award_3d : System.Web.UI.Page
    {
        public IList<string> DIC_QI { get; set; }
        public tbl_3dInfo Model { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            cpkjService service = new cpkjService();
            DIC_QI = service.M_GetCPqi("tbl_3d");
            if (!string.IsNullOrEmpty(Request["id"]))
            {
                Model = service.M_GetCPDetail<tbl_3dInfo>("tbl_3d", Int32.Parse(Request["id"]));
            }
            else
            {
                Model = service.M_GetCPInfo<tbl_3dInfo>("tbl_3d", Request["qi"]);
            }
        }
    }
}