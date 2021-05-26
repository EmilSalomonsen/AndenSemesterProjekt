# To get started
1. Navigate to Tools -> Nuget Package Manager -> Package Manager Console
2. Execute the following:
* `EntityFrameworkCore\Add-Migration first`
* `EntityFrameworkCore\Update-Database`
3a. Navigate to SQL Server Object Explorer -> Click refresh top left corner of SQL Server Object Explorer
3b. Verify that UsersDB has been created and tables has been created
4. Navigate to Queries folder in Solution Explorer -> press connect on the top -> press local -> press <your-local-DB> -> enter database name `UsersDB` and press connect -> execute `CreateUsers.sql` by pressing the green arrow
5. Verify application works
