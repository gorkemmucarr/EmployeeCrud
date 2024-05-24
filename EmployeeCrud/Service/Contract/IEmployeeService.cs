using EmployeeCrud.Dto;
using EmployeeCrud.Models;

namespace EmployeeCrud.Service.Contract
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployee();
        Employee GetOneEmployee(int id);
        void CreateEmployee(EmployeeDto employeeDto);
        void UpdateEmployee(EmployeeDto employeeDto);
        void DeleteOneEmployee(int id);
    }
}
