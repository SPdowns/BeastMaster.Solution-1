using Microsoft.EntityFrameworkCore.Migrations;

namespace BeastMaster.Migrations
{
    public partial class Secondary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Creatures");

            migrationBuilder.InsertData(
                table: "Creatures",
                columns: new[] { "CreatureId", "CreatureAbility", "CreatureDescription", "CreatureHabitat", "CreatureImage", "CreatureLifespan", "CreatureMorality", "CreatureName", "CreatureNemesis", "CreatureOriginCulture", "CreatureOriginDate", "CreatureRelatedCreature", "CreatureTaxonomy", "CreatureType", "CreatureWeakness" },
                values: new object[] { 1, "Fire-Breathing", "this is my description of Matilda the fire-breathing kid", "Chokey", "http://wwww.dummyurl.com", "86", "good", "Matilda", "mom and dad", null, "1996", "None", "Human", "Little girl", "water" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Creatures",
                nullable: true);
        }
    }
}
