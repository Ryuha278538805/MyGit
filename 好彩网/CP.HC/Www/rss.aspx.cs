using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;
using Business;
using Model;
using Common;
using DataProvider;
using System.Text;

namespace Www
{
    public partial class rss : Pages
    {        
        public int cid;
        private string ename;
        protected NewsClassInfo newsclassinfo = new NewsClassInfo();
        StringBuilder sb = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ename = BBRequest.GetQueryString("ename");
            }
            catch { }
            if (!string.IsNullOrEmpty(ename))
            {
                cid = NewsClass.GetNewsClassInfo(ename, true).cid;
            }
            if (cid > 0)
            {
                newsclassinfo = NewsClass.GetNewsClassInfo(cid, true);
                binderList();
            }
            else
                Response.Redirect("/");
        }

        private void binderList()
        {
            int pagesize = 50;
            List<NewsInfo> List = News.GetNewsList(pagesize, cid, 0);            
            sb.Append(@"<?xml version=""1.0""  encoding=""utf-8"" ?>");            
            sb.Append(@"<rss version=""2.0"">");
            sb.Append(@"<channel>");
            sb.Append(@"<title>"+newsclassinfo.name+"</title>");            
            if (List != null && List.Count > 0)
            {
                for (int i = 0; i < List.Count; i++)
                {
                    sb.Append(@"<item>");
                    sb.Append(@"<title>" + List[i].title + "</title>");
                    sb.Append(@"<link>http://www.haocw.com/" + ename + "/" + Getdir(List[i].addtime) + "/" + List[i].nid + ".html</link>");
                    sb.Append(@"<description></description>");
                    sb.Append(@"<category></category>");
                    sb.Append(@"<author>" + List[i].anthor + "</author>");
                    sb.Append(@"<pubDate>" + XmlConvert.ToString(List[i].addtime, "yyyy-MM-dd HH:mm:ss.fffffffzzzzzz") + "</pubDate>");
                    sb.Append(@"</item>");
                }
            }
            sb.Append("@</channel>");
            sb.Append("@</rss>");
            Response.Clear();
            this.Response.ContentType = "text/xml";
            Response.Charset = "utf-8";
            Response.Write(sb);
        }
    }
}