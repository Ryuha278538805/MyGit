using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 双色球模型
    /// </summary>
    public class KjhSsqInfo
    {
        public int id { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        public int qi { get; set; }

        /// <summary>
        /// 第一个号
        /// </summary>
        public int a { get; set; }

        /// <summary>
        /// 第二个号
        /// </summary>
        public int b { get; set; }

        /// <summary>
        /// 第三个号
        /// </summary>
        public int c { get; set; }

        /// <summary>
        /// 第四个号
        /// </summary>
        public int d { get; set; }

        /// <summary>
        /// 第五个号
        /// </summary>
        public int e { get; set; }

        /// <summary>
        /// 第六个号
        /// </summary>
        public int f { get; set; }

        /// <summary>
        /// 第七个号
        /// </summary>
        public int g { get; set; }

        /// <summary>
        /// 特别号
        /// </summary>
        public string h { get; set; }

        /// <summary>
        /// 和值
        /// </summary>
        public int hz { get; set; }

        /// <summary>
        /// 一等奖个数
        /// </summary>
        public string zj1 { get; set; }

        /// <summary>
        /// 二等奖个数
        /// </summary>
        public string zj2 { get; set; }

        /// <summary>
        /// 三等奖个数
        /// </summary>
        public string zj3 { get; set; }

        /// <summary>
        /// 四等奖个数
        /// </summary>
        public string zj4 { get; set; }

        /// <summary>
        /// 五等奖个数
        /// </summary>
        public string zj5 { get; set; }

        /// <summary>
        /// 六等奖个数
        /// </summary>
        public string zj6 { get; set; }

        /// <summary>
        /// 七等奖个数
        /// </summary>
        public string zj7 { get; set; }

        /// <summary>
        /// 一等奖奖金
        /// </summary>
        public string jo1 { get; set; }

        /// <summary>
        /// 二等奖奖金
        /// </summary>
        public string jo2 { get; set; }

        /// <summary>
        /// 投注额
        /// </summary>
        public string tzmoney { get; set; }

        /// <summary>
        /// 奖池基金
        /// </summary>
        public string nextmoney { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string cc { get; set; }

        /// <summary>
        /// 开奖日期
        /// </summary>
        public DateTime date { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime addtime { get; set; }
    }
}
