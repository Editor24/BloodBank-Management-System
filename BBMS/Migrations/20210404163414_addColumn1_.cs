using Microsoft.EntityFrameworkCore.Migrations;

namespace BBMS.Migrations
{
    public partial class addColumn1_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DonortName",
                table: "DonorDetails");

            migrationBuilder.AddColumn<string>(
                name: "DonorName",
                table: "DonorDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DonorName",
                table: "DonorDetails");

            migrationBuilder.AddColumn<string>(
                name: "DonortName",
                table: "DonorDetails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
