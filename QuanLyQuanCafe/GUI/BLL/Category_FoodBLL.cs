using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;
using System.Diagnostics;
using DTO;
using GUI.DAL.IDAL;

namespace BLL
{
    public  class Category_FoodBLL
    {
        private readonly ICategoryDAL _categoryDAL;


        public Category_FoodBLL(ICategoryDAL table)
        {
            _categoryDAL = table;
        }
        public DataTable hienThiDanhSachFoodCategory()
        {
            return _categoryDAL.hienThiDanhSachFoodCategory();
        }
        public  bool xuLyThemCategoryFood(string name, ref string er)
        {
            if (name == "")
            {
                er = "Chưa nhập tên danh mục";
                return false;
            }
            List<string> t = danhSachTenDanhMuc();

            foreach (string v in t)
            {
                if (name == v)
                {
                    er = "Tên danh mục đã tồn tại trong danh sách";
                    return false;
                }

            }
            return true;

        }

        public List<string> danhSachTenDanhMuc()
        {

            return _categoryDAL.danhSachCategory();


        }
        public bool themRow(string name)
        {
            return _categoryDAL.themRow(name);
        }
        public bool xuLyChinhSuaCategoryFood(int id ,string name,  ref string er)
        {
            if (name == "")
            {
                er = "Chưa nhập tên loại món ăn";
                return false;
            }
            List<string> t = danhSachTenDanhMuc();
            // tìm name by idGia 
           
                foreach (string v in t)
                {
                    string name1 = v.Trim();
                    if (name == name1)
                    {
                        er = "Tên loại món ăn đã tồn tại trong danh sách";
                        return false;
                    }


                }
            
          
            return true;
        }


        public bool chinhSuaRow(CategoryDTO a)
        {
            return _categoryDAL.chinhSuaRow(a);
        }
        public DataTable TimKiemLoaiMonAn(string n)
        {
            return _categoryDAL.TimKiemLoaiMonAn(n);


        }
        public  bool xoaLoaiMonAn(int id)
        {
            return _categoryDAL.xoaLoaiMonAn(id);
        }
    }
}
