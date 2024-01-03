using BLL;
using DAL;
using DTO;
using GUI.DAL.IDAL;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.BLLTest
{
    public  class FoodBLLTest
    {
        private Mock<IFoodDAL> _mockFoodDAL;
        private FoodBLL _foodBLL;

        [SetUp]
        public void Init()
        {
            _mockFoodDAL = new Mock<IFoodDAL>();

            _foodBLL = new FoodBLL(_mockFoodDAL.Object);
          
        }

        [Test]
        public void FoodBLL_getFoodByCateGory()
        {
            // setup method
            int ma = 1;
            List<FoodDTO> expectedFoodList = new List<FoodDTO>();
            _mockFoodDAL.Setup(m => m.getFoodByCateGory(ma)).Returns(expectedFoodList);
            // call action
            List<FoodDTO> actualFoodList = _foodBLL.getFoodByCateGory(ma);
            // compare
            Assert.AreEqual(expectedFoodList, actualFoodList);
        }

        [Test]
        public void FoodBLL_hienThiDanhSachFood()
        {
            // setup method
            DataTable expectedDataTable = new DataTable();
            _mockFoodDAL.Setup(m => m.hienThiDanhSachFood()).Returns(expectedDataTable);
            // call action
            DataTable actualDataTable = _foodBLL.hienThiDanhSachFood();
            // compare
            Assert.AreEqual(expectedDataTable, actualDataTable);
        }

        [Test]
        [TestCase("", "10450",false )]
        [TestCase("Sinh tố", "", false)]
        [TestCase("Nước ép", "-10", false)]
        [TestCase("Nước ép", "adjd", false)]
        [TestCase("Cà phê", "10500", false)]
        [TestCase("Cà phê sữa", "10500", true)]
        [TestCase("Nước ngọt", "10500", false)] // Tên món ăn đã tồn tại trong danh sách
        [TestCase("Cà phê", "0", true)] // Giá bằng 0
        public void FoodBLL_xuLyThemFood(string name, string price, bool expected)
        {
            // setup method
            List<string> _listTable = new List<string>()
            {
               "Nước ngọt","Cà phê"
            };
            _mockFoodDAL.Setup(m => m.danhSachFood()).Returns(_listTable);

            string er = "";
            // call action
            bool actual = _foodBLL.xuLyThemFood(name, price, ref er);
            // compare
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void FoodBLL_themRow()
        {
            // setup method
            FoodDTO foodDTO = new FoodDTO();
            _mockFoodDAL.Setup(m => m.themRow(foodDTO)).Returns(true);
            // call action
            // call action
            bool actual = _foodBLL.themRow(foodDTO);
            // compare
            Assert.IsTrue(actual);
        }

        [Test]
        [TestCase(1,"", "10450", false)]
        [TestCase(1, "Sinh tố", "", false)]
        [TestCase(1, "Nước ép", "-10", false)]
        [TestCase(1, "Nước ép", "adjd", false)]
        [TestCase(1, "Cà phê", "10500", false)]
        [TestCase(1, "Cà phê sữa", "10500", true)]
        public void FoodBLL_xuLyChinhSuaFood(int id, string name, string price, bool expected)
        {
            // setup method
            List<string> _listTable = new List<string>()
            {
               "Nước ngọt","Cà phê"
            };
            _mockFoodDAL.Setup(m => m.danhSachFood()).Returns(_listTable);

            string er = "";
            // call action
            bool actual = _foodBLL.xuLyChinhSuaFood(id, name, price, ref er);
            // compare
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void FoodBLL_chinhSuaRow()
        {
            // setup method
            FoodDTO foodDTO = new FoodDTO();
            _mockFoodDAL.Setup(m => m.chinhSuaRow(foodDTO)).Returns(true);
            // call action
            bool actual = _foodBLL.chinhSuaRow(foodDTO);
            // compare
            Assert.IsTrue(actual);
        }

        [Test]
        public void FoodBLL_TimKiemMonAn()
        {
            // setup method
            string n = "Search Query";
            DataTable expectedDataTable = new DataTable();
            _mockFoodDAL.Setup(m => m.TimKiemMonAn(n)).Returns(expectedDataTable);
            // call action
            DataTable actualDataTable = _foodBLL.TimKiemMonAn(n);
            // compare
            Assert.AreEqual(expectedDataTable, actualDataTable);
        }

        [Test]
        public void FoodBLL_xoaMonAn()
        {
            // setup method
            int id = 1;
            _mockFoodDAL.Setup(m => m.xoaMonAn(id)).Returns(true);
            // call action
            bool actual = _foodBLL.xoaMonAn(id);
            // compare
            Assert.IsTrue(actual);
        }
    }
}
