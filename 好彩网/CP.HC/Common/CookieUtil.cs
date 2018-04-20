using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Configuration;

namespace Common
{
    /// <summary>
    /// /cookie操作类
    /// </summary>
    public class CookieUtil
    {
        /// <summary>
        /// 写cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="strValue">值</param>
        public static void WriteCookie(string strName, string strValue)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
            if (cookie == null)
            {
                cookie = new HttpCookie(strName);
            }
            cookie.Value = HttpContext.Current.Server.UrlEncode(strValue); ;
            cookie.Domain = ".haocw.com";
            HttpContext.Current.Response.AppendCookie(cookie);
        }


        /// <summary>
        /// 写cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="strValue">值</param>
        /// <param name="strValue">过期时间(分钟)</param>
        public static void WriteCookie(string strName, string strValue, int expires)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
            if (cookie == null)
            {
                cookie = new HttpCookie(strName);
            }
            cookie.Value = HttpContext.Current.Server.UrlEncode(strValue);
            if (string.IsNullOrEmpty(ConfigurationManager.AppSettings["domain"]) || ConfigurationManager.AppSettings["domain"] != "off")
            {
                cookie.Domain = ".haocw.com";
            }
            cookie.Expires = DateTime.Now.AddHours(expires);
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// 写Cookie
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="strValue">值</param>
        /// <param name="expires">过期具体时间</param>
        public static void WriteCookieDateTime(string strName, string strValue, DateTime expires)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
            if (cookie == null)
            {
                cookie = new HttpCookie(strName);
            }
            cookie.Value = HttpContext.Current.Server.UrlEncode(strValue);
            cookie.Domain = ".haocw.com";
            cookie.Expires = expires;
            HttpContext.Current.Response.AppendCookie(cookie);

        }


        /// <summary>
        /// 读cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <returns>cookie值</returns>
        public static string GetCookie(string strName)
        {
            if (HttpContext.Current.Request.Cookies != null && HttpContext.Current.Request.Cookies[strName] != null)
            {
                HttpContext.Current.Request.Cookies[strName].Domain = ".haocw.com";
                return HttpContext.Current.Server.UrlDecode(HttpContext.Current.Request.Cookies[strName].Value.ToString());
            }
            return "";
        }

        /// <summary>
        /// 读cookie某键值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="strName">键名称</param>
        /// <returns>cookie值</returns>
        public static string GetCookie(string strName, string Key)
        {
            if (HttpContext.Current.Request.Cookies != null && HttpContext.Current.Request.Cookies[strName] != null)
            {
                HttpContext.Current.Request.Cookies[strName].Domain = ".haocw.com";
                return HttpContext.Current.Server.UrlDecode(HttpContext.Current.Request.Cookies[strName][Key].ToString());
            }
            return "";
        }

        /// <summary>
        /// 清理Cookie值
        /// </summary>
        public static void ClearAllCookie()
        {
            ClearCookie("htcode");
            ClearCookie("dnt");
        }

        /// <summary>
        /// 清理Cookie值
        /// </summary>
        public static void ClearHtCookie()
        {
            ClearCookie("htcode");
        }

        /// <summary>
        /// 清理某个Cookie值
        /// </summary>
        public static void ClearCookie(string strName)
        {
            HttpContext.Current.Response.Cookies[strName].Domain = ".haocw.com";
            HttpContext.Current.Response.Cookies[strName].Expires = DateTime.Now.AddDays(-600);
        }
    }
}
