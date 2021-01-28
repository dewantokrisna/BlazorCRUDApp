using System;
using System.Collections.Generic;
using System.Linq;

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

        public void AddEmployee(Employee employee)
        {
            var id = Guid.NewGuid();
            employee.Id = id;
            employees.Add(employee);
        }

        public void DeleteEmployee(Guid id)
        {
            var employee = GetEmployee(id);
            employees.Remove(employee);
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }


        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void UpdateEmployee(Employee employee)
        {
            var getOldEmployee = GetEmployee(employee.Id);
            getOldEmployee.Name = employee.Name;

        }
    }
}
