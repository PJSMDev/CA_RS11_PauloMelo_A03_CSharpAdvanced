using System;
using System.Collections.Generic;
using D00_Utility;

namespace E04_FuncionalidadesRecentes
{
    public class Person
    {
        #region Enums
        public enum EnumMaritalStatus
        {
            Single,
            Married,
            Divorced,
            Widowed
        }

        public enum EnumEyeColor
        {
            Brown = 10,
            Green = 20,
            Blue = 5
        }

        public enum EnumHairColor
        {
            Brown,
            Black,
            White,
            Blond,
            Red
        }
        #endregion

        #region Properties

        public static int NextId { get; set; } = 1;
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public EnumMaritalStatus MaritalStatus { get; set; }

        #endregion

        #region Constructors

        public Person()
        {
            Id = 0;
            Name = string.Empty;
            Age = 0;
        }

        public Person(string name)
        {
            Id = NextId++;
            Name = name;
        }

        public Person(string name, EnumMaritalStatus maritalStatus)
        {
            Id = NextId++;
            Name = name;
            MaritalStatus = maritalStatus;
        }

        public Person(string name, int age)
        {
            Id = NextId++;
            Name = name;
            Age = age;
        }

        public Person(string name, int age, EnumMaritalStatus maritalStatus)
        {
            Id = NextId++;
            Name = name;
            Age = age;
            MaritalStatus = maritalStatus;
        }

        #endregion

        #region Methods

        public static void AddPerson(List<Person> listPerson)
        {
            Utility.WriteTitle("Person");

            Utility.WriteMessage("Name: ", "\n\n");
            string name = Console.ReadLine();

            Utility.WriteMessage("Marital status (Single, Married, Divorced, Widowed): ", "\n");
            string maritalStatus = Console.ReadLine();

            if (Enum.TryParse(maritalStatus, true, out EnumMaritalStatus status))
            {
                Person person = new Person(name, status);
                listPerson.Add(person);
                Utility.WriteMessage($"Person '{person.Name}' inserted successfully with ID '{person.Id}' and marital status '{person.MaritalStatus}'.", "\n\n", "\n");
            }
            else
            {
                Utility.WriteMessage("Invalid marital status entered,", "\n\n");
            }
        }

        public (string fullName, int age) GetPersonInfo()
        {
            return (Name, Age);
        }

        public void Deconstruct(out string name, out int age, out EnumMaritalStatus maritalStatus)
        {
            name = Name;
            age = Age;
            maritalStatus = MaritalStatus;
        }

        #endregion
    }
}
