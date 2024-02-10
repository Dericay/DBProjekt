using DBProjekt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjekt.Data
{
    internal class DBProjektDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Staff> Staffs { get; set;}
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<SchoolInfo> SchoolInfo { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = ANTON ;Initial Catalog = DBProjekt;TrustServerCertificate =True;Integrated security =True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(new Student { StudentID = 1, FName = "Anton", LName = "Larsson", PersonalNumber = "9309302312", StudentClass = "A" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentID = 2, FName = "Alfred", LName = "Larsson", PersonalNumber = "9502152255", StudentClass = "B" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentID = 3, FName = "Maureen", LName = "Supit", PersonalNumber = "93121926677", StudentClass = "A" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentID = 4, FName = "Sara", LName = "Lövström", PersonalNumber = "9505252222", StudentClass = "B" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentID = 5, FName = "Daniel", LName = "Strömsson", PersonalNumber = "9607109888", StudentClass = "C" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentID = 6, FName = "Emma", LName = "Svensson", PersonalNumber = "9604051111", StudentClass = "C" });

            modelBuilder.Entity<Departments>().HasData(new Departments { DeparmentID = 1, Deparment="Teacher"});
            modelBuilder.Entity<Departments>().HasData(new Departments { DeparmentID = 2, Deparment = "Admin" });
            modelBuilder.Entity<Departments>().HasData(new Departments { DeparmentID = 3, Deparment = "IT" });
            modelBuilder.Entity<Departments>().HasData(new Departments { DeparmentID = 4, Deparment = "HeadMaster" });

            modelBuilder.Entity<Staff>().HasData(new Staff { StaffID = 1, FirstName = "Anas", LastName = "Qlok", Salary = 31500, DepartmentId = 3, YearsWorked=3 });
            modelBuilder.Entity<Staff>().HasData(new Staff { StaffID = 2, FirstName = "Tobias", LastName = "KloQ", Salary = 30500, DepartmentId = 3, YearsWorked = 6 });
            modelBuilder.Entity<Staff>().HasData(new Staff { StaffID = 3, FirstName = "Reinar", LastName = "SöderLund", Salary = 29400, DepartmentId = 2, YearsWorked = 2 });
            modelBuilder.Entity<Staff>().HasData(new Staff { StaffID = 4, FirstName = "Margareta", LastName = "Danielsson", Salary = 28500, DepartmentId = 1, YearsWorked = 8 });
            modelBuilder.Entity<Staff>().HasData(new Staff { StaffID = 5, FirstName = "Lukas", LastName = "Andersson", Salary = 26500, DepartmentId = 1, YearsWorked = 3 });
            modelBuilder.Entity<Staff>().HasData(new Staff { StaffID = 6, FirstName = "Pontus", LastName = "Lövgren", Salary = 23500, DepartmentId = 1, YearsWorked = 5 });
            modelBuilder.Entity<Staff>().HasData(new Staff { StaffID = 7, FirstName = "Svante", LastName = "Svanslös", Salary = 38500, DepartmentId = 4, YearsWorked = 10 });

            modelBuilder.Entity<Course>().HasData(new Course { CourseID = 1, CourseType = "English" });
            modelBuilder.Entity<Course>().HasData(new Course { CourseID = 2, CourseType = "Science" });
            modelBuilder.Entity<Course>().HasData(new Course { CourseID = 3, CourseType = "Math" });

        }
    }
}
