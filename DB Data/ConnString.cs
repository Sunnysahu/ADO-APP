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

        public static string GetConnectionStringPersonExecuteScalar()
        {
            string myConnection = "Data Source=MSI;Initial Catalog=person;Integrated Security=True;";
            //string myConnection = "Data Source=MSI;Database=person; Initial Catalog=sspi";

            return myConnection;
        }

        public static (string[] NameArray, string Email, string Phone) GetDetails()
        {
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            string[] nameArray = { };
            if (name != "")
            {
                Console.WriteLine("nice");
                //Console.WriteLine(nameArray.Length);
                nameArray = name.Split(" ");
            }

            Console.Write("Enter Email : ");
            string email = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter Mobile No. : ");
            Console.WriteLine();
            string phoneno = Console.ReadLine();
            Console.WriteLine();


            return (nameArray, email, phoneno);
        }

    }
}
