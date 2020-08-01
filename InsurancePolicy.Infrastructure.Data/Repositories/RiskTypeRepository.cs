using System.Collections.Generic;

namespace InsurancePolicy.Infrastructure.Data.Repositories
{
    using Domain.Interfaces;
    using Domain.Models;
    using Data.Context;

    public class RiskTypeRepository : IRiskTypeRepository
    {
        public InsurancePolicyDbContext _context;
        public RiskTypeRepository(InsurancePolicyDbContext context)
        {
            _context = context;
        }
        public IEnumerable<RiskType> GetRiskTypes()
        {
            throw new System.NotImplementedException();
        }
    }
}
