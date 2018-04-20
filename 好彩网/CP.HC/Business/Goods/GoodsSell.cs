using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using DataProvider;
using Common;

namespace Business
{
    /// <summary>
    /// 商品销售信息的业务处理类
    /// simwon
    /// </summary>
    public class GoodsSell
    {
        /// <summary>
        /// 单个商品销售信息
        /// </summary>
        /// <returns></returns>
        public static GoodsSellInfo GetGoodsSellInfo(int sid)
        {
            GoodsSellInfo info = new GoodsSellInfo();
            DataTable dt = GoodsSellData.GetGoodsSellInfoData(sid);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
                info.codes = dr["codes"].ToString().Trim();
                info.gid = TypeConverter.ObjectToInt(dr["gid"]);
                info.isposted = TypeConverter.ObjectToBool(dr["isposted"]);
                info.postaddress = dr["postaddress"].ToString().Trim();
                info.postcode = dr["postcode"].ToString().Trim();
                info.postmethod = dr["postmethod"].ToString().Trim();
                info.postname = dr["postname"].ToString().Trim();
                info.postno = dr["postno"].ToString().Trim();
                info.posttel = dr["posttel"].ToString().Trim();
                info.sid = TypeConverter.ObjectToInt(dr["sid"]);
                info.username = dr["username"].ToString().Trim();             
            }
            return info;
        }

        /// <summary>
        /// 某商品某用户的最新一条购买记录
        /// </summary>
        /// <returns></returns>
        public static GoodsSellInfo GetGoodsSellInfo(int gid, string username)
        {
            GoodsSellInfo info = new GoodsSellInfo();
            DataRow dr = GoodsSellData.GetGoodsSellInfoData(gid, username);
            if (dr != null)
            {
                info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
                info.codes = dr["codes"].ToString().Trim();
                info.gid = TypeConverter.ObjectToInt(dr["gid"]);
                info.isposted = TypeConverter.ObjectToBool(dr["isposted"]);
                info.postaddress = dr["postaddress"].ToString().Trim();
                info.postcode = dr["postcode"].ToString().Trim();
                info.postmethod = dr["postmethod"].ToString().Trim();
                info.postname = dr["postname"].ToString().Trim();
                info.postno = dr["postno"].ToString().Trim();
                info.posttel = dr["posttel"].ToString().Trim();
                info.sid = TypeConverter.ObjectToInt(dr["sid"]);
                info.username = dr["username"].ToString().Trim();
            }
            else
            {
                info.addtime = DateTime.Now.AddYears(-1);
            }
            return info;
        }

            /// <summary>
        /// 某用户的全部购买记录
        /// </summary>
        /// <returns></returns>
        public static List<GoodsSellInfo> GetUserGoodsSellList(string username)
        {
            List<GoodsSellInfo> list = new List<GoodsSellInfo>();
            DataTable dt = GoodsSellData.GetGoodsSellInfoData(username);
            if (dt != null && dt.Rows.Count >0)
            {                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    GoodsSellInfo info = new GoodsSellInfo();
                    info.addtime = TypeConverter.ObjectToDateTime(dr["addtime"]);
                    info.codes = dr["codes"].ToString().Trim();
                    info.gid = TypeConverter.ObjectToInt(dr["gid"]);
                    info.isposted = TypeConverter.ObjectToBool(dr["isposted"]);
                    info.postaddress = dr["postaddress"].ToString().Trim();
                    info.postcode = dr["postcode"].ToString().Trim();
                    info.postmethod = dr["postmethod"].ToString().Trim();
                    info.postname = dr["postname"].ToString().Trim();
                    info.postno = dr["postno"].ToString().Trim();
                    info.posttel = dr["posttel"].ToString().Trim();
                    info.sid = TypeConverter.ObjectToInt(dr["sid"]);
                    info.username = dr["username"].ToString().Trim();
                    list.Add(info);
                }
            }          
            return list;
        }

        /// <summary>
        /// 删除商品销售信息
        /// </summary>
        /// <param name="gid"></param>
        public static void DeleteGoodsSellInfo(string sid)
        {
            GoodsSellData.DeleteGoodsSellInfo(sid);
        }

        /// <summary>
        /// 生成/更新商品销售信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateGoodsSellInfo(GoodsSellInfo info, GoodsInfo ginfo)
        {
            int id = 0;
            //购买商品设置卡密  —else 则不处理
            if (!(info.sid > 0))
            {
                //有卡密
                if (ginfo.isautopost && ginfo.codeslist.Length > 0)
                {
                    info.codes = ginfo.codeslist[0];
                    info.isposted = true;
                    ginfo.codes = "";
                    for (int i = 1; i < ginfo.codeslist.Length; i++)
                    {
                        if (i < (ginfo.codeslist.Length - 1))
                            ginfo.codes += ginfo.codeslist[i] + "|";
                        else
                            ginfo.codes += ginfo.codeslist[i];
                    }
                    if (ginfo.codesselled.Length > 0)
                        ginfo.codesselled += "|" + info.codes;
                    else
                        ginfo.codesselled += info.codes;
                }
            }
            id = GoodsSellData.CreateGoodsSellInfo(info, ginfo);
            return id;
        }
    }
}
