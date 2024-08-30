using day5.Functionality;
using day5.Service;
public class Controller
{
    public static void Main()
    {
        IEmployeeOperation employeeOperation = new EmployeeService();  //Seperation of concern
        var result=employeeOperation.EmpList();
        var temp=from r in result select r;
        // foreach (var i in temp)
        // {
        //     Console.WriteLine(i.EmpID+" "+i.EmpName+" "+i.Department);
        // }
        var res=employeeOperation.GetEmployeeSearchById(101);
        foreach (var i in res)
        {
            Console.WriteLine(i.EmpID+" "+i.EmpName+" "+i.Department);
        }
     
        // EmployeeService employeeService = new EmployeeService();

        // var employees = employeeService.EmpList();

        // Console.WriteLine(res[0].EmpID+" "+res[0].EmpName);
        // Console.WriteLine(res[1].EmpID+" "+res[1].EmpName);
        // var temp=from r in res select r;
        // foreach (var i in temp)
        // {
        //     Console.WriteLine(i.EmpID+" "+i.EmpName);
        // }

        // Console.WriteLine("------------------------------");
        // foreach (var i in res)
        // {
        //     Console.WriteLine(i.EmpID+" "+i.EmpName);
        // }


        // all
        // var allEmployees = from e in employees select e;
        // foreach (var emp in allEmployees)
        // {
        //     Console.WriteLine($"Id: {emp.EmpID}, Name: {emp.EmpName}, Salary: {emp.Salary}");
        // }

        // //
        // var itEmployees = from e in employees
        //                   where e.Department == "IT"
        //                   select e;
        // if(!itEmployees.Any())
        // {
        //     Console.WriteLine("No employee find");
        // }

        // foreach (var emp in itEmployees)
        // {
        //     Console.WriteLine($"Id: {emp.EmpID}, Name: {emp.EmpName}, Department: {emp.Department}, Salary: {emp.Salary}");
        // }


        // //
        // var sortedEmployees = from e in employees
        //                       orderby e.Salary
        //                       select e;

        // foreach (var emp in sortedEmployees)
        // {
        //     Console.WriteLine($"Id: {emp.EmpID}, Name: {emp.EmpName}, Department: {emp.Department}, Salary: {emp.Salary}");
        // }

        // //
        // var highSalaryEmployees = from e in employees
        //                           where e.Salary > 10000
        //                           select e;

        // foreach (var emp in highSalaryEmployees)
        // {
        //     Console.WriteLine($"Id: {emp.EmpID}, Name: {emp.EmpName}, Department: {emp.Department}, Salary: {emp.Salary}");
        // }


        // //

        // var employeeNames = from e in employees
        // select e.EmpName;/

        // foreach (var name in employees)
        // {
        //     if(name.EmpID==101 || name.EmpID==102){
        //         Console.WriteLine(name.EmpName+ " "+ name.EmpID);
        //     }
        // }



    }
}