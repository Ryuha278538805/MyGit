using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using Business;

namespace Admin.Ajax
{
    public partial class Config : Pages
    {
        //操作对象 1资讯分类，2专题，3彩种，4资讯, 5管理组，6管理员, 
        // 7社区商店商品,8商品分类 ,9商品销售记录,10新闻模板,11预测信息,12预测专题
        protected int Mode;        
        protected int Method;
        protected string id="";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (allow.AllowConfig)
            {
                Mode = BBRequest.GetFormInt("mo", 0);
                Method = BBRequest.GetFormInt("me", 0);
                id = BBRequest.GetFormString("id",false);
                id = id.Replace("on,", "").Replace(",0","");  //剔除无效数据
                if (Mode > 0 && Method > 0 && id!=null && id.Length > 0)
                {
                    Action();
                }
            }
        }

        private void Action()
        {
            string Result = "nook";
            string OK = "ok";
            switch (Mode)
            {
                case 1:
                    if (Method == 2)
                    {
                        NewsClass.DeleteNewsClassInfo(id);
                        Result = OK;
                    }
                    break;
                case 2:
                    if (Method == 2)
                    {
                        Zone.DeleteZoneInfo(id);
                        Result = OK;
                    }
                    break;
                case 3:
                    if (Method == 1)
                    {
                        Cz.UpdateCzQi(id);
                        Result = OK;
                    }
                    else if (Method == 2)
                    {
                        Cz.DeleteCzInfo(id);
                        Result = OK;
                    }
                    break;
                case 4:
                    if (Method == 2)
                    {
                        Business.News.DeleteNewsInfo(id);
                        Result = OK;
                    }
                    break;
                case 5:
                    if (Method == 2)
                    {
                        MasterGroup.DeleteMasterGroupInfo(id);
                        Result = OK;
                    }
                    break;
                case 6:
                    if (Method == 2)
                    {
                        MasterUser.DeleteMasterInfo(id);
                        Result = OK;
                    }
                    break;
                case 7:
                    if (Method == 2)
                    {
                        Goods.DeleteGoodsInfo(id);
                        Result = OK;
                    }
                    break;
                case 8:
                    if (Method == 2)
                    {
                        GoodsClass.DeleteGoodsClassInfo(id);
                        Result = OK;
                    }
                    break;
                case 9:
                    if (Method == 2)
                    {
                        GoodsSell.DeleteGoodsSellInfo(id);
                        Result = OK;
                    }
                    break;
                case 10:
                    if (Method == 2)
                    {
                        NewsTemplet.DeleteNewsTempletInfo(id);
                        Result = OK;
                    }
                    break;
                case 11:
                    if (Method == 1)
                    {                     
                        if (YcUtil.ReCreateYcInfo(id))
                           Result = OK;
                    }
                    else if (Method == 2)
                    {
                        Yc.DeleteYcInfo(id);
                        Result = OK;
                    }
                    break;
                case 12:
                    if (Method == 1)
                    {
                        YcUtil.CreateAndCheckYcInfo(id);
                        Result = OK;
                    }
                    else if (Method == 2)
                    {
                        YcZone.DeleteYcZoneInfo(id);
                        Result = OK;
                    }
                    break;
                default:
                    break;
            }
            Response.Write(Result);
        }
    }
}