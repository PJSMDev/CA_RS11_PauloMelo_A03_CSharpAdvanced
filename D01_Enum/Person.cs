using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D01_Enum
{
    internal class Person
    {

        #region Enums
        // Enums têm scope
        // Estes Enums só são relativos à Person, por isso fica aqui dentro
        // Enums por default são int e 0-based
        // O que fica guardado é o valor numérico, por trás da enumeração
        internal enum EnumMaritalStatus
        {
            Single,     // 0
            Married,    // 1
            Divorced,   // 2
            Widowed     // 3
        }

        internal enum EnumEyeColor
        {
            Brown = 10,     // 10
            Green = 20,     // 20
            Blue = 5        // 5
        }

        internal enum EnumHairColor
        {
            Brown,      // 0
            Black,      // 1
            White,      // 2
            Blond,      // 3
            Red         // 4
        }
        #endregion

        #region Properties

        internal static int NextId { get; set; } = 1;
        internal string Name { get; set; }
        internal int Id { get; set; }
        // É preciso criar uma propriedade para o Enum
        // A propriedade não pode ter o mesmo nome que o tipo de dados
        // ERRO: internal MaritalStatus MaritalStatus { get; set; }
        // É preferível manter o nome da Propriedade -> vai ser mais prático no futuro
        internal EnumMaritalStatus MaritalStatus { get; set; }
        #endregion

        #region Constructors

        internal Person()
        {
            Id = 0;
            Name = string.Empty;
        }

        internal Person(string name)
        {
            Id = NextId++;
            Name = name;
        }

        internal Person(string name, EnumMaritalStatus maritalStatus)
        {
            Id = NextId++;
            Name = name;
            MaritalStatus = maritalStatus;
        }

        #endregion

        #region Methods

        #region 1. AddPerson()

        internal static void AddPerson(List<Person> listPerson)
        {
            Utility.WriteTitle("Person");

            Utility.WriteMessage("Name: ", "\n\n");

            string name = Console.ReadLine();

            Utility.WriteMessage("Marital status (Single, Married, Divorced, Widowed): ", "\n");

            string maritalStatus = Console.ReadLine();

            // Validar de o input é correto de acordo com a enum
            // Sempre que validamos os valores dos inputs, devemos não guardar diretamente na propriedade
            // usar TryParse para validar enums
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

        #endregion

        #endregion

    }
}