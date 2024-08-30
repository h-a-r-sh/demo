

Steps to implement Db First approach
1. Create Database.. create table(already created)
2. Ef core Provide tool to achieve DB First approach 
3.when we release the tool
    a. Table..class
    b. EF core class will be created (Context)

        Developer need to write the code to implement
        
        dotnet ef 
        dbcontext 
        scaffold 
        "Data Source=DESKTOP-78R12T0\MANOJ1;Initial Catalog=Emp_DB_Service;User Id=sa;Password=manoj123;multipleactiveresultsets=True;Encrypt=False" 
        Microsoft.EntityFrameworkCore.sqlserver -o Models

        dotnet ef dbcontext scaffold "Data Source=DESKTOP-DE69VTH\SQLSERVER;Initial Catalog=CoforgeDb;integrated security=true;multipleactiveresultsets=True;Encrypt=False" Microsoft.EntityFrameworkCore.sqlserver -o Models

        before releasing above command 
        install all four efcore packages
        
