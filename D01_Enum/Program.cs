using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D01_Enum
{
    internal class Program
    {

        static List<Person> listPersons = new List<Person>();

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            // Instaciar
            Person person01 = new Person();

            person01.Name = "aa";
            person01.MaritalStatus = Person.EnumMaritalStatus.Widowed;

            Person person02 = new Person("bb", Person.EnumMaritalStatus.Single);

            /*
            listPersons.Add(person01);
            listPersons.Add(person02);
            */

            Person.AddPerson(listPersons);

            Utility.TerminateConsole();
        }
    }
}
