namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;
    public interface ICoverageType
    {
        CoverageTypeViewModel GetCoverageTypes();
    }
}
