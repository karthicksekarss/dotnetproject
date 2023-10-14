using DotNet6.API.Interface;
using DotNet6.API.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet6.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class EmployeeController : ControllerBase
    {
        private IEmployee empservice { get; set; }
        private IConfiguration _configuration { get; set; }
        public EmployeeController(IEmployee employee, IConfiguration configuration)
        {
            empservice = employee;
            _configuration  = configuration;
        }

        [HttpGet]
        [Route("GetEmployeeById")]
        public Employee GetEmployeeById(int empId)
        {
            return empservice.GetEmployeeById(empId);
        }

        [HttpGet]
        [Route("GetEmployees")]
        public List<Employee> GetEmployees()
        {
            string sampleKeyValue = _configuration["SampleValue"];
            string AudienceKeyValue = _configuration["TokenOptions:Audience"];
            return empservice.GetEmployees();
        }
    }
}
