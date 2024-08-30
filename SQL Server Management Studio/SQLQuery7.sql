use EmpDb
select * from Employees
select * from Departments

create view EmployeeView
as
	select FirstName from Employees
	
select * from EmployeeView

update EmployeeView set FirstName = 'Aman' where FirstName='Jane'


-- 1 Basic Employee Details View

CREATE VIEW EmployeeDetails AS
SELECT EmployeeID, FirstName,LastName, Position, DepartmentID, Salary
FROM Employees;

select * from EmployeeDetails

--  2: Employee Details with Department Name

CREATE VIEW EmployeeWithDepartments AS
SELECT e.EmployeeID, e.FirstName,e.LastName, e.Position, e.Salary, d.DepartmentName
FROM Employees e
INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID;

select * from EmployeeWithDepartments

-- 3: Managers Only View
CREATE VIEW Managers AS
SELECT EmployeeID, FirstName,LastName, Position, Salary
FROM Employees
WHERE Position LIKE '%Manager%';

select * from Managers

-- 4: Example 4: Employees Hired in Last Year

CREATE VIEW RecentHires AS
SELECT EmployeeID, FirstName,LastName, Position, Salary, HireDate
FROM Employees
WHERE HireDate >= DATEADD(YEAR, -1, GETDATE());

select * from RecentHires


-- 5:Employee Salaries Above Average

CREATE VIEW HighEarners AS
SELECT EmployeeID, FirstName,LastName, Position, Salary
FROM Employees
WHERE Salary > (SELECT AVG(Salary) FROM Employees);

select * from HighEarners



--6 Department-wise Employee Count

CREATE VIEW DepartmentEmployeeCount AS
SELECT d.DepartmentID, d.DepartmentName, COUNT(e.EmployeeID) AS EmployeeCount
FROM Departments d
LEFT JOIN Employees e ON d.DepartmentID = e.DepartmentID
GROUP BY d.DepartmentID, d.DepartmentName;

select * from DepartmentEmployeeCount


--7 Employees Without Assigned Departments

CREATE VIEW EmployeesWithoutDepartment AS
SELECT EmployeeID, FirstName,LastName, Position, Salary
FROM Employees
WHERE DeptID IS NULL;


-- Views 
--1. View to display simple employee details
create view vw_empDetails
as
  select * from employees

select * from vw_empDetails

--2. View to show employee with hire year
create view vw_hireYearEmployee
as
  select Firstname,LastName,Year(HireDate) as Hired_Year
  from employees

select * from vw_hireYearEmployee

--3. View to show employes by department
create view empByDept
as
  select DepartmentID,count(*) as num_emp from employees
  group by DepartmentID

select * from empByDept

--4. View to show highest paid employees
create view vw_highestPaidEmp
as
  select top 3 EmployeeId,FirstName,LastName,Salary
  from employees
  order by Salary desc

select * from vw_highestPaidEmp

create view highest3PaidEmp
as
	select top 1 *
	from vw_highestPaidEmp 
	order by Salary asc














--having clause
select DepartmentID,count(*) as num_employee
from employees
group by DepartmentID

-- group by with avg(salary) in department
select DepartmentID,avg(salary) as Average_Salary
from employees
group by DepartmentID

--group by hire year
select year(HireDate) as HiredYear,count(*) as Num_employee
from employees
group by year(HireDate)

-- Having Clause 1
select DepartmentID,avg(Salary) as Average_Salary
from Employees
group by DepartmentID
having avg(Salary) > 60000

--2
select DepartmentID,count(*) from employees	
group by DepartmentID
having count(*) > 1

--3 department with avg sal less than threshold
select DepartmentID,avg(Salary) as Average 
from employees
group by DepartmentID
having avg(Salary) > 65000
