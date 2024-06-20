using D00_Utility;
using System;
using System.Collections.Generic;

namespace E04_FuncionalidadesRecentes
{
    class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            List<Person> people = new List<Person>();
            Person.AddPerson(people);
            Utility.PauseConsole();

            Person p1 = new Person("Paulo Melo", 38, Person.EnumMaritalStatus.Single);
            Utility.WriteMessage(p1.GetFullName());

            var (fullName, age) = p1.GetPersonInfo();
            Utility.WriteMessage($"Full Name: {fullName}, Age: {age}");

            var (_, personAge) = p1.GetPersonInfo();
            Utility.WriteMessage($"Age: {personAge}");

            p1.Deconstruct(out string name, out int ageFromDeconstruct, out Person.EnumMaritalStatus maritalStatus);
            Utility.WriteMessage($"Name: {name}, Age: {ageFromDeconstruct}, Marital Status: {maritalStatus}");

            Utility.TerminateConsole();
        }
    }
}
