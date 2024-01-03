using DAL;
using DTO;
using GUI.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
    public class FoodBLL
    {
        private readonly IFoodDAL _foodDAL;


        public FoodBLL(IFoodDAL table)
        {
            _foodDAL = table;
        }
        public List<FoodDTO> getFoodByCateGory(int ma)
        {
            return _foodDAL.getFoodByCateGory(ma);

        }
        public DataTable hienThiDanhSachFood()
        {
            return _foodDAL.hienThiDanhSachFood();
       }
       public bool  xuLyThemFood( string  name, string price , ref string  er)
        {
           
            if (name=="")
            {
                er = "Chưa nhập tên món ăn";
                return false;
            }
            if(price=="")
            {
                er = "Chưa nhập giá của món ăn";
                return false;
            }    
            List<string> t = danhSachFood();
            // tìm name by idGia 
            

                foreach (string v in t)
                {
                    string name1 = v.Trim();

                    if (name == name1)
                    {
                        er = "Tên món ăn đã tồn tại trong danh sách";
                        return false;
                    }


                }
            
            double p;
            if (!double.TryParse(price, out p ))
            {
                er = "Giá không đúng định dạng";
                return false;
            }    
            if (p < 0)
            {
                er = "Giá không được nhỏ hơn 0";
                return false;

            }
            return true;
        }
        public bool themRow(FoodDTO a)
        {
            return _foodDAL.themRow(a);


        }
        public bool xuLyChinhSuaFood(int id ,string name , string  price, ref string  er)
        {
            if (name == "")
            {
                er = "Chưa nhập tên món ăn";
                return false;
            }
            if (price=="")
            {
                er = "Chưa nhập giá của món ăn";
                return false;
            }    
            List<string> t = danhSachFood();
            // tìm name by idGia 


                foreach (string v in t)
                {
                    string name1 = v.Trim();

                    if (name == name1)
                    {
                        er = "Tên bàn ăn đã tồn tại trong danh sách";
                        return false;
                    }


                }
            
            double p;



            if (!double.TryParse(price , out p))
            {
                er = "Giá chưa đúng định dạng";
                return false;
            }    
            if (p<0)
            {
                er = "Giá không được nhỏ hơn 0";
                return false;
            }    

            return true;

        }
        public List<string> danhSachFood()
        {
            List<string> i = _foodDAL.danhSachFood();
            return i;


        }
        public bool chinhSuaRow(FoodDTO a)
        {
            return _foodDAL.chinhSuaRow(a);
       }
        public DataTable TimKiemMonAn(string n)
        {
            return _foodDAL.TimKiemMonAn(n);

        }
        public  bool xoaMonAn(int id)
        {
            return _foodDAL.xoaMonAn(id);
        }
    }
}
