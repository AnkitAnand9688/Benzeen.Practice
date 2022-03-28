using Benzeen.Practice.Infrastructure.Contracts.Service;
using Benzeen.Practice.Infrastructure.DTO.Department;
using Benzeen.Practice.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Benzeen.Practice.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var department = _departmentService.GetAll();
            return Ok(department);

        }
        [HttpGet("GetAllMix")]
        public IActionResult GetAllMix()
        {
            var departmentEmployee = _departmentService.GetAllMix();
            return Ok(departmentEmployee);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int Id)
        {
            var department = _departmentService.GetById(Id);
            return Ok(department);
        }
        [HttpPost("Post")]
        public IActionResult Post([FromBody] DepartmentRequest departmentRequest)
        {
            var department = _departmentService.Post(departmentRequest);
            return Ok(department);
        }
        [HttpPut("Update")]
        public IActionResult Update([FromBody] DepartmentRequest departmentRequest)
        {
            var department = _departmentService.Update(departmentRequest);
            return Ok(department);
        }
        [HttpDelete("Delete")]

        public IActionResult Delete(int Id)
        {
            var department = _departmentService.Delete(Id);
            return Ok(department);
        }
        [HttpGet("Multi")]
        public IActionResult Multi()
        {
            var department = _departmentService.Multi();    
            return Ok(department);  
        }

    }
}
