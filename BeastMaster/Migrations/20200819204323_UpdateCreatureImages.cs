using Microsoft.EntityFrameworkCore.Migrations;

namespace BeastMaster.Migrations
{
    public partial class UpdateCreatureImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 5,
                column: "CreatureImage",
                value: "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/hippogryph.jpg");

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 9,
                column: "CreatureImage",
                value: "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/satyr.jpg");

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 10,
                column: "CreatureImage",
                value: "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/shadow-person.jpg");

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 11,
                column: "CreatureImage",
                value: "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/shug-monkey.jpg");

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 12,
                column: "CreatureImage",
                value: "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/sirin.jpg");

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 13,
                column: "CreatureImage",
                value: "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/skin-walker.jpg");

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 14,
                column: "CreatureImage",
                value: "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/alicorn.jpg");

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 15,
                column: "CreatureImage",
                value: "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/angel.jpg");

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 16,
                column: "CreatureImage",
                value: "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/aphrodite.jpg");

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 32,
                column: "CreatureImage",
                value: "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/gorgon.jpg");

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 33,
                column: "CreatureImage",
                value: "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/gremlin.jpg");

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 34,
                column: "CreatureImage",
                value: "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/griffin.jpg");

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 45,
                column: "CreatureImage",
                value: "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/vampire.jpg");

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 49,
                column: "CreatureImage",
                value: "https://coding-assets.s3-us-west-2.amazonaws.com/BeastMaster/zombie.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 5,
                column: "CreatureImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 9,
                column: "CreatureImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 10,
                column: "CreatureImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 11,
                column: "CreatureImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 12,
                column: "CreatureImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 13,
                column: "CreatureImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 14,
                column: "CreatureImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 15,
                column: "CreatureImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 16,
                column: "CreatureImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 32,
                column: "CreatureImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 33,
                column: "CreatureImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 34,
                column: "CreatureImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 45,
                column: "CreatureImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 49,
                column: "CreatureImage",
                value: null);
        }
    }
}
