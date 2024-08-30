use EmpDb
-- Create Departments table
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY IDENTITY(1,1),
    DepartmentName NVARCHAR(100) NOT NULL
);

-- Create Employees table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Position NVARCHAR(100) NOT NULL,
    DepartmentID INT NOT NULL,
    Salary DECIMAL(18, 2) NOT NULL,
    HireDate DATE NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    PhoneNumber NVARCHAR(15),
    DateOfBirth DATE,
    Address NVARCHAR(250),
    CONSTRAINT FK_Employees_Departments FOREIGN KEY (DepartmentID)
        REFERENCES Departments (DepartmentID)
);

-- Insert sample data into Departments table
INSERT INTO Departments (DepartmentName) VALUES
('Human Resources'),
('IT'),
('Finance'),
('Marketing');

-- Insert sample data into Employees table
INSERT INTO Employees (FirstName, LastName, Position, DepartmentID, Salary, HireDate, Email, PhoneNumber, DateOfBirth, Address) VALUES
('John', 'Doe', 'Software Engineer', 2, 60000, '2023-01-15', 'john.doe@example.com', '123-456-7890', '1990-05-10', '123 Elm Street'),
('Jane', 'Smith', 'HR Manager', 1, 75000, '2021-03-10', 'jane.smith@example.com', '234-567-8901', '1985-04-22', '456 Oak Avenue'),
('Michael', 'Brown', 'Accountant', 3, 50000, '2022-07-22', 'michael.brown@example.com', '345-678-9012', '1992-11-30', '789 Pine Road'),
('Emily', 'Davis', 'Marketing Specialist', 4, 55000, '2020-11-05', 'emily.davis@example.com', '456-789-0123', '1988-07-15', '321 Maple Lane');

select * from Employees
-- 1 Add Employee
alter PROCEDURE AddEmployees
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Position NVARCHAR(100),
    @DepartmentID INT,
    @Salary DECIMAL(18, 2),
    @HireDate DATE,
    @Email NVARCHAR(100),
    @PhoneNumber NVARCHAR(15) = NULL,
    @DateOfBirth DATE = NULL,
    @Address NVARCHAR(250) = NULL
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, Position, DepartmentID, Salary, HireDate, Email, PhoneNumber, DateOfBirth, Address)
    VALUES (@FirstName, @LastName, @Position, @DepartmentID, @Salary, @HireDate, @Email, @PhoneNumber, @DateOfBirth, @Address);
END;

exec AddEmployees 'Harsh','Chaudhary','Software Engineer',2,50000,'2024-06-19','Harsh@coforge.com','9764575','2002-04-23','ddtstdt'




-- 2 Get Employee By ID
create PROCEDURE GetEmployeesByID
    @EmployeeID INT
AS
BEGIN
    SELECT * FROM Employees WHERE EmployeeID = @EmployeeID;
END;
exec GetEmployeesByID 1




---3 Get All Employee
CREATE PROCEDURE GetAllEmployees
AS
BEGIN
    SELECT * FROM Employees;
END;
exec GetAllEmployees




-- 4 Update Employee
CREATE PROCEDURE UpdateEmployee
    @EmployeeID INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Position NVARCHAR(100),
    @DepartmentID INT,
    @Salary DECIMAL(18, 2),
    @HireDate DATE,
    @Email NVARCHAR(100),
    @PhoneNumber NVARCHAR(15) = NULL,
    @DateOfBirth DATE = NULL,
    @Address NVARCHAR(250) = NULL
AS
BEGIN
    UPDATE Employees
    SET FirstName = @FirstName,
        LastName = @LastName,
        Position = @Position,
        DepartmentID = @DepartmentID,
        Salary = @Salary,
        HireDate = @HireDate,
        Email = @Email,
        PhoneNumber = @PhoneNumber,
        DateOfBirth = @DateOfBirth,
        Address = @Address
    WHERE EmployeeID = @EmployeeID;
END;

exec UpdateEmployee 1 ,'Harsh','Chaudhary','Software Engineer',2,50000,'2024-06-19','Harsh@coforge.com','9764575','2002-04-23','ddtstdt'




--5  Delete Employee
CREATE PROCEDURE DeleteEmployee
    @EmployeeID INT
AS
BEGIN
    DELETE FROM Employees WHERE EmployeeID = @EmployeeID;
END;
exec DeleteEmployee 1





--6  Get Employee by Department
CREATE PROCEDURE GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT * FROM Employees WHERE DepartmentID = @DepartmentID;
END;
exec GetEmployeesByDepartment 2





-- 7 Employee bY Hire date
CREATE PROCEDURE GetEmployeesHiredAfter
    @HireDate DATE
AS
BEGIN
    SELECT * FROM Employees WHERE HireDate > @HireDate;
END;
exec GetEmployeesHiredAfter '2021-01-01'



-- 8 Employee By Salary
CREATE PROCEDURE GetEmployeesWithSalaryAbove
    @Salary DECIMAL(18, 2)
AS
BEGIN
    SELECT * FROM Employees WHERE Salary > @Salary;
END;

exec GetEmployeesWithSalaryAbove 2000




--9 Employe Count by Department
CREATE PROCEDURE GetEmployeesCountByDepartment
AS
BEGIN
    SELECT DepartmentID, COUNT(*) AS EmployeeCount
    FROM Employees
    GROUP BY DepartmentID;
END;
exec GetEmployeesCountByDepartment




--10  Employee Details with departments
CREATE PROCEDURE GetEmployeeDetailsWithDepartment
AS
BEGIN
    SELECT e.EmployeeID, e.FirstName, e.LastName, e.Position, e.Salary, e.HireDate, e.Email, e.PhoneNumber, e.DateOfBirth, e.Address, d.DepartmentName
    FROM Employees e
    JOIN Departments d ON e.DepartmentID = d.DepartmentID;
END;
exec GetEmployeeDetailsWithDepartment 

