using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cifralite.Web.Core.Data.Migrations.Sqlite
{
    /// <inheritdoc />
    public partial class MigracaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: false),
                    Artista = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Tempo = table.Column<int>(type: "INTEGER", nullable: false),
                    Tom = table.Column<string>(type: "TEXT", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Secoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Acordes = table.Column<string>(type: "TEXT", nullable: false),
                    IdMusica = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Secoes_Musicas_IdMusica",
                        column: x => x.IdMusica,
                        principalTable: "Musicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Secoes_IdMusica",
                table: "Secoes",
                column: "IdMusica");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Secoes");

            migrationBuilder.DropTable(
                name: "Musicas");
        }
    }
}
