using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentManagement.Migrations
{
    public partial class changeRecordKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BorrowRecord",
                table: "BorrowRecord");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "BorrowRecord",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BorrowRecord",
                table: "BorrowRecord",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowRecord_Order_id",
                table: "BorrowRecord",
                column: "Order_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BorrowRecord",
                table: "BorrowRecord");

            migrationBuilder.DropIndex(
                name: "IX_BorrowRecord_Order_id",
                table: "BorrowRecord");

            migrationBuilder.DropColumn(
                name: "id",
                table: "BorrowRecord");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BorrowRecord",
                table: "BorrowRecord",
                column: "Order_id");
        }
    }
}
