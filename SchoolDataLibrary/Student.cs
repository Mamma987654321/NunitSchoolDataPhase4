using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataLibrary
{
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
        public string GetStudentInfo()
        {
            return $"{Name} is in grade {Grade}";
        }
    }
}
