using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XOPOW.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Morodci",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    LOLRank = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Term = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Morodci", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Morodci",
                columns: new[] { "Id", "Address", "Date", "LOLRank", "Name", "Size", "Term" },
                values: new object[] { 1, "Do Pískovny 420 Mníšek", new DateTime(2001, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ajron třy", "Rodec", 14, "Naní chálec jako chálec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Morodci");
        }
    }
}
