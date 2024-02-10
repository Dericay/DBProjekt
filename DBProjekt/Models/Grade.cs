using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjekt.Models
{
    internal class Grade
    {
        [Key]
        public int GradeID { get; set; }

        public string GradeType { get; set; }
    }
}
