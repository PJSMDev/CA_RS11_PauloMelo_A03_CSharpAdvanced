namespace D21_SOLID_05_DIP
{
    public class Employee : Person
    {

        #region Properties
        public string EmployeeId { get; set; }
        #endregion

        #region Constructors
        public Employee(string firstName, string lastName, int age, string employeeId)
            : base(firstName, lastName, age)
        {

            EmployeeId = employeeId;

        }
        #endregion

    }

}
