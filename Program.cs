using ADO_APP.DB_Data;
using System.Data.SqlClient;
using System.Data;

public class Customer
{
    public static void Main1(String[] args)
    {
        //string myConnection = "Data Source=MSI;Database=ADOTEST; Initial Catalog=sspi";

        Console.WriteLine("Enter Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Email : ");
        string email = Console.ReadLine();
        Console.WriteLine("Enter Mobile No. : ");
        string phoneno = Console.ReadLine();


        try
        {
            SqlConnection connection = new SqlConnection(ConnString.GetConnectionString());
            SqlCommand cmd = new SqlCommand("Sp_CreateCustomer", connection); // Stored Procedure Name 
            cmd.CommandType = System.Data.CommandType.StoredProcedure; // Command Type
            cmd.Parameters.AddWithValue("@customername", name);
            cmd.Parameters.Add(new SqlParameter("@customeremail", SqlDbType.VarChar, 50)).Value = email;
            cmd.Parameters.AddWithValue("@customermobile", phoneno);

            connection.Open();

            Console.WriteLine("Connection Successful");

            int affectedRowCount = cmd.ExecuteNonQuery(); // Execute the command and return the number of rows affected

            if(affectedRowCount > 0)
            {
                Console.WriteLine("Customer Created Successfully");
            }
            else
            {
                Console.WriteLine("Customer Creation Failed");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Connection Unsuccessful" + ex.Message);
        }

    }
}