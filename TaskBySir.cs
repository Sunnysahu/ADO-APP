using ADO_APP.DB_Data;
using System;
using System.Data.SqlClient;

namespace ADO_APP
{
    public class TaskBySir
    {
        public static void Main(string[] args)
        {
            var details = ConnString.GetDetails();
            if (details.NameArray.Length < 1)
            {
                throw new Exception("Please enter a valid name");
            }
            else if (!details.Email.Contains("@"))
            {
                throw new Exception("Please Enter a valid email");
            }
            else if (details.Phone.Length != 10 || !long.TryParse(details.Phone, out _))
            {
                throw new Exception("Please enter a valid phone number");
            }


            for (int i = 0; i < details.NameArray.Length; i++)
            {
                Console.WriteLine("details : " + details.NameArray[i]);
            }
            Console.WriteLine(details.Email);
            Console.WriteLine(details.Phone);


            try
            {
                SqlConnection connection = new SqlConnection(ConnString.GetConnectionStringPersonExecuteScalar());
                SqlCommand command = new SqlCommand("sp_insertdata", connection);
                Console.WriteLine(connection.ConnectionString);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@firstname", details.NameArray[0]);
                //command.Parameters.AddWithValue("@lastname", details.NameArray[1] ? details.NameArray[1] : "Alias");
                command.Parameters.AddWithValue("@lastname", details.NameArray.Length > 1 ? details.NameArray[1] : "Alias");
                command.Parameters.AddWithValue("@email", details.Email);
                command.Parameters.AddWithValue("@mobilenumber", Convert.ToDecimal(details.Phone));
                command.Parameters.AddWithValue("@createddate", DateTime.Now);
                connection.Open();

                int affectedRowCount = command.ExecuteNonQuery();

                if (affectedRowCount > 0)
                {
                    Console.WriteLine("Created Successfully");
                }
                else
                {
                    Console.WriteLine("Customer Creation Failed");
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection Unsuccessful :: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Ho gaya Bhai Done ✅");
            }
            Console.WriteLine("hello");
        }
    }
}
