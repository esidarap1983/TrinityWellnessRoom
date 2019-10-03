using Microsoft.EntityFrameworkCore.Migrations;

namespace WellnessRoomTracker.Migrations
{
    public partial class RemoveTableWellnessRoomAndChangeStatusTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropColumn(
                name: "IsOccupied",
                table: "RoomHistory");

            migrationBuilder.AddColumn<bool>(
                name: "IsCheckin",
                table: "RoomHistory",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCheckin",
                table: "RoomHistory");

            migrationBuilder.AddColumn<bool>(
                name: "IsOccupied",
                table: "RoomHistory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WellnessRoomStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomHistory_WellnessRoomStatusId",
                        column: x => x.WellnessRoomStatusId,
                        principalTable: "RoomHistory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_WellnessRoomStatusId",
                table: "Rooms",
                column: "WellnessRoomStatusId");
        }
    }
}
