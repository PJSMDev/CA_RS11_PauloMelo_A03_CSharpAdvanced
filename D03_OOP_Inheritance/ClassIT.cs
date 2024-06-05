using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using D00_Utility;

namespace D03_OOP_Inheritance
{
    internal class ClassIT : Course
    {
        #region Properties

        internal bool Exam { get; set; }

        // Reescrever a propriedade herdada: override
        internal override string FullCourse => $"Course nº {CourseId}: {Area} - {Name}, exam? {Exam}";

        #endregion

        #region Constructors

        internal ClassIT() : base()
        {
            Exam = true;
        }

        internal ClassIT(int courseId, string name, string area, bool exam) : base(courseId, name, area)
        {
            Exam = exam;
        }

        #endregion

        #region Methods

        internal new void ReadCourse()
        {
            base.ReadCourse();

            Utility.WriteMessage("Course exam (true|false)?");
            Exam = Convert.ToBoolean(Console.ReadLine());
        }

        internal new void ListCourse()
        {
            Utility.WriteMessage(FullCourse, "\n\n", "\n\n\n");
        }

        #endregion
    }
}
