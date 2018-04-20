using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataProvider;
using Business;
using Common;
using Model;
using System.Text;

namespace Admin.Ajax
{
    public partial class NewsGet : System.Web.UI.Page
    {
        protected int cid;
        protected int page,pagesize;
        protected int nid;
        protected int count;
        StringBuilder sb = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {
            //cid = BBRequest.GetQueryInt("cid", 0);
            //nid = BBRequest.GetQueryInt("nid", 0);
            //page = BBRequest.GetQueryInt("page", 1);
            //pagesize = BBRequest.GetQueryInt("pagesize", 10);

            cid = BBRequest.GetFormInt("cid", 0);
            nid = BBRequest.GetFormInt("nid", 0);
            page = BBRequest.GetFormInt("page", 1);
            pagesize = BBRequest.GetFormInt("pagesize", 10);

            if (nid > 0)
            {
                GetInfo();
            }
            else
            {
                GetList();
            }
        }

        private void GetList()
        {
            List<NewsInfo> List = Business.News.GetNewsPageList(pagesize, page, cid, 0, 0, out count, 0);
            sb.Append("<?xml version=\"1.0\"  encoding=\"utf-8\" ?>\n");
            sb.Append("<list>\n");

            if (List != null && List.Count > 0)
            {
                for (int i = 0; i < List.Count; i++)
                {
                    sb.Append("<news>\n");
                    sb.Append("<nid>" + List[i].nid + "</nid>\n");
                    sb.Append("<cid>" + List[i].cid + "</cid>\n");
                    sb.Append("<zid>" + List[i].zid + "</zid>\n");
                    sb.Append("<title><![CDATA[" + List[i].title + "]]></title>\n");
                    sb.Append("</news>\n");
                }
            }
            sb.Append("<count>" + count + "</count>\n");
            sb.Append("</list>\n");            
            Response.Clear();
            this.Response.ContentType = "text/xml";
            Response.Charset = "utf-8";
            Response.Write(sb);
        }

        private void GetInfo()
        {
            NewsInfo Info = Business.News.GetNewsInfo(nid);
            sb.Append("<?xml version=\"1.0\"  encoding=\"utf-8\" ?>\n");
            sb.Append("<list>\n");

            if (Info != null && Info.title.Length > 0)
            {
                sb.Append("<news>\n");
                sb.Append("<nid>" + Info.nid + "</nid>\n");
                sb.Append("<cid>" + Info.cid + "</cid>\n");
                sb.Append("<zid>" + Info.zid + "</zid>\n");
                sb.Append("<title><![CDATA[" + Info.title + "]]></title>\n");
                sb.Append("<context><![CDATA[" + Info.context + "]]></context>\n");
                sb.Append("</news>\n");
            }
            sb.Append("</list>\n");
            Response.Clear();
            this.Response.ContentType = "text/xml";
            Response.Charset = "utf-8";
            Response.Write(sb);
        }
     
    }
}
