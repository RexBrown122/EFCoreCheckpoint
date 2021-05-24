﻿using System;
using App.Context;
using App.Models;
using System.Linq;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new DataContext();

            // Selecting a student from Database
            Console.WriteLine("\nStudents in Database:");
            var students = from student in database.Students
                            select student;
            students.ToList().ForEach(student => Console.WriteLine($"Student Name: {student.FirstName} {student.LastName}"));

            // Selecting a student and showing their grades
            // var students2 = from student in database.Students select new {ID = student.ID, Grades = student.GradesList};
            // students2.ToList().ForEach(student => Console.WriteLine($"Student Grades: {student.ID} : {student.Grades}"));

            // Selecting a student and showing AVG grade

            // Student with the highest AVG grade

            // Student in the most courses
            Console.WriteLine("\nStudent enrolled in most classes:");
            var students5 = (from student in database.Students
                            orderby student.GradesList.Count() descending
                            select new {studentFName = student.FirstName, studentLName = student.LastName, studentGrades = student.GradesList}).FirstOrDefault();
            Console.WriteLine($"{students5.studentFName} {students5.studentLName} is in {students5.studentGrades.Count()} classes.");

            // Student taking ZERO courses
            Console.WriteLine("\nStudent enrolled in ZERO classes:");
            var students6 = (from student in database.Students
                            orderby student.GradesList.Count() ascending
                            select new {studentFName = student.FirstName, studentLName = student.LastName, studentGrades = student.GradesList}).FirstOrDefault();
            Console.WriteLine($"{students6.studentFName} {students6.studentLName} is in {students6.studentGrades.Count()} classes.");

            // Total number of Freshmen
            Console.WriteLine("\nNumber of Freshmen enrolled:");
            var freshmanCount = (from student in database.Students
                            where student.ClassYear.Equals(Classification.Freshman)
                            select new {studentClassYear = student.ClassYear}).Count();
            Console.WriteLine($"There are {freshmanCount} Freshmen.");

            // AVG grade among all Sophomores
            Console.WriteLine("\nAVG grade among all Sophomores:");
            var sophomoreCount = (from student in database.Students
                            where student.ClassYear.Equals(Classification.Sophomore)
                            select new {studentClassYear = student.ClassYear}).Count();

            Console.WriteLine();
        }
    }
}
