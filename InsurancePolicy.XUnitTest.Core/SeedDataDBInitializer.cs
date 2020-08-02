namespace InsurancePolicy.XUnitTest.Core
{
    using Domain.Models;
    using Infrastructure.Data.Context;
    using System;

    public class SeedDataDBInitializer
    {
        public SeedDataDBInitializer()
        {


        }
        public void Seed(InsurancePolicyDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.CoverageTypes.AddRange(
                new CoverageType() { CoverageTypeCode = "earthquake", CoverageTypeName = "Terremoto" },
                new CoverageType() { CoverageTypeCode = "conflagration", CoverageTypeName = "Incendio" },
                new CoverageType() { CoverageTypeCode = "theft", CoverageTypeName = "Robo" },
                new CoverageType() { CoverageTypeCode = "forfeiture", CoverageTypeName = "Pérdida" }
            );
            context.RiskTypes.AddRange(
                new RiskType() { RiskTypeCode = "low", RiskTypeName = "Bajo", MaxCoverage = 100 },
                new RiskType() { RiskTypeCode = "medium", RiskTypeName = "Medio", MaxCoverage = 100 },
                new RiskType() { RiskTypeCode = "mediumhigh", RiskTypeName = "Medio Alto", MaxCoverage = 100 },
                new RiskType() { RiskTypeCode = "high", RiskTypeName = "Alto", MaxCoverage = 50 }
            );

            context.StatusTypes.AddRange(
                new StatusType() { StatusTypeCode = "assigned", StatusTypeName = "Asignado" },
                new StatusType() { StatusTypeCode = "cancelled", StatusTypeName = "Cancelado" }
            );

            context.InsurancePolicies.AddRange(
                new InsurancePolicy() { Name = "Poliza contra terremoto", Description = "Poliza contra terremoto", CoverageTypeID = 1, CoveragePercentage = 100, CoverageTimeElapsed = 12, RiskTypeID = 1, TotalCost = 1800000, Startdate = new DateTime() },
                new InsurancePolicy() { Name = "Poliza contra incendios", Description = "Poliza contra incendios", CoverageTypeID = 2, CoveragePercentage = 50 , CoverageTimeElapsed = 12, RiskTypeID = 4, TotalCost = 2800000, Startdate = new DateTime() }
            );

            context.SaveChanges();
        }
    }
}
