using Microsoft.EntityFrameworkCore.Migrations;

namespace WellnessRoomTracker.Migrations
{
    public partial class SeedPersonTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
migrationBuilder.Sql("insert into persons (name) values ('Weifen Qiu');");
migrationBuilder.Sql("insert into persons (name) values ('Anu Krishnan');");
migrationBuilder.Sql("insert into persons (name) values ('Terry Ann Garcia');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
