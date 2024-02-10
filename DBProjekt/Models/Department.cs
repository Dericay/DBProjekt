using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjekt.Models
{
    internal class Departments
    {
        [Key]
        public int DeparmentID { get; set; }

        public string Deparment { get; set; }
    }
}
