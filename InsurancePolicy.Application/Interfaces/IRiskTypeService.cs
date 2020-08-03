namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;
    using System.Collections.Generic;

    public interface IRiskTypeService
    {
        void CreateRiskType(RiskTypeViewModel riskType);
        void UpdateRiskType(RiskTypeViewModel riskType);
        IEnumerable<RiskTypeViewModel> GetRiskTypes();
        void DeleteRiskType(RiskTypeViewModel riskType);
    }
}
