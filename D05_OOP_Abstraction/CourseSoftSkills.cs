using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_OOP_Abstraction
{
    internal class CourseSoftSkills : Course
    {
        #region Properties

        internal string SubArea { get; set; }

        // new: nova implementação -> nunca será afetado pelo método que deu herança
        //internal new string FullCourse => $"Course nº {CourseId}: {Area} ({SubArea}) - {Name}";
        // Precisa de uma propriedade nova porque a FullCourse que herou não imprime a SubArea

        // override: polimorfismo
        // Reescrever o que foi herdado
        // Ofuscar, criar uma nova com o mesmo nome: new
        internal override string FullCourse => $"Course nº {CourseId}: {Area} ({SubArea}) - {Name}";

        internal override double Value { get; set; }

        #endregion

        #region Constructors

        internal CourseSoftSkills() : base()
        {
            SubArea = string.Empty;
            Value = 150;
        }

        internal CourseSoftSkills(int courseId, string name, string area, string subArea) : base(courseId, name, area)
        {
            SubArea = subArea;
            Value = 150;
        }

        #endregion

        #region Methods

        internal override void ReadCourse()
        {
            base.ReadCourse();
            Utility.WriteMessage("Course SubArea: ");
            SubArea = Console.ReadLine();
        }

        // Overloading -> Não posso fazer override para não mandar informação que as outras sub-classes não querem
        internal void ListCourse(string level)
        {
            Utility.WriteMessage($"{FullCourse} ({level})", "\n\n", "\n\n\n");
            // Quero o FullCourse da CourseSoftSkills porque já tem a SubArea
        }

        // Overloading
        internal void ListCourse(DateTime timestamp)
        {
            Utility.WriteMessage($"{FullCourse} ({timestamp.ToShortDateString()})", "\n\n", "\n\n\n");
        }

        internal override void Billing(string status)
        {
            // Utility.WriteMessage($"(120,00 €) Estado de pagamento: {status}", "", "\n\n");
            // valor tem de vir da Propriedade

            Utility.WriteMessage($"{Value:C2} € Estado de pagamento: {status}", "", "\n\n");
        }

        #endregion
    }
}
