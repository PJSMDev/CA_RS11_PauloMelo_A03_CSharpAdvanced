using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D04_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Course

            Course course01 = new Course();

            Utility.WriteTitle("Course");

            course01.ReadCourse();
            course01.ListCourse();

            #endregion

            #region CourseIT

            CourseIT courseIT01 = new CourseIT();

            Utility.WriteTitle("CourseIT");

            courseIT01.ReadCourse();
            courseIT01.ListCourse();

            #endregion

            #region CourseSoftSkills

            CourseSoftSkills courseSoftSkills01 = new CourseSoftSkills();

            Utility.WriteTitle("Course Soft Skills");

            courseSoftSkills01.ReadCourse();
            courseSoftSkills01.ListCourse();

            courseSoftSkills01.ListCourse("Level 1");

            courseSoftSkills01.ListCourse(DateTime.Today);

            #endregion

            Utility.TerminateConsole();
        }
    }
}
