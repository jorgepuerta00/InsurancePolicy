namespace InsurancePolicy.Domain.Interfaces
{
    using Domain.Models;
    using System.Collections.Generic;
    
    public interface ICoverageTypeRepository
    {
        void CreateCoverageTypes(CoverageType coverageType);
        void UpdateCoverageTypes(CoverageType coverageType);
        IEnumerable<CoverageType> GetCoverageTypes();
        void DeleteCoverageTypes(CoverageType coverageType);
    }
}
