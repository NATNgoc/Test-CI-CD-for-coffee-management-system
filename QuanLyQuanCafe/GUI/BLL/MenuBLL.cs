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
    public  class MenuBLL
    {
        private readonly IMenuDAL _menuDAL;


        public MenuBLL(IMenuDAL table)
        {
            _menuDAL = table;
        }
        public DataTable hienThiMenu(int idT, ref int idBill)
        {
            int idB=-1;

            DataTable dt = new DataTable();
            dt = _menuDAL.hienThiMenu(idT, ref idB);
            idBill = idB;
            return dt;

        }
        public DataTable hienThiMenuByIDBill(int idBill)
        {
      

            
            return _menuDAL.hienThiMenuByIDBill(idBill);
            

        }
    }
}
