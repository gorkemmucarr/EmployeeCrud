using EmployeeCrud.Dto;
using EmployeeCrud.Models;

namespace EmployeeCrud.Repositories.Contract
{
    public interface IEmployeeRepository :IRepositoryBase<Employee>
    {
        IQueryable<Employee> GetAllEmployees();
        Employee GetOneEmployee(int id);
        void CreateEmployee(Employee employee);
        void DeleteOneEmployee(Employee employee);
        void UpdateOneEmployee(Employee employee);
    }
}
