using HCW.Bussiness;
using HCW.Master;
using HCW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HCWDDL.M
{
    public partial class awards : System.Web.UI.Page
    {
        public tbl_3dInfo SDInfo { get; set; }
        public tbl_ssqInfo SSQInfo { get; set; }
        public tbl_dltInfo DLTInfo { get; set; }
        public tbl_p3Info P3Info { get; set; }
        public tbl_qxcInfo QXCInfo { get; set; }
        public tbl_qlcInfo QLCInfo { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            SDInfo = CPManager.SDInfo;
            SSQInfo = CPManager.SSQInfo;
            DLTInfo = CPManager.DLTInfo;
            P3Info = CPManager.P3Info;
            QXCInfo = CPManager.QXCInfo;
            QLCInfo = CPManager.QLCInfo;
        }
    }
}