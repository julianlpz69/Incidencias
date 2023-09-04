using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class TerceraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_matricul_persona_IdPersonaFK",
                table: "matricul");

            migrationBuilder.DropForeignKey(
                name: "FK_matricul_salon_IdSalonFk",
                table: "matricul");

            migrationBuilder.DropPrimaryKey(
                name: "PK_matricul",
                table: "matricul");

            migrationBuilder.RenameTable(
                name: "matricul",
                newName: "matricula");

            migrationBuilder.RenameIndex(
                name: "IX_matricul_IdSalonFk",
                table: "matricula",
                newName: "IX_matricula_IdSalonFk");

            migrationBuilder.RenameIndex(
                name: "IX_matricul_IdPersonaFK",
                table: "matricula",
                newName: "IX_matricula_IdPersonaFK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_matricula",
                table: "matricula",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_matricula_persona_IdPersonaFK",
                table: "matricula",
                column: "IdPersonaFK",
                principalTable: "persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_matricula_salon_IdSalonFk",
                table: "matricula",
                column: "IdSalonFk",
                principalTable: "salon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_matricula_persona_IdPersonaFK",
                table: "matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_matricula_salon_IdSalonFk",
                table: "matricula");

            migrationBuilder.DropPrimaryKey(
                name: "PK_matricula",
                table: "matricula");

            migrationBuilder.RenameTable(
                name: "matricula",
                newName: "matricul");

            migrationBuilder.RenameIndex(
                name: "IX_matricula_IdSalonFk",
                table: "matricul",
                newName: "IX_matricul_IdSalonFk");

            migrationBuilder.RenameIndex(
                name: "IX_matricula_IdPersonaFK",
                table: "matricul",
                newName: "IX_matricul_IdPersonaFK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_matricul",
                table: "matricul",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_matricul_persona_IdPersonaFK",
                table: "matricul",
                column: "IdPersonaFK",
                principalTable: "persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_matricul_salon_IdSalonFk",
                table: "matricul",
                column: "IdSalonFk",
                principalTable: "salon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
