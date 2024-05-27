using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D03_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            CourseIT courseIT = new CourseIT(); // Instanciar a classe CourseIT

            courseIT.ReadCourse();
            courseIT.ListCourse();

            Utility.TerminateConsole();
        }
    }
}
