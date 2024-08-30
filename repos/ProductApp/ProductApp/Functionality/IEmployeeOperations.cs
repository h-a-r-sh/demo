using ProductApp.Models;

namespace ProductApp.Functionality
{
    public interface IEmployeeOperations
    {
        public int AddEmployee(Employee employee);
        public int DeleteEmployee(int ID);
        public int UpdateEmployee(int ID,string name,string dep,int sal);
        public List<Employee> GetAll();
    }
}
