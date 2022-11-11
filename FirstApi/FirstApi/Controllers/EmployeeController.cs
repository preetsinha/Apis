using DatabaseProject.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _EmployeeRepository;

      public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _EmployeeRepository = employeeRepository;
        }
        [HttpGet]

        public IActionResult GetEmployees()
        {
            try
            {
                var employees = _EmployeeRepository.GetEmployees();
                return Ok(employees);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExceptionFailed, ex.Message);
            }
        }
    }
}
