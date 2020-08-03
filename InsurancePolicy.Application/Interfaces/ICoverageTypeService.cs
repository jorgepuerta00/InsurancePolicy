namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;

    public interface ICoverageTypeService
    {
        void CreateCoverageType(CoverageTypeViewModel coverageType);
        void UpdateCoverageType(CoverageTypeViewModel coverageType);
        CoverageTypeViewModel GetCoverageTypes();
        void DeleteCoverageType(CoverageTypeViewModel coverageType);
    }
}
