using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using Microsoft.VisualBasic;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Xml;
namespace Common
{
    public class Utils
    {

        /// <summary>
        /// 同时清除后台和前台的品牌cache
        /// </summary>
        /// <param name="key"></param>
        public static void RemoveCache(string key)
        {
            CacheUtil.Remove(key);
            doGet("http://www.haocw.com/services/webcache.aspx?key="+key);
        }

        /// <summary>
        /// get请求
        /// </summary>
        /// <param name="url"></param>
        private static void doGet(string url)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);
                request.Method = "GET";
                request.Timeout = 10000;//10秒超时
                WebResponse response = request.GetResponse();
            }
            catch { }

        }
        /// <summary>
        /// 读取本地文本文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static  string GetFileText(string path)
        {
            string str = string.Empty;

            try
            {
                StreamReader sr = new StreamReader(path);
                str = sr.ReadToEnd();
                sr.Close();
            }
            catch { 
            
            }
            return str;
        }

        /// <summary>
        /// baes64反编码
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string DecodeBase64(string code)
        {
            string decode = "";
            byte[] bytes = Convert.FromBase64String(code);
            try
            {
                decode = System.Text.Encoding.UTF8.GetString(bytes);
            }
            catch
            {
                decode = code;
            }
            return decode;
        }

        /// <summary>
        /// base64编码
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string EncodeBase64(string code)
        {
            string encode = "";
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(code);
            try
            {
                encode = Convert.ToBase64String(bytes);
            }
            catch
            {
                encode = code;
            }
            return encode;
        }

        /// <summary>
        /// 某字符串的长度.
        /// 中文算2个...
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int GetStringLength(string str)
        {
            return Encoding.Default.GetBytes(str).Length;
        }


        /// <summary>
        /// 中英文字串截取
        /// </summary>
        /// <param name="str"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string GetCutString(string str, int len)
        {
            if (string.IsNullOrEmpty(str))
                return "";
            Regex regex = new Regex("[\u4e00-\u9fa5]+", RegexOptions.Compiled);
            char[] stringChar = str.ToCharArray();
            StringBuilder sb = new StringBuilder();
            int nLength = 0;
            for (int i = 0; i < stringChar.Length; i++)
            {
                if (regex.IsMatch((stringChar[i]).ToString()))
                {
                    sb.Append(stringChar[i]);
                    nLength += 2;
                }
                else
                {
                    sb.Append(stringChar[i]);
                    nLength = nLength + 1;
                } if (nLength > len)
                {
                    break;
                }
            }
            //if (isCut)
            //    return sb.ToString() + "...";
            //else
             return sb.ToString();
        }

        /// <summary>
        /// 邮件发送程序 
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public static bool SendMail(MailMessage mail)
        {
            bool yes = false;
            mail.IsBodyHtml = true;
            mail.SubjectEncoding = System.Text.Encoding.GetEncoding("utf-8");
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.EnableSsl = false;
            smtpClient.Host = "smtp.exmail.qq.com";
            smtpClient.Port = 25;

            smtpClient.Credentials = new NetworkCredential("service@haocw.com", "tco99312^");
            try
            {
                smtpClient.Send(mail);
                yes = true;
            }
            catch //(Exception ex)
            {
                //System.Web.HttpContext.Current.Response.Write(ex.Message );
            }
            return yes;
        }


        /// <summary>
        /// object型转换为bool型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的bool类型结果</returns>
        public static bool StrToBool(object expression, bool defValue)
        {
            return TypeConverter.StrToBool(expression, defValue);
        }

        /// <summary>
        /// string型转换为bool型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的bool类型结果</returns>
        public static bool StrToBool(string expression, bool defValue)
        {
            return TypeConverter.StrToBool(expression, defValue);
        }

        /// <summary>
        /// 将对象转换为Int32类型
        /// </summary>
        /// <param name="expression">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static int StrToInt(object expression, int defValue)
        {
            return TypeConverter.ObjectToInt(expression, defValue);
        }

        /// <summary>
        /// 将字符串转换为Int32类型
        /// </summary>
        /// <param name="expression">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static int StrToInt(string expression, int defValue)
        {
            return TypeConverter.StrToInt(expression, defValue);
        }

        /// <summary>
        /// Object型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static float StrToFloat(object strValue, float defValue)
        {
            return TypeConverter.StrToFloat(strValue, defValue);
        }

        /// <summary>
        /// string型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static float StrToFloat(string strValue, float defValue)
        {
            return TypeConverter.StrToFloat(strValue, defValue);
        }

        /// <summary>
        /// 验证是否为正整数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsInt(string str)
        {
            return Regex.IsMatch(str, @"^[0-9]*$");
        }


        /// <summary>
        /// 取页面源码
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string GetPagehtml(string url)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);
                request.Timeout = 20000;//20秒超时
                WebResponse response = request.GetResponse();

                Stream resStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(resStream);
                return sr.ReadToEnd();
            }
            catch { return ""; }
        }

        /// <summary>
        /// 返回url的根域名
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string GetUrlDomainName(string url)
        {
            // string p = @"http://[^\.]*\.(?<domain>[^/]*)";
            string p = @"^https?://(?<domain>[^/]+)(/|$)";
            Regex reg = new Regex(p, RegexOptions.IgnoreCase);
            Match m = reg.Match(url);
            return m.Groups["domain"].Value.ToString().Trim();
        }

        /// <summary>
        /// 获得当前页面客户端的IP
        /// </summary>
        /// <returns>当前页面客户端的IP</returns>
        public static string GetIP()
        {
            //取CDN用户真实IP的方法
            //当用户使用代理时，取到的是代理IP
            string result = String.Empty;
            result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            try
            {
                if (!string.IsNullOrEmpty(result))
                {
                    //可能有代理  
                    if (result.IndexOf(".") == -1)
                        result = null;
                    else
                    {
                        if (result.IndexOf(",") != -1)
                        {
                            result = result.Replace("  ", "").Replace("'", "");
                            string[] temparyip = result.Split(",;".ToCharArray());
                            for (int i = 0; i < temparyip.Length; i++)
                            {
                                if (Utils.IsIP(temparyip[i]) && temparyip[i].Substring(0, 3) != "10." && temparyip[i].Substring(0, 7) != "192.168" && temparyip[i].Substring(0, 7) != "172.16.")
                                {
                                    result = temparyip[i];
                                }
                            }
                            string[] str = result.Split(',');
                            if (str.Length > 0)
                                result = str[0].ToString().Trim();
                        }
                        else if (Utils.IsIP(result))
                            return result;
                    }
                }
            }
            catch
            {
                result = "";
            }

            if (string.IsNullOrEmpty(result))
                result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            if (string.IsNullOrEmpty(result))
                result = HttpContext.Current.Request.UserHostAddress;
            if (string.IsNullOrEmpty(result))
                result = "127.0.0.1";


            return result;
        }

        /// <summary>
        /// 根据webservice调用返回IP地域
        /// </summary>
        /// <param name="strIP"></param>
        /// <returns></returns>
        public static string GetstringIpAddress(string strIP)
        {
            string stringIpAddress = "";
            IPScaner sc = new IPScaner();
            sc.DataPath = System.Web.HttpContext.Current.Server.MapPath("/") + "common/QQWry.Dat";
            sc.IP = strIP;
            stringIpAddress = sc.IPLocation();
            return stringIpAddress;
        }

        /// <summary>
        /// IP编码成数字格式
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static string IpToInt(string ip)
        {
            char[] dot = new char[] { '.' };
            string[] ipArr = ip.Split(dot);
            if (ipArr.Length == 3)
                ip = ip + ".0";
            ipArr = ip.Split(dot);

            long ip_Int = 0;
            long p1 = long.Parse(ipArr[0]) * 255 * 255 * 255;
            long p2 = long.Parse(ipArr[1]) * 255 * 255;
            long p3 = long.Parse(ipArr[2]) * 256;
            long p4 = long.Parse(ipArr[3]);
            ip_Int = p1 + p2 + p3 + p4;
            return ip_Int.ToString();
        }

        /// <summary>
        /// 获得当前绝对路径
        /// </summary>
        /// <param name="strPath">指定的路径</param>
        /// <returns>绝对路径</returns>
        public static string GetMapPath(string strPath)
        {
            if (HttpContext.Current != null)
            {
                return HttpContext.Current.Server.MapPath(strPath);
            }
            else //非web程序引用
            {
                strPath = strPath.Replace("/", "\\");
                if (strPath.StartsWith("\\"))
                {
                    strPath = strPath.Substring(strPath.IndexOf('\\', 1)).TrimStart('\\');
                }
                return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, strPath);
            }
        }

        #region 客户端信息

        /// <summary>
        /// 取客户端用户的OS
        /// </summary>
        /// <returns></returns>
        public static string GetClientOS()
        {
            string userAgent = HttpContext.Current.Request.UserAgent;
            string osVersion = "未知";
            if (userAgent.Contains("NT 6.1"))
            {
                osVersion = "Windows 7";
            }
            else if (userAgent.Contains("NT 6.0"))
            {
                osVersion = "Windows Vista/Server 2008";
            }
            else if (userAgent.Contains("NT 5.2"))
            {
                osVersion = "Windows Server 2003";
            }
            else if (userAgent.Contains("NT 5.1"))
            {
                osVersion = "Windows XP";
            }
            else if (userAgent.Contains("NT 5"))
            {
                osVersion = "Windows 2000";
            }
            else if (userAgent.Contains("Mac"))
            {
                osVersion = "Mac";
            }
            else if (userAgent.Contains("Unix"))
            {
                osVersion = "UNIX";
            }
            else if (userAgent.Contains("Linux"))
            {
                osVersion = "Linux";
            }
            else if (userAgent.Contains("SunOS"))
            {
                osVersion = "SunOS";
            }
            return osVersion;

        }

        /// <summary>
        /// 返回上一个页面的地址
        /// </summary>
        /// <returns>上一个页面的地址</returns>
        public static string GetUrlReferrer()
        {
            string retVal = string.Empty;
            if (HttpContext.Current.Request.UrlReferrer != null)
                retVal = HttpContext.Current.Request.UrlReferrer.ToString().Trim().ToLower();

            return retVal;
        }

        /// <summary>
        /// 返回当前页面是否是跨站提交
        /// </summary>
        /// <returns>当前页面是否是跨站提交</returns>
        public static bool IsCrossSitePost()
        {
            // 如果不是提交则为true
            if (!HttpContext.Current.Request.HttpMethod.Equals("POST"))
                return true;

            return IsCrossSitePost(GetUrlReferrer(), HttpContext.Current.Request.Url.Host);
        }

        /// <summary>
        /// 判断是否是跨站提交
        /// </summary>
        /// <param name="urlReferrer">上个页面地址</param>
        /// <param name="host">论坛url</param>
        /// <returns>bool</returns>
        public static bool IsCrossSitePost(string urlReferrer, string host)
        {
            if (urlReferrer.Length < 7)
                return true;

            Uri u = new Uri(urlReferrer);
            return u.Host != host;
        }
        #endregion

        /// <summary>
        /// 检测是否有Sql危险字符
        /// </summary>
        /// <param name="str">要判断字符串</param>
        /// <returns>判断结果</returns>
        public static bool IsSafeSqlString(string str)
        {
            return !Regex.IsMatch(str, @"[-|;|,|\/|\(|\)|\[|\]|\}|\{|%|@|\*|!|\']");
        }

        /// <summary>
        /// 检测是否有危险的可能用于链接的字符串
        /// </summary>
        /// <param name="str">要判断字符串</param>
        /// <returns>判断结果</returns>
        public static bool IsSafeUserInfoString(string str)
        {
            return !Regex.IsMatch(str, @"^\s*$|^c:\\con\\con$|[%,\*" + "\"" + @"\s\t\<\>\&]|游客|^Guest|管理员|巡查|区长|；|~|。|，|、|《|》|（|）|￥");
        }

        /// <summary>
        /// 是否为ip
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static bool IsIP(string ip)
        {
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }

        /// <summary>
        /// 移除Html标记
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string RemoveHtml(string content)
        {
            return Regex.Replace(content, @"<[^>]*>", string.Empty, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// 过滤HTML中的不安全标签
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string RemoveUnsafeHtml(string content)
        {
            content = Regex.Replace(content, @"(\<|\s+)o([a-z]+\s?=)", "$1$2", RegexOptions.IgnoreCase);
            content = Regex.Replace(content, @"(script|frame|form|meta|behavior|style)([\s|:|>])+", "$1.$2", RegexOptions.IgnoreCase);
            return content;
        }

        /// <summary>
        /// 将全角数字转换为数字
        /// </summary>
        /// <param name="SBCCase"></param>
        /// <returns></returns>
        public static string SBCCaseToNumberic(string SBCCase)
        {
            char[] c = SBCCase.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                byte[] b = System.Text.Encoding.Unicode.GetBytes(c, i, 1);
                if (b.Length == 2)
                {
                    if (b[1] == 255)
                    {
                        b[0] = (byte)(b[0] + 32);
                        b[1] = 0;
                        c[i] = System.Text.Encoding.Unicode.GetChars(b)[0];
                    }
                }
            }
            return new string(c);
        }
    }
}
