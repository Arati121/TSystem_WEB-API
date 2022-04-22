using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSystem_WEB_API.Model;

namespace TSystem_WEB_API.Services
{
   public  interface ICourseServices
    {
        IEnumerable<Course> GetAllCourses();
        int AddCourse(Course cus );
        int ModifyCourse(Course cus);
        int DeleteCourse(int CId);
    }
}
