using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ZoneInfo
    {
        /// <summary>
        /// 专题id
        /// </summary>
        public int zid { get; set; }

        /// <summary>
        /// 专题名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 分类id
        /// </summary>
        public int cid { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int orderint { get; set; }

        /// <summary>
        /// SEO关键字
        /// </summary>
        public string keywords { get; set; }

        /// <summary>
        /// SEO描述
        /// </summary>
        public string description { get; set; }
    }
}
