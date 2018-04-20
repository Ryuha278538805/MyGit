using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 大乐透模型
    /// </summary>
    public class KjhDltInfo
    {
        public int id { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        public int qi { get; set; }

        /// <summary>
        /// 前区第一个号
        /// </summary>
        public int a { get; set; }

        /// <summary>
        /// 前区第二个号
        /// </summary>
        public int b { get; set; }

        /// <summary>
        /// 前区第三个号
        /// </summary>
        public int c { get; set; }

        /// <summary>
        /// 前区第四个号
        /// </summary>
        public int d { get; set; }

        /// <summary>
        /// 前区第五个号
        /// </summary>
        public int e { get; set; }

        /// <summary>
        /// 后区第一个号
        /// </summary>
        public int f { get; set; }

        /// <summary>
        /// 后区第二个号
        /// </summary>
        public int g { get; set; }

        /// <summary>
        /// 前区和值
        /// </summary>
        public int qhz { get; set; }

        /// <summary>
        /// 后区和值
        /// </summary>
        public int hhz { get; set; }

        /// <summary>
        /// 总和值
        /// </summary>
        public int hz { get; set; }

        /// <summary>
        /// 一等奖个数
        /// </summary>
        public int zj1 { get; set; }

        /// <summary>
        /// 二等奖个数
        /// </summary>
        public int zj2 { get; set; }

        /// <summary>
        /// 三等奖个数
        /// </summary>
        public int zj3 { get; set; }

        /// <summary>
        /// 四等奖个数
        /// </summary>
        public int zj4 { get; set; }

        /// <summary>
        /// 五等奖个数
        /// </summary>
        public int zj5{ get; set; }

        /// <summary>
        /// 六等奖个数
        /// </summary>
        public int zj6 { get; set; }

        /// <summary>
        /// 七等奖个数
        /// </summary>
        public int zj7 { get; set; }

        /// <summary>
        /// 八等奖个数
        /// </summary>
        public int zj8 { get; set; }

        /// <summary>
        /// 一等奖奖金
        /// </summary>
        public int jo1 { get; set; }

        /// <summary>
        /// 二等奖奖金
        /// </summary>
        public int jo2 { get; set; }

        /// <summary>
        /// 三等奖奖金
        /// </summary>
        public int jo3 { get; set; }

        /// <summary>
        /// 追加一等奖个数
        /// </summary>
        public int zzj1 { get; set; }

        /// <summary>
        /// 追加二等奖个数
        /// </summary>
        public int zzj2 { get; set; }

        /// <summary>
        /// 追加三等奖个数
        /// </summary>
        public int zzj3 { get; set; }

        /// <summary>
        /// 追加四等奖个数
        /// </summary>
        public int zzj4 { get; set; }

        /// <summary>
        /// 追加五等奖个数
        /// </summary>
        public int zzj5 { get; set; }

        /// <summary>
        /// 追加六等奖个数
        /// </summary>
        public int zzj6 { get; set; }

        /// <summary>
        /// 追加七等奖个数
        /// </summary>
        public int zzj7 { get; set; }

        /// <summary>
        /// 追加一等奖奖金
        /// </summary>
        public int zjo1 { get; set; }

        /// <summary>
        /// 追加二等奖奖金
        /// </summary>
        public int zjo2 { get; set; }

        /// <summary>
        /// 追加三等奖奖金
        /// </summary>
        public int zjo3 { get; set; }

        /// <summary>
        /// 12选2附加中奖
        /// </summary>
        public int fjzj { get; set; }

        /// <summary>
        /// 投注额
        /// </summary>
        public string tzmoney { get; set; }

        /// <summary>
        /// 附加投注额
        /// </summary>
        public string fjtzmoney { get; set; }

        /// <summary>
        /// 奖池基金
        /// </summary>
        public string nextmoney { get; set; }

        /// <summary>
        /// 附加奖池基金
        /// </summary>
        public string fjnextmoney { get; set; }

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
