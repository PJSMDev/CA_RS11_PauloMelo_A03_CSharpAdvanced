namespace D21_SOLID_05_DIP
{

    public interface IEmployeeRepository
    {

        void AddEmployee(Employee employee);

        Employee GetEmployee(string employeeId);

    }

}
