using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentManagement.Data.Migrations
{
    public partial class hotmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hot_mail",
                table: "Member",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hot_mail",
                table: "Member");
        }
    }
}
