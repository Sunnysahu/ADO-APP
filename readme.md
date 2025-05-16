1. Create an Connection String for establishing connection to the database
	> Create a Database in SQL and use the Server name and Database name to create a connection string

2. Setup it Here
	Here `MSI` is SQL server name and `ADOTEST`
	```
	   string myConnection = "Data Source=MSI;Database=ADOTEST; Initial Catalog=sspi";
        string myConnection = "Data Source=MSI;Initial Catalog=ADOTEST;Integrated Security=True;";
	```
3. Better wait is create a class and put the connection return there.