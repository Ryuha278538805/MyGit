using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Web;
using System.Web.Caching;

namespace Common
{
    /// <summary>
    /// 缓存
    /// </summary>
    public class CacheUtil
    {    
        /// <summary>
        /// 清理所有缓存
        /// </summary>
        public static void Clear()
        {
            IDictionaryEnumerator enu = HttpContext.Current.Cache.GetEnumerator();
            while (enu.MoveNext())
            {
                Remove(enu.Key.ToString());
            }
        }

        /// <summary>
        /// 写新的缓存
        /// </summary>
        /// <param name="strKey">缓存名称</param>
        /// <param name="valueObj">缓存对像</param>
        /// <param name="durationSecond">缓存时间(分钟)</param>
        /// <returns>是否写入成功</returns>
        public static bool Insert(string strKey, object valueObj, double durationMinutes)
        {
            if (((strKey != null) && (strKey.Length != 0)) && (valueObj != null))
            {
                CacheItemRemovedCallback callBack = new CacheItemRemovedCallback(CacheUtil.onRemove);
                HttpContext.Current.Cache.Insert(strKey, valueObj, null, DateTime.Now.AddMinutes(durationMinutes), Cache.NoSlidingExpiration, CacheItemPriority.Normal, callBack);
                return true;
            }
            return false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="strKey">缓存名称</param>
        /// <returns>是否存在</returns>
        public static bool IsExist(string strKey)
        {
            return (HttpContext.Current.Cache[strKey] != null);
        }

        /// <summary>
        /// 此方法在值失效之前调用，可以用于在失效之前更新数据库，或从数据库重新获取数据
        /// </summary>
        /// <param name="strKey"></param>
        /// <param name="obj"></param>
        /// <param name="reason"></param>
        private static void onRemove(string strKey, object obj, CacheItemRemovedReason reason)
        {
        }

        /// <summary>
        /// 按缓存名称读取值
        /// </summary>
        /// <param name="strKey"></param>
        /// <returns>缓存对像object</returns>
        public static object Read(string strKey)
        {
            if (HttpContext.Current.Cache[strKey] == null)
            {
                return null;
            }
            object obj = HttpContext.Current.Cache[strKey];
            if (obj == null)
            {
                return null;
            }
            return obj;
        }

        /// <summary>
        /// 按缓存名移出缓存对像
        /// </summary>
        /// <param name="strKey"></param>
        public static void Remove(string strKey)
        {
            if (HttpContext.Current.Cache[strKey] != null)
            {
                try
                {
                    HttpContext.Current.Cache.Remove(strKey);
                }
                catch { }
            }
        }

        /// <summary>
        /// 正则表达式方式移出缓存
        /// </summary>
        /// <param name="pattern">正则字符串</param>
        public static void RemoveByRegexp(string pattern)
        {
            if (pattern != "")
            {
                IDictionaryEnumerator enu = HttpContext.Current.Cache.GetEnumerator();
                while (enu.MoveNext())
                {
                    string key = enu.Key.ToString();
                    if (Regex.IsMatch(key, pattern))
                    {
                        Remove(key);
                    }
                }
            }
        }

    }
}
