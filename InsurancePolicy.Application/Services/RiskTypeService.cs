namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Interfaces;

    public class RiskTypeService : IRiskType
    {
        public IRiskTypeRepository _riskTypeRepository;
        public RiskTypeService(IRiskTypeRepository riskTypeRepository)
        {
            _riskTypeRepository = riskTypeRepository;
        }
        RiskTypeViewModel IRiskType.GetRiskTypes()
        {
            return new RiskTypeViewModel()
            {
                RiskTypes = _riskTypeRepository.GetRiskTypes()
            };
        }
    }
}
