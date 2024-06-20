/*
    SOLID
    SRP
    Single Responsibility Principle
    
    A classe Person deve ter apenas uma responsabilidade: guardar os dados de uma pessoa
*/

namespace D21_SOLID_01_SRP
{
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
