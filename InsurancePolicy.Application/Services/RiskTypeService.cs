namespace InsurancePolicy.Application.Services
{
    using Interfaces;
    using ViewModels;
    using Domain.Interfaces;
    using Domain.Models;

    public class RiskTypeService : BaseData, IRiskTypeService
    {
        public IRepository<RiskType> _riskTypeRepository;
        public RiskTypeService(IRepository<RiskType> riskTypeRepository)
        {
            _riskTypeRepository = riskTypeRepository;
        }

        public void CreateRiskType(RiskTypeViewModel riskTypeViewModel)
        {
            var riskType = this._mapper.Map<RiskTypeViewModel, RiskType>(riskTypeViewModel);
            _riskTypeRepository.Create(riskType);
        }

        public void DeleteRiskType(RiskTypeViewModel riskTypeViewModel)
        {
            var riskType = this._mapper.Map<RiskTypeViewModel, RiskType>(riskTypeViewModel);
            _riskTypeRepository.Delete(riskType);
        }

        public RiskTypeViewModel GetRiskTypes()
        {
            return new RiskTypeViewModel()
            {
                RiskTypes = _riskTypeRepository.GetAll()
            };
        }

        public void UpdateRiskType(RiskTypeViewModel riskTypeViewModel)
        {
            var riskType = this._mapper.Map<RiskTypeViewModel, RiskType>(riskTypeViewModel);
            _riskTypeRepository.Update(riskType);
        }
    }
}
