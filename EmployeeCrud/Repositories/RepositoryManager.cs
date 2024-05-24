using EmployeeCrud.Repositories.Contract;

namespace EmployeeCrud.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IEmployeeRepository _employeeRepository;

        public RepositoryManager(
            RepositoryContext context,
            IEmployeeRepository employeeRepository)
        {
            _context = context;
            _employeeRepository = employeeRepository;
        }

        public IEmployeeRepository EmployeeRepository => _employeeRepository;
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
