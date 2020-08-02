namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;
    using Domain.Models;

    public interface ICoverageTypeService
    {
        void CreateCoverageType(CoverageType coverageType);
        void UpdateCoverageType(CoverageType coverageType);
        CoverageTypeViewModel GetCoverageTypes();
        void DeleteCoverageType(CoverageType coverageType);
    }
}
