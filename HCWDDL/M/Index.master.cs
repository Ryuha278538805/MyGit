using HCW.Master;
using HCW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class M_Index : System.Web.UI.MasterPage
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

    protected void Page_Load(object sender, EventArgs e)
    {
        Navs = NewsClassManager.Navs;
        Menus = NewsClassManager.Menus;
        ParentNames = Menus.Select(p=>p.PName).Distinct().ToArray();
    }
}
