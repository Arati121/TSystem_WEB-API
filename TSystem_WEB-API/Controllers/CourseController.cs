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
    public class CourseController : ControllerBase
    {
        private readonly ICourseServices _cusservice;
        public CourseController(ICourseServices cusservice)
        {
            _cusservice = cusservice;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Course/GetCourses")]
        public IActionResult GetAllCourses()
        {
            return new ObjectResult(_cusservice.GetAllCourses());
        }
        [HttpPost]
        [Route("AddCourse")]
        public IActionResult AddCourse(Course cus)
        {
            return new ObjectResult(_cusservice.AddCourse(cus));
        }

        [HttpPost]
        [Route("ModifyCourse")]
        public IActionResult ModifyCourse(Course cus)
        {
            return new ObjectResult(_cusservice.ModifyCourse(cus));
        }

        [HttpGet]
        [Route("DeleteCourse/{CId}")]
        public IActionResult DeleteCourse(int CId)
        {
            return new ObjectResult(_cusservice.DeleteCourse(CId));
        }
    }
}
