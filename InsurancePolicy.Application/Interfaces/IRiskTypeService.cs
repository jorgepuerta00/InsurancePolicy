namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;
    using Domain.Models;

    public interface IRiskTypeService
    {
        void CreateRiskType(RiskType riskType);
        void UpdateRiskType(RiskType riskType);
        RiskTypeViewModel GetRiskTypes();
        void DeleteRiskType(RiskType riskType);
    }
}
