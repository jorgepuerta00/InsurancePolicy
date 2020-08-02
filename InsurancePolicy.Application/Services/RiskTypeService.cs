namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Interfaces;
    using Domain.Models;

    public class RiskTypeService : IRiskTypeService
    {
        public IRepository<RiskType> _riskTypeRepository;
        public RiskTypeService(IRepository<RiskType> riskTypeRepository)
        {
            _riskTypeRepository = riskTypeRepository;
        }

        public void CreateRiskType(RiskType riskType)
        {
            _riskTypeRepository.Create(riskType);
        }

        public void DeleteRiskType(RiskType riskType)
        {
            _riskTypeRepository.Delete(riskType);
        }

        public RiskTypeViewModel GetRiskTypes()
        {
            return new RiskTypeViewModel()
            {
                RiskTypes = _riskTypeRepository.GetAll()
            };
        }

        public void UpdateRiskType(RiskType riskType)
        {
            _riskTypeRepository.Update(riskType);
        }
    }
}
