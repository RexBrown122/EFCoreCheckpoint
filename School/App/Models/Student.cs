using System.Collections.Generic;

namespace App.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Classification ClassYear { get; set; }
        public List<Grades> GradesList { get; set; }
    }
}