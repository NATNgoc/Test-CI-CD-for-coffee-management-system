using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAL.IDAL
{
    public interface  IBillDAL
    {
        int getUncheckBillByTable(int id);
        bool thucHienCheckOut(int maBan);
        bool themBill(int maBan);
        bool ChuyenBan(int maBill, int maBanNew);
        DataTable HienThiDoanhThu(int page, DateTime dateStart, DateTime dateEnd);
        int hienThiTongDanhThu(DateTime dateStart, DateTime dateEnd);
        bool capNhatDiscount(int maBill, decimal discount);
        int getSizeOfBill(DateTime dateStart, DateTime dateEnd);
        int getDiscount(int maBill);
        bool huyBill(int maBill);
        bool xoaBill_Infor(int maBill);
        DataTable HienThiDoanhThuForReport(DateTime dateStart, DateTime dateEnd);
    }
}
