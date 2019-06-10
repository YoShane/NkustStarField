using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentManagement.Migrations
{
    public partial class remarkCStr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "BorrowRecord",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Remark",
                table: "BorrowRecord",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
