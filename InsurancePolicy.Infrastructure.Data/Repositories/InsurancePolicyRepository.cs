namespace InsurancePolicy.Infrastructure.Data.Repositories
{
    using Domain.Interfaces;
    using Domain.Models;
    using Data.Context;
    using System.Collections.Generic;

    public class InsurancePolicyRepository : IInsurancePolicyRepository
    {
        public InsurancePolicyDbContext _context;
        public InsurancePolicyRepository(InsurancePolicyDbContext context)
        {
            _context = context;
        }
        public IEnumerable<InsurancePolicy> GetInsurancePolicies()
        {
            return _context.InsurancePolicies;

        }
    }
}
