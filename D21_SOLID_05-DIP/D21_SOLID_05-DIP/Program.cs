using D00_Utility;

namespace D21_SOLID_05_DIP
{

    internal class Program
    {
    
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            // Repositories
            IPersonRepository personRepository = new PersonRepository();
            INameFormatter nameFormatter = new FullNameFormatter();
            PersonService personService = new PersonService(personRepository, nameFormatter);
            IEmployeeRepository employeeRepository = new EmployeeRepository();
            EmployeeService employeeService = new EmployeeService(employeeRepository, nameFormatter);

            // Add person
            Person person = new Person("Milena", "Reis e Sousa", 56);
            personService.AddPerson(person);

            // Get person formatted name
            string formattedName = personService.GetFormattedName("Milena", "Reis e Sousa");
            Utility.WriteTitle("Person");
            Utility.WriteMessage($"Formatted person name: {formattedName}", "", "\n\n");

            // Add employee
            Employee employee = new Employee("Paulo", "Silva Melo", 36, "01");
            employeeService.AddEmployee(employee);

            // Get employee formatted name
            string formattedEmployeeName = employeeService.GetFormattedName("01");
            Utility.WriteTitle("Employee");
            Utility.WriteMessage($"Formatted employee name: {formattedEmployeeName}");

            Utility.TerminateConsole();

        }

    }

}
