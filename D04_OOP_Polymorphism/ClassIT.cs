using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using D00_Utility;

namespace D04_OOP_Polymorphism
{
    internal class CourseIT : Course // Corrigido para CourseIT
    {
        #region Properties

        internal bool Exam { get; set; }

        // Ofuscar, criar uma nova com o mesmo nome: new
        // Reescrever a propriedade herdada: override
        internal override string FullCourse => $"Course nº {CourseId}: {Area} - {Name}, exam? {Exam}";

        #endregion

        #region Constructors

        internal CourseIT() : base()
        {
            Exam = true;
        }

        internal CourseIT(int courseId, string name, string area, bool exam) : base(courseId, name, area)
        {
            Exam = exam;
        }

        #endregion

        #region Methods

        internal override void ReadCourse()
        {
            base.ReadCourse();

            Utility.WriteMessage("Course exam (true|false)? ");
            Exam = Convert.ToBoolean(Console.ReadLine());
        }

        internal override void ListCourse()
        {
            Utility.WriteMessage(FullCourse, "\n\n", "\n\n\n");
        }

        #endregion
    }
}
