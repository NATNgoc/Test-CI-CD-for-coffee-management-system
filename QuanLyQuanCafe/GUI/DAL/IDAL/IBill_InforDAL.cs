using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAL.IDAL
{
    public interface IBill_InforDAL
    {
        bool themMonAnChoBill(int maBill, int maFood, int soLuong);
        DataTable getBill_Infor(int maBill);
        bool capNhapSoLuong(int maBill, int maMon, int soLuong);
    }
}
