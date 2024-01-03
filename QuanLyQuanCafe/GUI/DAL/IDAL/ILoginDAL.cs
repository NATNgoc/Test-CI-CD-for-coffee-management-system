using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAL.IDAL
{
    public interface  ILoginDAL
    {
        string maHoaMatKhau(string password);
        bool Login(string username, string password, ref Account a);
        bool ktCurPass(string username, string password);
        DataTable hienThiDanhSachTaiKhoan();
        List<string> danhSachUserName();
        bool themRow(Account d);
        bool xoaRow(int ma);
        string timUserNameByIDAccount(int id);
        bool chinhSuaRow(Account d);
        DataTable timKiemTaiKhoan(string displayName);
        bool DoiPassword(string username, string password);
    }
}
