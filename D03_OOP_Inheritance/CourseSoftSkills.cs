using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_OOP_Inheritance
{
    internal class CourseSoftSkills : Course
    {
        #region Properties

        internal string SubArea { get; set; }
        internal new string FullCourse => $"Course nº {CourseId} - Name: {Name} - {Area} - SubArea: {SubArea}";
        // Precisa de uma propriedade nova porque a FullCourse que herou não imprime a SubArea

        #endregion

        #region Constructors

        internal CourseSoftSkills() : base()
        {
            SubArea = string.Empty;
        }

        internal CourseSoftSkills(int courseId, string name, string area, string subArea) : base(courseId, name, area)
        {
            SubArea = subArea;
        }

        #endregion

        #region Methods

        internal new void ReadCourse()
        {
            base.ReadCourse();
            Utility.WriteMessage("Course SubArea: ");
            SubArea = Console.ReadLine();
        }

        internal new void ListCourse()
        {
            Utility.WriteMessage(FullCourse, "\n\n", "\n\n\n");
        }

        #endregion
    }
}
