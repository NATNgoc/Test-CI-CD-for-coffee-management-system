using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    [ExcludeFromCodeCoverage]
    public class DataBLL 
    {
        public void closeCon()
        {
            Sql_Connection.Instance.closeCon();
        }


    }
}
