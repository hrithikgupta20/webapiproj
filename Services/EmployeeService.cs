using webapi.Models;
using webapi.Services.Interfaces;
using System.Collections.Generic;

namespace webapi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEnumerable<Employee> _employees;

        public EmployeeService()
        {
            _employees = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Hrithik"},
                new Employee(){ Id = 2, Name = "Rahul"}
            };
        }
        public IEnumerable<Employee> GetEmployees()

        {
            return _employees;
            throw new NotImplementedException();
        }
    }
}
