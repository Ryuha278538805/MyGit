using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Common
{
    public class XMLReader
    {
        /// <summary>
        /// 远程读取xml文档
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static System.Xml.XmlTextReader GetXmlDocument(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            //声明一个HttpWebRequest请求
            request.Timeout = 10000;
            //设置连接超时时间
            //request.Method = "POST";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream streamReceive = response.GetResponseStream();
            Encoding encoding = Encoding.GetEncoding("UTF-8");
            StreamReader streamReader = new StreamReader(streamReceive, encoding);
            System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader(streamReader);
            return reader;
        }

        /// <summary>
        /// 返回url HTML源码
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public StringBuilder GetPageHTML(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 15000;
            request.KeepAlive = false;
            StreamReader sr = null;
            HttpWebResponse response = null;
            Stream res = null;
            System.Text.StringBuilder sb = new StringBuilder();
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                res = response.GetResponseStream();
                sr = new StreamReader(res, System.Text.Encoding.Default);
                sb.Append(sr.ReadToEnd());
            }
            catch (System.Net.WebException ex)
            { System.Web.HttpContext.Current.Response.Write(ex.Message); }
            finally
            {
                if (sr != null)
                    sr.Close();
                if (res != null)
                    res.Close();
            }
            return sb;
        }
    }
}
