/*
    SOLID
    OCP
    Open/Closed Principle
    
    As classes devem estar abertas para extensão, mas fechadas para modificação
    
    Exemplo: criar uma classe com um método para formatar o nome de uma pessoa e permitir que essa funcionalidade seja estendida
*/

namespace D21_SOLID_02_OCP
{

    public interface INameFormatter 
    {
        string FormatName(Person person);
    }

    public class FullNameFormatter : INameFormatter
    {

        public string FormatName(Person person)
        {
            return $"{person.FirstName} {person.LastName}";
        }
    }

    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age) 
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
