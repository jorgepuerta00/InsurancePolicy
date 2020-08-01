namespace InsurancePolicy.Application.ViewModels
{
    using Domain.Models;
    using System.Collections.Generic;
    public class RiskTypeViewModel
    {
        public IEnumerable<RiskType> Books { get; set; }
    }
}
