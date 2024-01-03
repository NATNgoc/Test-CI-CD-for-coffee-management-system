using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Xml.Linq;
using GUI.DAL.IDAL;

namespace BLL
{
    public class AccountBLL
    {

        private readonly ILoginDAL _loginDAL;


        public AccountBLL(ILoginDAL table)
        {
            _loginDAL = table;
        }
        public  bool xuLyLogin(string username, string password)
        {
            if (username == "Nhập tên đăng nhập..." || password == "Nhập mật khẩu...") return false;
                   
            if (username.Trim().Length==0 || password.Trim().Length ==  0) return false;
            return true;
        }
        public bool Login (string username,  string password, ref Account a) { 
        
                return _loginDAL.Login(username, password,ref a);
        }
        public DataTable hienThiDanhSachTaiKhoan()
        {
            DataTable kq = new DataTable();
            kq.Columns.Add("Mã tài khoản", typeof(Int32));
            kq.Columns.Add("Tên hiển thị", typeof(string));
            kq.Columns.Add("Username", typeof(string));
            kq.Columns.Add("Loại tài khoản", typeof(string));
            


            DataTable dt = _loginDAL.hienThiDanhSachTaiKhoan();
            for (int i = 0;i< dt.Rows.Count;i++)
            {
              DataRow dr = dt.Rows[i];
                DataRow k = kq.NewRow();
                k["Mã tài khoản"] = dr[0];
                k["Tên hiển thị"] = dr[1];
                k["Username"] = dr[2];
                if ((int)dr["Loại tài khoản"]==1 )
                {
                 
                    k["Loại tài khoản"] = "Admin";


                }    
                else
                {
                    k["Loại tài khoản"] = "Staff";
                }    
                kq.Rows.Add(k);

            }
            return kq;



        }
        public bool xuLyThemAccount(string username,string displayName,  ref string er)
        {
            if (displayName == "")
            {
                er = "Chưa nhập tên hiển thị";
                return false;
            }


            if (username == "")
            {
                er = "Chưa nhập username";
                return false;
            }
            List<string> t = danhSachUserName();

            foreach (string v in t)
            {
                if (username == v)
                {
                    er = "Username đã tồn tại trong hệ thống";
                    return false;
                }

            }
            



            return true;
        }

        public   List<string> danhSachUserName()
        {
            return _loginDAL.danhSachUserName();


        }
        public  bool themRow(Account d)
        {
            return _loginDAL.themRow(d);
        }
       public   bool  xoaRow(int ma)
        {

            return _loginDAL.xoaRow(ma);

        }
       public bool xuLyChinhSuaAccount(int id,string  username,string  displayname, ref string  er)
        {

            if (username == "")
            {
                er = "Chưa nhập username";
                return false;
            }
            List<string> t = danhSachUserName();

            

                foreach (string v in t)
                {
                    if (username == v)
                    {
                        er = "Tên username đã tồn tại trong danh sách";
                        return false;
                    }

                }
            
            if (displayname == "")
            {
                er = "Chưa nhập tên hiển thị";
                return false;
            }
            return true;
        }
       public  bool  chinhSuaRow(Account d)
        {
            return _loginDAL.chinhSuaRow(d);

        }
       public  DataTable TimKiemTaiKhoan(string name)
        {

           return  _loginDAL.timKiemTaiKhoan(name);

        }
        public  bool ktCurPass(string username, string password)
        {
           return  _loginDAL.ktCurPass(username, password);
        }
        public  bool DoiPassword( string username, string password)
        {

            return _loginDAL.DoiPassword(username, password);


        }
    }
}
