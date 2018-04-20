using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data;
using System.Text;
using System.Xml;
using Common;
using Business;
using Model;
using DataProvider;

namespace Admin
{
    public partial class lottery_dlt : Pages
    {
        protected int id;
        protected int CzMode = (int)KjhCz.Czdlt;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowPage)
                AllowMessage("对不起，当前用户无此权限！");

            menus1.clicked = 8;   //左边menu样式选中
            id = BBRequest.GetQueryInt("id", 0);
            if (!Page.IsPostBack)
            {
                BinderList();
                if (id > 0)
                    BinderKjhDltInfo();
            }
        }

        private void BinderList()
        {
            string where = string.Empty;
            DataSet ds = KjhDltData.GetPageListKjh(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "tbl_dlt", "qi desc", where);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.list.DataSource = ds.Tables[0];
                list.DataBind();
                this.AspNetPager1.RecordCount = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
            }
        }

        private void BinderKjhDltInfo()
        {
            KjhDltInfo info = KjhDlt.GetKjhDltInfo(id, 0, false);
            if (info != null && info.id > 0)
            {
                qi.Text = info.qi.ToString().Trim();
                a.Text = info.a.ToString().Trim();
                b.Text = info.b.ToString().Trim();
                c.Text = info.c.ToString().Trim();
                d.Text = info.d.ToString().Trim();
                e.Text = info.e.ToString().Trim();
                f.Text = info.f.ToString().Trim();
                g.Text = info.g.ToString().Trim();
                zj1.Text = info.zj1.ToString().Trim();
                zj2.Text = info.zj2.ToString().Trim();
                zj3.Text = info.zj3.ToString().Trim();
                zj4.Text = info.zj4.ToString().Trim();
                zj5.Text = info.zj5.ToString().Trim();
                zj6.Text = info.zj6.ToString().Trim();
                zj7.Text = info.zj7.ToString().Trim();
                zj8.Text = info.zj8.ToString().Trim();
                zzj1.Text = info.zzj1.ToString().Trim();
                zzj2.Text = info.zzj2.ToString().Trim();
                zzj3.Text = info.zzj3.ToString().Trim();
                zzj4.Text = info.zzj4.ToString().Trim();
                zzj5.Text = info.zzj5.ToString().Trim();
                zzj6.Text = info.zzj6.ToString().Trim();
                zzj7.Text = info.zzj7.ToString().Trim();
                jo1.Text = info.jo1.ToString().Trim();
                jo2.Text = info.jo2.ToString().Trim();
                jo3.Text = info.jo3.ToString().Trim();
                zjo1.Text = info.zjo1.ToString().Trim();
                zjo2.Text = info.zjo2.ToString().Trim();
                zjo3.Text = info.zjo3.ToString().Trim();
                tzmoney.Text = info.tzmoney;
                nextmoney.Text = info.nextmoney;
                fjtzmoney.Text = info.fjtzmoney;
                fjnextmoney.Text = info.fjnextmoney;
                date.Text = info.date.ToShortDateString();
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            KjhDltInfo info = new KjhDltInfo();
            info.id = id;
            info.qi = TypeConverter.StrToInt(qi.Text);
            info.a = TypeConverter.StrToInt(a.Text);
            info.b = TypeConverter.StrToInt(b.Text);
            info.c = TypeConverter.StrToInt(c.Text);
            info.d = TypeConverter.StrToInt(d.Text);
            info.e = TypeConverter.StrToInt(this.e.Text);
            info.f = TypeConverter.StrToInt(f.Text);
            info.g = TypeConverter.StrToInt(g.Text);
            info.zj1 = TypeConverter.StrToInt(zj1.Text);
            info.zj2 = TypeConverter.StrToInt(zj2.Text);
            info.zj3 = TypeConverter.StrToInt(zj3.Text);
            info.zj4 = TypeConverter.StrToInt(zj4.Text);
            info.zj5 = TypeConverter.StrToInt(zj5.Text);
            info.zj6 = TypeConverter.StrToInt(zj6.Text);
            info.zj7 = TypeConverter.StrToInt(zj7.Text);
            info.zj8 = TypeConverter.StrToInt(zj8.Text);
            info.zzj1 = TypeConverter.StrToInt(zzj1.Text);
            info.zzj2 = TypeConverter.StrToInt(zzj2.Text);
            info.zzj3 = TypeConverter.StrToInt(zzj3.Text);
            info.zzj4 = TypeConverter.StrToInt(zzj4.Text);
            info.zzj5 = TypeConverter.StrToInt(zzj5.Text);
            info.zzj6 = TypeConverter.StrToInt(zzj6.Text);
            info.zzj7 = TypeConverter.StrToInt(zzj7.Text);
            info.jo1 = TypeConverter.StrToInt(jo1.Text);
            info.jo2 =TypeConverter.StrToInt( jo2.Text);
            info.jo3 = TypeConverter.StrToInt(jo3.Text);
            info.zjo1 = TypeConverter.StrToInt(zjo1.Text);
            info.zjo2 = TypeConverter.StrToInt(zjo2.Text);
            info.zjo3 = TypeConverter.StrToInt(zjo3.Text);
            info.tzmoney = tzmoney.Text.Trim().Replace(",", "");
            info.nextmoney = nextmoney.Text.Trim().Replace(",", "");
            info.fjtzmoney = fjtzmoney.Text.Trim().Replace(",", "");
            info.fjnextmoney = fjnextmoney.Text.Trim().Replace(",", "");
            info.date = TypeConverter.StrToDateTime(date.Text);

            int i = KjhDlt.CreateKjhDltInfo(info);
            if (i > 0)
            {
                if (id == 0)
                    AlertMessage("提示：数据添加成功! ", "lottery_Dlt.aspx");
                else
                    AlertMessage("提示：数据编辑成功! ", "lottery_Dlt.aspx");
            }
            else if (i < 0)
                AlertMessage("数据已经存在，请勿重复添加....");
            else
                AlertMessage("保存失败，请重试....");
        }

        protected void autoget_Click(object sender, EventArgs e)
        {
            int qi = Cz.GetNewQi((int)KjhCz.Czdlt);
            int getqi;
            int endqi = 155;
            //本年度到顶 过年了
            if (TypeConverter.StrToInt(qi.ToString().Substring(4, 3)) == endqi)
            {
                qi = (TypeConverter.StrToInt(qi.ToString().Substring(0, 4)) + 1) * 1000 + 1;
            }
            getqi = TypeConverter.StrToInt(qi.ToString().Substring(2, 5));
            //写获取XML自动
            string url = "http://www.500.com/static/info/kaijiang/xml/dlt/" + getqi.ToString("00000") + ".xml";
            DataSet ds = new DataSet();
            ds.ReadXml(XMLReader.GetXmlDocument(url));
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                KjhDltInfo info = KjhDlt.GetKjhDltInfo(0, qi, false);
                info.qi = qi;
                info.a = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["ForeResult"].ToString().Split(',')[0]);
                info.b = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["ForeResult"].ToString().Split(',')[1]);
                info.c = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["ForeResult"].ToString().Split(',')[2]);
                info.d = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["ForeResult"].ToString().Split(',')[3]);
                info.e = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["ForeResult"].ToString().Split(',')[4]);
                info.f = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BackResult"].ToString().Split(',')[0]);
                info.g = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BackResult"].ToString().Split(',')[1]);
                info.zj1 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseNum1"].ToString().Replace(",", ""));
                info.zj2 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseNum2"].ToString().Replace(",", ""));
                info.zj3 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseNum3"].ToString().Replace(",", ""));
                info.zj8 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Num8"].ToString().Replace(",", ""));
                info.zzj1 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionNum1"].ToString().Replace(",", ""));
                info.zzj2 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionNum2"].ToString().Replace(",", ""));
                info.zzj3 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionNum3"].ToString().Replace(",", ""));

                //开通了4-7等奖也追加
                if (getqi > 9120)
                {
                    info.zj4 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseNum4"].ToString().Replace(",", ""));
                    info.zj5 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseNum5"].ToString().Replace(",", ""));
                    info.zj6 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseNum6"].ToString().Replace(",", ""));
                    info.zj7 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseNum7"].ToString().Replace(",", ""));                    
                    info.zzj4 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionNum4"].ToString().Replace(",", ""));
                    info.zzj5 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionNum5"].ToString().Replace(",", ""));
                    info.zzj6 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionNum6"].ToString().Replace(",", ""));
                    info.zzj7 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionNum7"].ToString().Replace(",", ""));
                }
                else
                {
                    info.zj4 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Num4"].ToString().Replace(",", ""));
                    info.zj5 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Num5"].ToString().Replace(",", ""));
                    info.zj6 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Num6"].ToString().Replace(",", ""));
                    info.zj7 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Num7"].ToString().Replace(",", ""));
                }
                info.jo1 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseMoney1"].ToString().Replace(",",""));
                info.jo2 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseMoney2"].ToString().Replace(",", ""));
                info.jo3 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseMoney3"].ToString().Replace(",", ""));
                info.zjo1 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionMoney1"].ToString().Replace(",", ""));
                info.zjo2 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionMoney2"].ToString().Replace(",", ""));
                info.zjo3 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionMoney3"].ToString().Replace(",", ""));
                info.tzmoney = ds.Tables[0].Rows[0]["TotalMoney"].ToString().Replace(",", "");
                info.nextmoney = ds.Tables[0].Rows[0]["CCMoney"].ToString().Replace(",", "");
                info.fjtzmoney = ds.Tables[0].Rows[0]["SEXETotalMoney"].ToString().Replace(",", "");
                info.fjnextmoney = ds.Tables[0].Rows[0]["AddCCMoney"].ToString().Replace(",", "");
                info.date = TypeConverter.ObjectToDateTime(ds.Tables[0].Rows[0]["ResultTime"]);

                int i;
                i = KjhDlt.CreateKjhDltInfo(info);
                if (i > 0)
                {
                    JsRedirect("lottery_dlt.aspx");
                    //if (id == 0)
                    //    AlertMessage("提示：数据添加成功! ", "lottery_sd.aspx");
                    //else
                    //    AlertMessage("提示：数据编辑成功! ", "lottery_sd.aspx");
                }
                else if (i < 0)
                    AlertMessage("数据已经存在，请勿重复添加....");
                else
                    AlertMessage("保存失败，请重试....");
            }
        }

        protected string GetKjh(object obj)
        {
            if (obj != null && obj.ToString().Length > 0)
                return TypeConverter.ObjectToInt(obj).ToString("00");
            else
                return "";
        }

        protected string GetDateStr(object obj)
        {
            return GetDate(obj);
        }

        protected void autoget2_Click(object sender, EventArgs e)
        {
            int qi = Cz.GetMaxQi((int)KjhCz.Czqlc);
            int getqi = TypeConverter.StrToInt(qi.ToString().Substring(2, 5));
            //写获取XML自动
            string url = "http://www.500.com/static/info/kaijiang/xml/dlt/" + getqi.ToString("00000") + ".xml";
            DataSet ds = new DataSet();
            ds.ReadXml(XMLReader.GetXmlDocument(url));
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                KjhDltInfo info = new KjhDltInfo();
                info.qi = qi;
                info.a = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["ForeResult"].ToString().Split(',')[0]);
                info.b = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["ForeResult"].ToString().Split(',')[1]);
                info.c = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["ForeResult"].ToString().Split(',')[2]);
                info.d = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["ForeResult"].ToString().Split(',')[3]);
                info.e = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["ForeResult"].ToString().Split(',')[4]);
                info.f = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BackResult"].ToString().Split(',')[0]);
                info.g = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BackResult"].ToString().Split(',')[1]);
                info.zj1 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseNum1"].ToString().Replace(",", ""));
                info.zj2 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseNum2"].ToString().Replace(",", ""));
                info.zj3 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseNum3"].ToString().Replace(",", ""));
                info.zj8 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Num8"].ToString().Replace(",", ""));
                info.zzj1 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionNum1"].ToString().Replace(",", ""));
                info.zzj2 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionNum2"].ToString().Replace(",", ""));
                info.zzj3 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionNum3"].ToString().Replace(",", ""));

                //开通了4-7等奖也追加
                if (getqi > 9120)
                {
                    info.zj4 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseNum4"].ToString().Replace(",", ""));
                    info.zj5 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseNum5"].ToString().Replace(",", ""));
                    info.zj6 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseNum6"].ToString().Replace(",", ""));
                    info.zj7 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseNum7"].ToString().Replace(",", ""));
                    info.zzj4 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionNum4"].ToString().Replace(",", ""));
                    info.zzj5 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionNum5"].ToString().Replace(",", ""));
                    info.zzj6 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionNum6"].ToString().Replace(",", ""));
                    info.zzj7 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionNum7"].ToString().Replace(",", ""));
                }
                else
                {
                    info.zj4 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Num4"].ToString().Replace(",", ""));
                    info.zj5 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Num5"].ToString().Replace(",", ""));
                    info.zj6 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Num6"].ToString().Replace(",", ""));
                    info.zj7 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Num7"].ToString().Replace(",", ""));
                }
                info.jo1 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseMoney1"].ToString().Replace(",", ""));
                info.jo2 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseMoney2"].ToString().Replace(",", ""));
                info.jo3 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BaseMoney3"].ToString().Replace(",", ""));
                info.zjo1 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionMoney1"].ToString().Replace(",", ""));
                info.zjo2 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionMoney2"].ToString().Replace(",", ""));
                info.zjo3 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["AdditionMoney3"].ToString().Replace(",", ""));
                info.tzmoney = ds.Tables[0].Rows[0]["TotalMoney"].ToString().Replace(",", "");
                info.nextmoney = ds.Tables[0].Rows[0]["CCMoney"].ToString().Replace(",", "");
                info.fjtzmoney = ds.Tables[0].Rows[0]["SEXETotalMoney"].ToString().Replace(",", "");
                info.fjnextmoney = ds.Tables[0].Rows[0]["AddCCMoney"].ToString().Replace(",", "");
                info.date = TypeConverter.ObjectToDateTime(ds.Tables[0].Rows[0]["ResultTime"]);

                int i;
                i = KjhDlt.CreateKjhDltInfo(info);
                if (i > 0)
                {
                    JsRedirect("lottery_dlt.aspx");
                    //if (id == 0)
                    //    AlertMessage("提示：数据添加成功! ", "lottery_sd.aspx");
                    //else
                    //    AlertMessage("提示：数据编辑成功! ", "lottery_sd.aspx");
                }
                else if (i < 0)
                    AlertMessage("数据已经存在，请勿重复添加....");
                else
                    AlertMessage("保存失败，请重试....");
            }
        }
    }
}