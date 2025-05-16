using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_APP.DB_Data
{
    public static class ConnString
    {
        public static string GetConnectionString()
        {
            //string myConnection = "Data Source=MSI;Database=ADOTEST; Initial Catalog=sspi";
            string myConnection = "Data Source=MSI;Initial Catalog=ADOTEST;Integrated Security=True;";

            return myConnection;

        }
    }
}
