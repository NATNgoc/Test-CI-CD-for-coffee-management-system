using DAL;
using GUI.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class Bill_InforBLL
    {
        private readonly IBill_InforDAL _billInforDAL;


        public Bill_InforBLL(IBill_InforDAL table)
        {
            _billInforDAL = table;
        }
        public bool  themMonAnChoBill(int maBill, int maFood, int soLuong)
        {
            return _billInforDAL.themMonAnChoBill(maBill, maFood, soLuong);
               


        }
        public DataTable getBill_Infor (int maBill)
        {
            return _billInforDAL.getBill_Infor(maBill);
          
        }
        public bool capNhapSoLuong(int maBill, int maMon, int soLuong)
        {
            return _billInforDAL.capNhapSoLuong(maBill, maMon, soLuong);
        }

    }
}
