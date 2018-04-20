using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using DataProvider;
using Business;
using Common;
using Model;


namespace Www.ajax
{
    public partial class waterfall : Pages
    {
        protected int cid;
        protected int page, pagesize;
        protected int count;
        protected string ename = "";
        StringBuilder sb = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {
            cid = BBRequest.GetFormInt("cid", 0);
            page = BBRequest.GetFormInt("page", 1);
            pagesize = BBRequest.GetFormInt("pagesize", 10);
            GetList();
        }

        private void GetList()
        {
            string where = "",pic= "";
            if (cid > 0)
            {
                ename = NewsClass.GetNewsClassInfo(cid, true).ename;
                where = "cid=" + cid.ToString();
            }
            else
            {
                ename = "sd";
            }
            DataSet ds = NewsData.GetPageList(pagesize, page, "vv_newsinfo", "nid desc", where);
            sb.Append("<?xml version=\"1.0\"  encoding=\"utf-8\" ?>\n");
            sb.Append("<channel>\n");

            if (ds != null && ds.Tables.Count>0  && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    sb.Append("<item>\n");
                    sb.Append("<nid>" + ds.Tables[0].Rows[i]["nid"] + "</nid>\n");
                    sb.Append("<url>http://www.haocw.com/" + ename + "/" + Getdir(ds.Tables[0].Rows[i]["addtime"]) + "/" + ds.Tables[0].Rows[i]["nid"].ToString().Trim() + ".html</url>");
                    Regex regex = new Regex(@"src=.[a-zA-z]+://[^\s]*");
                    MatchCollection matches = regex.Matches(ds.Tables[0].Rows[i]["context"].ToString().Trim());
                    try
                    {
                        pic = matches[0].Groups[0].ToString().Replace("src=","").Replace("\"","");
                    }
                    catch { }
                    sb.Append("<src><![CDATA[" + pic + "]]></src>\n");
                    sb.Append("<title>" + ds.Tables[0].Rows[i]["title"].ToString().Trim() + "</title>\n");
                    sb.Append("<anthor>" + ds.Tables[0].Rows[i]["anthor"].ToString().Trim() + "</anthor>\n");
                    sb.Append("<addtime>" + TypeConverter.ObjectToDateTime(ds.Tables[0].Rows[i]["addtime"]).ToString("MM-dd hh:mm") + "</addtime>\n");
                    sb.Append("</item>\n");
                }
            }
            sb.Append("<count>" + count + "</count>\n");
            sb.Append("</channel>\n");
            Response.Clear();
            this.Response.ContentType = "text/xml";
            Response.Charset = "utf-8";
            Response.Write(sb);
        }
    }
}