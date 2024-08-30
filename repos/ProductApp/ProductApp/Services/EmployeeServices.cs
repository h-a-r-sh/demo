using ProductApp.Database;
using ProductApp.Functionality;
using ProductApp.Models;

namespace ProductApp.Services
{
    public class EmployeeServices : IEmployeeOperations
    {
        AccountDBContext accountDBContext;
        public EmployeeServices() 
        { 
            accountDBContext=new AccountDBContext();
        }

        int IEmployeeOperations.AddEmployee(Employee employee)
        {
            accountDBContext.Employees.Add(employee);    //record added in local memory
            return accountDBContext.SaveChanges();
        }

        int IEmployeeOperations.DeleteEmployee(int ID)
        {
            var del = accountDBContext.Employees.Where(e => e.EmployeeId==ID).FirstOrDefault();
            accountDBContext.Employees.Remove(del);
            return accountDBContext.SaveChanges();
        }

        List<Employee> IEmployeeOperations.GetAll()
        {
            var temp = accountDBContext.Employees.ToList();
            return temp;
        }

        int IEmployeeOperations.UpdateEmployee(int ID,string name,string dep,int sal)
        {
            var re = accountDBContext.Employees.Where(e => e.EmployeeId == ID).FirstOrDefault();
            re.EmployeeName = name;
            re.EmployeeDepartment = dep;
            re.EmployeeSalary = sal;
            
            return accountDBContext.SaveChanges();
        }
    }
}
