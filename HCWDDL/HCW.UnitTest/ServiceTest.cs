using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HCW.Bussiness;

namespace HCW.UnitTest
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void M_GetNav()
        {
            tbl_newsService s = new tbl_newsService();
            var aa = s.M_GetNav();
        }
    }
}
