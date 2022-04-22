using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSystem_WEB_API.Entities;
using TSystem_WEB_API.Model;

namespace TSystem_WEB_API.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        RepositoriesContext context;
        public EmployeeRepository(RepositoriesContext context) //DI
        {
            this.context = context;
        }
        public int AddEmployee(Employee emp)
        {
            context.Employees.Add(emp);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteEmployee(int EId)
        {
            var emp = context.Employees.Where(e => e.EId == EId).SingleOrDefault();
            if (emp != null)
            {
                context.Employees.Remove(emp);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return context.Employees.ToList();
        }

        public int ModifyEmployee(Employee emp)
        {
            var Employee = context.Employees.Where(e => e.EId == emp.EId).SingleOrDefault();
            if (Employee != null)
            {
                Employee.EName = emp.EName;
                Employee.ESalary = emp.ESalary;
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
