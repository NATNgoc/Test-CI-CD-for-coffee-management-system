using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAL.IDAL
{
    public interface  IFoodDAL
    {
        List<FoodDTO> getFoodByCateGory(int ma);
        DataTable hienThiDanhSachFood();
        bool themRow(FoodDTO a);
        List<string> danhSachFood();
        bool chinhSuaRow(FoodDTO a);
        string timNameFoodByIDFood(int idFood);
        DataTable TimKiemMonAn(string n);
        bool xoaMonAn(int id);
    }
}
