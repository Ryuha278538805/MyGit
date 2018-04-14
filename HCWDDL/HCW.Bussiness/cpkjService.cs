using HCW.Common;
using HCW.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace HCW.Bussiness
{
    public class cpkjService
    {
        private DBHelper dbHelper = new DBHelper(DBHelper.CONN_KJ);

        /// <summary>
        /// 获取3D开奖信息
        /// </summary>
        /// <returns></returns>
        public tbl_3dInfo M_Get3D()
        {
            return dbHelper.GetEntity<tbl_3dInfo>("SELECT TOP 1 * FROM  dbo.tbl_3d ORDER BY qi DESC");
        }

        /// <summary>
        /// 获取首页菜单列表
        /// </summary>
        /// <returns></returns>
        public tbl_ssqInfo M_GetSSQ()
        {
            return dbHelper.GetEntity<tbl_ssqInfo>("SELECT TOP 1 * FROM  dbo.tbl_ssq ORDER BY qi DESC");
        }
    }
}
