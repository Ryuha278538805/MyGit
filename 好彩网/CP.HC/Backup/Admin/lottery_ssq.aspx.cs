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
    public partial class lottery_ssq : Pages
    {
        protected int id;
        protected int CzMode = (int)KjhCz.Czssq;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowPage)
                AllowMessage("对不起，当前用户无此权限！");

            menus1.clicked = 4;   //左边menu样式选中
            id = BBRequest.GetQueryInt("id", 0);
            if (!Page.IsPostBack)
            {
                BinderList();
                if (id > 0)
                    BinderKjhSsqInfo();
            }            
        }

        private void BinderList()
        {
            string where = string.Empty;
            DataSet ds = KjhSsqData.GetPageListKjh(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "tbl_ssq", "qi desc", where);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.list.DataSource = ds.Tables[0];
                list.DataBind();
                this.AspNetPager1.RecordCount = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
            }
        }

        private void BinderKjhSsqInfo()
        {
            KjhSsqInfo info = KjhSsq.GetKjhSsqInfo(id, 0, false);
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
                jo1.Text = info.jo1.ToString().Trim();
                jo2.Text = info.jo2.ToString().Trim();                
                tzmoney.Text = info.tzmoney;
                nextmoney.Text = info.nextmoney;
                cc.Text = info.cc;
                date.Text = info.date.ToShortDateString();
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            KjhSsqInfo info = new KjhSsqInfo();
            info.id = id;
            info.qi = TypeConverter.StrToInt(qi.Text);
            info.a = TypeConverter.StrToInt(a.Text);
            info.b = TypeConverter.StrToInt(b.Text);
            info.c = TypeConverter.StrToInt(c.Text);
            info.d = TypeConverter.StrToInt(d.Text);
            info.e = TypeConverter.StrToInt(this.e.Text);
            info.f = TypeConverter.StrToInt(f.Text);
            info.g = TypeConverter.StrToInt(g.Text);
            info.zj1 = zj1.Text.Trim().Replace(",", "");
            info.zj2 = zj2.Text.Trim().Replace(",", "");
            info.zj3 = zj3.Text.Trim().Replace(",", "");
            info.zj4 = zj4.Text.Trim().Replace(",", "");
            info.zj5 = zj5.Text.Trim().Replace(",", "");
            info.zj6 = zj6.Text.Trim().Replace(",", "");
            info.jo1 = jo1.Text.Trim().Replace(",", "");
            info.jo2 = jo2.Text.Trim().Replace(",", "");
            info.tzmoney = tzmoney.Text.Trim().Replace(",", "");
            info.nextmoney = nextmoney.Text.Trim().Replace(",", "");
            info.cc = cc.Text.Trim();
            info.date = TypeConverter.StrToDateTime(date.Text);

            int i = KjhSsq.CreateKjhSsqInfo(info);
            if (i > 0)
            {
                if (id == 0)
                    AlertMessage("提示：数据添加成功! ", "lottery_ssq.aspx");
                else
                    AlertMessage("提示：数据编辑成功! ", "lottery_ssq.aspx");
            }
            else if (i < 0)
                AlertMessage("数据已经存在，请勿重复添加....");
            else
                AlertMessage("保存失败，请重试....");
        }

        protected void autoget_Click(object sender, EventArgs e)
        {
            int qi = Cz.GetNewQi((int)KjhCz.Czssq);
            int getqi;
            int endqi = 155;
            //本年度到顶 过年了
            if (TypeConverter.StrToInt(qi.ToString().Substring(4, 3)) == endqi)
            {
                qi = (TypeConverter.StrToInt(qi.ToString().Substring(0, 4)) + 1) * 1000 + 1;
            }
            getqi = TypeConverter.StrToInt(qi.ToString().Substring(2, 5));
            //写获取XML自动
            string url = "http://www.500.com/static/info/kaijiang/xml/ssq/" + getqi.ToString("00000") + ".xml";
            DataSet ds = new DataSet();
            ds.ReadXml(XMLReader.GetXmlDocument(url));
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                KjhSsqInfo info = new KjhSsqInfo();
                info.qi = qi;
                info.a = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["RedResult"].ToString().Split(',')[0]);
                info.b = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["RedResult"].ToString().Split(',')[1]);
                info.c = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["RedResult"].ToString().Split(',')[2]);
                info.d = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["RedResult"].ToString().Split(',')[3]);
                info.e = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["RedResult"].ToString().Split(',')[4]);
                info.f = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["RedResult"].ToString().Split(',')[5]);
                info.g= TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BlueResult"]);
                info.zj1 = ds.Tables[0].Rows[0]["Num1"].ToString().Replace(",", "");
                info.zj2 = ds.Tables[0].Rows[0]["Num2"].ToString().Replace(",", "");
                info.zj3 = ds.Tables[0].Rows[0]["Num3"].ToString().Replace(",", "");
                info.zj4 = ds.Tables[0].Rows[0]["Num4"].ToString().Replace(",", "");
                info.zj5 = ds.Tables[0].Rows[0]["Num5"].ToString().Replace(",", "");
                info.zj6 = ds.Tables[0].Rows[0]["Num6"].ToString().Replace(",", "");
                info.jo1 = ds.Tables[0].Rows[0]["Money1"].ToString().Replace(",","");
                info.jo2 = ds.Tables[0].Rows[0]["Money2"].ToString().Replace(",", "");
                info.tzmoney = ds.Tables[0].Rows[0]["CCMoney"].ToString().Replace(",", "");
                info.nextmoney = ds.Tables[0].Rows[0]["TotalMoney"].ToString().Replace(",", "");
                info.cc = "";
                info.date = TypeConverter.ObjectToDateTime(ds.Tables[0].Rows[0]["ResultTime"]);

                int i;
                i = KjhSsq.CreateKjhSsqInfo(info);
                if (i > 0)
                {
                    JsRedirect("lottery_ssq.aspx");
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
            int qi = Cz.GetMaxQi((int)KjhCz.Czssq);
            int getqi = TypeConverter.StrToInt(qi.ToString().Substring(2, 5));
            //写获取XML自动
            string url = "http://www.500.com/static/info/kaijiang/xml/ssq/" + getqi.ToString("00000") + ".xml";
            DataSet ds = new DataSet();
            ds.ReadXml(XMLReader.GetXmlDocument(url));
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                KjhSsqInfo info = KjhSsq.GetKjhSsqInfo(0, qi, false);
                info.qi = qi;
                info.a = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["RedResult"].ToString().Split(',')[0]);
                info.b = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["RedResult"].ToString().Split(',')[1]);
                info.c = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["RedResult"].ToString().Split(',')[2]);
                info.d = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["RedResult"].ToString().Split(',')[3]);
                info.e = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["RedResult"].ToString().Split(',')[4]);
                info.f = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["RedResult"].ToString().Split(',')[5]);
                info.g = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["BlueResult"]);
                info.zj1 = ds.Tables[0].Rows[0]["Num1"].ToString().Replace(",", "");
                info.zj2 = ds.Tables[0].Rows[0]["Num2"].ToString().Replace(",", "");
                info.zj3 = ds.Tables[0].Rows[0]["Num3"].ToString().Replace(",", "");
                info.zj4 = ds.Tables[0].Rows[0]["Num4"].ToString().Replace(",", "");
                info.zj5 = ds.Tables[0].Rows[0]["Num5"].ToString().Replace(",", "");
                info.zj6 = ds.Tables[0].Rows[0]["Num6"].ToString().Replace(",", "");
                info.jo1 = ds.Tables[0].Rows[0]["Money1"].ToString().Replace(",", "");
                info.jo2 = ds.Tables[0].Rows[0]["Money2"].ToString().Replace(",", "");
                info.tzmoney = ds.Tables[0].Rows[0]["CCMoney"].ToString().Replace(",", "");
                info.nextmoney = ds.Tables[0].Rows[0]["TotalMoney"].ToString().Replace(",", "");
                info.cc = "";
                info.date = TypeConverter.ObjectToDateTime(ds.Tables[0].Rows[0]["ResultTime"]);

                int i;
                i = KjhSsq.CreateKjhSsqInfo(info);
                if (i > 0)
                {
                    JsRedirect("lottery_ssq.aspx");
                }
                else if (i < 0)
                    AlertMessage("数据已经存在，请勿重复添加....");
                else
                    AlertMessage("保存失败，请重试....");
            }
        }
    }
}