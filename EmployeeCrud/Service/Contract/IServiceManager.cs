namespace EmployeeCrud.Service.Contract
{
    public interface IServiceManager
    {
        IEmployeeService EmployeeService { get; }
    }
}
