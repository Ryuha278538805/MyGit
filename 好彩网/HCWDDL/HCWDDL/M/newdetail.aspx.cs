using HCW.Bussiness;
using HCW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HCWDDL.M
{
    public partial class newdetail : System.Web.UI.Page
    {
        public tbl_news_Model Model { get; set; }
        public IList<tbl_news_Model> lstHots { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            tbl_newsService s = new tbl_newsService();
            Model = s.M_GetNewsDetail(Int32.Parse(Request["id"]));
            lstHots = s.M_GetHots(Model.cid);
        }
    }
}