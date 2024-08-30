using System.Collections.Generic;
using day5.Functionality;
using day5.Models;
namespace day5.Service
{
    public class EmployeeService : IEmployeeOperation
    {
         List<Employee> empList = new List<Employee>();
        List<Employee> IEmployeeOperation.EmpList()
        {

           
            Employee obj = new Employee();
            obj.EmpID = 101;
            obj.EmpName = "Harsh";
            obj.Salary = 20000;
            obj.Department = "Python";
            empList.Add(obj);

            Employee obj1 = new Employee();
            obj1.EmpID = 102;
            obj1.EmpName = "Mayank";
            obj1.Salary = 20000;
            obj1.Department = "Python";
            empList.Add(obj1);


            return empList;
        }

        List<Employee> IEmployeeOperation.GetEmployeeSearchById(int id)
        {
            var itEmployees = empList.Where(e => e.EmpID==id).ToList();
        
        return itEmployees;
        }
    }
}
