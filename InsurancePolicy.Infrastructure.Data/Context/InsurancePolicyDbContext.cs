namespace InsurancePolicy.Infrastructure.Data.Context
{
    using Domain.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class InsurancePolicyDbContext : DbContext, IDbContext
    {
        public InsurancePolicyDbContext(DbContextOptions options) : base(options) { }
        public DbSet<InsurancePolicy> InsurancePolicies { get; set; }
        public DbSet<CoverageType> CoverageTypes { get; set; }
        public DbSet<RiskType> RiskTypes { get; set; }
        public DbSet<StatusType> StatusTypes { get; set; }
        IQueryable<T> IDbContext.Set<T>()
        {
            return base.Set<T>();
        }
    }
}
