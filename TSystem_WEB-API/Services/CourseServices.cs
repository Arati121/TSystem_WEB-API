using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSystem_WEB_API.Model;
using TSystem_WEB_API.Repositories;

namespace TSystem_WEB_API.Services
{
    public class CourseServices : ICourseServices
    {
        private readonly ICourseRepository _iCourseRepo;
        public CourseServices(ICourseRepository iCourseRepo)
        {
            _iCourseRepo = iCourseRepo;
        }
        public int AddCourse(Course cus)
        {
            return _iCourseRepo.AddCourse(cus);
        }

        public int DeleteCourse(int CId)
        {
            return _iCourseRepo.DeleteCourse(CId);
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _iCourseRepo.GetAllCourses();
        }

        public int ModifyCourse(Course cus)
        {
            return _iCourseRepo.ModifyCourse(cus);
        }
    }
}
