using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WellnessRoomTracker.Migrations
{
    public partial class AddTimeToRoomHistriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ChangedTime",
                table: "RoomHistries",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChangedTime",
                table: "RoomHistries");
        }
    }
}
