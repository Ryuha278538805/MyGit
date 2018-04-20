using System;
using System.Collections.Generic;
using System.Text;
using Common;
using Business;
using Model;

namespace Business
{
    public class Templet
    {
        public static string[,] temp = new string[66, 3];

        /// <summary>
        /// 初始化无数据模板
        /// </summary>
        /// <param name="nids"></param>
        /// <param name="istop"></param>
        public static void CrTemplet()
        {
            #region 随机号码
            temp[0, 0] = "七码";
            temp[0, 1] = "{qima}";

            temp[1, 0] = "六码";
            temp[1, 1] = "{liuma}";

            temp[2, 0] = "五码";
            temp[2, 1] = "{wuma}";

            temp[3, 0] = "四码";
            temp[3, 1] = "{sima}";

            temp[4, 0] = "三胆";
            temp[4, 1] = "{sandan}";

            temp[5, 0] = "双胆";
            temp[5, 1] = "{erdan}";

            temp[6, 0] = "独胆";
            temp[6, 1] = "{dudan}";

            temp[7, 0] = "杀一码";
            temp[7, 1] = "{sha1ma}";

            temp[8, 0] = "杀二码";
            temp[8, 1] = "{sha2ma}";

            temp[9, 0] = "杀三码";
            temp[9, 1] = "{sha3ma}";

            temp[10, 0] = "包星一组";
            temp[10, 1] = "{baoxing1}";

            temp[11, 0] = "包星两组";
            temp[11, 1] = "{baoxing2}";

            temp[12, 0] = "包星三组";
            temp[12, 1] = "{baoxing3}";

            temp[13, 0] = "二码定位";
            temp[13, 1] = "{ermdw}";

            temp[14, 0] = "三码定位";
            temp[14, 1] = "{sanmdw}";

            temp[15, 0] = "四码定位";
            temp[15, 1] = "{simdw}";
            
            temp[16, 0] = "五码定位";
            temp[16, 1] = "{wumdw}";

            temp[17, 0] = "六码定位";
            temp[17, 1] = "{liumdw}";

            temp[18, 0] = "大小";
            temp[18, 1] = "{dx}";

            temp[19, 0] = "奇偶";
            temp[19, 1] = "{jo}";

            temp[20, 0] = "质合";
            temp[20, 1] = "{zh}";

            temp[21, 0] = "码一";
            temp[21, 1] = "{ma1}";

            temp[22, 0] = "码二";
            temp[22, 1] = "{ma2}";

            temp[23, 0] = "码三";
            temp[23, 1] = "{ma3}";

            temp[24, 0] = "码四";
            temp[24, 1] = "{ma4}";

            temp[25, 0] = "码五";
            temp[25, 1] = "{ma5}";

            temp[26, 0] = "码六";
            temp[26, 1] = "{ma6}";

            temp[27, 0] = "码七";
            temp[27, 1] = "{ma7}";

            temp[28, 0] = "杀码一";
            temp[28, 1] = "{shama1}";

            temp[29, 0] = "杀码二";
            temp[29, 1] = "{shama2}";

            temp[30, 0] = "杀码三";
            temp[30, 1] = "{shama3}";

            temp[30, 0] = "杀码三";
            temp[30, 1] = "{shama3}";
            #endregion

            #region 上期3D开奖号
            temp[31, 0] = "3D开奖号";
            temp[31, 1] = "{3dkjh}";

            temp[32, 0] = "3D开奖号类型";
            temp[32, 1] = "{3dkjhzu}";

            temp[33, 0] = "3D开奖号百位";
            temp[33, 1] = "{3dkjh1}";

            temp[34, 0] = "3D开奖号十位";
            temp[34, 1] = "{3dkjh2}";

            temp[35, 0] = "3D开奖号个位";
            temp[35, 1] = "{3dkjh3}";

            temp[36, 0] = "3D开奖号大小";
            temp[36, 1] = "{3dkjhdx}";

            temp[37, 0] = "3D开奖号奇偶";
            temp[37, 1] = "{3dkjhjo}";

            temp[38, 0] = "3D开奖号质合";
            temp[38, 1] = "{3dkjhzh}";

            temp[39, 0] = "3D开奖号012路";
            temp[39, 1] = "{3dkjh012}";

            temp[40, 0] = "3D开奖号跨度";
            temp[40, 1] = "{3dkjhkd}";

            temp[41, 0] = "3D开奖号和值";
            temp[41, 1] = "{3dkjhhz}";

            temp[42, 0] = "3D开奖号和值大小";
            temp[42, 1] = "{3dkjhhzdx}";

            temp[43, 0] = "3D开奖号和值奇偶";
            temp[43, 1] = "{3dkjhhzjo}";

            temp[44, 0] = "3D试机号";
            temp[44, 1] = "{3dsjh}";

            temp[45, 0] = "3D试机号类型";
            temp[45, 1] = "{3dsjhlx}";

            temp[46, 0] = "3D试机号大小";
            temp[46, 1] = "{3dsjhdx}";

            temp[47, 0] = "3D试机号奇偶";
            temp[47, 1] = "{3dsjhjo}";

            temp[48, 0] = "3D试机号质合";
            temp[48, 1] = "{3dsjhzh}";

            temp[49, 0] = "3D试机号和值";
            temp[49, 1] = "{3dsjhhz}";

            temp[50, 0] = "3D试机号和值大小";
            temp[50, 1] = "{3dsjhhzdx}";

            temp[51, 0] = "3D试机号和值奇偶";
            temp[51, 1] = "{3dsjhhzjo}";
            #endregion

            #region P3
            temp[52, 0] = "P3开奖号";
            temp[52, 1] = "{p3kjh}";

            temp[53, 0] = "P3开奖号百位";
            temp[53, 1] = "{p3kjh1}";

            temp[54, 0] = "P3开奖号十位";
            temp[54, 1] = "{p3kjh2}";

            temp[55, 0] = "P3开奖号个位";
            temp[55, 1] = "{p3kjh3}";

            temp[56, 0] = "P3开奖号和值";
            temp[56, 1] = "{p3kjhhz}";

            temp[57, 0] = "P3开奖号和值奇偶";
            temp[57, 1] = "{p3kjhhzjo}";

            temp[58, 0] = "P3开奖号和值大小";
            temp[58, 1] = "{p3kjhhzdx}";

            temp[59, 0] = "P3试机号";
            temp[59, 1] = "{p3sjh}";

            temp[60, 0] = "P3试机号类型";
            temp[60, 1] = "{p3sjhlx}";

            temp[61, 0] = "P3开奖号大小";
            temp[61, 1] = "{p3kjhdx}";

            temp[62, 0] = "P3开奖号奇偶";
            temp[62, 1] = "{p3kjhjo}";

            temp[63, 0] = "P3开奖号质合";
            temp[63, 1] = "{p3kjhzh}";

            temp[64, 0] = "P3开奖号012";
            temp[64, 1] = "{p3kjh012}";

            temp[65, 0] = "P3开奖号跨度";
            temp[65, 1] = "{p3kjhkd}";
            #endregion

            for (int i = 0; i < 66; i++)
            {
                temp[i, 2] = "";
            }
        }

