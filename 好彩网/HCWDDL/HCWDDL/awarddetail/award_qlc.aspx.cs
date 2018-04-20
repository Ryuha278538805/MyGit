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
    public partial class award_qlc : System.Web.UI.Page
    {
        public IList<QiModel> DIC_QI { get; set; }
        public tbl_qlcInfo Model { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            cpkjService service = new cpkjService();
            DIC_QI = service.M_GetCPqi("tbl_qlc");
            if (!string.IsNullOrEmpty(Request["id"]))
            {
                Model = service.M_GetCPDetail<tbl_qlcInfo>("tbl_qlc", Int32.Parse(Request["id"]));
            }
        }
    }
}