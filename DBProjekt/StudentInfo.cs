using DBProjekt.Data;
using DBProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjekt
{
    internal class StudentInfo
    {

        public static void ShowStudentInfo() 
        {
            using (DBProjektDbContext db = new DBProjektDbContext())
            {
                Console.Clear();

                Console.WriteLine("This is all information about the students in the school");
                Console.WriteLine();

                var StudentCourseInfo = db.Students.ToList();

                foreach (var info in StudentCourseInfo)
                {
                    Console.WriteLine($"Student ID: {info.StudentID}");
                    Console.WriteLine($"Name: {info.FName} " + $"{info.LName}");
                    Console.WriteLine($"Class: {info.PersonalNumber}");
                    Console.WriteLine($"Class: {info.StudentClass}");
                    Console.WriteLine("");
                    




                }
                Console.WriteLine("Please press enter to continue");
                Console.ReadKey();
                Console.Clear() ;
            }
        }

    }
}
