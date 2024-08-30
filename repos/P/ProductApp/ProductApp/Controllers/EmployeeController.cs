using Microsoft.AspNetCore.Mvc;
using ProductApp.Functionality;
using ProductApp.Models;
using ProductApp.Services;

namespace ProductApp.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeOperations Eoperation;
        public EmployeeController()
        {
            Eoperation = new EmployeeServices();
        }
        public IActionResult Index()
        {
            return View();
        }
   
            [HttpGet]
            public IActionResult CreateEmployee()
            {
                return View();
            }
            [HttpPost]
            public IActionResult CreateEmployee(Employee employee)
            {
                int temp = Eoperation.AddEmployee(employee);
                if (temp > 0)
                {
                    ViewBag.Message = "Employee Added";
                }
                return View();
            }
            [HttpGet]
            //public IActionResult ShowEmployee()
            //{
            //    return View();
            //}
            //[HttpPost]
            public IActionResult ShowEmployee()
            {
                var res = Eoperation.GetAll();
                return View(res);
            }

            [HttpGet]
            public IActionResult updateEmployee()
            {
                return View();
            }
            [HttpPost]
            public IActionResult updateEmployee(Employee employee)
            {
                var update = Eoperation.UpdateEmployee(employee.EmployeeId, employee.EmployeeName,employee.EmployeeDepartment,employee.EmployeeSalary);
                return View();
            }

            [HttpGet]
            public IActionResult RemoveEmployee()
            {
                return View();
            }
               
            [HttpPost]
            public IActionResult RemoveEmployee(Employee employee)
            {
                var r = Eoperation.DeleteEmployee(employee.EmployeeId);
            if (r > 0)
            {
                ViewBag.Message = "Employee Removed";
                return RedirectToAction("ShowEmployee","Employee"); // Redirect to action after successful removal
            }
            return View();
            }

        }
    }
