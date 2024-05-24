namespace EmployeeCrud.Repositories.Contract
{
    public interface IRepositoryManager
    {
        IEmployeeRepository EmployeeRepository { get; }
        void Save();
    }
}
