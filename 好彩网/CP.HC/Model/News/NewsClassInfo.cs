using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 文章分类
    /// 结构描述
    /// </summary>
    public class NewsClassInfo
    {

        /// <summary>
        /// 分类id
        /// </summary>
        public int cid { get; set; }

        /// <summary>
        /// 分类名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 分类英文/拼音名
        /// </summary>
        public string ename { get; set; }

        /// <summary>
        /// parentid
        /// </summary>
        public int pid { get; set; }

        /// <summary>
        /// rootid
        /// </summary>
        public int rid { get; set; }

        /// <summary>
        /// 层次
        /// </summary>
        public int depth { get; set; }

        /// <summary>
        /// 彩种
        /// </summary>
        public int czid { get; set; }

        /// <summary>
        /// 是否每期一条
        /// </summary>
        public int everqi { get; set; }

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
