using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class CzInfo
    {
        /// <summary>
        /// 彩种id
        /// </summary>
        public int czid { get; set; }

        /// <summary>
        /// 彩种名
        /// </summary>
        public string czname { get; set; }

        /// <summary>
        /// 简写彩种名
        /// </summary>
        public string shortname { get; set; }

        /// <summary>
        /// 最新期数
        /// </summary>
        public int qi { get; set; }

    }
}
