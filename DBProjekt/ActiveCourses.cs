using DBProjekt.Data;
using DBProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjekt
{
    internal class ActiveCourses
    {
        public static void CourseActive()
        {
            using (DBProjektDbContext db = new DBProjektDbContext())
            {
                
                {
                    Console.Clear();
                    Console.WriteLine("Active courses: ");
                    Console.WriteLine();

                    var activeCourses = db.Courses.ToList();

                    foreach (var course in activeCourses)
                    {
                        Console.WriteLine($"Course: {course.CourseType}");
                    }
                }
                Console.WriteLine("Please press enter to continue");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
