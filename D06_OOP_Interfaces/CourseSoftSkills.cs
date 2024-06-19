using System;

namespace D06_OOP_Interfaces
{
    internal class CourseSoftSkills : Course, ICourseSoftSkills
    {
        #region Properties

        public EnumLanguage CourseLanguage { get; set; }

        #endregion

        #region Methods

        public new void ListCourse(string level)
        {
            Console.WriteLine($"Listing course {Name} at level {level} for soft skills development.");
        }

        public new void ListCourse(DateTime timestamp)
        {
            Console.WriteLine($"Listing course {Name} for soft skills development at {timestamp}.");
        }

        public new void ReadCourse()
        {
            Console.WriteLine($"Reading course: {Name} for soft skills development.");
        }

        #endregion
    }
}
