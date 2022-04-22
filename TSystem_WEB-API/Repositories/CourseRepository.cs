using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSystem_WEB_API.Entities;
using TSystem_WEB_API.Model;

namespace TSystem_WEB_API.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        RepositoriesContext context;
        public CourseRepository(RepositoriesContext context) //DI
        {
            this.context = context;
        }
        public int AddCourse(Course cus)
        {
            context.Courses.Add(cus);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteCourse(int CId)
        {
            var cus = context.Courses.Where(c => c.CId == CId).SingleOrDefault();
            if (cus != null)
            {
                context.Courses.Remove(cus);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return context.Courses.ToList();
        }

        public int ModifyCourse(Course cus)
        {
            var Course = context.Courses.Where(c => c.CId == cus.CId).SingleOrDefault();
            if (Course != null)
            {
                Course.CName = cus.CName;
                Course.CFees = cus.CFees;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
