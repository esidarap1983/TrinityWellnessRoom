using Microsoft.EntityFrameworkCore.Migrations;

namespace WellnessRoomTracker.Migrations
{
    public partial class ChangeRoomHistriesTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomHistories_Persons_PersonId",
                table: "RoomHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomHistories",
                table: "RoomHistories");

            migrationBuilder.RenameTable(
                name: "RoomHistories",
                newName: "RoomHistries");

            migrationBuilder.RenameIndex(
                name: "IX_RoomHistories_PersonId",
                table: "RoomHistries",
                newName: "IX_RoomHistries_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomHistries",
                table: "RoomHistries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomHistries_Persons_PersonId",
                table: "RoomHistries",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomHistries_Persons_PersonId",
                table: "RoomHistries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomHistries",
                table: "RoomHistries");

            migrationBuilder.RenameTable(
                name: "RoomHistries",
                newName: "RoomHistories");

            migrationBuilder.RenameIndex(
                name: "IX_RoomHistries_PersonId",
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
    }
}
