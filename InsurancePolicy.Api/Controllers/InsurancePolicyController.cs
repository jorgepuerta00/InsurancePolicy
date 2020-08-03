namespace InsurancePolicy.Api.Controllers
{
    using InsurancePolicy.Application.Interfaces;
    using InsurancePolicy.Application.ViewModels;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;

    [ApiController]
    [Route("api/[controller]")]
    public class InsurancePolicyController : ControllerBase
    {
        private readonly IInsurancePolicyService _insurancePolicyService;
        private readonly ILogger<InsurancePolicyController> _logger;

        public InsurancePolicyController(ILogger<InsurancePolicyController> logger, IInsurancePolicyService insuranceService)
        {
            _logger = logger;
            _insurancePolicyService = insuranceService;
        }

        [HttpGet]
        public IActionResult GetInsurancePolicies()
        {
            try
            {
                return this.Ok(_insurancePolicyService.GetInsurancePolicies());
            }
            catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateInsurancePolicy([FromBody]InsurancePolicyViewModel InsurancePolicy)
        {
            try
            {
                _insurancePolicyService.CreateInsurancePolicy(InsurancePolicy);
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateInsurancePolicy([FromBody]InsurancePolicyViewModel InsurancePolicy)
        {
            try
            {
                _insurancePolicyService.UpdateInsurancePolicy(InsurancePolicy);
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteInsurancePolicy([FromBody]InsurancePolicyViewModel InsurancePolicy)
        {
            try
            {
                _insurancePolicyService.DeleteInsurancePolicy(InsurancePolicy);
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}
