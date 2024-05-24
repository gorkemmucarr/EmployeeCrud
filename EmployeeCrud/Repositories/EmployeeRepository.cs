using EmployeeCrud.Dto;
using EmployeeCrud.Models;
using EmployeeCrud.Repositories.Contract;
using System.Linq.Expressions;

namespace EmployeeCrud.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateEmployee(Employee employee) => Create(employee);


        public void DeleteOneEmployee(Employee employee) => Delete(employee);


        public IQueryable<Employee> GetAllEmployees() => GetAll();
        

        public Employee GetOneEmployee(int id)
        {
            return FindByCondition(p => p.EmployeeId.Equals(id));
        }

        public void UpdateOneEmployee(Employee employee) => Update(employee);
        
    }
}
