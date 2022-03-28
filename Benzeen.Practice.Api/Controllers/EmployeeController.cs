using Benzeen.Practice.Infrastructure.Contracts.Service;
using Benzeen.Practice.Infrastructure.DTO.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Benzeen.Practice.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var employees = _employeeService.GetAll();
            return Ok (employees);

        }
        [HttpGet("GetById")]
        public IActionResult GetById(int Id)
        {
            var employee = _employeeService.GetById(Id);
            return Ok (employee);
        }
        [HttpPost("Post")]
        public IActionResult Post([FromBody] EmployeeRequest employeeRequest)
        {
            var affctedRows = _employeeService.Post(employeeRequest);
            return Ok (affctedRows);
        }
        [HttpPut("Update")]
        public IActionResult Update([FromBody] EmployeeRequest employeeRequest)
        {
            var affctedRows = _employeeService.Update(employeeRequest);
            return Ok(affctedRows);
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int Id)
        {
            var employee = _employeeService.Delete(Id);
            return Ok(employee);
        }
        [HttpGet("Multi")]
        public IActionResult Multi()
        {
            var employeemulti = _employeeService.Multi();
            return Ok(employeemulti);
        }
    }
}
