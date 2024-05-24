using EmployeeCrud.Repositories.Contract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EmployeeCrud.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, new()
    {
        private readonly RepositoryContext _context;

        public RepositoryBase(RepositoryContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public T FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).AsNoTracking().SingleOrDefault();
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
