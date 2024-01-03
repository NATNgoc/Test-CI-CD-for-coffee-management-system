using DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.DALTest
{
    public  class BillDALTest
    {
        #region ThemBill
        [Test]
        [TestCase(1, true)]
        public void testThemBill(int maBan, bool expected)
        {
            // setup method

            // call action
            bool actual = BillDAL.Instance.themBill(maBan);

            //compare
            Assert.AreEqual(expected, actual);
        }
        #endregion
        #region ThucHienCheckOut
        [Test]
        [TestCase(1, true)]
        public void testThucHienCheckOut(int maBan, bool expected)
        {

            // call action
            bool actual = BillDAL.Instance.thucHienCheckOut(maBan);

            //compare
            Assert.AreEqual(expected, actual);
        }
        #endregion
        #region HuyBill
        [Test]
        public void TestHuyBill_ReturnsFalse_WhenXoaBill_InforReturnsFalse()
        {
            // setup method
            int maBill = BillDAL.Instance.getUncheckBillByTable(1);

            // call action
            bool actual = BillDAL.Instance.huyBill(maBill);

            // compare 
            Assert.IsTrue(actual);
        }
        #endregion
        #region GetUncheckBillByTable
        [Test]
        [TestCase(68, 245)]
        public void testGetUncheckBillByTable(int id, int expected)
        {
            // call action
            int actual = BillDAL.Instance.getUncheckBillByTable(id);

            //compare
            Assert.AreEqual(expected, actual);
        }
        #endregion
        #region ChuyenBan
        [Test]
        [TestCase(1, 2, true)]
        public void testChuyenBan(int maBill, int maBanNew, bool expected)
        {
            // setup method

            // call action
            bool actual = BillDAL.Instance.ChuyenBan(maBill, maBanNew);

            //compare
            Assert.AreEqual(expected, actual);
        }
        #endregion
        #region HienThiDoanhThu
        [Test]
        public void testHienThiDoanhThu()
        {
            // setup method
            string dateString = "2023-11-11";
            DateTime startDate = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime endDate = startDate;
            // call action
            DataTable actual = BillDAL.Instance.HienThiDoanhThu(1, startDate, endDate);

            //compare
            Assert.AreEqual(7, actual.Rows.Count);
        }
        #endregion
        #region HienThiDoanhThuForReport
        [Test]
        public void TestHienThiDoanhThuForReport_ReturnsDataTable_WhenExecuteSalesReportReturnsDataTable()
        {
            // setup method
            string dateString = "2023-11-11";
            DateTime startDate = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime endDate = startDate;

            // call action
            DataTable actual = BillDAL.Instance.HienThiDoanhThuForReport(startDate, endDate);

            // compare
            Assert.AreEqual(7, actual.Rows.Count);
        }
        #endregion
        #region CapNhatDiscount
        [Test]
        [TestCase(2, 50, true)]
        public void TestCapNhatDiscount(int maBill, decimal discount, bool expected)
        {


            // call action
            bool actual = BillDAL.Instance.capNhatDiscount(maBill, discount);

            // compare
            Assert.AreEqual(expected, actual);
        }
        #endregion
        #region GetDiscount
        [Test]
        public void TestGetDiscount_ReturnsDiscount_WhenExecuteScalarReturnsDiscount()
        {
            // setup method
            int maBill = 2;
            int expectedDiscount = 50;

            // call action
            int actual = BillDAL.Instance.getDiscount(maBill);

            // compare
            Assert.AreEqual(expectedDiscount, actual);
        }
        #endregion
        #region GetSizeOfBill
        [Test]
        public void TestGetSizeOfBill_ReturnsCountOfBills_WhenExecuteScalarReturnsCount()
        {
            // setup method
            string dateString = "2023-11-11";
            DateTime startDate = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime endDate = startDate;
            int expectedCount = 7;

            // call action
            int actual = BillDAL.Instance.getSizeOfBill(startDate, endDate);

            // compare
            Assert.AreEqual(expectedCount, actual);
        }
        #endregion
        #region HienThiTongDanhThu
        [Test]
        public void testHienThiTongDanhThu()
        { // setup method
            string dateString = "2023-11-11";
            DateTime startDate = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime endDate = startDate;

            // call action
            int actual = BillDAL.Instance.hienThiTongDanhThu(startDate, endDate);

            //compare
            Assert.AreEqual(575500, actual);
        }
        #endregion

    }
}
