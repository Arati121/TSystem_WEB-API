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
    public class StudenttController: ControllerBase
    {
        private readonly IStudentServices _studservice;
        public StudenttController(IStudentServices studservice)
        {
            _studservice = studservice;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Studentt/GetStudents")]
        public IActionResult GetStudents()
        {
            return new ObjectResult(_studservice.GetAllStudents());
        }
        [HttpPost]
        [Route("AddStudentt")]
        public IActionResult AddStudentt(Studentt stud)
        {
            return new ObjectResult(_studservice.AddStudentt(stud));
        }

        [HttpPost]
        [Route("ModifyStudentt")]
        public IActionResult ModifyStudentt(Studentt stud)
        {
            return new ObjectResult(_studservice.ModifyStudentt(stud));
        }

        [HttpGet]
        [Route("DeleteStudentt/{rollno}")]
        public IActionResult DeleteStudentt(int rollno)
        {
            return new ObjectResult(_studservice.DeleteStudentt(rollno));
        }
    }
}
