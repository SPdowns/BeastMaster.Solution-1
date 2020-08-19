using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeastMaster.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Creatures",
                columns: table => new
                {
                    CreatureId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatureName = table.Column<string>(nullable: true),
                    CreatureOriginCulture = table.Column<string>(nullable: true),
                    CreatureOriginDate = table.Column<string>(nullable: true),
                    CreatureTaxonomy = table.Column<string>(nullable: true),
                    CreatureType = table.Column<string>(nullable: true),
                    CreatureAbility = table.Column<string>(nullable: true),
                    CreatureHabitat = table.Column<string>(nullable: true),
                    CreatureMorality = table.Column<string>(nullable: true),
                    CreatureDescription = table.Column<string>(nullable: true),
                    CreatureImage = table.Column<string>(nullable: true),
                    CreatureLifespan = table.Column<string>(nullable: true),
                    CreatureRelatedCreature = table.Column<string>(nullable: true),
                    CreatureNemesis = table.Column<string>(nullable: true),
                    CreatureWeakness = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creatures", x => x.CreatureId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Creatures");
        }
    }
}
