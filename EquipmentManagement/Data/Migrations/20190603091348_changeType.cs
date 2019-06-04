using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentManagement.Data.Migrations
{
    public partial class changeType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Member_fee",
                table: "Member",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "Special",
                table: "Equipment",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Member_fee",
                table: "Member",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "Special",
                table: "Equipment",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
