using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Model;
using DataProvider;
using Common;
using System.IO;
using System.Net;

namespace Www
{
    public partial class makepage : Pages
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private string getPage(string url)
        {
            Stream responseStream = null;
            StreamReader reader = null;
            StringBuilder builder = new StringBuilder();
            HttpWebRequest request = null;
            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 10000;
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1) ";
                responseStream = ((HttpWebResponse)request.GetResponse()).GetResponseStream();
                reader = new StreamReader(responseStream, Encoding.UTF8);
                builder.Append(reader.ReadToEnd());
            }
            catch (Exception exception)
            {
                AlertMessage(exception.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (responseStream != null)
                {
                    responseStream.Close();
                }
            }
            return builder.ToString();
        }

        private void makeFile(string url, string filename)
        {
            string page = string.Empty;
            Stream stream = null;
            StreamReader reader = null;
            try
            {
                string str2 = HttpContext.Current.Request.Url.Host.ToString();
                url = "http://" + str2 + url;
                page = getPage(url);
                if ((page != null) && (page.Trim().Length > 0))
                {
                    StreamWriter writer = new StreamWriter(filename, false, Encoding.UTF8);
                    writer.Write(page);
                    writer.Close();
                    AlertMessage("生成成功！" + DateTime.Now.ToString());
                }
            }
            catch (Exception exception)
            {
                AlertMessage(exception.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (reader != null)
                    reader.Close();
            }
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            makeFile("/index.aspx", base.Server.MapPath("/") + "index.htm");
        }
    }
}