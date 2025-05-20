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

- ExecuteScalar() --> Returns the Object <--> first column of the first row in the result set returned by the query. Extra columns or rows are ignored.

- ExecuteReader() --> Returns a SqlDataReader object that can be used to read the rows returned by the query.

- ExecuteNonQuery() --> Returns the number of rows affected by the query. This is used for INSERT, UPDATE, DELETE statements.

### Optionals
	- ExecuteXmlReader() --> Returns an XmlReader object that can be used to read XML data returned by the query.
	- ExecuteReaderAsync() --> Asynchronously executes the command and returns a SqlDataReader object.
	- ExecuteNonQueryAsync() --> Asynchronously executes the command and returns the number of rows affected.
	- ExecuteScalarAsync() --> Asynchronously executes the command and returns the first column of the first row in the result set.
	- ExecuteXmlReaderAsync() --> Asynchronously executes the command and returns an XmlReader object.
	- ExecuteReaderAsync() --> Asynchronously executes the command and returns a SqlDataReader object.
	- ExecuteNonQueryAsync() --> Asynchronously executes the command and returns the number of rows affected.
	- ExecuteScalarAsync() --> Asynchronously executes the command and returns the first column of the first row in the result set.
	- ExecuteXmlReaderAsync() --> Asynchronously executes the command and returns an XmlReader object.
	- ExecuteReaderAsync() --> Asynchronously executes the command and returns a SqlDataReader object.
	- ExecuteNonQueryAsync() --> Asynchronously executes the command and returns the number of rows affected.
	- ExecuteScalarAsync() --> Asynchronously executes the command and returns the first column of the first row in the result set.


## For ExecuteScalar Example
```

create database company
go
use company
go
create table Employee(
empid int primary key,
empname nvarchar(max),
salary decimal)
go
insert into Employee values(1, 'Sunny', 150000)
insert into Employee values(2, 'Sanjana', 50000)
insert into Employee values(3, 'Sanu', 10000)
go

select * from Employee

select * from Employee where empid=1
```


# Task by Sir

- MYSQL SERVER CODE
```
create database person

use person

create table persontable(
firstname nvarchar(20) not null,
lastname nvarchar(30) null,
email nvarchar(100) not null primary key,
mobilenumber decimal unique,
createddate Date
)

create procedure sp_insertdata (@firstname nvarchar(20), @lastname nvarchar(30), @email nvarchar(100), @mobilenumber decimal, @createddate Date)
as

begin 

insert into persontable values (@firstname, @lastname, @email, @mobilenumber, @createddate )

end
go

exec sp_insertdata 'Sunny', 'Sahu', 'sunny@example.com', 1234567890, '2025-05-20';

delete from persontable where firstname='dsads';

delete from persontable

select * from persontable

```

- C# CODE check the TasyBySir.cs File