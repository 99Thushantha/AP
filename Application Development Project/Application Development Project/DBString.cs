using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Application_Development_Project
{
    
    class DBString
    {
        //private string connection = "Data Source=DESKTOP-AA823FE\\SQLEXPRESS;Initial Catalog=Connection;Integrated Security=True";
        private string connection = "Data Source=DESKTOP-STV3MKF\\SQLEXPRESS;" + "Initial Catalog=Connection;Integrated Security=True;" + "MultipleActiveResultSets=True";

        public string GetConnection()
        {
            return connection;
        }
    }
}
