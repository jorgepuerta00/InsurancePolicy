namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Interfaces;
    using Domain.Models;

    public class CoverageTypeService : ICoverageTypeService
    {
        public IRepository<CoverageType> _coverageTypeRepository;
        public CoverageTypeService(IRepository<CoverageType> coverageTypeRepository)
        {
            _coverageTypeRepository = coverageTypeRepository;
        }

        public void CreateCoverageType(CoverageType coverageType)
        {
            _coverageTypeRepository.Create(coverageType);
        }

        public void DeleteCoverageType(CoverageType coverageType)
        {
            _coverageTypeRepository.Delete(coverageType);
        }

        public CoverageTypeViewModel GetCoverageTypes()
        {
            return new CoverageTypeViewModel()
            {
                CoverageTypes = _coverageTypeRepository.GetAll()
            };
        }

        public void UpdateCoverageType(CoverageType coverageType)
        {
            _coverageTypeRepository.Update(coverageType);
        }
    }
}
