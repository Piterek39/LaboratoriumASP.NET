using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PostData.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatePost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Content = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Autor = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    postdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Tag = table.Column<string>(type: "TEXT", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "posts",
                columns: new[] { "id", "Autor", "Comment", "Content", "postdate", "Tag" },
                values: new object[,]
                {
                    { 1, "adam@wsei.edu.pl", "ciekawy post", "Pierwszy post", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "#pierwszypost" },
                    { 2, "elon@wsei.edu.pl", "nudny post", "Drugi post", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "#drugipost" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "posts");
        }
    }
}
