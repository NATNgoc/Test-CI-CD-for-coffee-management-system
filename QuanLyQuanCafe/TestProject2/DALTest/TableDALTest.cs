using DAL;
using DTO;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.DALTest
{
    [TestFixture]
    public class TableDALTest
    {
        #region themRow
        [Test]
        [TestCase("Bàn 200", "Trống", false)]
        [TestCase("Bàn 105", "Trống", true)]
        public void testThemRow(string name, string status, bool expected)
        {

           //setup method
            TableDTO tableDTO = new TableDTO() { Name = name, Status = status };
           //call action
            bool actual = TableDAL.Instance.themRow(tableDTO);
           // compare
            Assert.AreEqual(expected, actual);

        }

        #endregion
        #region chinhSuaRow
        [Test]
        [TestCase(1, "Bàn 200", "Trống", false)]
        [TestCase(53, "Bàn 107", "Trống", true)]
        public void testchinhSuaRow(int id, string name, string status, bool expected)
        {

            //setup method
            TableDTO tableDTO = new TableDTO() { Name = name, Status = status };

            // call action
            bool actual = TableDAL.Instance.chinhSuaRow(tableDTO);
            // compare
            Assert.AreEqual(expected, actual);

        }
        #endregion
        #region danhsachbanan
        [Test]
        public void testDanhSachBanAn()
        {
            //setup method

            int expectedResult = 34;

          //  call action
            List<string> listTable = TableDAL.Instance.danhSachBanAn();
           // compare
            Assert.AreEqual(expectedResult, listTable.Count);
        }
        #endregion
        #region DanhSachIDTable
        [Test]
        public void testDanhSachIDTable()
        {
            //setup method
            int expectedResult = 34;
           // call action
            List<int> kq = TableDAL.Instance.danhSachIDTable();
           // compare
            Assert.AreEqual(expectedResult, kq.Count);
        }
        #endregion
        #region xoaRow
        [Test]
        [TestCase(73, true)]
        [TestCase(1, false)]

        public void testXoaRow(int ma, bool expected)
        {
           // setup method
            // call action
            bool actual = TableDAL.Instance.xoaRow(ma);
           // compare
            Assert.AreEqual(expected, actual);

        }
        #endregion
        #region timKiemTable
        [Test]
        [TestCase("Bàn")]
        public void testTimKiemTable(string n)
        {

            // setup method
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Mã bàn ăn", typeof(int));
            dataTable.Columns.Add("Tên bàn ăn", typeof(string));
            dataTable.Columns.Add("Trạng thái", typeof(string));

            // Thêm dữ liệu vào DataTable
            DataRow row1 = dataTable.NewRow();
            row1["Mã bàn ăn"] = 1;
            row1["Tên bàn ăn"] = "Bàn 200";
            row1["Trạng thái"] = "Trống";
            dataTable.Rows.Add(row1);
        

            // call action
            DataTable actual = TableDAL.Instance.timKiemTable("Bàn 200");
            //compare
            Assert.AreEqual(1, actual.Rows.Count);


        }
        #endregion
        #region timNameTableByIDTable
        [Test]
        [TestCase("1")]

        public void testimNameTableByIDTable(int idTable)
        {

            string expectedResult = "Bàn 200";
            // call action
            string actual = TableDAL.Instance.timNameTableByIDTable(idTable);
            //compare
            Assert.AreEqual(expectedResult, actual);


        }
        #endregion
        #region HienThiTable
        [Test]
        public void testHienThiTable()
        {
            // call action
            DataTable actual = TableDAL.Instance.HienThiTable();
            //compare
            Assert.AreEqual(34, actual.Rows.Count);

        }
        #endregion
    }

}
