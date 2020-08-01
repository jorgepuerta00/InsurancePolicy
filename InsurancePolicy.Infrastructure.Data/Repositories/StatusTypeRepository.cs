namespace InsurancePolicy.Infrastructure.Data.Repositories
{
    using Domain.Interfaces;
    using Domain.Models;
    using Data.Context;
    using System.Collections.Generic;

    public class StatusTypeRepository : IStatusTypeRepository
    {
        public InsurancePolicyDbContext _context;
        public StatusTypeRepository(InsurancePolicyDbContext context)
        {
            _context = context;
        }
        public IEnumerable<StatusType> GetStatusTypes()
        {
            return _context.StatusTypes;
        }
    }
}
