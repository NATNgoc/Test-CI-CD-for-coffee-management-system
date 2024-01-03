using DAL;
using DTO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.DALTest
{
    public class LoginDALTest
    {
        #region Login
        [Test]
        [TestCase("username1", "password1", true)]
        [TestCase("username2", "password2", false)]
        public void testLogin(string username, string password, bool expected)
        {
       
            // call action
            Account a = new Account();
            bool actual = LoginDAL.Instance.Login(username, password, ref a);

            //compare
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region KtCurPass
        [Test]
        [TestCase("username1", "password1", true)]
        [TestCase("username2", "password2", false)]
        public void testKtCurPass(string username, string password, bool expected)
        {
            // setup method

            

            // call action
            bool actual = LoginDAL.Instance.ktCurPass(username, password);

            //compare
            Assert.AreEqual(expected, actual);
        }
        #endregion
        #region HienThiDanhSachTaiKhoan
        [Test]
        public void testHienThiDanhSachTaiKhoan()
        {
          

            // call action
            DataTable actual = LoginDAL.Instance.hienThiDanhSachTaiKhoan();

            //compare
            Assert.AreEqual(1, actual.Rows.Count);
        }
        #endregion

        #region DanhSachUserName
        [Test]
        public void testDanhSachUserName()
        {
            // call action
            List<string> actual = LoginDAL.Instance.danhSachUserName();

            //compare
            Assert.AreEqual(1, actual.Count);
        }
        #endregion

        #region ThemRow
        [Test]
        public void testThemRow()
        {
            // setup method
            Account account = new Account() { UserName = "username1", DisplayName = "Người dùng 1", Password = "password1", TypeAccount = 1 };

            // call action
            bool actual = LoginDAL.Instance.themRow(account);

            //compare
            Assert.AreEqual(true, actual);
        }
        #endregion

        #region XoaRow
        [Test]
        public void testXoaRow()
        {
            // setup method

            // call action
            bool actual = LoginDAL.Instance.xoaRow(1);

            //compare
            Assert.AreEqual(true, actual);
        }
        #endregion

        #region TimUserNameByIDAccount
        [Test]
        public void testTimUserNameByIDAccount()
        {
            // setup method
         

            // call action
            string actual = LoginDAL.Instance.timUserNameByIDAccount(1);

            //compare
            Assert.AreEqual("username1", actual);
        }
        #endregion

        #region ChinhSuaRow
        [Test]
        public void testChinhSuaRow()
        {
            // setup method
            Account account = new Account() { ID = 1, UserName = "username1", DisplayName = "Người dùng 1", Password = "password1", TypeAccount = 1 };

            // call action
            bool actual = LoginDAL.Instance.chinhSuaRow(account);

            //compare
            Assert.AreEqual(true, actual);
        }
        #endregion

        #region TimKiemTaiKhoan
        [Test]
        public void testTimKiemTaiKhoan()
        {
          

            // call action
            DataTable actual = LoginDAL.Instance.timKiemTaiKhoan("Người dùng 1");

            //compare
            Assert.AreEqual(1, actual.Rows.Count);
        }
        #endregion

        #region DoiPassword
        [Test]
        public void testDoiPassword()
        {
      

            // call action
            bool actual = LoginDAL.Instance.DoiPassword("username1", "password1");

            //compare
            Assert.AreEqual(true, actual);
        }
        #endregion
    }
}
