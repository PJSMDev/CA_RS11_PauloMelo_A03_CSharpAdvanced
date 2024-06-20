using System.Collections.Generic;
using System.Linq;

namespace D21_SOLID_05_DIP
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public Employee GetEmployee(string employeeId)
        {
            return _employees.FirstOrDefault(e => e.EmployeeId == employeeId);
        }
    }
}
