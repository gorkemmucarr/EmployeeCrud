using EmployeeCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeCrud.Config
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(new Employee()
            {
                EmployeeId = 1,
                Firstname = "Görkem",
                Lastname = "Uçar",
                Deparment = "Software Developer",
                Address = "İzmir"
            },
                new Employee()
                {
                    EmployeeId = 2,
                    Firstname = "Ali",
                    Lastname = "Al",
                    Deparment = "IT",
                    Address = "Ankara"
                },
                new Employee()
                {
                    EmployeeId = 3,
                    Firstname = "Deniz",
                    Lastname = "Dağ",
                    Deparment = "IT",
                    Address = "Ankara"
                },
                new Employee()
                {
                    EmployeeId = 4,
                    Firstname = "Cemre",
                    Lastname = "Kaya",
                    Deparment = "Software Developer",
                    Address = "Antalya"
                },
                new Employee()
                {
                    EmployeeId = 5,
                    Firstname = "Ahmet",
                    Lastname = "Uzun",
                    Deparment = "IT",
                    Address = "Bursa"
                });
        }
    }
}
