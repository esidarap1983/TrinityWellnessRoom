using Microsoft.EntityFrameworkCore.Migrations;

namespace WellnessRoomTracker.Migrations
{
    public partial class ChangePropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomHistory_Persons_PersonId",
                table: "RoomHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomHistory",
                table: "RoomHistory");

            migrationBuilder.RenameTable(
                name: "RoomHistory",
                newName: "RoomHistories");

            migrationBuilder.RenameIndex(
                name: "IX_RoomHistory_PersonId",
                table: "RoomHistories",
                newName: "IX_RoomHistories_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomHistories",
                table: "RoomHistories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomHistories_Persons_PersonId",
                table: "RoomHistories",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomHistories_Persons_PersonId",
                table: "RoomHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomHistories",
                table: "RoomHistories");

            migrationBuilder.RenameTable(
                name: "RoomHistories",
                newName: "RoomHistory");

            migrationBuilder.RenameIndex(
                name: "IX_RoomHistories_PersonId",
                table: "RoomHistory",
                newName: "IX_RoomHistory_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomHistory",
                table: "RoomHistory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomHistory_Persons_PersonId",
                table: "RoomHistory",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
