using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_APP.DB_Data
{
    public static class ConnString
    {
        public static string GetConnectionStringforNonQuery()
        {
            //string myConnection = "Data Source=MSI;Database=ADOTEST; Initial Catalog=sspi";

            string myConnection = "Data Source=MSI;Initial Catalog=ADOTEST;Integrated Security=True;";


            return myConnection;

        }
        public static string GetConnectionStringForExecuteScalar()
        {
            string myConnection = "Data Source=MSI;Initial Catalog=company;Integrated Security=True;";

            return myConnection;

        }
    }
}
