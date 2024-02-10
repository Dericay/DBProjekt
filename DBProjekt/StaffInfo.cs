using DBProjekt.Data;
using DBProjekt.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjekt
{
    internal class StaffInfo
    {
        

        public static void InfoStaff()
        {
            using (DBProjektDbContext db = new DBProjektDbContext())
            {
                Console.Clear();
                Console.WriteLine("Number of employees on each department: ");
                Console.WriteLine();

                var Departments = db.Departments.ToList();

                foreach(var Deparment in Departments)
                {
                    int personCount = db.Staffs.Count(p => p.DepartmentId == Deparment.DeparmentID);
                    Console.WriteLine(value: $"{Deparment.Deparment} Department currently have {personCount} Employees");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            Console.Clear();

        
                
            

        }

    }
}
