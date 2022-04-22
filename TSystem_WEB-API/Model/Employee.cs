using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TSystem_WEB_API.Model
{
    [Table("Employee")]

    public class Employee
    {
        [Key]
        public int EId { get;  set; }
        public string EName { get; set; }
        public int ESalary { get; set; }

    }
}
