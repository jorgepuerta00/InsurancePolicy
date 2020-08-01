namespace InsurancePolicy.Domain.Interfaces
{
    using Domain.Models;
    using System.Collections.Generic;

    public interface IRiskTypeRepository
    {
        IEnumerable<RiskType> GetRiskTypes();
    }
}
