namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Interfaces;
    using Domain.Models;

    public class CoverageTypeService : ICoverageTypeService
    {
        public ICoverageTypeRepository _coverageTypeRepository;
        public CoverageTypeService(ICoverageTypeRepository coverageTypeRepository)
        {
            _coverageTypeRepository = coverageTypeRepository;
        }

        public void CreateCoverageTypes(CoverageType coverageType)
        {
            _coverageTypeRepository.CreateCoverageTypes(coverageType);
        }

        public void DeleteCoverageTypes(CoverageType coverageType)
        {
            _coverageTypeRepository.DeleteCoverageTypes(coverageType);
        }

        public CoverageTypeViewModel GetCoverageTypes()
        {
            return new CoverageTypeViewModel()
            {
                CoverageTypes = _coverageTypeRepository.GetCoverageTypes()
            };
        }

        public void UpdateCoverageTypes(CoverageType coverageType)
        {
            _coverageTypeRepository.UpdateCoverageTypes(coverageType);
        }
    }
}
