using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using D00_Utility;

namespace D05_OOP_Abstraction
{
    internal class CourseIT : Course 
    {
        #region Properties

        internal bool Exam { get; set; }

        // Ofuscar, criar uma nova com o mesmo nome: new
        // Reescrever a propriedade herdada: override
        internal override string FullCourse => $"Course nº {CourseId}: {Area} - {Name}, exam? {Exam}";

        internal override double Value { get; set; }

        #endregion

        #region Constructors

        internal CourseIT() : base()
        {
            Exam = true;
            Value = 100;
        }

        internal CourseIT(int courseId, string name, string area, bool exam) : base(courseId, name, area)
        {
            Exam = exam;
            Value = 100;
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

        internal override void Billing(string status)
        {
            //Utility.WriteMessage($"(100,00 €) Estado de pagamento: {status}", "", "\n\n");
            // valor tem de vir da Propriedade
            Utility.WriteMessage($"{Value:C2} € Estado de pagamento: {status}", "", "\n\n");
        }

        #endregion
    }
}
