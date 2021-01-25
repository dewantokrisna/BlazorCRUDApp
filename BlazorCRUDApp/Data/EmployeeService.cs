using System;
using System.Collections.Generic;

namespace BlazorCRUDApp.Data
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Employee 1"
            },
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Employee 2"
            }
        };
        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
