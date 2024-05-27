using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D02_OOP_Encapsulation
{
    internal class Course
    {
        #region Fields

        private string name;
        
        private string area;

        #endregion

        #region Properties

        // Auto-implemented
        internal int CourseId { get; set; }
        
        //internal string Name { get; set; }
        // Clássica: usa Field
        internal string Name
        {
            get { return name; }
            set { name = value.ToUpper(); }
        }

        //internal string Area { get; set; }      
        // Bodied-expression -> Usa Lambda e Field
        internal string Area
        {
            get => area;
            set => area = value.ToUpper();
        }

        // É apenas get, não precisa de fields
        internal string FullCourse => $"Course nº {CourseId}: {Area} - {Name}";     // Get
        // internal string FullCourse => field = value;     // Isto seria um Set mas precisaria do field

        #endregion

        #region Constructors



        #endregion

        #region Methods

        internal void ReadCourse()
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

        internal void ListCourse()
        {
            Utility.WriteMessage(FullCourse, "\n\n", "\n\n\n");
        }

        #endregion
    }
}
