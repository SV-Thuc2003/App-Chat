using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppChatBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEH2iJ+DZ1GbzxkVw1GE1x1IUgrC3Z6gKvMZwHWowb/8fp+6bVwAUV3TjewIvSTWAcw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEDPIb9P1Y0EhmG7ziXHFN0XG+K2Xyiuk6zIVFlGiAKa4XHhpuiqY9H1qnPhtyt6lvQ==");
        }
    }
}
