using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CEP.Migrations
{
    public partial class Cep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cep",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CepCep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ibge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ddd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Siafi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cep", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cep");
        }
    }
}
