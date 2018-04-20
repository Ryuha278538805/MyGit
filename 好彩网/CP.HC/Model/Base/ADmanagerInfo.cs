using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ADmanagerInfo
    {
        /// <summary>
        /// id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 广告标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 广告链接
        /// </summary>
        public string link { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public int source { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public float? sort { get; set; }

    }
}
