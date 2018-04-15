﻿//Generated by CodeGen
//Generated Time: 2018-04-15 18:04:37
using System;
using System.Collections.Generic;
using System.Text;

namespace HCW.Model
{
    [Serializable]
    public class tbl_qlcInfo : CPKJModel
    {
        public bool IsidPassed = false;
        public bool IsqiPassed = false;
        public bool IsaPassed = false;
        public bool IsbPassed = false;
        public bool IscPassed = false;
        public bool IsdPassed = false;
        public bool IsePassed = false;
        public bool IsfPassed = false;
        public bool IsgPassed = false;
        public bool IshPassed = false;
        public bool IszjtPassed = false;
        public bool IsjotPassed = false;
        public bool Iszj1Passed = false;
        public bool Isjo1Passed = false;
        public bool Iszj2Passed = false;
        public bool Isjo2Passed = false;
        public bool Iszj3Passed = false;
        public bool Iszj4Passed = false;
        public bool Iszj5Passed = false;
        public bool Iszj6Passed = false;
        public bool Iszj7Passed = false;
        public bool IsdatePassed = false;
        public bool IsaddtimePassed = false;
        public bool IsnextmoneyPassed = false;
        public bool IstzmoneyPassed = false;
        public bool IshzPassed = false;
        public bool Isjo3Passed = false;

        private int mid;
        private int? mqi;
        private int? ma;
        private int? mb;
        private int? mc;
        private int? md;
        private int? me;
        private int? mf;
        private int? mg;
        private int? mh;
        private string mzjt = "";
        private string mjot = "";
        private string mzj1 = "";
        private string mjo1 = "";
        private string mzj2 = "";
        private string mjo2 = "";
        private string mzj3 = "";
        private string mzj4 = "";
        private string mzj5 = "";
        private string mzj6 = "";
        private string mzj7 = "";
        private DateTime? mdate;
        private DateTime? maddtime;
        private string mnextmoney = "";
        private string mtzmoney = "";
        private int? mhz;
        private string mjo3 = "";


        public tbl_qlcInfo() { }

