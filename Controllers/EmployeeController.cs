using Microsoft.AspNetCore.Mvc;
using webapi.Services.Interfaces;

namespace webapi.Controllers
{
    [Route("Employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet("Employee")]
        public IActionResult GetEmployees()
        {
            return new JsonResult(_employeeService.GetEmployees());
        }
    }
}
