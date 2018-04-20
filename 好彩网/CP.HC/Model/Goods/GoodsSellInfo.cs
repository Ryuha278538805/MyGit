using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 社区商店商品出售情况描述类
    /// </summary>
    public class GoodsSellInfo
    {
        /// <summary>
        /// sid
        /// </summary>
        public int sid { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public int gid { get; set; }

        /// <summary>
        /// 买家用户名
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// 卡密
        /// </summary>
        public string codes { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        public string postaddress { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        public string postno { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        public string postname { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string posttel { get; set; }

        /// <summary>
        /// 寄件快递
        /// </summary>
        public string postmethod { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        public string postcode { get; set; }

        /// <summary>
        /// 是否发货
        /// </summary>
        public bool isposted { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime addtime { get; set; }

    }
}
