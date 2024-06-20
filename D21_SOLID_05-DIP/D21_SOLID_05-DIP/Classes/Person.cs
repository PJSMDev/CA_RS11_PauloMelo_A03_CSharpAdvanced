/*
    SOLID
    DIP
    Dependency Inversion Principle (DIP)

    As classes devem depender de abstrações, não de classes concretas

    Exemplo: criar a classe PersonService que depende de interfaces para realizar operações
*/

namespace D21_SOLID_05_DIP
{

    public class Person
    {

        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        #endregion

        #region Constructor
        public Person(string firstName, string lastName, int age)
        {

            FirstName = firstName;
            LastName = lastName;
            Age = age;

        }
        #endregion

    }

}
