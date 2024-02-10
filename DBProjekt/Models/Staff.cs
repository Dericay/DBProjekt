using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjekt.Models
{
    internal class Staff
    {
        [Key]
        public int StaffID { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        public int Salary {  get; set; }

        public int DepartmentId { get; set; }

        public Departments Department { get; set; }

        public int YearsWorked { get; set; }

        

    }
}
