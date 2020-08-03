using Microsoft.EntityFrameworkCore.Migrations;

namespace InsurancePolicy.Infrastructure.Data.Migrations
{
    public partial class MigrationInsurancePolicyv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "InsurancePolicies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "InsurancePolicies");
        }
    }
}
