namespace InsurancePolicy.UnitTest.Test
{
    using Domain.Models;
    using Infrastructure.Data.Repositories;
    using Infrastructure.Data.Context;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Domain.Interfaces;
    using Moq;
    using Application.Services;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    [TestClass]
    public class InsurancePolicyContextTest
    {
        private Mock<IRepository<InsurancePolicy>> dbSetMock;
        private IRepository<InsurancePolicy> _repository;

        [TestInitialize]
        public void TestInitialize()
        {
            dbSetMock = new Mock<IRepository<InsurancePolicy>>();
            _repository = dbSetMock.Object;
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _repository = null;
        }

        [TestMethod]
        public void CreateInsurancePolicy()
        {
            // Arrange
            var insurancePolicy = new InsurancePolicy
            {
                Name = "Prueba",
                Description = "Prueba"
            };

            // Act
            _repository.Create(insurancePolicy);

            //Assert
            dbSetMock.Verify(x => x.Create(It.Is<InsurancePolicy>(y => y == insurancePolicy)));
        }

        [TestMethod]
        public void GetAllInsurancePolicies()
        {
            // Arrange
            var testObject = new InsurancePolicy() { Name = "Prueba" };
            var testList = new List<InsurancePolicy>() { testObject, testObject, testObject, testObject };

            dbSetMock
                .Setup(s => s.GetAll())
                .Returns(testList);

            // Act
            var result = _repository.GetAll();

            //Assert
            Assert.AreEqual(testList, result);
        }

        [TestMethod]
        public void UpdateInsurancePolicy()
        {
            // Arrange
            var insurancePolicy = new InsurancePolicy
            {
                Name = "Prueba",
                Description = "Prueba"
            };

            // Act
            _repository.Update(insurancePolicy);

            //Assert
            dbSetMock.Verify(x => x.Update(It.Is<InsurancePolicy>(y => y == insurancePolicy)));
        }

        [TestMethod]
        public void DeleteInsurancePolicy()
        {
            // Arrange
            var insurancePolicy = new InsurancePolicy
            {
                Name = "Prueba",
                Description = "Prueba"
            };

            // Act
            _repository.Delete(insurancePolicy);

            //Assert
            dbSetMock.Verify(x => x.Delete(It.Is<InsurancePolicy>(y => y == insurancePolicy)));
        }
    }
}