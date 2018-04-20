using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    /// <summary>
    /// 缓存键与值
    /// </summary>
    public class CacheKeys
    {
        /// <summary>
        /// 资讯分类
        /// </summary>
        public const string NEWS_CLASS = "NewsClassList";

        /// <summary>
        /// 后台用户组
        /// </summary>
        public const string MASTERGROUP = "MasterGroup";

        /// <summary>
        /// 后台用户
        /// </summary>
        public const string MASTER = "MasterList";

        /// <summary>
        /// 彩种
        /// </summary>
        public const string CZ = "CzList";

        /// <summary>
        /// 专题
        /// </summary>
        public const string ZONE = "ZoneList";

        /// <summary>
        /// 预测专题
        /// </summary>
        public const string YCZONE = "YcZoneList";

        /// <summary>
        /// 22选5开奖号
        /// </summary>
        public const string KJH225 = "Kjh225List";

        /// <summary>
        /// 3D开奖号
        /// </summary>
        public const string KJH3D = "Kjh3DList";

        /// <summary>
        /// 大乐透开奖号
        /// </summary>
        public const string KJHDLT = "KjhDltList";

        /// <summary>
        /// P3开奖号
        /// </summary>
        public const string KJHP3 = "KjhP3List";

        /// <summary>
        /// 七乐彩开奖号
        /// </summary>
        public const string KJHQLC = "KjhQlcList";

        /// <summary>
        /// 七星彩开奖号
        /// </summary>
        public const string KJHQXC = "KjhQxcList";

        /// <summary>
        /// 双色球开奖号
        /// </summary>
        public const string KJHSSQ = "KjhSsqList";

        /// <summary>
        /// 商品信息分类
        /// </summary>
        public const string GOODS_CLASS = "KjhSsqList";

        /// <summary>
        /// 用户组
        /// </summary>
        public const string USERGROUP = "UserGroupList";

        /// <summary>
        /// 新闻UI
        /// </summary>
        public const string NEWSUI = "NewsUI";
    }

     /// <summary>
    /// 缓存时间
    /// </summary>
    public enum CacheMin : int
    {
        One = 1,
        Two = 2,
        Five = 5,
        Ten = 10,
        Twenty = 20,
        Thirty = 30,
        Fifty = 50,
        Sixty = 60,
        Ninety = 90,
        Twh = 200,
        Thh = 300,
        Frh = 400,
        Nih=900,
        Twt=2000
    }
}
