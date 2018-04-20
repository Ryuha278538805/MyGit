using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Business;
using DataProvider;
using Model;

namespace Business
{
    public class YcUtil
    {
        public static string[] YcType = { "独胆", "双胆", "三胆", "杀一码", "杀二码" };

        /// <summary>
        /// 生成新一期的预测数据 并自动判断上一期的是否正确
        /// </summary>
        /// <param name="yzid"></param>
        public static void CreateAndCheckYcInfo(string yzidstr)
        {
            string[] yzids = yzidstr.Split(',');
            int yzid;
            YcZoneInfo yzinfo;
            for (int i = 0; i < yzids.Length; i++)
            {
                yzid = TypeConverter.StrToInt(yzids[i], 0);
                if (yzid > 0)
                {
                    yzinfo = YcZone.GetYcZoneByYzID(yzid);
                    if (yzinfo.isautowrite)
                    {
                        ChkIsRightAndUpdateYcInfo(yzinfo);                        
                        CreateANewYcInfo(yzinfo);
                    }
                }
            }
        }

        /// <summary>
        /// 验证正确与否并保存结果
        /// </summary>
        /// <param name="yzid"></param>
        public static void ChkIsRightAndUpdateYcInfo(YcZoneInfo yzinfo)
        {
            YcInfo ycinfo = Yc.GetYcInfoNoChkTop1ByYzid(yzinfo.yzid);            
            if (ycinfo.yid > 0)
            {
                switch (yzinfo.czid)
                {
                    //双色球
                    case 7:
                        KjhSsqInfo kjhssq = KjhSsq.GetKjhSsqInfo(0, ycinfo.qi, false);
                        if (kjhssq.id > 0)
                            ycinfo.kjh = kjhssq.a.ToString() + " " + kjhssq.b.ToString() + " " + kjhssq.c.ToString() + " " + kjhssq.d.ToString() + " " + kjhssq.e.ToString() + " " + kjhssq.f.ToString() + " + " + kjhssq.g.ToString();
                        else
                            ycinfo.kjh = "";
                        break;
                    //3D
                    case 1:
                        Kjh3dInfo kjh3d = Kjh3d.GetKjh3dInfo(0, ycinfo.qi, false);
                        if (kjh3d.id > 0)
                            ycinfo.kjh = kjh3d.kjh.ToString("000");
                        else
                            ycinfo.kjh = "";
                        break;
                    //排列三
                    case 2:
                        KjhP3Info kjhp3 = KjhP3.GetKjhP3Info(0, ycinfo.qi, false);
                        if (kjhp3.id > 0)
                            ycinfo.kjh = kjhp3.a.ToString() + kjhp3.b.ToString() + kjhp3.c.ToString();
                        else
                            ycinfo.kjh = "";
                        break;
                    default:
                        break;
                }
                if (!string.IsNullOrEmpty(ycinfo.kjh))
                {
                    ycinfo = ChkIsRight(yzinfo, ycinfo);   //验证是否正确
                    Yc.CreateYcInfo(ycinfo);  //更新预测结果
                }
            }
        }
        
        /// <summary>
        /// 验证正误
        /// </summary>
        /// <param name="yzid"></param>
        public static YcInfo ChkIsRight(YcZoneInfo yzinfo, YcInfo ycinfo)
        {
            switch (yzinfo.type)
            {
                   //独胆
                case 1:
                    ycinfo.isright = ChkDuDan(ycinfo);
                    break;
                //双胆
                case 2:
                    ycinfo.isright = ChkShuangDan(ycinfo);
                    break;
                //三胆
                case 3:
                    ycinfo.isright = ChkSanDan(ycinfo);
                    break;
                //杀一码
                case 4:
                    ycinfo.isright = ChkShaYiMa(ycinfo);
                    break;
                //杀二码
                case 5:
                    ycinfo.isright = ChkShaErMa(ycinfo);
                    break;
                default:
                    break;
            }
            ycinfo.title = TempletChange(yzinfo.titlemodel, ycinfo, yzinfo);
            ycinfo.context = TempletChange(yzinfo.contextmodel, ycinfo, yzinfo);
            return ycinfo;
        }

        /// <summary>
        /// 随机生成一个新的预测信息
        /// </summary>
        /// <param name="yzid"></param>
        public static void CreateANewYcInfo(YcZoneInfo yzinfo)
        {
            CzInfo czinfo = Cz.GetCzInfo(yzinfo.czid, false);            
            YcInfo ycinfo = CreateYcInfo(czinfo, yzinfo);  //生成新预测
            yzinfo.lastqi = ycinfo.qi;
            Yc.CreateYcInfo(ycinfo); //保存新预测
            YcZone.CreateYcZoneInfo(yzinfo); //更新预测专题期数
        }

        public static YcInfo CreateYcInfo(CzInfo czinfo, YcZoneInfo yzinfo)
        {
            YcInfo ycinfo = new YcInfo();
            ycinfo.qi = czinfo.qi;
            ycinfo.yzid = yzinfo.yzid;
            switch (yzinfo.type)
            {
                //独胆
                case 1:
                    ycinfo.info = CreateDuDan(czinfo);
                    break;
                //双胆
                case 2:
                    ycinfo.info = CreateShuangDan(czinfo);
                    break;
                //三胆
                case 3:
                    ycinfo.info = CreateSanDan(czinfo);
                    break;
                //杀一码
                case 4:
                    ycinfo.info = CreateDuDan(czinfo);
                    break;
                //杀二码
                case 5:
                    ycinfo.info = CreateShuangDan(czinfo);
                    break;
                default:
                    break;
            }
            //期数：{qi},专题名：{zonename},预测类型：{typename},预测内容：{info},对错：{rightwrong}，开奖号：{kjh}
            ycinfo.title = TempletChange(yzinfo.titlemodel, ycinfo, yzinfo);
            ycinfo.context = TempletChange(yzinfo.contextmodel, ycinfo, yzinfo);
            return ycinfo;
        }