        public tbl_qlcInfo(int mid, 
            int? mqi, 
            int? ma, 
            int? mb, 
            int? mc, 
            int? md, 
            int? me, 
            int? mf, 
            int? mg, 
            int? mh, 
            string mzjt, 
            string mjot, 
            string mzj1, 
            string mjo1, 
            string mzj2, 
            string mjo2, 
            string mzj3, 
            string mzj4, 
            string mzj5, 
            string mzj6, 
            string mzj7, 
            DateTime? mdate, 
            DateTime? maddtime, 
            string mnextmoney, 
            string mtzmoney, 
            int? mhz, 
            string mjo3)
        {
            this.mid = mid;
            this.mqi = mqi;
            this.ma = ma;
            this.mb = mb;
            this.mc = mc;
            this.md = md;
            this.me = me;
            this.mf = mf;
            this.mg = mg;
            this.mh = mh;
            this.mzjt = mzjt;
            this.mjot = mjot;
            this.mzj1 = mzj1;
            this.mjo1 = mjo1;
            this.mzj2 = mzj2;
            this.mjo2 = mjo2;
            this.mzj3 = mzj3;
            this.mzj4 = mzj4;
            this.mzj5 = mzj5;
            this.mzj6 = mzj6;
            this.mzj7 = mzj7;
            this.mdate = mdate;
            this.maddtime = maddtime;
            this.mnextmoney = mnextmoney;
            this.mtzmoney = mtzmoney;
            this.mhz = mhz;
            this.mjo3 = mjo3;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>不允许Null</remark>
        public int id
        {
            get { return mid; }
            set
            {
                mid = value;
                IsidPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>允许Null</remark>
        public int? qi
        {
            get { return mqi; }
            set
            {
                mqi = value;
                IsqiPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>允许Null</remark>
        public int? a
        {
            get { return ma; }
            set
            {
                ma = value;
                IsaPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>允许Null</remark>
        public int? b
        {
            get { return mb; }
            set
            {
                mb = value;
                IsbPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>允许Null</remark>
        public int? c
        {
            get { return mc; }
            set
            {
                mc = value;
                IscPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>允许Null</remark>
        public int? d
        {
            get { return md; }
            set
            {
                md = value;
                IsdPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>允许Null</remark>
        public int? e
        {
            get { return me; }
            set
            {
                me = value;
                IsePassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>允许Null</remark>
        public int? f
        {
            get { return mf; }
            set
            {
                mf = value;
                IsfPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>允许Null</remark>
        public int? g
        {
            get { return mg; }
            set
            {
                mg = value;
                IsgPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>允许Null</remark>
        public int? h
        {
            get { return mh; }
            set
            {
                mh = value;
                IshPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>nvarchar</returns>
        /// <remark>允许Null</remark>
        public string zjt
        {
            get { return mzjt; }
            set
            {
                mzjt = value;
                IszjtPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>nvarchar</returns>
        /// <remark>允许Null</remark>
        public string jot
        {
            get { return mjot; }
            set
            {
                mjot = value;
                IsjotPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>nvarchar</returns>
        /// <remark>允许Null</remark>
        public string zj1
        {
            get { return mzj1; }
            set
            {
                mzj1 = value;
                Iszj1Passed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>nvarchar</returns>
        /// <remark>允许Null</remark>
        public string jo1
        {
            get { return mjo1; }
            set
            {
                mjo1 = value;
                Isjo1Passed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>nvarchar</returns>
        /// <remark>允许Null</remark>
        public string zj2
        {
            get { return mzj2; }
            set
            {
                mzj2 = value;
                Iszj2Passed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>nvarchar</returns>
        /// <remark>允许Null</remark>
        public string jo2
        {
            get { return mjo2; }
            set
            {
                mjo2 = value;
                Isjo2Passed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>nvarchar</returns>
        /// <remark>允许Null</remark>
        public string zj3
        {
            get { return mzj3; }
            set
            {
                mzj3 = value;
                Iszj3Passed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>nvarchar</returns>
        /// <remark>允许Null</remark>
        public string zj4
        {
            get { return mzj4; }
            set
            {
                mzj4 = value;
                Iszj4Passed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>nvarchar</returns>
        /// <remark>允许Null</remark>
        public string zj5
        {
            get { return mzj5; }
            set
            {
                mzj5 = value;
                Iszj5Passed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>nvarchar</returns>
        /// <remark>允许Null</remark>
        public string zj6
        {
            get { return mzj6; }
            set
            {
                mzj6 = value;
                Iszj6Passed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>nvarchar</returns>
        /// <remark>允许Null</remark>
        public string zj7
        {
            get { return mzj7; }
            set
            {
                mzj7 = value;
                Iszj7Passed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>datetime</returns>
        /// <remark>允许Null</remark>
        public DateTime? date
        {
            get { return mdate; }
            set
            {
                mdate = value;
                IsdatePassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>datetime</returns>
        /// <remark>允许Null</remark>
        public DateTime? addtime
        {
            get { return maddtime; }
            set
            {
                maddtime = value;
                IsaddtimePassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>nvarchar</returns>
        /// <remark>允许Null</remark>
        public string nextmoney
        {
            get { return mnextmoney; }
            set
            {
                mnextmoney = value;
                IsnextmoneyPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>nvarchar</returns>
        /// <remark>允许Null</remark>
        public string tzmoney
        {
            get { return mtzmoney; }
            set
            {
                mtzmoney = value;
                IstzmoneyPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>允许Null</remark>
        public int? hz
        {
            get { return mhz; }
            set
            {
                mhz = value;
                IshzPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>nvarchar</returns>
        /// <remark>允许Null</remark>
        public string jo3
        {
            get { return mjo3; }
            set
            {
                mjo3 = value;
                Isjo3Passed = true;
            }
        }

        public tbl_qlcInfo Clonetbl_qlc()
        {
            return (tbl_qlcInfo)this.MemberwiseClone();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
