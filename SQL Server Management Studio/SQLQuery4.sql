create database EmpDb
use EmpDb
create table Employee
(
	id int primary key,
	ename varchar(20),
	empsalary int
)
select * from Employee

insert into Employee values(102,'deepa',1203)
insert into Employee values(101,'kHUSHI',1200)


create function getEmployeeDetails(@i int)
returns varchar(20)
as
begin
	declare @result varchar(20)
	select @result=ename from employee where id=@i
	return @result
end
print dbo.getEmployeeDetails(102)



create function getEmployeeSalary(@i int)
returns int
as
begin
	declare @result int
	select @result=empsalary from employee where id=@i
	return @result
end
print dbo.getEmployeeSalary(102




create function getEmployeeAllDetails(@i int)
returns table
as
	return (select ename,empsalary from employee where id=@i)

select * from dbo.getEmployeeAllDetails(102)

create table Membership
(
	uusername varchar(20) primary key,
	upassword varchar(20),
	uage int
)
insert into Membership values('Mayank','test1',21)
insert into Membership values('Anant','test2',22)
insert into Membership values('Aman','test3',21)
insert into Membership values('Harsh','test4',23)


select * from Membership

create function Login(@username varchar(20),@password varchar(20) )
returns int
as
begin
	declare @result int
	select @result=count(*) from membership where uusername=@username AND upassword=@password
	return @result
end
print dbo.Login('Mayank','mayank@1')

# 
create function UserByAge(@age int)
returns table
as
begin
	declare @result int
	select @result=count(*) from membership where uusername=@username AND upassword=@password
	return @result
end
print dbo.Login('Mayank','mayank@1')




CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10, 2)
)


insert into Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary)
values
    (1, 'John', 'Doe', 1, 50000.00),
    (2, 'Jane', 'Smith', 1, 55000.00),
    (3, 'Michael', 'Johnson', 2, 60000.00),
    (4, 'Emily', 'Brown', 2, 52000.00),
    (5, 'William', 'Davis', 1, 48000.00),
    (6, 'Olivia', 'Garcia', 3, 65000.00),
    (7, 'James', 'Martinez', 3, 53000.00),
    (8, 'Sophia', 'Lopez', 2, 58000.00),
    (9, 'Alexander', 'Hernandez', 1, 51000.00),
    (10, 'Abigail', 'Gonzalez', 3, 59000.00)

select * from Employees

-- No. of Employee
create function GetEmployeeCount()
returns int
as
begin
    declare @count int
    select @count = count(*) from employees
    return @count
end
print dbo.GetEmployeeCount()


-- Average Salary
create function dbo.GetAverageSalary()
returns decimal(10, 2)
as
begin
    declare @avgsalary decimal(10, 2)
    select @avgsalary = avg(salary) from employees
    return @avgsalary
end
print dbo.GetAverageSalary()


-- Employee by id
create function dbo.GetEmployeeByID(@employeeid int)
returns table
as
return
(
    select employeeid, firstname, lastname, departmentid, salary
    from employees
    where employeeid = @employeeid
)
select * from dbo.GetEmployeeByID(2)


-- Total salary for Department
create function GetTotalSalaryByDepartment(@departmentid int)
returns decimal(10, 2)
as
begin
    declare @totalsalary decimal(10, 2)
    select @totalsalary = sum(salary) from employees where departmentid = @departmentid
    return @totalsalary
end
print dbo.GetTotalSalaryByDepartment(1)



--  employee count by department
create function GetEmployeeCountByDepartment(@DepartmentID int)
returns int
as
begin
    declare @count int
    select @count = count(*) from employees where departmentid = @departmentid
    return @count
end
print dbo.GetEmployeeCountByDepartment(1);



-- calculate annual salary
create function CalculateAnnualSalary(@EmployeeID int)
returns decimal(10, 2)
as
begin
    declare @annualsalary decimal(10, 2)
    select @annualsalary = salary * 12
    from employees
    where employeeid = @employeeid
    return @annualsalary
end
print dbo.CalculateAnnualSalary(2)


create table Departments 
(
    DepartmentID int primary key,
    DepartmentName varchar(100)
)
insert into Departments (DepartmentID, DepartmentName)values(1, 'Sales'),(2, 'Marketing'),(3, 'Engineering');


alter table Employees
add constraint FK_Employees_Departments
foreign key (DepartmentID) references Departments(DepartmentID)
on delete cascade


-- delete details by departments
create function DeleteByDepartment(@DepartmentID int)
returnsint



-- Procedure

select * from Employee

create proc GetPhoneNumber
as 
begin
	return 01230
end

declare @temp int
exec @temp=GetPhoneNumber
print @temp


create proc GetAddress
@address varchar(20) output
as 
begin
	set @address='noida'
end

declare @add varchar(20)
exec GetAddress @add output
print @add


create proc GetDetails
@add varchar(20) output,
@phno int output
as 
begin
	set @add='noidaa'
	set @phno=1263
end

declare @add varchar(20)
declare @pno int
exec GetDetails @add output,@pno output
print @add
print @pno


create proc addEmployee
@i int,
@en varchar(20),
@esalary int
as 
begin
	insert into employee values(@i,@en,@esalary)
end
exec addEmployee 106,'deepi',1201,111

select * from Employee

-- Details by id
create proc GetDetailsByID
@i int,
@name varchar(20) output,
@salary int output
as 
begin
	select @name=ename from employee where id = @i
	select @salary=empsalary from employee where id = @i
end
declare @ename varchar(20)
declare @esalary int

exec GetDetailsByID 101 ,@ename output,@esalary output

print @ename
print @esalary

-- update by id
create proc UpdateByID
@i int,
@name varchar(20),
@salary int
as 
begin
	update  Employee
	set ename=@name,empsalary=@salary
	where id=@i
end

exec UpdateByID 105,'deepti',1300

select * from Employee
select * from Membership

-- check for login

create proc CheckLogin
@id varchar(20),
@pass varchar(20)
as 
begin
	declare @result int
	select @result=count(*) from membership where uusername=@id AND upassword=@pass
	return @result
end
declare @res int
exec @res=CheckLogin 'Aman','test3'
print @res


select * from Employees