using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAL.IDAL
{
    public interface  ITableDAL
    {
        List<int> danhSachIDTable();
        List<string> danhSachBanAn();
        bool themRow(TableDTO a);
        bool xoaRow(int ma);
        bool chinhSuaRow(TableDTO a);
        DataTable timKiemTable(string n);
        string timNameTableByIDTable(int idTable);
        DataTable HienThiTable();
    }
}
