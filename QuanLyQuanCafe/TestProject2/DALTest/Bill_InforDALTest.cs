using DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.DALTest
{
    public  class Bill_InforDALTest
    {
        [Test]
        [TestCase("69", "11", 1, true)] 
        [TestCase("69", "-1", 1, false)]

        public void themMonAnChoBill(int maBill, int maFood, int soLuong, bool expectedResult)
        {
            // call action
            bool actual = Bill_InforDAL.Instance.themMonAnChoBill(maBill, maFood, soLuong);

            //compare
            Assert.AreEqual(expectedResult, actual);
        }
        #region getBill_Infor 
        [Test]
        [TestCase(2,  1)]
        [TestCase(100, 0)]

        public void getBill_Infor(int maBill, int expectedResult)
        {
            // call action
            DataTable actual = Bill_InforDAL.Instance.getBill_Infor(maBill);

            //compare
            Assert.AreEqual(expectedResult, actual.Rows.Count);
        }
        #endregion
        #region capNhatSoLuong
        [Test]
        [TestCase("69", "11",-2 )]

        public void capNhapSoLuong(int maBill, int maMon, int soLuong)
        {
            bool expectedResult = true;
            // call action
            bool actual = Bill_InforDAL.Instance.capNhapSoLuong( maBill,  maMon,  soLuong);

            //compare
            Assert.AreEqual(expectedResult, actual);
        }
        #endregion
    }
}
