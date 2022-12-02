using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApexLegendsFinal.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                    name: "Role",
                    columns: table => new
                    {
                        RoleID = table.Column<int>(nullable: false)
                            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                        Name = table.Column<string>(nullable: false)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Roles", x => x.RoleID);
                    });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Ultimate = table.Column<string>(nullable: false),
                    Heirloom = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.CharacterID);
                    table.ForeignKey(
                        name: "FK_Chrcahters_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);

                });
            migrationBuilder.InsertData(
               table: "Roles",
               columns: new[] { "RoleId", "Name" },
               values: new object[] { 1, "Assault" });

            migrationBuilder.InsertData(
               table: "Roles",
               columns: new[] { "RoleId", "Name" },
               values: new object[] { 2, "Recon" });

            migrationBuilder.InsertData(
                   table: "Roles",
                   columns: new[] { "RoleId", "Name" },
                   values: new object[] { 3, "Fortified" });

            migrationBuilder.InsertData(
                   table: "Roles",
                   columns: new[] { "RoleId", "Name" },
                   values: new object[] { 4, "Support" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "RoleId", "Name", "Description", "Ultimate", "Heirloom" },
                values: new object[,]
                {
                    { 1, 1, "Wraith", "Interdementional Skirmisher", "Dimensional Rift", "Kunai" },
                    { 2, 1, "Bangalore", "Professional Soldier", "Rolling Thunder", "Cold Steel" },
                    { 3, 1, "Mirage", "Holographic Trickster", "Life of The Party", "" },
                    { 4, 1, "Octane", "High-Speed DareDevil", "Launch Pad", "" },
                    { 5, 1, "Revenant", "Synthetic Nightmare", "Death Totem", "" },
                    { 6, 1, "Horizon", "Gravity Manipulator", "Black Hole", "" },
                    { 7, 1, "Fuse", "Explosive Enthusiast", "The Motherload", "" },
                    { 8, 1, "Ash", "Inclusive Instigator", "Phase Breach", "" },
                    { 9, 1, "Mad Maggie", "Rebel Warlord", "Wreching Ball", "" },

                    { 10, 2, "BloodHound", "Technological Tracker", "Beast of the Hunt", "" },
                    { 11, 2, "Pathfinder", "Forward Scout", "ZipLine Gun", "" },
                    { 12, 2, "Crypto", "Surveillance Expert", "Drone EMP", "" },
                    { 13, 2, "Valkyrie", "Winged Avanger", "Skyward Dive", "" },
                    { 14, 2, "Seer", "Ambush Artist", "Exhibit", "" },
                    { 15, 2, "Vantage", "Survivalist Sniper", "Sniper's Mark", "" },

                    { 16, 3, "Gibraltar", "Shielded Fortress", "Defense Bombardment", "" },
                    { 17, 3, "Caustic", "Toxic Trapper", "Nox Gas Granade", "" },
                    { 18, 3, "Wattson", "Static Defender", "INterception Pylon", "" },
                    { 19, 3, "Rampart", "Base of Fire", "Mobile Minigun SHEILA", "" },
                    { 20, 3, "New Castle", "Mobile Guardian", "Castle Wall", "" },
                    { 21, 3, "Catalyst", "Defense Conjurer", "Dark Veil", "" },

                    { 22, 4, "Lifeline", "Combat Medic", "Care Package", "" },
                    { 23, 4, "Loba", "Translocating Thief", "Black Market Boutique", "" }
                });
            migrationBuilder.CreateIndex(

                name: "IX_Characters_CharacterID",
                table: "Characters",
                column: "RoleId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Characters");

            migrationBuilder.DropTable(name: "Roles");
        }
    }
}
