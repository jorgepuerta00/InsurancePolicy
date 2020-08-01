using Microsoft.EntityFrameworkCore;

namespace InsurancePolicy.Infrastructure.Data.Context
{
    using Domain.Models;
    public class InsurancePolicyDbContext : DbContext
    {
        public InsurancePolicyDbContext(DbContextOptions options) : base(options) { }
        public DbSet<InsurancePolicy> InsurancePolicies { get; set; }
        public DbSet<CoverageType> CoverageTypes { get; set; }
        public DbSet<RiskType> RiskTypes { get; set; }
        public DbSet<StatusType> StatusTypes { get; set; }
    }
}
