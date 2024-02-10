using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjekt.Models
{
    internal class Course
    {
        [Key]
        public int CourseID { get; set; } 

        public string CourseType { get; set; }
    }
}
