﻿namespace InsurancePolicy.Application.ViewModels
{
    using Domain.Models;
    using System.Collections.Generic;
    public class CoverageTypeViewModel
    {
        public IEnumerable<CoverageType> Books { get; set; }
    }
}