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
    public  class CategoryDALTest
    {
        
        #region themRow
        [Test]
        [TestCase("Kem F", true)] // thay A,B,C 
        [TestCase("Sinh tố", false)]
        public void testThemRow(string name, bool expected)
        {
             // call action
            bool actual = CategoryDAL.Instance.themRow(name);
            //compare
            Assert.AreEqual(expected, actual);

        }
        #endregion

        #region hienThiDanhSachFoodCategory
        [Test]
        public void testHienThiDanhSachFoodCategory()
        {
            int expectedResult = 15; // tăng
            // call action
            DataTable actual = CategoryDAL.Instance.hienThiDanhSachFoodCategory();
            //compare
            Assert.AreEqual(expectedResult, actual.Rows.Count);
        }
        #endregion

        #region danhSachCategory
        [Test]
        public void testdanhSachCategory()
        {
            int expectedResult = 15; // tăng
            // call action
            List<string> listTable = CategoryDAL.Instance.danhSachCategory();
            //compare
            Assert.AreEqual(expectedResult, listTable.Count);
        }
        #endregion

        // ko ảnh hưởng
        #region chinhSuaRow
        [Test]
        [TestCase(53, "Kem 1", true)] // thay 1,2,3
        [TestCase(53, "Sinh tố", false)]

        public void testchinhSuaRow(int id, string name, bool expected)
        {

            // setup method
            CategoryDTO categoryDTO = new CategoryDTO() { Id = id, Name = name };

            // call action
            bool actual = CategoryDAL.Instance.chinhSuaRow(categoryDTO);
            //compare
            Assert.AreEqual(expected, actual);

        }
        #endregion
        #region xoaLoaiMonAn
        [Test]
        [TestCase(18, false)]
        [TestCase(34, true)]

        public void testxoaLoaiMonAn(int ma, bool expected)
        {
            // setup method
            // call action 
            bool actual = CategoryDAL.Instance.xoaLoaiMonAn(ma);
            // compare
            Assert.AreEqual(expected, actual);

        }
        #endregion
     
        #region TimNameCateGory_FoodByID
        [Test]
        [TestCase(18, "Sinh tố")]


        public void testTimNameCateGory_FoodByID(int id, string expected)
        {

            // call action
            string actual = CategoryDAL.Instance.timNameCateGory_FoodByID(id);

            //compare
            Assert.AreEqual(expected, actual);
        }
        #endregion
        #region TimKiemLoaiMonAn
        [Test]
        [TestCase("Trà sữa")]
        public void testTimKiemLoaiMonAn(string name)
        {

            // setup method

            // call action
            DataTable actual = CategoryDAL.Instance.TimKiemLoaiMonAn(name);
            //compare
            Assert.AreEqual(1, actual.Rows.Count);
        }
        #endregion
    }
}
