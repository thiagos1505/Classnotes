using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Classnotes.Migrations
{
    /// <inheritdoc />
    public partial class M08UpdateUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professor_Endereco_EnderecoUsuarioEnderecoId",
                table: "Professor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Professor",
                table: "Professor");

            migrationBuilder.RenameTable(
                name: "Professor",
                newName: "Usuarios");

            migrationBuilder.RenameIndex(
                name: "IX_Professor_EnderecoUsuarioEnderecoId",
                table: "Usuarios",
                newName: "IX_Usuarios_EnderecoUsuarioEnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Endereco_EnderecoUsuarioEnderecoId",
                table: "Usuarios",
                column: "EnderecoUsuarioEnderecoId",
                principalTable: "Endereco",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Endereco_EnderecoUsuarioEnderecoId",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Professor");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_EnderecoUsuarioEnderecoId",
                table: "Professor",
                newName: "IX_Professor_EnderecoUsuarioEnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Professor",
                table: "Professor",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Professor_Endereco_EnderecoUsuarioEnderecoId",
                table: "Professor",
                column: "EnderecoUsuarioEnderecoId",
                principalTable: "Endereco",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
