namespace InsurancePolicy.XUnitTest.Core
{
    using Infrastructure.Data.Repositories;
    using Infrastructure.Data.Context;
    using Microsoft.EntityFrameworkCore;
    using System.Configuration;

    public class InsurancePolicyTestController
    {
        private InsurancePolicyRepository repository;
        public static DbContextOptions<InsurancePolicyDbContext> dbContextOptions { get; }
        public static string connectionString = ConfigurationManager.ConnectionStrings["InsurancePolicyConnection"].ConnectionString;

        static InsurancePolicyTestController()
        {
            dbContextOptions = new DbContextOptionsBuilder<InsurancePolicyDbContext>()
                .UseSqlServer(connectionString)
                .Options;
        }

        public InsurancePolicyTestController()
        {
            var context = new InsurancePolicyDbContext(dbContextOptions);
            SeedDataDBInitializer db = new SeedDataDBInitializer();
            db.Seed(context);

            repository = new InsurancePolicyRepository(context);
        }

    }
}
