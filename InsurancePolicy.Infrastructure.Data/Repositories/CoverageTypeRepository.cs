﻿namespace InsurancePolicy.Infrastructure.Data.Repositories
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
        public IEnumerable<CoverageType> GetCoverageTypes()
        {
            return _context.CoverageTypes;
        }
    }
}
