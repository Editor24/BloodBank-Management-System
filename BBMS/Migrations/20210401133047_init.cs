using Microsoft.EntityFrameworkCore.Migrations;

namespace BBMS.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PetientDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientName = table.Column<string>(nullable: true),
                    PatientAge = table.Column<int>(nullable: false),
                    Disease = table.Column<string>(nullable: true),
                    BloodGroupId = table.Column<int>(nullable: false),
                    Unit = table.Column<int>(nullable: false),
                    RequestStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetientDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetientDetails");
        }
    }
}
