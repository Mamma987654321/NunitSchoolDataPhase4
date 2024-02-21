using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataLibrary
{
    public class Teacher
    {
        public virtual string Name { get; set; }
        public string  Subject { get; set; }
        public Teacher(string name, string subject)
        {
            Name = name;
            Subject = subject;
        }
        public string GetTeacherInfo()
        {
            return $"{Name} teaches {Subject}";
        }
    }
}
