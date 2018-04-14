using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HCW.Common;
using System.Configuration;
using System.Data;
using HCW.Model;

namespace HCW.UnitTest
{
    [TestClass]
    public class CommonTest
    {
        [TestMethod]
        public void ExecuteScalar()
        {
            DBHelper dbHelper = new DBHelper(DBHelper.CONN_Main);
            var result = dbHelper.ExecuteScalar("SELECT TOP 1 title FROM dbo.tbl_news");
        }

        [TestMethod]
        public void ExecuteNonQuery()
        {
            DBHelper dbHelper = new DBHelper(DBHelper.CONN_Main);
            var result = dbHelper.ExecuteNonQuery("UPDATE dbo.tbl_news SET istop=1 WHERE nid=37");
        }

        [TestMethod]
        public void GetDataTable()
        {
            DBHelper dbHelper = new DBHelper(DBHelper.CONN_Main);
            DataTable result = dbHelper.GetDataTable("SELECT TOP 100 * FROM dbo.tbl_news");
        }

        [TestMethod]
        public void GetList()
        {
            DBHelper dbHelper = new DBHelper(DBHelper.CONN_Main);
            var result = dbHelper.GetList<tbl_news_Model>("SELECT TOP 100 * FROM dbo.tbl_news where 1=0");
        }

        [TestMethod]
        public void GetEntity()
        {
            DBHelper dbHelper = new DBHelper(DBHelper.CONN_Main);
            var result = dbHelper.GetEntity<tbl_news_Model>("SELECT TOP 100 * FROM dbo.tbl_news");
            result = dbHelper.GetEntity<tbl_news_Model>("SELECT TOP 1 * FROM dbo.tbl_news");
            result = dbHelper.GetEntity<tbl_news_Model>("SELECT TOP 1 * FROM dbo.tbl_news where 1=0");
        }
    }
}
