using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSystem_WEB_API.Model;
using TSystem_WEB_API.Services;

namespace TSystem_WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _empservice;
        public EmployeeController(IEmployeeServices empservice)
        {
            _empservice = empservice;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployees")]
        public IActionResult GetEmployees()
        {
            return new ObjectResult(_empservice.GetAllEmployees());
        }
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(Employee emp)
        {
            return new ObjectResult(_empservice.AddEmployee(emp));
        }

        [HttpPost]
        [Route("ModifyEmployee")]
        public IActionResult ModifyEmployee(Employee emp)
        {
            return new ObjectResult(_empservice.ModifyEmployee(emp));
        }

        [HttpGet]
        [Route("DeleteEmployee/{EId}")]
        public IActionResult DeleteEmployee(int EId)
        {
            return new ObjectResult(_empservice.DeleteEmployee(EId));
        }
    }
}
