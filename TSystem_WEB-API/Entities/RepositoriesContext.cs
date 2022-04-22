using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSystem_WEB_API.Model;

namespace TSystem_WEB_API.Entities
{
    public class RepositoriesContext: DbContext
    {
        public RepositoriesContext(DbContextOptions options) : base(options) { }

        public DbSet<Studentt> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
