using System;

namespace D06_OOP_Interfaces
{
    internal class CourseIT : Course, ICourseIT
    {
        #region Properties

        public bool Exam { get; set; }

        #endregion

        #region Methods

        public new void ListCourse(string level)
        {
            Console.WriteLine($"Listing course {Name} at level {level} for IT students.");
        }

        public new void ListCourse(DateTime timestamp)
        {
            Console.WriteLine($"Listing course {Name} for IT students at {timestamp}.");
        }

        public new void ReadCourse()
        {
            Console.WriteLine($"Reading course: {Name} for IT students.");
        }

        #endregion
    }
}
