using Microsoft.EntityFrameworkCore.Migrations;

namespace InsurancePolicy.Infrastructure.Data.Migrations
{
    public partial class MigrationInsurancePolicyv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusTypeID",
                table: "InsurancePolicies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusTypeID",
                table: "InsurancePolicies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
