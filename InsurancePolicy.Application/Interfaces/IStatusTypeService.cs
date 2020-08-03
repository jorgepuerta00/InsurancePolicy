namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;

    public interface IStatusTypeService
    {
        void CreateStatusType(StatusTypeViewModel statusType);
        void UpdateStatusType(StatusTypeViewModel statusType);
        StatusTypeViewModel GetStatusTypes();
        void DeleteStatusType(StatusTypeViewModel statusType);
    }
}
