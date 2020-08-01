using System.Collections.Generic;

namespace InsurancePolicy.Infrastructure.Data.Repositories
{
    using Domain.Interfaces;
    using Domain.Models;
    using Data.Context;

    public class StatusTypeRepository : IStatusTypeRepository
    {
        public InsurancePolicyDbContext _context;
        public StatusTypeRepository(InsurancePolicyDbContext context)
        {
            _context = context;
        }
        public IEnumerable<StatusType> GetStatusTypes()
        {
            throw new System.NotImplementedException();
        }
    }
}
