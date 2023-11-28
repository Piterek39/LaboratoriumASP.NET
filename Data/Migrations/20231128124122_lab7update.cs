using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class lab7update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f1b98af6-e052-4d11-920c-9ff1d6eb4d48", "049d7309-8cc0-420c-96cd-53f2423d702f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1b98af6-e052-4d11-920c-9ff1d6eb4d48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "049d7309-8cc0-420c-96cd-53f2423d702f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09c74fcd-eefa-4a18-9e38-cd0f2d09c53f", "09c74fcd-eefa-4a18-9e38-cd0f2d09c53f", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "92704b12-3de8-4aed-9478-0c578ce154eb", 0, "5cd74967-bed0-49a7-b780-5fb7d7f5bf3b", "adam@wsei.pl", true, false, null, "ADAM@WSEI.PL", null, "AQAAAAEAACcQAAAAELp4BRWhVFiOzHIkyRzCjnyXxH+XUsLR8sgKcDyzlbue5sgXgO6jyx1l6DWTEc1fIA==", null, false, "3034ea72-4c3e-4a8f-aae4-81840cf4aa3b", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09c74fcd-eefa-4a18-9e38-cd0f2d09c53f", "92704b12-3de8-4aed-9478-0c578ce154eb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09c74fcd-eefa-4a18-9e38-cd0f2d09c53f", "92704b12-3de8-4aed-9478-0c578ce154eb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09c74fcd-eefa-4a18-9e38-cd0f2d09c53f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92704b12-3de8-4aed-9478-0c578ce154eb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1b98af6-e052-4d11-920c-9ff1d6eb4d48", "f1b98af6-e052-4d11-920c-9ff1d6eb4d48", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "049d7309-8cc0-420c-96cd-53f2423d702f", 0, "560a880f-e37c-49bf-b088-f6b506e65126", "adam@wsei.pl", true, false, null, "ADAM@WSEI.PL", "ADAM@WSEI.PL", "AQAAAAEAACcQAAAAENibf/7eB2fi5wgf27XKFYHxzl4iLtLNjZLy3DaiKwWpBQxx6fkPsCdLr2qpHa6l1g==", null, false, "00496ade-cab9-4c92-bc3c-d10602938ddf", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f1b98af6-e052-4d11-920c-9ff1d6eb4d48", "049d7309-8cc0-420c-96cd-53f2423d702f" });
        }
    }
}