        public static bool ReCreateYcInfo(object yid)        
        {
            bool isok = false;
            int _yid = TypeConverter.ObjectToInt(yid);
            if(_yid>0)
            {
                YcInfo ycinfo = Yc.GetYcInfoByYID(_yid);
                //未开奖 重新生成
                if (string.IsNullOrEmpty(ycinfo.kjh))
                {
                    YcZoneInfo yzinfo = YcZone.GetYcZoneByYzID(ycinfo.yzid);
                    CzInfo czinfo = Cz.GetCzInfo(yzinfo.czid, false);
                    ycinfo = CreateYcInfo(czinfo, yzinfo);
                    ycinfo.yid = _yid;
                    if(Yc.CreateYcInfo(ycinfo)>0)
                        isok = true;
                }
            }
            return isok;
        }

        #region 验证结果
        public static bool ChkDuDan(YcInfo ycinfo)
        {
            bool result = false;
            if (ycinfo.kjh.IndexOf(ycinfo.info) >= 0)
                result = true;
            return result;
        }

        public static bool ChkShuangDan(YcInfo ycinfo)
        {
            bool result = false;
            string[] dan = ycinfo.info.Split(',');
            if (dan.Length == 2)
            {
                for (int i = 0; i < dan.Length; i++)
                {
                    if (ycinfo.kjh.IndexOf(dan[i]) >= 0)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        public static bool ChkSanDan(YcInfo ycinfo)
        {
            bool result = false;
            string[] dan = ycinfo.info.Split(',');
            if (dan.Length == 3)
            {
                for (int i = 0; i < dan.Length; i++)
                {
                    if (ycinfo.kjh.IndexOf(dan[i]) >= 0)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        public static bool ChkShaYiMa(YcInfo ycinfo)
        {
            bool result = false;
            if (!(ycinfo.kjh.IndexOf(ycinfo.info) >= 0))
                result = true;
            return result;
        }

        public static bool ChkShaErMa(YcInfo ycinfo)
        {
            bool result = true;
            string[] dan = ycinfo.info.Split(',');
            if (dan.Length == 2)
            {
                for (int i = 0; i < dan.Length; i++)
                {
                    if (ycinfo.kjh.IndexOf(dan[i]) >= 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }
        #endregion

        #region  生成预测内容
        public static string CreateDuDan(CzInfo czinfo)
        {
            string result = string.Empty;
            //3D，排列三
            if (czinfo.czid == 1 || czinfo.czid == 2)
                result = RandomNum.RandomList(10, 0, 10)[0].ToString();
            //双色球
            if (czinfo.czid == 7)
                result = RandomNum.RandomList(33, 1, 34)[0].ToString();
            return result;
        }

        public static string CreateShuangDan(CzInfo czinfo)
        {
            string result = string.Empty;
            //3D，排列三
            if (czinfo.czid == 1 || czinfo.czid == 2)
                result = RandomNum.RandomList(10, 0, 10)[0].ToString() + "," + RandomNum.RandomList(10, 0, 10)[1].ToString();
            //双色球
            if (czinfo.czid == 7)
                result = RandomNum.RandomList(33, 1, 34)[0].ToString() + "," + RandomNum.RandomList(33, 1, 34)[1].ToString();
            return result;
        }

        public static string CreateSanDan(CzInfo czinfo)
        {
            string result = string.Empty;
            //3D，排列三
            if (czinfo.czid == 1 || czinfo.czid == 2)
                result = RandomNum.RandomList(10, 0, 10)[0].ToString() + "," + RandomNum.RandomList(10, 0,10)[1].ToString() + "," + RandomNum.RandomList(10, 0, 10)[2].ToString();
            //双色球
            if (czinfo.czid == 7)
                result = RandomNum.RandomList(33, 1, 34)[0].ToString() + "," + RandomNum.RandomList(33, 1, 34)[1].ToString() + "," + RandomNum.RandomList(33, 1, 34)[2].ToString();
            return result;
        }
        #endregion

        public static string GetYcTypeName(object yctype)
        {
            if (TypeConverter.ObjectToInt(yctype) > 0)
                return YcUtil.YcType[TypeConverter.ObjectToInt(yctype) - 1];
            else
                return "";
        }

        public static string GetIsRightStr(bool isright)
        {
            if (isright)
                return "正确";
            else
                return "错误";
        }

        public static string TempletChange(string model, YcInfo ycinfo, YcZoneInfo yzinfo)
        {
            //期数：{qi},专题名：{zonename},预测类型：{typename},预测内容：{info},对错：{rightwrong}，开奖号：{kjh}
            string result = "";
            result = model.Replace("{qi}", ycinfo.qi.ToString()).Replace("{zonename}", yzinfo.name).Replace("{typename}", GetYcTypeName(yzinfo.type))
                .Replace("{info}", ycinfo.info);
            if (string.IsNullOrEmpty(ycinfo.kjh))
                result = result.Replace("{rightwrong}", "-").Replace("{kjh}", "未开");
            else
                result = result.Replace("{rightwrong}", GetIsRightStr(ycinfo.isright)).Replace("{kjh}", ycinfo.kjh);
            return result;
        }
    }
}
