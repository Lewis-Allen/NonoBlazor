using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NonoBlazor.Database.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StandardNonograms",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PublicID = table.Column<Guid>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    RowValues = table.Column<string>(nullable: true),
                    ColumnValues = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardNonograms", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "StandardNonograms",
                columns: new[] { "ID", "ColumnValues", "Height", "PublicID", "RowValues", "Width" },
                values: new object[] { 1, "3,3,3,3,3,3,3,3,3,3", 10, new Guid("cc5f50ad-3c3c-452c-8d9f-43396b46664b"), "3,3,3,3,3,3,3,3,3,3", 10 });

            migrationBuilder.InsertData(
                table: "StandardNonograms",
                columns: new[] { "ID", "ColumnValues", "Height", "PublicID", "RowValues", "Width" },
                values: new object[] { 2, "3,3,3,3,3,3,3,3,3,3", 10, new Guid("ea6ef215-d7e1-4f82-8cd4-b83e56e8c40d"), "3,3,3,3,3,3,3,3,3,3", 10 });

            migrationBuilder.InsertData(
                table: "StandardNonograms",
                columns: new[] { "ID", "ColumnValues", "Height", "PublicID", "RowValues", "Width" },
                values: new object[] { 3, "3,3,3,3,3,3,3,3,3,3", 10, new Guid("8d1388be-25d0-40b5-b7aa-8c204dea4247"), "3,3,3,3,3,3,3,3,3,3", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StandardNonograms");
        }
    }
}
