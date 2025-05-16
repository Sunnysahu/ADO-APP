using System.Data.SqlClient;

public class Customer
{
    public static void Main(String[] args)
    {
        //string myConnection = "Data Source=MSI;Database=ADOTEST; Initial Catalog=sspi";
        string myConnection = "Data Source=MSIS;Initial Catalog=ADOTEST;Integrated Security=True;";


        try
        {
            SqlConnection connection = new SqlConnection(myConnection);

            connection.Open();

            Console.WriteLine("Connection Successful");


        }
        catch(Exception ex)
        {
            Console.WriteLine("Connection Unsuccessful" + ex.Message);
        }
        
    }
}