using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Subscribechecks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AdvertisingUpdates",
                table: "SubscribeEntities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DailyNewsletter",
                table: "SubscribeEntities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EventUpdates",
                table: "SubscribeEntities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Podcasts",
                table: "SubscribeEntities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "StartupsWeekly",
                table: "SubscribeEntities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "WeekInReview",
                table: "SubscribeEntities",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdvertisingUpdates",
                table: "SubscribeEntities");

            migrationBuilder.DropColumn(
                name: "DailyNewsletter",
                table: "SubscribeEntities");

            migrationBuilder.DropColumn(
                name: "EventUpdates",
                table: "SubscribeEntities");

            migrationBuilder.DropColumn(
                name: "Podcasts",
                table: "SubscribeEntities");

            migrationBuilder.DropColumn(
                name: "StartupsWeekly",
                table: "SubscribeEntities");

            migrationBuilder.DropColumn(
                name: "WeekInReview",
                table: "SubscribeEntities");
        }
    }
}
