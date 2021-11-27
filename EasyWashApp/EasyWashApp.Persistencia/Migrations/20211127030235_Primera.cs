using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyWashApp.Persistencia.Migrations
{
    public partial class Primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDocumento = table.Column<int>(type: "int", nullable: false),
                    Numdoc_per = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom_per = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fechanac_per = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edad_per = table.Column<int>(type: "int", nullable: false),
                    Tel1_per = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel2_per = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dir_per = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email_per = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eps_trab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arl_trab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaIng_trab = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFin_trab = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Usu_trab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pass_trab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_trab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porcen_trab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Roles = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
