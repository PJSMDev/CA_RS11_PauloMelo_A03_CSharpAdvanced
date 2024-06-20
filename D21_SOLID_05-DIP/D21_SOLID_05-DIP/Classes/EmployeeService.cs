namespace D21_SOLID_05_DIP
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly INameFormatter _nameFormatter;

        public EmployeeService(IEmployeeRepository employeeRepository, INameFormatter nameFormatter)
        {
            _employeeRepository = employeeRepository;
            _nameFormatter = nameFormatter;
        }

        public void AddEmployee(Employee employee)
        {
            _employeeRepository.AddEmployee(employee);
        }

        public string GetFormattedName(string employeeId)
        {
            var employee = _employeeRepository.GetEmployee(employeeId);
            return _nameFormatter.FormatName(employee);
        }
    }
}
