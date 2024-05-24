using EmployeeCrud.Dto;
using EmployeeCrud.Models;
using EmployeeCrud.Repositories.Contract;
using EmployeeCrud.Service.Contract;

namespace EmployeeCrud.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepositoryManager _manager;

        public EmployeeService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateEmployee(EmployeeDto employeeDto)
        {
            Employee employee = new Employee()
            {
                Firstname = employeeDto.Firstname,
                Lastname = employeeDto.Lastname,
                Address = employeeDto.Address,
                Deparment= employeeDto.Deparment
            };
            _manager.EmployeeRepository.Create(employee);
            _manager.Save();
        }

        public void DeleteOneEmployee(int id)
        {
            var employee = _manager.EmployeeRepository.GetOneEmployee(id);
            if (employee is not null)
            {
                _manager.EmployeeRepository.Delete(employee);
                _manager.Save();
            }
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            var employees = _manager.EmployeeRepository.GetAllEmployees();
            return employees;
        }

        public Employee GetOneEmployee(int id)
        {
            var employee = _manager.EmployeeRepository.GetOneEmployee(id);
            if (employee is null)
            {
                throw new Exception("Employee could not found");
            }
            return employee;
        }

        public void UpdateEmployee(EmployeeDto employeeDto)
        {
            var employee = _manager.EmployeeRepository.GetOneEmployee(employeeDto.EmployeeId);
            employee.Firstname = employeeDto.Firstname;
            employee.Lastname = employeeDto.Lastname;
            employee.Address = employeeDto.Address;
            employee.Deparment = employeeDto.Deparment;

            _manager.EmployeeRepository.Update(employee);
            _manager.Save();
        }
    }
}
