using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDatos.Migrations
{
    /// <inheritdoc />
    public partial class Algunasrelaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SocioCliente",
                table: "Cliente",
                newName: "EsSocio");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Prestamo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPersona",
                table: "Cliente",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAutor",
                table: "AutorLibro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdLibro",
                table: "AutorLibro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPersona",
                table: "Autor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_IdCliente",
                table: "Prestamo",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdPersona",
                table: "Cliente",
                column: "IdPersona",
                unique: true,
                filter: "[IdPersona] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AutorLibro_IdAutor",
                table: "AutorLibro",
                column: "IdAutor");

            migrationBuilder.CreateIndex(
                name: "IX_AutorLibro_IdLibro",
                table: "AutorLibro",
                column: "IdLibro");

            migrationBuilder.CreateIndex(
                name: "IX_Autor_IdPersona",
                table: "Autor",
                column: "IdPersona",
                unique: true,
                filter: "[IdPersona] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Autor_Persona_IdPersona",
                table: "Autor",
                column: "IdPersona",
                principalTable: "Persona",
                principalColumn: "IdPersona");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLibro_Autor_IdAutor",
                table: "AutorLibro",
                column: "IdAutor",
                principalTable: "Autor",
                principalColumn: "IdAutor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLibro_Libro_IdLibro",
                table: "AutorLibro",
                column: "IdLibro",
                principalTable: "Libro",
                principalColumn: "IdLibro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Persona_IdPersona",
                table: "Cliente",
                column: "IdPersona",
                principalTable: "Persona",
                principalColumn: "IdPersona");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_Cliente_IdCliente",
                table: "Prestamo",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autor_Persona_IdPersona",
                table: "Autor");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorLibro_Autor_IdAutor",
                table: "AutorLibro");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorLibro_Libro_IdLibro",
                table: "AutorLibro");

            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Persona_IdPersona",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_Cliente_IdCliente",
                table: "Prestamo");

            migrationBuilder.DropIndex(
                name: "IX_Prestamo_IdCliente",
                table: "Prestamo");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_IdPersona",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_AutorLibro_IdAutor",
                table: "AutorLibro");

            migrationBuilder.DropIndex(
                name: "IX_AutorLibro_IdLibro",
                table: "AutorLibro");

            migrationBuilder.DropIndex(
                name: "IX_Autor_IdPersona",
                table: "Autor");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Prestamo");

            migrationBuilder.DropColumn(
                name: "IdPersona",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "IdAutor",
                table: "AutorLibro");

            migrationBuilder.DropColumn(
                name: "IdLibro",
                table: "AutorLibro");

            migrationBuilder.DropColumn(
                name: "IdPersona",
                table: "Autor");

            migrationBuilder.RenameColumn(
                name: "EsSocio",
                table: "Cliente",
                newName: "SocioCliente");
        }
    }
}
