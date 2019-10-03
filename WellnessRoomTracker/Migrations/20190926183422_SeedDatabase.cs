using Microsoft.EntityFrameworkCore.Migrations;

namespace WellnessRoomTracker.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "RoomHistory");

            migrationBuilder.AddColumn<bool>(
                name: "IsOccupied",
                table: "RoomHistory",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOccupied",
                table: "RoomHistory");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "RoomHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
