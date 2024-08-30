"Data Source=TRD-417\\MSSQLSERVER2;Initial Catalog=CoforgeDB;integrated security=true;multipleactiveresultsets=True;Encrypt=False"

Steps to implement DB FIRST APPROACH
1) Create database..create table   //(Already created)
2) EF core provide to achieve DB first approach.
3) When we release the tool
    3.1) Table..class
    3.2) Ef core class will be created(dbcontext)

        developer needs to write the code to implement.

        //Syntax
        dotnet ef
        dbcontext scaffold
        "Data Source=TRD-417\\MSSQLSERVER2;Initial Catalog=Emp_DB_Service;User Id=sa;Password=manoj123;multipleactiveresultsets=True;Encrypt=False"
        Microsoft.EntityFrameworkCore.sqlserver -o Models
        //

        Actual code for ProductDBFIRST:
        dotnet ef dbcontext scaffold "Data Source=TRD-417\MSSQLSERVER2;Initial Catalog=CoforgeDB;integrated security=true;multipleactiveresultsets=True;Encrypt=False" Microsoft.EntityFrameworkCore.sqlserver -o Models

        Before release the above code, you need to install all 4 packages, important is the first one