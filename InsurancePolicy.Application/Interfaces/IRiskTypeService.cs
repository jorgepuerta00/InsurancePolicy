namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;

    public interface IRiskTypeService
    {
        void CreateRiskType(RiskTypeViewModel riskType);
        void UpdateRiskType(RiskTypeViewModel riskType);
        RiskTypeViewModel GetRiskTypes();
        void DeleteRiskType(RiskTypeViewModel riskType);
    }
}
