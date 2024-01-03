using DAL;
using GUI.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class BillBLL
    {
        private readonly IBillDAL _billDAL;


        public BillBLL(IBillDAL table)
        {
            _billDAL = table;
        }
        public bool thucHienCheckOut(int maBan)
        {
            return _billDAL.thucHienCheckOut(maBan);
        }
        public int getIdBillByIdTable (int idTable)
        {

            return _billDAL.getUncheckBillByTable(idTable);

        }
        public bool themBill(int maBan)
        {
            return _billDAL.themBill(maBan);
        }
       public bool ChuyenBan(int maBill,int  maBanNew )
        {
            return _billDAL.ChuyenBan(maBill,maBanNew);

        }
        public   DataTable HienThiDoanhThu(int page, DateTime dateStart, DateTime dateEnd)
        {
            return _billDAL.HienThiDoanhThu(page, dateStart,dateEnd);

        }
        public bool capNhatDiscount(int maBill, decimal discount)
        {
            return _billDAL.capNhatDiscount(maBill,discount);
        }
        public int getDiscount(int maBill)
        {
            return _billDAL.getDiscount(maBill);
        }
        public bool huyBill(int maBill)
        {
            return _billDAL.huyBill(maBill);
        }
        public  int getSizeOfBill(DateTime dateStart, DateTime dateEnd)
        {
            return _billDAL.getSizeOfBill(dateStart, dateEnd);
        }
        public  int hienThiTongDanhThu(DateTime dateStart, DateTime dateEnd)
        {
            return _billDAL.hienThiTongDanhThu(dateStart, dateEnd);
        }
        public   DataTable HienThiDoanhThuForReport(DateTime dateStart, DateTime dateEnd)
        {
            return _billDAL.HienThiDoanhThuForReport(dateStart, dateEnd);
        }
    }
}
