using System;
using System.Collections.Generic;
using day5.Models;

namespace day5.Functionality
{
    public interface IEmployeeOperation
    {
        List<Employee> EmpList();
        List<Employee> GetEmployeeSearchById(int id);
    }
}