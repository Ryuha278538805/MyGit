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
    public partial class award_ssq : System.Web.UI.Page
    {
        public IList<QiModel> DIC_QI { get; set; }
        public tbl_ssqInfo Model { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            cpkjService service = new cpkjService();
            DIC_QI = service.M_GetCPqi("tbl_ssq");
            if (!string.IsNullOrEmpty(Request["id"]))
            {
                Model = service.M_GetCPDetail<tbl_ssqInfo>("tbl_ssq", Int32.Parse(Request["id"]));
            }
        }
    }
}