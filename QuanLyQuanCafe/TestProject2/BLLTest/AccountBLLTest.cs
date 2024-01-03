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
    public class AccountBLLTest
    {
        private Mock<ILoginDAL> _mockLoginDAL;
        private AccountBLL _accountBLL;

        [SetUp]
        public void Init()
        {
            _mockLoginDAL = new Mock<ILoginDAL>();
            _accountBLL = new AccountBLL(_mockLoginDAL.Object);
          
        }

        [Test]
        [TestCase("", "", false)]
        [TestCase("h", "", false)]
        [TestCase("", "k", false)]
        [TestCase("trinhxinhdep", "123456", true)]
        [TestCase("Nhập tên đăng nhập...", "123456", false)]
        [TestCase("trinhxinhdep", "Nhập mật khẩu...", false)]

        public void AccountBLL_xuLyLogin(string username, string password, bool expected)
        {
            // set up method
            // call action
            bool actual = _accountBLL.xuLyLogin(username, password);
            // compare
            Assert.AreEqual(expected, actual);

        }


        [Test]
        [TestCase("trinhxinhdep", "123456", true)]

        public void AccountBLL_Login(string username, string password, bool expected)
        {
            // set up method
            Account a = new Account();
            _mockLoginDAL.Setup(m => m.Login(username, password, ref a)).Returns(true);

            // call action
            bool actual = _accountBLL.Login(username, password, ref a);
            // compare
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void AccountBLL_hienThiDanhSachTaiKhoan()
        {
            // set up method
            DataTable expectedTable = new DataTable();
            expectedTable.Columns.Add("id", typeof(Int32));
            expectedTable.Columns.Add("displayName", typeof(string));
            expectedTable.Columns.Add("userName", typeof(string));
            expectedTable.Columns.Add("Loại tài khoản", typeof(int));

            // Thêm dữ liệu vào DataTable
            DataRow row1 = expectedTable.NewRow();
            row1["id"] = 1;
            row1["displayName"] = "Trinh";
            row1["userName"] = "Trinh";
            row1["Loại tài khoản"] = 1;
            expectedTable.Rows.Add(row1);

            DataRow row2 = expectedTable.NewRow();
            row2["id"] = 2;
            row2["displayName"] = "Trinh";
            row2["userName"] = "Trinh";
            row2["Loại tài khoản"] = 2;

            expectedTable.Rows.Add(row2);
            _mockLoginDAL.Setup(m => m.hienThiDanhSachTaiKhoan()).Returns(expectedTable);
            // call action
            DataTable actualTable = _accountBLL.hienThiDanhSachTaiKhoan();
            // compare
            Assert.AreEqual(2, actualTable.Rows.Count);

        }
        [Test]
        [TestCase("", "", false)]
        [TestCase("hu", "", false)]
        [TestCase("", "hu", false)]
        [TestCase("hu", "hu", true)]
        [TestCase("thuytrinh", "Trinh Nguyen", false)]

        public void AccountBLL_xuLyThemAccount(string username, string displayName, bool expectedResult)
        {
            // set up method
            List<string> _listTable = new List<string>()
            {
                "thuytrinh",
                "thuytrinhkute"
            };
            _mockLoginDAL.Setup(m => m.danhSachUserName()).Returns(_listTable);
            // call action
            string er = "";
            bool actualResult = _accountBLL.xuLyThemAccount(username, displayName, ref er);
            // compare
            Assert.AreEqual(expectedResult, actualResult);


        }
        [Test]
        public void AccountBLL_themRow()
        {
            // set up method
            Account account = new Account();
            _mockLoginDAL.Setup(m => m.themRow(account)).Returns(true);
            // call action
            bool actual = _accountBLL.themRow(account);
            // compare
            Assert.AreEqual(true, actual);


        }
        [Test]
        public void AccountBLL_xoaRow()
        {
            // set up method
            Account account = new Account();
            _mockLoginDAL.Setup(m => m.xoaRow(1)).Returns(true);
            // call action
            bool actual = _accountBLL.xoaRow(1);
            // compare
            Assert.AreEqual(true, actual);


        }
        [Test]
        [TestCase(1, "", "", false)]
        [TestCase(1, "hu", "", false)]
        [TestCase(1, "", "hu", false)]
        [TestCase(1, "hu", "hu", true)]
        [TestCase(1, "thuytrinh", "Trinh Nguyen", false)]
        public void AccountBLL_xuLyChinhSuaAccount(int id, string username, string displayName, bool expected)
        {
            // set up method
            List<string> _listTable = new List<string>()
            {
                "thuytrinh",
                "thuytrinhkute"
            };
            _mockLoginDAL.Setup(m => m.danhSachUserName()).Returns(_listTable);
            // call action
            string er = "";
            bool actualResult = _accountBLL.xuLyChinhSuaAccount(id, username, displayName, ref er);
            // compare
            Assert.AreEqual(expected, actualResult);

        }
        [Test]
        public void AccountBLL_chinhSuaRow()
        {
            // set up method
            Account a = new Account();
            _mockLoginDAL.Setup(m => m.chinhSuaRow(a)).Returns(true);
            // call action

            bool actual = _accountBLL.chinhSuaRow(a);
            // compare
            Assert.AreEqual(true, actual);

        }
        [Test]
        public void AccountBLL_TimKiemTaiKhoan()
        {

            // set up method
            DataTable expectedTable = new DataTable();
            _mockLoginDAL.Setup(m => m.timKiemTaiKhoan("trinh")).Returns(expectedTable);
            // call action

            DataTable actualTable = _accountBLL.TimKiemTaiKhoan("trinh");
            // compare
            Assert.AreEqual(expectedTable, actualTable);

        }
        [Test]
        public void AccountBLL_ktCurPass()
        {
            // set up method
            DataTable expectedTable = new DataTable();
            _mockLoginDAL.Setup(m => m.ktCurPass("trinh", "123")).Returns(true);
            // call action

            bool actual = _accountBLL.ktCurPass("trinh", "123");
            // compare
            Assert.AreEqual(actual, true);
        }
        [Test]
        public void AccountBLL_DoiPassword()
        {
            // set up method
            DataTable expectedTable = new DataTable();
            _mockLoginDAL.Setup(m => m.DoiPassword("trinh", "123")).Returns(true);
            // call action

            bool actual = _accountBLL.DoiPassword("trinh", "123");
            // compare
            Assert.AreEqual(actual, true);
        }
    } 
    }
