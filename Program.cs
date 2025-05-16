using ADO_APP.DB_Data;
using System.Data.SqlClient;

public class Customer
{
    public static void Main(String[] args)
    {
        //string myConnection = "Data Source=MSI;Database=ADOTEST; Initial Catalog=sspi";
        


        try
        {
            SqlConnection connection = new SqlConnection(ConnString.GetConnectionString());

            connection.Open();

            Console.WriteLine("Connection Successful");


        }
        catch(Exception ex)
        {
            Console.WriteLine("Connection Unsuccessful" + ex.Message);
        }
        
    }
}