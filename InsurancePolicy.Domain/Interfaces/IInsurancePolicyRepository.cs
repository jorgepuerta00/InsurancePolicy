using System.Collections.Generic;

namespace InsurancePolicy.Domain.Interfaces
{
    using Domain.Models;
    public interface IInsurancePolicyRepository
    {
        IEnumerable<InsurancePolicy> GetInsurancePolicies();
    }
}
