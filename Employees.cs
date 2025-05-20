
using ADO_APP.DB_Data;
using System.Data.SqlClient;

namespace ADO_APP
{
    public class Employees
    {
        public static void Main2(string[] args)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnString.GetConnectionStringForExecuteScalar());
                SqlCommand command = new SqlCommand("select empname from Employee", connection);

                connection.Open();
                Object obj = command.ExecuteScalar();


                connection.Close();
                string n = Convert.ToString(obj);
                string msg = "Emp Name : " + n;
                Console.WriteLine(msg);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Connection Unsuccessful" + ex.Message);
            }
        }
    }
}
