using System;
using D00_Utility;

namespace D06_OOP_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region CourseIT

            CourseIT courseIT01 = new CourseIT
            {
                CourseId = 101,
                AreaId = 201,
                Name = "Introduction to Programming",
                AreaName = "IT",
                SubAreaName = "Programming",
                Description = "A beginner-friendly course on programming.",
                FullCourse = "Full course on programming.",
                Exam = true
            };

            Utility.WriteTitle("CourseIT");

            courseIT01.ReadCourse();
            courseIT01.ListCourse("Beginner");

            // Implementação fictícia do método Billing
            Console.WriteLine("Billing: Pago.");

            #endregion

            #region CourseSoftSkills

            CourseSoftSkills courseSoftSkills01 = new CourseSoftSkills
            {
                CourseId = 102,
                AreaId = 202,
                Name = "Effective Communication",
                AreaName = "Soft Skills",
                SubAreaName = "Communication",
                Description = "A course on improving communication skills.",
                FullCourse = "Full course on communication skills.",
                CourseLanguage = EnumLanguage.English
            };

            Utility.WriteTitle("Course Soft Skills");

            courseSoftSkills01.ReadCourse();
            courseSoftSkills01.ListCourse("Level 1");
            courseSoftSkills01.ListCourse(DateTime.Today);

            // Implementação fictícia do método Billing
            Console.WriteLine("Billing: Em dívida.");

            #endregion

            Utility.TerminateConsole();
        }
    }
}
