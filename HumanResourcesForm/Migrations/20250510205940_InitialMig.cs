using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResourcesForm.Migrations
{
    /// <inheritdoc />
    public partial class InitialMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_FormId",
                table: "Contacts",
                column: "FormId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Forms_FormId",
                table: "Contacts",
                column: "FormId",
                principalTable: "Forms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Forms_FormId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_FormId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "FormId",
                table: "Contacts");
        }
    }
}
