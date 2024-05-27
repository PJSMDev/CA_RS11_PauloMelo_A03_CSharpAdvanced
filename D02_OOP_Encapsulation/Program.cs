using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D02_OOP_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Course course01 = new Course();
            Course course02 = new Course();

            Utility.WriteTitle("Courses");

            // Propriedades: escrever diretamente 
            course01.CourseId = 1;
            course01.Name = "C#";
            course01.Area = "Dev";

            //Utility.WriteMessage(course01.FullCourse);
            // Não vou ver os fields porque são encaplulados à Class Course.cs

            // Pripriedades: chamar o método
            course02.ReadCourse();

            // Listar
            course01.ListCourse();
            course02.ListCourse();

            Utility.TerminateConsole();
        }
    }
}
