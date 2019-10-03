using Microsoft.EntityFrameworkCore.Migrations;

namespace WellnessRoomTracker.Migrations
{
    public partial class SeedHistoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
migrationBuilder.Sql("insert into [RoomHistories] ([PersonId], [IsCheckin]) values (1,1);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
