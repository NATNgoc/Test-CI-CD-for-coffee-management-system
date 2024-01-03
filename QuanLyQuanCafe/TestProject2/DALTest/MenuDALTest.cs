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
    public class MenuDALTest
    {
        [Test]
        #region testDoiPassword 
        public void hienThiMenuByIDBill()
        {

            int expectedResult = 1;
            // call action
            DataTable actual = MenuDAL.Instance.hienThiMenuByIDBill(63);

            //compare
            Assert.AreEqual(1, actual.Rows.Count);
        }
        #endregion



    }
}
