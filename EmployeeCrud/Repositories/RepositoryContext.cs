using EmployeeCrud.Config;
using EmployeeCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrud.Repositories
{
    public class RepositoryContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EmployeeConfig());
        }
    }
}
