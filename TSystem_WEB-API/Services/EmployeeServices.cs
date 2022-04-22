using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSystem_WEB_API.Model;
using TSystem_WEB_API.Repositories;

namespace TSystem_WEB_API.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepository _iempRepo;
        public EmployeeServices(IEmployeeRepository iempRepo)
        {
            _iempRepo = iempRepo;
        }
        public int AddEmployee(Employee emp)
        {
            return _iempRepo.AddEmployee(emp);
        }

        public int DeleteEmployee(int EId)
        {
            return _iempRepo.DeleteEmployee(EId);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _iempRepo.GetAllEmployees();
        }

        public int ModifyEmployee(Employee emp)
        {
            return _iempRepo.ModifyEmployee(emp);
        }
    }
}
