namespace InsurancePolicy.Application.Services
{
    using Interfaces;
    using ViewModels;
    using Domain.Interfaces;
    using Domain.Models;

    public class CoverageTypeService : BaseData, ICoverageTypeService
    {
        public IRepository<CoverageType> _coverageTypeRepository;
        public CoverageTypeService(IRepository<CoverageType> coverageTypeRepository)
        {
            _coverageTypeRepository = coverageTypeRepository;
        }

        public void CreateCoverageType(CoverageTypeViewModel coverageTypeViewModel)
        {
            var coverageType = this._mapper.Map<CoverageTypeViewModel, CoverageType>(coverageTypeViewModel);
            _coverageTypeRepository.Create(coverageType);
        }

        public void DeleteCoverageType(CoverageTypeViewModel coverageTypeViewModel)
        {
            var coverageType = this._mapper.Map<CoverageTypeViewModel, CoverageType>(coverageTypeViewModel);
            _coverageTypeRepository.Delete(coverageType);
        }

        public CoverageTypeViewModel GetCoverageTypes()
        {
            return new CoverageTypeViewModel()
            {
                CoverageTypes = _coverageTypeRepository.GetAll()
            };
        }

        public void UpdateCoverageType(CoverageTypeViewModel coverageTypeViewModel)
        {
            var coverageType = this._mapper.Map<CoverageTypeViewModel, CoverageType>(coverageTypeViewModel);
            _coverageTypeRepository.Update(coverageType);
        }
    }
}
