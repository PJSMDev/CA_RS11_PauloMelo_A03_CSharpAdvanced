using System;

namespace D06_OOP_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseSoftSkills coursePt = new CourseSoftSkills(Language.Portuguese);
            coursePt.DisplayCourseLanguage();

            CourseSoftSkills courseEn = new CourseSoftSkills(Language.English);
            courseEn.DisplayCourseLanguage();

            CourseSoftSkills courseEs = new CourseSoftSkills(Language.Spanish);
            courseEs.DisplayCourseLanguage();
        }
    }
}
