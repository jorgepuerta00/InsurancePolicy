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

        public void CreateCoverageTypes(CoverageType coverageType)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCoverageTypes(CoverageType coverageType)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<InsurancePolicy> GetInsurancePolicies()
        {
            return _context.InsurancePolicies;
        }

        public void UpdateCoverageTypes(CoverageType coverageType)
        {
            throw new System.NotImplementedException();
        }
    }
}
