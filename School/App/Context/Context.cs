using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grades> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var students = new Student[]
            {
                new Student { ID = 1, FirstName = "Mark", LastName = "Flores", Age = 15, ClassYear = Classification.Freshman },
                new Student { ID = 2, FirstName = "John", LastName = "Doe", Age = 16, ClassYear = Classification.Sophomore },
                new Student { ID = 3, FirstName = "Jessica", LastName = "Robinson", Age = 17, ClassYear = Classification.Junior },
                new Student { ID = 4, FirstName = "Rex", LastName = "Brown", Age = 18, ClassYear = Classification.Senior },
                new Student { ID = 5, FirstName = "Amanda", LastName = "Johnson", Age = 18, ClassYear = Classification.Senior }
            };

            var grades = new Grades[]
            {
                new Grades { ID = 1, StudentID = 1, CourseName = "English", Grade = 80 },
                new Grades { ID = 2, StudentID = 2, CourseName = "Math", Grade = 60 },
                new Grades { ID = 3, StudentID = 3, CourseName = "Science", Grade = 75 },
                new Grades { ID = 4, StudentID = 4, CourseName = "Government", Grade = 90 },
                new Grades { ID = 5, StudentID = 2, CourseName = "English", Grade = 100 }
            };

            modelBuilder.Entity<Student>().HasData(students);
            modelBuilder.Entity<Grades>().HasData(grades);
            base.OnModelCreating(modelBuilder);
        }
    }
}