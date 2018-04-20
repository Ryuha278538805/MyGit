using HCW.Bussiness;
using HCW.Common;
using HCW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace HCW.Master
{
    public class CPManager
    {
        private static cpkjService service = new cpkjService();
        private static int timespan = Int32.Parse(ConfigurationManager.AppSettings["cache_awards"]);

        /// <summary>
        /// 3D信息
        /// </summary>
        private static string cache3d = "cache3d";
        public static tbl_3dInfo SDInfo
        {
            get
            {
                tbl_3dInfo info = CacheHelper.GetCache<tbl_3dInfo>(cache3d);
                if (info == null)
                {
                    info = service.M_GetCPInfo<tbl_3dInfo>("tbl_3d");
                    CacheHelper.SetCache(cache3d, info, DateTime.Now.AddMinutes(timespan), new TimeSpan());
                }
                return info;
            }
        }

        /// <summary>
        /// 双色球
        /// </summary>
        private static string cachessq = "cachessq";
        public static tbl_ssqInfo SSQInfo
        {
            get
            {
                tbl_ssqInfo info = CacheHelper.GetCache<tbl_ssqInfo>(cachessq);
                if (info == null)
                {
                    info = service.M_GetCPInfo<tbl_ssqInfo>("tbl_ssq");
                    CacheHelper.SetCache(cachessq, info, DateTime.Now.AddMinutes(timespan), new TimeSpan());
                }
                return info;
            }
        }

        /// <summary>
        /// 大乐透
        /// </summary>
        private static string cacheddt = "cacheddt";
        public static tbl_dltInfo DLTInfo
        {
            get
            {
                tbl_dltInfo info = CacheHelper.GetCache<tbl_dltInfo>(cacheddt);
                if (info == null)
                {
                    info = service.M_GetCPInfo<tbl_dltInfo>("tbl_dlt");
                    CacheHelper.SetCache(cacheddt, info, DateTime.Now.AddMinutes(timespan), new TimeSpan());
                }
                return info;
            }
        }

        /// <summary>
        /// 大乐透
        /// </summary>
        private static string cachep3 = "cachep3";
        public static tbl_p3Info P3Info
        {
            get
            {
                tbl_p3Info info = CacheHelper.GetCache<tbl_p3Info>(cachep3);
                if (info == null)
                {
                    info = service.M_GetCPInfo<tbl_p3Info>("tbl_p3");
                    CacheHelper.SetCache(cachep3, info, DateTime.Now.AddMinutes(timespan), new TimeSpan());
                }
                return info;
            }
        }

        /// <summary>
        /// 七星彩
        /// </summary>
        private static string cacheqxc = "cacheqxc";
        public static tbl_qxcInfo QXCInfo
        {
            get
            {
                tbl_qxcInfo info = CacheHelper.GetCache<tbl_qxcInfo>(cacheqxc);
                if (info == null)
                {
                    info = service.M_GetCPInfo<tbl_qxcInfo>("tbl_qxc");
                    CacheHelper.SetCache(cacheqxc, info, DateTime.Now.AddMinutes(timespan), new TimeSpan());
                }
                return info;
            }
        }

        /// <summary>
        /// 七乐彩
        /// </summary>
        private static string cacheqlc = "cacheqlc";
        public static tbl_qlcInfo QLCInfo
        {
            get
            {
                tbl_qlcInfo info = CacheHelper.GetCache<tbl_qlcInfo>(cacheqlc);
                if (info == null)
                {
                    info = service.M_GetCPInfo<tbl_qlcInfo>("tbl_qlc");
                    CacheHelper.SetCache(cacheqlc, info, DateTime.Now.AddMinutes(timespan), new TimeSpan());
                }
                return info;
            }
        }
    }
}
