namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;
    using System.Collections.Generic;

    public interface ICoverageTypeService
    {
        void CreateCoverageType(CoverageTypeViewModel coverageType);
        void UpdateCoverageType(CoverageTypeViewModel coverageType);
        IEnumerable<CoverageTypeViewModel> GetCoverageTypes();
        void DeleteCoverageType(CoverageTypeViewModel coverageType);
    }
}
