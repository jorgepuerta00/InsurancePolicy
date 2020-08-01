using System.Collections.Generic;

namespace InsurancePolicy.Infrastructure.Data.Repositories
{
    using Domain.Interfaces;
    using Domain.Models;
    using Data.Context;

    public class InsurancePolicyRepository : IInsurancePolicyRepository
    {
        public InsurancePolicyDbContext _context;
        public InsurancePolicyRepository(InsurancePolicyDbContext context)
        {
            _context = context;
        }
        public IEnumerable<InsurancePolicy> GetInsurancePolicies()
        {
            throw new System.NotImplementedException();
        }
    }
}
