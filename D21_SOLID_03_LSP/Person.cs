/*
    SOLID
    LSP
    Liskov Substitution Principle
    
    Classes derivadas devem ser substituíveis pelas classes base

    Exemplo: criar a classe Employee que herda de Person e mantém o comportamento
*/

namespace D21_SOLID_03_LSP
{
    public interface IPersonRepository
    {
        void AddPerson(Person person);
        Person GetPerson(string firstName, string lastName);
    }

    public interface IEmployeeRepository
    {
        void AddEmployee(Employee employee);
        Employee GetEmployee(string employeeId);
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

    public class Employee : Person
    {
        public string EmployeeId { get; set; }

        public Employee(string firstName, string lastName, int age, string employeeId)
            : base(firstName, lastName, age)
        {
            EmployeeId = employeeId;
        }
    }
}
