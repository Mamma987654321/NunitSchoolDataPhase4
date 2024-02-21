using SchoolDataLibrary;
using System.Reflection.Metadata;

namespace SchoolData
{
    [TestFixture]
    public class Tests    {


        [Test]
        public void Teacher_GetInfo() {
            var teacher = new Teacher("Sam", "English");
            var result = teacher.GetTeacherInfo();
            Assert.That(result, Is.EqualTo("Sam teaches English"));
        }
        [Test]
        public void Student_GetInfo()
        {
            var student = new Student("Samantha", 5);
            var result = student.GetStudentInfo();
            Assert.That(result, Is.EqualTo("Samantha is in grade 5"));
        }
        [Test]
        public void Subject_GetInfo()
        {
            var subject = new Subject("Biology", 2);
            var result = subject.GetSubjectInfo();
            Assert.That(result, Is.EqualTo("Biology has 2 credits"));
        }
        //[Test]
        //public void MockingExample()
        //{
        //    var mockTeacher = new Teacher("MockedTeacher", "MockedSubject");
        //    var result = mockTeacher.GetTeacherInfo();
        //    Assert.That(result, Is.EqualTo("MockerTeacher teaches MockedSubject"));
        //}
        [Test]
        [TestCase("Prank", 8)]
        [TestCase("Chemistry", 1)]
         public void Student_Get_Info_WithData(string studentName, int grade)
        {

            var student = new Student(studentName, grade);
            var result = student.GetStudentInfo();
            Assert.That(result, Is.EqualTo($"{studentName} is in grade {grade}"));
        }

    

    }
}