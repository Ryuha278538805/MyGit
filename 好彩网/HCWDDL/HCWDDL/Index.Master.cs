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
    public partial class Index : System.Web.UI.MasterPage
    {
        /// <summary>
        /// 首页导航
        /// </summary>
        public IList<tbl_news_classInfo> Navs { get; set; }

        /// <summary>
        /// 首页菜单
        /// </summary>
        public IList<M_MenuModel> Menus { get; set; }

        public IList<string> ParentNames { get; set; }

        public IList<tbl_ADmanagerInfo> ADsMTop { get; set; }

        public IList<tbl_ADmanagerInfo> ADsM { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Navs = NewsClassManager.Navs;
            Menus = NewsClassManager.Menus;
            //上位广告获取
            ADsMTop = NewsClassManager.ADsM.Where(p => p.PositonType == 0).ToList();
            //下位广告获取
            ADsM = NewsClassManager.ADsM.Where(p => p.PositonType == 1).ToList();

            ParentNames = Menus.Select(p => p.PName).Distinct().ToArray();
        }
    }
}