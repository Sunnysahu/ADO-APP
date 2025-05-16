1. Create an Connection String for establishing connection to the database
	> Create a Database in SQL and use the Server name and Database name to create a connection string

2. Setup it Here
	Here `MSI` is SQL server name and `ADOTEST`
	```
	   string myConnection = "Data Source=MSI;Database=ADOTEST; Initial Catalog=sspi";
       string myConnection = "Data Source=MSI;Initial Catalog=ADOTEST;Integrated Security=True;";
	```
3. Better is create a class and put the connection return there.
4. Create a SP in the MYSQL 
	```
	use ADOTEST

	create table tbl_customer (
	customerid int identity primary key,
	customername varchar(50) not null,
	customeremail varchar(50) unique,
	customermobile varchar(15) unique,
	)

	create procedure Sp_CreateCustomer (
	@customername varchar(50),
	@customeremail varchar(50),
	@customermobile varchar(15)
	)

	as 
	begin

	insert into tbl_customer values(@customername, @customeremail, @customermobile)
	end
	```



	

5. Take the user Input

	```
		Console.WriteLine("Enter Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Email : ");
        string email = Console.ReadLine();
        Console.WriteLine("Enter Mobile No. : ");
        string phoneno = Console.ReadLine();
	```

	## 🧾 SQL Command Setup with Explanation
	```
		// Create a new SqlCommand object to call the stored procedure "Sp_CreateCustomer"
		SqlCommand cmd = new SqlCommand("Sp_CreateCustomer", connection);

		// Specify that the command is a stored procedure
		cmd.CommandType = CommandType.StoredProcedure;

		// Add parameters to the command to pass data to the stored procedure

		// Adds the customer's name as a parameter
		cmd.Parameters.AddWithValue("@customername", name);

		// Adds the customer's email with explicit SQL data type and size
		cmd.Parameters.Add(new SqlParameter("@customeremail", SqlDbType.VarChar, 50)).Value = email;

		// Adds the customer's mobile number as a parameter
		cmd.Parameters.AddWithValue("@customermobile", phoneno);
	```