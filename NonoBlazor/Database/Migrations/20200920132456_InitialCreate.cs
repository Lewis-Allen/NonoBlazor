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
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                columns: new[] { "ID", "ColumnValues", "Height", "RowValues", "Width" },
                values: new object[] { 1, "3,1 3,5,3 1,3", 5, "3,1 3,5,3 1,3", 5 });

            migrationBuilder.InsertData(
                table: "StandardNonograms",
                columns: new[] { "ID", "ColumnValues", "Height", "RowValues", "Width" },
                values: new object[] { 2, "2,1 1,3 1,4,3", 5, "3,4,1 3,1 1,2", 5 });

            migrationBuilder.InsertData(
                table: "StandardNonograms",
                columns: new[] { "ID", "ColumnValues", "Height", "RowValues", "Width" },
                values: new object[] { 3, "7 1,7 2,6,5 1,4 1 2,1 1 3,4,1 5,3 5,3 6", 10, "6 1,5 2,5 3,5 1,4 1 1,3 1 3,2 1 4,5,1 6,2 6", 10 });

            migrationBuilder.InsertData(
                table: "StandardNonograms",
                columns: new[] { "ID", "ColumnValues", "Height", "RowValues", "Width" },
                values: new object[] { 4, "4,2 1,3 1,1 4 2,1 2 1,2 1 1,2 2,2,2,1", 10, "4,2 2,2 1,1 1,1 1,1 1,1 2,1 2 2,2 3,5", 10 });

            migrationBuilder.InsertData(
                table: "StandardNonograms",
                columns: new[] { "ID", "ColumnValues", "Height", "RowValues", "Width" },
                values: new object[] { 5, "2,1 1 1,1 2 3,1 1 6,1 1 1,1 2,2 1 1,2 1 2,3 3,5", 10, "4,2 2,1 1 1,3 1,2 1,1 2,1 1 1,3 1 2,2 1 3,9", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StandardNonograms");
        }
    }
}
