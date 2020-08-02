namespace InsurancePolicy.Infrastructure.Data.Repositories
{
    using Domain.Interfaces;
    using Domain.Models;
    using Data.Context;
    using System.Collections.Generic;

    public class CoverageTypeRepository : ICoverageTypeRepository
    {
        public InsurancePolicyDbContext _context;
        public CoverageTypeRepository(InsurancePolicyDbContext context)
        {
            _context = context;
        }

        public void CreateCoverageTypes(CoverageType coverageType)
        {
            using (_context)
            {
                _context.CoverageTypes.Add(coverageType);
                _context.SaveChanges();
            }
        }

        public void DeleteCoverageTypes(CoverageType coverageType)
        {
            using (_context)
            {
                _context.CoverageTypes.Remove(coverageType);
                _context.SaveChanges();
            }
        }

        public IEnumerable<CoverageType> GetCoverageTypes()
        {
            return _context.CoverageTypes;
        }

        public void UpdateCoverageTypes(CoverageType coverageType)
        {
            using (_context)
            {
                _context.CoverageTypes.Add(coverageType);
                _context.SaveChanges();
            }
        }
    }
}
