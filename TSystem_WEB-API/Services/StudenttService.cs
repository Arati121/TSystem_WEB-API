using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSystem_WEB_API.Model;
using TSystem_WEB_API.Repositories;

namespace TSystem_WEB_API.Services
{
    public class StudenttService : IStudentServices
    {
        private readonly IStudenttRepository _iStudentRepo;
        public StudenttService(IStudenttRepository iStudentRepo)
        {
            _iStudentRepo = iStudentRepo;
        }
        public int AddStudentt(Studentt stud)
        {
            return _iStudentRepo.AddStudentt(stud);
        }

        public int DeleteStudentt(int rollno)
        {
            return _iStudentRepo.DeleteStudentt(rollno);
        }

        public IEnumerable<Studentt> GetAllStudents()
        {
            return _iStudentRepo.GetAllStudents();
        }

        public int ModifyStudentt(Studentt stud)
        {
            return _iStudentRepo.ModifyStudentt(stud);
        }
    }
}
