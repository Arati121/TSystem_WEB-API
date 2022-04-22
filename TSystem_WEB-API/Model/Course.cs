using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TSystem_WEB_API.Model
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int CId { get; set; }
        public string CName { get; set; }
        public int CFees { get; set; }
    }
}
