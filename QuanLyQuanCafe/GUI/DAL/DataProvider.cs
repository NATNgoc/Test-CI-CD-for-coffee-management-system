using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL 
{
    public  class DataProvider 
    {
        private DataProvider() { }
        private static DataProvider instance = null;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
            private set
            { DataProvider.instance = value; }
        }
        public DataTable excecuteQuerry(string q)
        {
            try
            {
                Sql_Connection.Instance.connect();
                Sql_Connection.Instance.openCon();

                SqlCommand sqlCommand = new SqlCommand(q, Sql_Connection.Instance.sqlCon);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(data);


                return data;
            }
            catch
            {
                throw new Exception();
            }

        }



    }
}
