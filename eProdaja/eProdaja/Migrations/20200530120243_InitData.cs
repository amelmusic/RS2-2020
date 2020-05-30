using Microsoft.EntityFrameworkCore.Migrations;

namespace eProdaja.Migrations
{
    public partial class InitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "JediniceMjere",
                columns: new[] { "JedinicaMjereID", "Naziv" },
                values: new object[] { 1, "Test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JediniceMjere",
                keyColumn: "JedinicaMjereID",
                keyValue: 1);
        }
    }
}
