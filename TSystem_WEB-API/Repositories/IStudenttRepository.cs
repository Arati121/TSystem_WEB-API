using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSystem_WEB_API.Model;

namespace TSystem_WEB_API.Repositories
{
    public interface IStudenttRepository
    {
        IEnumerable<Studentt> GetAllStudents();
        int AddStudentt(Studentt stud);
        int ModifyStudentt(Studentt stud);
        int DeleteStudentt(int rollno);
    }
}
