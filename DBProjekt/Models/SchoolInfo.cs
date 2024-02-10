using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjekt.Models
{
    internal class SchoolInfo
    {
        [Key]
        public int SchoolInfoID { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }

        public int StaffId { get; set; }

        public Staff Staff { get; set;}

        public int CourseId { get; set; }

        public Course Course { get; set; }

        public int GradeId { get; set; }

        public Grade Grade { get; set; }

        public DateTime GradeTime { get; set; }
    }
}
