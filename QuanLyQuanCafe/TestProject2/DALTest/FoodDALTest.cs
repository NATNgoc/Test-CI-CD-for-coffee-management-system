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
    public class FoodDALTest
    {

     
        private static IEnumerable<TestCaseData> FoodDTOTestCases
        {
            get
            {
                yield return new TestCaseData(new FoodDTO() { TenMon = "Cà phê đen", Gia = 50000, Loai = 1 }, false);
                yield return new TestCaseData(new FoodDTO() { TenMon = "Bánh giò G", Gia = 50000, Loai = 17 }, true);

                // Thêm các trường hợp kiểm tra khác tại đây
            }
        }
        private static IEnumerable<TestCaseData> updateFoodDTOTestCases

        {
            get
            {
                yield return new TestCaseData(new FoodDTO() {  Id = 56, TenMon = "Bánh giò bao ngon", Gia = 50000, Loai = 18 }, true);

                // Thêm các trường hợp kiểm tra khác tại đây
            }
        }

        #region themRow
        [Test, TestCaseSource(nameof(FoodDTOTestCases))]
        public void testThemRow(FoodDTO foodDTO, bool expected)
        {

            // call action
            bool actual = FoodDAL.Instance.themRow(foodDTO);

            //compare
            Assert.AreEqual(expected, actual);
        }
        #endregion
        #region DanhSachFood    
        [Test]
        public void testDanhSachFood()
        {
            // setup method
            int expectedResult = FoodDAL.Instance.danhSachFood().Count;

            // call action
            List<string> actual = FoodDAL.Instance.danhSachFood();

            //compare
            Assert.AreEqual(expectedResult, actual.Count);
        }
        #endregion
        #region HienThiDanhSachFood
        [Test]
        public void testHienThiDanhSachFood()
        {
            int expectedResult = FoodDAL.Instance.danhSachFood().Count; ;
            // call action
            DataTable actual = FoodDAL.Instance.hienThiDanhSachFood();

            //compare
            Assert.AreEqual(expectedResult , actual.Rows.Count);
        }
        #endregion


        // ko ảnh hưởng
      
        #region testGetFoodByCategory
        [Test]
        [TestCase(18, 5)]
        public void testGetFoodByCategory(int idCategory, int expected)
        {
            // call action
            List<FoodDTO> actual = FoodDAL.Instance.getFoodByCateGory(idCategory);

            //compare
            Assert.AreEqual(expected, actual.Count);
        }
        #endregion
        #region ChinhSuaRow
        [Test, TestCaseSource(nameof(updateFoodDTOTestCases))]
        public void testChinhSuaRow(FoodDTO foodDTO, bool expected)
        {
            // call action
            bool actual = FoodDAL.Instance.chinhSuaRow(foodDTO);

            //compare
            Assert.AreEqual(expected, actual);
        }
        #endregion
        #region TimNameFoodByIDFood
        [Test]
        [TestCase(11)]
        public void testTimNameFoodByIDFood(int id)
        {
            string expectedResult = "Cà phê đen";
            // call action
            string actual = FoodDAL.Instance.timNameFoodByIDFood(id);

            //compare
            Assert.AreEqual(expectedResult, actual);
        }
        #endregion
        #region TimKiemMonAn
        [Test]
        [TestCase("Cà phê đen", 1)]
        public void testTimKiemMonAn(string name, int expected)
        {
            

            // call action
            DataTable actual = FoodDAL.Instance.TimKiemMonAn(name);

            //compare
            Assert.AreEqual(expected, actual.Rows.Count);
        }
        #endregion
        #region XoaMonAn
        [Test]
        [TestCase(11, false)]
        [TestCase(54, true)]

        public void testXoaMonAn(int id, bool expected)
        {

            // call action
            bool actual = FoodDAL.Instance.xoaMonAn(id);

            //compare
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
