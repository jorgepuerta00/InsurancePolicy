namespace InsurancePolicy.Application.Interfaces
{
    using Application.ViewModels;
    using System.Collections.Generic;

    public interface IStatusTypeService
    {
        void CreateStatusType(StatusTypeViewModel statusType);
        void UpdateStatusType(StatusTypeViewModel statusType);
        IEnumerable<StatusTypeViewModel> GetStatusTypes();
        void DeleteStatusType(StatusTypeViewModel statusType);
    }
}
