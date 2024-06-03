using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D05_OOP_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region CourseIT

            CourseIT courseIT01 = new CourseIT();

            Utility.WriteTitle("CourseIT");

            courseIT01.ReadCourse();
            courseIT01.ListCourse();

            courseIT01.Billing("Pago.");

            #endregion

            #region CourseSoftSkills

            CourseSoftSkills courseSoftSkills01 = new CourseSoftSkills();

            Utility.WriteTitle("Course Soft Skills");

            courseSoftSkills01.ReadCourse();
            courseSoftSkills01.ListCourse();

            courseSoftSkills01.ListCourse("Level 1");

            courseSoftSkills01.ListCourse(DateTime.Today);

            courseSoftSkills01.Billing("Em dívida.");

            #endregion

            Utility.TerminateConsole();
        }
    }
}