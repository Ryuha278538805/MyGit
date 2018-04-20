using HCW.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace HCWDDL.M.Handler
{
    /// <summary>
    /// NewsHandler 的摘要说明
    /// </summary>
    public class NewsHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string json = "";
            tbl_newsService service = new tbl_newsService();

            int pagesize = Int32.Parse(context.Request["pagesize"]);
            int pageindex =  Int32.Parse(context.Request["pageindex"]);
            int cid = Int32.Parse(context.Request["cid"]);
            int zid = Int32.Parse(context.Request["zid"]);

            var lst = service.M_GetNewsList(pagesize, pageindex, cid, zid);
            json = JsonConvert.SerializeObject(lst);
            context.Response.Write(json);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}