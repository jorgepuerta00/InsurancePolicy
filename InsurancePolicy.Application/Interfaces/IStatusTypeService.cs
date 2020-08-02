namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;
    using Domain.Models;

    public interface IStatusTypeService
    {
        void CreateStatusType(StatusType statusType);
        void UpdateStatusType(StatusType statusType);
        StatusTypeViewModel GetStatusTypes();
        void DeleteStatusType(StatusType statusType);
    }
}
