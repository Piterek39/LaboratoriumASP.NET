using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class OrganizationEntity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contacts_OrganizationEntity_OrganizationId",
                table: "contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrganizationEntity",
                table: "OrganizationEntity");

            migrationBuilder.RenameTable(
                name: "OrganizationEntity",
                newName: "Organizations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organizations",
                table: "Organizations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_contacts_Organizations_OrganizationId",
                table: "contacts",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contacts_Organizations_OrganizationId",
                table: "contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organizations",
                table: "Organizations");

            migrationBuilder.RenameTable(
                name: "Organizations",
                newName: "OrganizationEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrganizationEntity",
                table: "OrganizationEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_contacts_OrganizationEntity_OrganizationId",
                table: "contacts",
                column: "OrganizationId",
                principalTable: "OrganizationEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
