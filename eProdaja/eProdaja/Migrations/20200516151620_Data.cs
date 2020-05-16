using Microsoft.EntityFrameworkCore.Migrations;

namespace eProdaja.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VrsteProizvoda",
                columns: new[] { "VrstaID", "Naziv" },
                values: new object[] { 100, "Vjezbe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VrsteProizvoda",
                keyColumn: "VrstaID",
                keyValue: 100);
        }
    }
}
