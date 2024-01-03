using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAL.IDAL
{
    public interface  ICategoryDAL
    {
        DataTable hienThiDanhSachFoodCategory();
        List<string> danhSachCategory();
        bool themRow(string name);
        string timNameCateGory_FoodByID(int id);
        bool chinhSuaRow(CategoryDTO a);
        DataTable TimKiemLoaiMonAn(string n);
        bool xoaLoaiMonAn(int id);
    }
}
