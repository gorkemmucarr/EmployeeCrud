using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCrud.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deparment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "Deparment", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { 1, "İzmir", "Software Developer", "Görkem", "Uçar" },
                    { 2, "Ankara", "IT", "Ali", "Al" },
                    { 3, "Ankara", "IT", "Deniz", "Dağ" },
                    { 4, "Antalya", "Software Developer", "Cemre", "Kaya" },
                    { 5, "Bursa", "IT", "Ahmet", "Uzun" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
