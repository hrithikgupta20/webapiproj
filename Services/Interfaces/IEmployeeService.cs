using System.Collections.Generic;
using webapi.Models;
namespace webapi.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
    }
}
