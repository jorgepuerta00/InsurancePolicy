namespace InsurancePolicy.UnitTest.Test
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class InsurancePolicyBusinessTest
    {
        private Mock<IInsurancePolicyService> insurancePolicyServiceMock;
        private IInsurancePolicyService insurancePolicyService;

        [TestInitialize]
        public void TestInitialize()
        {
            insurancePolicyServiceMock = new Mock<IInsurancePolicyService>();
            insurancePolicyService = insurancePolicyServiceMock.Object;
        }

        [TestCleanup]
        public void TestCleanup()
        {
            insurancePolicyService = null;
        }

        [TestMethod]
        public void ValidateInsurancePolicyFail()
        {
            // Arrange
            var insurancePolicy = new InsurancePolicyViewModel
            {
                InsurancePolicyID = 2,
                Name = "Poliza prueba",
                Description = "Poliza prueba",
                CoverageTypeID = 1,
                CoveragePercentage = 100,
                CoverageTimeElapsed = 12,
                TotalCost = 1800000,
                RiskTypeID = 4
            };

            var riskType = new RiskTypeViewModel 
            {
                RiskTypeID = 4,
                RiskTypeName = "Alto",
                MaxCoverage = 50
            };

            var expectedResult = insurancePolicy.CoveragePercentage <= riskType.MaxCoverage;

            insurancePolicyServiceMock.Setup(x => x.ValidateInsurancePolicy(It.IsAny<InsurancePolicyViewModel>(), It.IsAny<RiskTypeViewModel>())).Returns(false);

            // Act
            var result = insurancePolicyService.ValidateInsurancePolicy(insurancePolicy, riskType);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void ValidateInsurancePolicyOK()
        {
            // Arrange
            var insurancePolicy = new InsurancePolicyViewModel
            {
                InsurancePolicyID = 2,
                Name = "Poliza prueba",
                Description = "Poliza prueba",
                CoverageTypeID = 1,
                CoveragePercentage = 50,
                CoverageTimeElapsed = 12,
                TotalCost = 1800000,
                RiskTypeID = 4
            };

            var riskType = new RiskTypeViewModel
            {
                RiskTypeID = 4,
                RiskTypeName = "Alto",
                MaxCoverage = 50
            };

            var expectedResult = insurancePolicy.CoveragePercentage <= riskType.MaxCoverage;

            insurancePolicyServiceMock.Setup(x => x.ValidateInsurancePolicy(It.IsAny<InsurancePolicyViewModel>(), It.IsAny<RiskTypeViewModel>())).Returns(true);

            // Act
            var result = insurancePolicyService.ValidateInsurancePolicy(insurancePolicy, riskType);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}