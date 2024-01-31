using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace RgCms.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PontosDeInteresse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(160)", maxLength: 160, nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    SubCategoria = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "longtext", nullable: false),
                    Bairro = table.Column<string>(type: "longtext", nullable: false),
                    Cep = table.Column<string>(type: "longtext", nullable: false),
                    Latitude = table.Column<float>(type: "float", nullable: false),
                    Longitude = table.Column<float>(type: "float", nullable: false),
                    Telefone = table.Column<long>(type: "bigint", nullable: false),
                    WhatsApp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TelefoneFixo = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PontosDeInteresse", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Fotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Url = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    PontoDeInteresseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fotos_PontosDeInteresse_PontoDeInteresseID",
                        column: x => x.PontoDeInteresseID,
                        principalTable: "PontosDeInteresse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RedesSociais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "longtext", nullable: true),
                    PontoDeInteresseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedesSociais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RedesSociais_PontosDeInteresse_PontoDeInteresseID",
                        column: x => x.PontoDeInteresseID,
                        principalTable: "PontosDeInteresse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_PontoDeInteresseID",
                table: "Fotos",
                column: "PontoDeInteresseID");

            migrationBuilder.CreateIndex(
                name: "IX_RedesSociais_PontoDeInteresseID",
                table: "RedesSociais",
                column: "PontoDeInteresseID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fotos");

            migrationBuilder.DropTable(
                name: "RedesSociais");

            migrationBuilder.DropTable(
                name: "PontosDeInteresse");
        }
    }
}
