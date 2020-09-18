using Microsoft.EntityFrameworkCore.Migrations;

namespace NonoBlazor.Database.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StandardNonograms",
                columns: table => new
                {
                    StandardNonogramID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Width = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    RowValues = table.Column<string>(nullable: true),
                    ColumnValues = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardNonograms", x => x.StandardNonogramID);
                });

            migrationBuilder.InsertData(
                table: "StandardNonograms",
                columns: new[] { "StandardNonogramID", "ColumnValues", "Height", "RowValues", "Width" },
                values: new object[] { 1, "3,3,3,3,3,3,3,3,3,3", 10, "3,3,3,3,3,3,3,3,3,3", 10 });

            migrationBuilder.InsertData(
                table: "StandardNonograms",
                columns: new[] { "StandardNonogramID", "ColumnValues", "Height", "RowValues", "Width" },
                values: new object[] { 2, "3,3,3,3,3,3,3,3,3,3", 10, "3,3,3,3,3,3,3,3,3,3", 10 });

            migrationBuilder.InsertData(
                table: "StandardNonograms",
                columns: new[] { "StandardNonogramID", "ColumnValues", "Height", "RowValues", "Width" },
                values: new object[] { 3, "3,3,3,3,3,3,3,3,3,3", 10, "3,3,3,3,3,3,3,3,3,3", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StandardNonograms");
        }
    }
}
