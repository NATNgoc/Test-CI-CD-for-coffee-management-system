using DTO;
using GUI.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public  class CategoryDAL :ICategoryDAL
    {
        public CategoryDAL() { }
        private static CategoryDAL instance = null;
        public static CategoryDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryDAL();
                }
                return instance;
            }
            private set
            { CategoryDAL.instance = value; }
        }
        public  DataTable hienThiDanhSachFoodCategory()
        {
            string s = "select id [Mã danh mục], name [Tên danh mục] from food_category";
            return DataProvider.Instance.excecuteQuerry(s);
        }
        public  List<string> danhSachCategory()
        {
            string q = "select * from food_category";
            DataTable ds = DataProvider.Instance.excecuteQuerry(q);

            List<string> l = new List<string>();



            foreach (DataRow dr in ds.Rows)
            {
                l.Add(dr["name"].ToString().Trim());
            }



            return l;

        }

       public  bool themRow(string name)
        {
            try
            {
                Sql_Connection.Instance.connect();


                Sql_Connection.Instance.openCon();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into food_category values ( @name)";

                SqlParameter parname = new SqlParameter("@name", SqlDbType.NVarChar);
                parname.Value = name;

                cmd.Parameters.Add(parname);



                cmd.Connection = Sql_Connection.Instance.sqlCon;


                if (cmd.ExecuteNonQuery() < 0)
                {


                    return false;
                }
                {


                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }


        }
       public string timNameCateGory_FoodByID(int id)
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.excecuteQuerry("select * from food_category where id = " + id);
            DataRow dataRow = dt.Rows[0];
            return dataRow["name"].ToString().Trim();


        }
        public  bool chinhSuaRow(CategoryDTO a)
        {
            try
            {
                Sql_Connection.Instance.connect();
                Sql_Connection.Instance.openCon();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE food_category " +
                  "SET name = @name " +
                  "WHERE id = @id";
                cmd.Connection = Sql_Connection.Instance.sqlCon;


                SqlParameter parid = new SqlParameter("@id", SqlDbType.Int);
                SqlParameter parname = new SqlParameter("@name", SqlDbType.NVarChar);

                parid.Value = a.Id;
                parname.Value = a.Name;

                cmd.Parameters.Add(parid);
                cmd.Parameters.Add(parname);




                if (cmd.ExecuteNonQuery() < 0)
                {


                    return false;
                }
                {
                    return true;
                }
            }
            catch { return false; }

        }
        public  DataTable TimKiemLoaiMonAn(string n)
        {
            DataTable dataTable = new DataTable();
            Sql_Connection.Instance.openCon();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TimKiemLoaiMonAn";

            SqlParameter p = new SqlParameter("@name", SqlDbType.NVarChar);
            p.Value = n;
            cmd.Parameters.Add(p);

            cmd.Connection = Sql_Connection.Instance.sqlCon;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);

            return dataTable;




        }
        public   bool xoaLoaiMonAn(int id)
        {
            try
            {
                Sql_Connection.Instance.openCon();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from food_category where id = " + id;
                cmd.Connection = Sql_Connection.Instance.sqlCon;
                if (cmd.ExecuteNonQuery() < 0)
                    return false;
                return true;


            }
            catch
            {
                return false;
            }




        }
    }
}
