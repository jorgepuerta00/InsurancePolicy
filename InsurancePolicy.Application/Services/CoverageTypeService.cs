namespace InsurancePolicy.Application.Services
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Interfaces;

    public class CoverageTypeService : ICoverageTypeService
    {
        public ICoverageTypeRepository _coverageTypeRepository;
        public CoverageTypeService(ICoverageTypeRepository coverageTypeRepository)
        {
            _coverageTypeRepository = coverageTypeRepository;
        }
        public CoverageTypeViewModel GetCoverageTypes()
        {
            return new CoverageTypeViewModel()
            {
                CoverageTypes = _coverageTypeRepository.GetCoverageTypes()
            };
        }
    }
}
