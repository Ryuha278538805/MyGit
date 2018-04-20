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
    public partial class award_p3 : System.Web.UI.Page
    {
        public IList<QiModel> DIC_QI { get; set; }
        public tbl_p3Info Model { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            cpkjService service = new cpkjService();
            DIC_QI = service.M_GetCPqi("tbl_p3");
            if (!string.IsNullOrEmpty(Request["id"]))
            {
                Model = service.M_GetCPDetail<tbl_p3Info>("tbl_p3", Int32.Parse(Request["id"]));
            }
        }
    }
}