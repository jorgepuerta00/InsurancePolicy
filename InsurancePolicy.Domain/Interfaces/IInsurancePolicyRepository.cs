namespace InsurancePolicy.Domain.Interfaces
{
    using Domain.Models;
    using System.Collections.Generic;

    public interface IInsurancePolicyRepository
    {
        IEnumerable<InsurancePolicy> GetInsurancePolicies();
        void CreateCoverageTypes(CoverageType coverageType);
        void UpdateCoverageTypes(CoverageType coverageType);
        void DeleteCoverageTypes(CoverageType coverageType);
    }
}
