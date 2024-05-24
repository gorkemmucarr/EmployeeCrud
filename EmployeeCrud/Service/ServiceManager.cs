using EmployeeCrud.Service.Contract;

namespace EmployeeCrud.Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly IEmployeeService _employeeService;

        public ServiceManager(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IEmployeeService EmployeeService => _employeeService;
    }
}
