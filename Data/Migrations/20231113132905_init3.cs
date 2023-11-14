using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Priority",
                table: "contacts",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Created", "Priority" },
                values: new object[] { new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low" });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Created", "Priority" },
                values: new object[] { new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Priority",
                table: "contacts",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Created", "Priority" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Created", "Priority" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });
        }
    }
}
