using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DBProjekt.Models
{
    internal class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        [MaxLength(50)]
        public string FName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LName { get; set; }
        
        public string PersonalNumber { get; set; }
        
        public string StudentClass { get; set; }
    }
}
