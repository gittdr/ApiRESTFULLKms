using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTdrKms.Migrations
{
    public partial class CreacionTablaDistancia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Distancia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Economico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaFin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distancia", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Distancia");
        }
    }
}
