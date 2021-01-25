using System.Collections.Generic;

namespace BlazorCRUDApp.Data
{
    interface IEmployeeService
    {
        List<Employee> GetEmployees();
    }
}