        /// <summary>
        /// 初始化不含数据模板  (0为名称,1为标签,2为随机内容)
        /// </summary>
        public static string[,] CraeteVoidTemplet()
        {
            CrTemplet();
            return temp;
        }

        /// <summary>
        /// 初始化含数据模板
        /// </summary>
        /// <param name="nids"></param>
        /// <param name="istop"></param>
        public static string[,] CraeteTemplet()
        {
            CrTemplet();
            Kjh3dInfo sdinfo = Kjh3d.GetKjh3dInfoTop1(0, false);
            if (sdinfo.kjh == null && sdinfo.kjh == 0) sdinfo = Kjh3d.GetKjh3dInfoTop1(1, true);
            KjhP3Info p3info = KjhP3.GetKjhP3InfoTop1(false);

            int[] ranlist = RandomNum.RandomList(10, 0, 10);  //产生一个不重复随机数组

            temp[0, 2] = ranlist[0].ToString() + "," + ranlist[1].ToString() + "," + ranlist[2].ToString() + "," + ranlist[3].ToString() + "," + ranlist[4].ToString() + "," + ranlist[5].ToString() + "," + ranlist[6].ToString();
            temp[1, 2] = ranlist[0].ToString() + "," + ranlist[1].ToString() + "," + ranlist[2].ToString() + "," + ranlist[3].ToString() + "," + ranlist[4].ToString() + "," + ranlist[5].ToString();
            temp[2, 2] = ranlist[0].ToString() + "," + ranlist[1].ToString() + "," + ranlist[2].ToString() + "," + ranlist[3].ToString() + "," + ranlist[4].ToString();
            temp[3, 2] = ranlist[0].ToString() + "," + ranlist[1].ToString() + "," + ranlist[2].ToString() + "," + ranlist[3].ToString();
            temp[4, 2] = ranlist[0].ToString() + "," + ranlist[1].ToString() + "," + ranlist[2].ToString();
            temp[5, 2] = ranlist[0].ToString() + "," + ranlist[1].ToString();
            temp[6, 2] = ranlist[0].ToString();

            temp[7, 2] = ranlist[7].ToString();
            temp[8, 2] = ranlist[7].ToString() + "," + ranlist[8].ToString();
            temp[9, 2] = ranlist[7].ToString() + "," + ranlist[8].ToString() + "," + ranlist[9].ToString();


            if (ranlist[0] % 2 == 0)
            {
                temp[10, 2] = ranlist[0].ToString() + "**";
                temp[11, 2] = ranlist[0].ToString() + "** , *" + ranlist[1].ToString() + "*";
                temp[12, 2] = ranlist[0].ToString() + "** , *" + ranlist[1].ToString() + "*, **" + ranlist[2].ToString();
            }
            else
            {
                temp[10, 2] = "*" + ranlist[0].ToString() + "*";
                temp[11, 2] = "*" + ranlist[0].ToString() + "* , **" + ranlist[1].ToString();
                temp[12, 2] = "*" + ranlist[0].ToString() + "* , **" + ranlist[1].ToString() + ", **" + ranlist[2].ToString();
            }
            
            temp[13, 2] = ranlist[0].ToString() + ranlist[1].ToString() + " - " + ranlist[3].ToString() + ranlist[4].ToString() + " - " + ranlist[0].ToString() + ranlist[5].ToString();
            temp[14, 2] = ranlist[0].ToString() + ranlist[1].ToString() + ranlist[2].ToString() + " - " + ranlist[3].ToString() + ranlist[4].ToString() + ranlist[5].ToString() + " - " + ranlist[0].ToString() + ranlist[5].ToString() + ranlist[6].ToString();
            temp[15, 2] = ranlist[0].ToString() + ranlist[1].ToString() + ranlist[2].ToString() + ranlist[3].ToString() + " - " + ranlist[3].ToString() + ranlist[4].ToString() + ranlist[5].ToString() + ranlist[6].ToString() + " - " + ranlist[0].ToString() + ranlist[5].ToString() + ranlist[6].ToString() + ranlist[3].ToString();
            temp[16, 2] = ranlist[0].ToString() + ranlist[1].ToString() + ranlist[2].ToString() + ranlist[3].ToString() + ranlist[4].ToString()+ " - " + ranlist[3].ToString() + ranlist[4].ToString() + ranlist[5].ToString() + ranlist[6].ToString() + ranlist[2].ToString()+ " - " + ranlist[0].ToString() + ranlist[5].ToString() + ranlist[6].ToString() + ranlist[3].ToString()+ ranlist[1].ToString();
            temp[17, 2] = ranlist[0].ToString() + ranlist[1].ToString() + ranlist[2].ToString() + ranlist[3].ToString() + ranlist[4].ToString()+ ranlist[5].ToString()+ " - " + ranlist[3].ToString() + ranlist[4].ToString() + ranlist[5].ToString() + ranlist[6].ToString()+ ranlist[2].ToString() + ranlist[0].ToString()+ " - " + ranlist[0].ToString() + ranlist[5].ToString() + ranlist[6].ToString() + ranlist[3].ToString()+ ranlist[1].ToString()+ ranlist[2].ToString();
            
            temp[18, 2] = DxJoZh.Daxiao(ranlist[0]) + DxJoZh.Daxiao(ranlist[1]) + DxJoZh.Daxiao(ranlist[2]);
            temp[19, 2] = DxJoZh.Jiou(ranlist[0]) + DxJoZh.Jiou(ranlist[1]) + DxJoZh.Jiou(ranlist[2]);
            temp[20, 2] = DxJoZh.Zhihe(ranlist[0]) + DxJoZh.Zhihe(ranlist[1]) + DxJoZh.Zhihe(ranlist[2]);

            temp[21, 2] = ranlist[0].ToString();
            temp[22, 2] = ranlist[1].ToString();
            temp[23, 2] = ranlist[2].ToString();
            temp[24, 2] = ranlist[3].ToString();
            temp[25, 2] = ranlist[4].ToString();
            temp[26, 2] = ranlist[5].ToString();
            temp[27, 2] = ranlist[6].ToString();

            temp[28, 2] = ranlist[7].ToString();
            temp[29, 2] = ranlist[8].ToString();
            temp[30, 2] = ranlist[9].ToString();

            #region 上期3D开奖号
            temp[31, 2] = sdinfo.kjh.ToString();
            temp[32, 2] = DxJoZh.Zu(sdinfo.kjh_zu);
            temp[33, 2] = sdinfo.a.ToString();
            temp[34, 2] = sdinfo.b.ToString();
            temp[35, 2] = sdinfo.c.ToString();
            temp[36, 2] = DxJoZh.DaxiaoStr(sdinfo.kjh_dx);
            temp[37, 2] = DxJoZh.JiouStr(sdinfo.kjh_jo);
            temp[38, 2] = DxJoZh.ZhiheStr(sdinfo.kjh_zh);
            temp[39, 2] = (sdinfo.a % 2).ToString() + (sdinfo.b % 2).ToString() + (sdinfo.c % 2).ToString();
            temp[40, 2] = DxJoZh.Kuadu(sdinfo.a, sdinfo.b, sdinfo.c).ToString();
            temp[41, 2] = sdinfo.hz.ToString();
            temp[42, 2] = DxJoZh.DaxiaoStr(sdinfo.kjh_hz_dx);
            temp[43, 2] = DxJoZh.JiouStr(sdinfo.kjh_hz_jo);
            temp[44, 2] = sdinfo.sjh.ToString();
            temp[45, 2] = sdinfo.sjx;
            temp[46, 2] = DxJoZh.DaxiaoStr(sdinfo.sjh_dx); 
            temp[47, 2] = DxJoZh.JiouStr(sdinfo.sjh_jo);
            temp[48, 2] = DxJoZh.ZhiheStr(sdinfo.sjh_zh);
            temp[49, 2] = sdinfo.sjh_hz.ToString();
            temp[50, 2] = DxJoZh.DaxiaoStr(sdinfo.sjh_hz_dx);
            temp[51, 2] = DxJoZh.JiouStr(sdinfo.sjh_hz_jo);
            #endregion

            #region P3
            temp[52, 2] = p3info.kjh.ToString();
            temp[53, 2] = p3info.a.ToString();
            temp[54, 2] = p3info.b.ToString();
            temp[55, 2] = p3info.c.ToString();
            temp[56, 2] = p3info.hz.ToString();
            temp[57, 2] = DxJoZh.Jiou(p3info.hz);
            temp[58, 2] = DxJoZh.Daxiao(p3info.hz);
            temp[59, 2] = p3info.sjh;
            temp[60, 2] = p3info.sjhtype;
            temp[61, 2] = DxJoZh.Daxiao(p3info.a)+DxJoZh.Daxiao(p3info.b)+DxJoZh.Daxiao(p3info.c);
            temp[62, 2] = DxJoZh.Jiou(p3info.a)+DxJoZh.Jiou(p3info.b)+DxJoZh.Jiou(p3info.c);
            temp[63, 2] = DxJoZh.Zhihe(p3info.a)+DxJoZh.Zhihe(p3info.b)+DxJoZh.Zhihe(p3info.c);
            temp[64, 2] = (p3info.a % 2).ToString() + (p3info.b % 2).ToString() + (p3info.c % 2).ToString();
            temp[65, 2] = DxJoZh.Kuadu(p3info.a, p3info.b, p3info.c).ToString();
            #endregion

            return temp;
        }
    }
}
