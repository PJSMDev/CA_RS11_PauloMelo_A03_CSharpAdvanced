using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D04_OOP_Polymorphism
{
    internal class Course
    {
        #region Fields

        private string name;
        private string area;

        #endregion

        #region Properties

        internal int CourseId { get; set; }

        internal string Name
        {
            get { return name; }
            set { name = value.ToUpper(); }
        }

        internal string Area
        {
            get => area;
            set => area = value.ToUpper();
        }

        // virtual: indica que a propriedade pode ser reescrita (override) na derived class
        internal virtual string FullCourse => $"Course nº {CourseId}: {Area} - {Name}";

        #endregion

        #region Constructors

        internal Course()
        {
            CourseId = 0;
            Name = "";
            Area = string.Empty;
        }

        internal Course(int courseId, string name, string area)
        {
            CourseId = courseId;
            Name = name;
            Area = area;
        }

        #endregion

        #region Methods

        internal virtual void ReadCourse()
        {
            #region Course Id
            bool converted = false;
            int value = 0;

            Utility.WriteMessage("Course id: ");

            converted = int.TryParse(Console.ReadLine(), out value);

            if (converted)
            {
                CourseId = value;
            }
            #endregion

            #region Course Name
            Utility.WriteMessage("Course name: ");
            Name = Console.ReadLine();
            #endregion

            #region Course Area
            Utility.WriteMessage("Course area: ");
            Area = Console.ReadLine();
            #endregion
        }

        internal virtual void ListCourse()
        {
            Utility.WriteMessage(FullCourse, "\n\n", "\n\n\n");
        }

        #endregion
    }
}
