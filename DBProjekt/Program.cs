using System.Security.Cryptography.X509Certificates;

namespace DBProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome! Please choose one of the options below!");
                Console.WriteLine();
                Console.WriteLine("1:Number of staff in departments\n2:Students information\n3:Active Courses");

                string UserInput = Console.ReadLine();

                switch(UserInput)
                {
                    case "1":
                        StaffInfo.InfoStaff();
                        break;
                    case "2":
                        StudentInfo.ShowStudentInfo(); 
                        break;
                    case "3":
                        ActiveCourses.CourseActive();
                        break;
                }
            }
        }
    }
}