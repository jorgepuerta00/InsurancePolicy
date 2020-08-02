namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;
    using Domain.Models;

    public interface ICoverageTypeService
    {
        void CreateCoverageTypes(CoverageType coverageType);
        void UpdateCoverageTypes(CoverageType coverageType);
        CoverageTypeViewModel GetCoverageTypes();
        void DeleteCoverageTypes(CoverageType coverageType);
    }
}
