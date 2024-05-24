using System.Linq.Expressions;

namespace EmployeeCrud.Repositories.Contract
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetAll();
        T FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
