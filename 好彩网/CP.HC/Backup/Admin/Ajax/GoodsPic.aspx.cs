using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataProvider;
using Common;

namespace Admin.Ajax
{
    public partial class GoodsPic : System.Web.UI.Page
    {
        protected int gid = 0;
        protected int pid = 0;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            gid = BBRequest.GetFormInt("gid",0);
            pid = BBRequest.GetFormInt("pid", 0);
            if (pid > 0 && gid>0)
            {
                DelPic(pid);    //删除一张图
            }
            if (gid > 0)
            {
                GetPic(gid);   //获取图片
            }
        }

        private void DelPic(int pid)
        {
           // NewsPhotoData.DelPhotoInfo(pid, gid);
        }

        private void GetPic(int gid)
        {
            //string _photo = string.Empty;
            //DataTable dt = NewsPhotoData.GetGoodsPhotoInfo(gid);
            //if (dt != null && dt.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //       _photo += dt.Rows[i]["pid"].ToString()+","+dt.Rows[i]["photo"].ToString().Trim();
            //       if (i < dt.Rows.Count - 1)
            //           _photo += "|";
            //    }                
            //}
            //Response.Write(_photo);
        }
    }
}
