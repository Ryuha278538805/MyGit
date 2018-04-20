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
    public partial class main : System.Web.UI.Page
    {
        public tbl_3dInfo SDInfo { get; set; }
        public tbl_ssqInfo SSQInfo { get; set; }
        public IList<tbl_news_Model> IndexNews { get; set; }
        public IList<string> ParentNames { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            SDInfo = CPManager.SDInfo;
            SSQInfo = CPManager.SSQInfo;
            IndexNews = NewsClassManager.IndexNews;
            ParentNames = IndexNews.Select(p => p.PName).Distinct().ToArray();
        }
    }
}