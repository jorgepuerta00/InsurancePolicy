namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;
    public interface ICoverageTypeService
    {
        CoverageTypeViewModel GetCoverageTypes();
    }
}
