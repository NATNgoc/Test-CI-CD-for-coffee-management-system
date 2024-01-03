using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAL.IDAL
{
    public interface  IMenuDAL
    {
        DataTable hienThiMenu(int idT, ref int idBill);
        DataTable hienThiMenuByIDBill(int maBill);


    }
}
