using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityByExamples.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6e08078-55e3-45c7-b24c-be1a05b6c690", "8ee5f3c6-1415-4bbc-8c1e-0dddcc39d8dd", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "802abbfb-3173-40eb-a309-08e4dc683a6a", "ce230b0c-a88b-403e-92db-bca761194fcf", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "802abbfb-3173-40eb-a309-08e4dc683a6a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6e08078-55e3-45c7-b24c-be1a05b6c690");
        }
    }
}
