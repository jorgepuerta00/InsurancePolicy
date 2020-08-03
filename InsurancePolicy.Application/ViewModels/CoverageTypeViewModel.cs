namespace InsurancePolicy.Application.ViewModels
{
    using Domain.Models;
    using System.Collections.Generic;
    public class CoverageTypeViewModel
    {
        public int CoverageTypeID { get; set; }
        public string CoverageTypeCode { get; set; }
        public string CoverageTypeName { get; set; }
    }
}
