using System;

namespace D06_OOP_Interfaces
{
    internal class Course : IArea, ICourse
    {
        #region Properties

        public int CourseId { get; set; }
        public int AreaId { get; set; }
        public string Name { get; set; }
        public string AreaName { get; set; }
        public string SubAreaName { get; set; }
        public string Description { get; set; }
        public string FullCourse { get; set; }

        #endregion

        #region Methods

        public void ListCourse(string level)
        {
            Console.WriteLine($"Listing course {Name} at level {level}.");
        }

        public void ListCourse(DateTime timestamp)
        {
            Console.WriteLine($"Listing course {Name} at {timestamp}.");
        }

        public void ReadCourse()
        {
            Console.WriteLine($"Reading course: {Name}");
        }

        #endregion
    }
}
