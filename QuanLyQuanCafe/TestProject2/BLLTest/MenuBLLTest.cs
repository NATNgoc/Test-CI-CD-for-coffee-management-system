using BLL;
using DAL;
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
    public class MenuBLLTest
    {
        private Mock<IMenuDAL> _mockMenuDAL;
        private MenuBLL _menuBLL;

        [SetUp]
        public void Init()
        {
            _mockMenuDAL = new Mock<IMenuDAL>();

            _menuBLL = new MenuBLL(_mockMenuDAL.Object);
         
        }
        // mock ref ?
        [Test]
        public void MenuBLL_hienThiMenu()
        {
            // setup method
            int idT = 1;
            int idBill = 0;
            DataTable expectedDataTable = new DataTable();
            _mockMenuDAL.Setup(m => m.hienThiMenu(It.IsAny<int>(), ref idBill)).Returns(expectedDataTable);
            // call action
            DataTable actualDataTable = _menuBLL.hienThiMenu(idT, ref idBill);
            // compare
            Assert.AreEqual(expectedDataTable, actualDataTable);
        }

        [Test]
        public void MenuBLL_hienThiMenuByIDBill()
        {
            // setup method
            int idBill = 1;
            DataTable expectedDataTable = new DataTable();
            _mockMenuDAL.Setup(m => m.hienThiMenuByIDBill(It.IsAny<int>())).Returns(expectedDataTable);
            // call action
            DataTable actualDataTable = _menuBLL.hienThiMenuByIDBill(idBill);
            // compare
            Assert.AreEqual(expectedDataTable, actualDataTable);
        }
    }
}
