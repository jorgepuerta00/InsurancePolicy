namespace InsurancePolicy.Api.Controllers
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Linq;

    [ApiController]
    [Route("api/[controller]")]
    public class InsurancePolicyController : ControllerBase
    {
        private readonly IInsurancePolicyService _insurancePolicyService;
        private readonly IRiskTypeService _riskTypeService;
        private readonly ILogger<InsurancePolicyController> _logger;

        public InsurancePolicyController(ILogger<InsurancePolicyController> logger, IInsurancePolicyService insuranceService, IRiskTypeService riskTypeService)
        {
            _logger = logger;
            _insurancePolicyService = insuranceService;
            _riskTypeService = riskTypeService;
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

        [HttpGet]
        [Route("[action]")]
        public IActionResult ValidateInsurancePolicy([FromBody]InsurancePolicyViewModel InsurancePolicy)
        {
            try
            {
                var riskType = _riskTypeService.GetRiskTypes().Where(r => r.RiskTypeID == InsurancePolicy.RiskTypeID).FirstOrDefault();

                return this.Ok(_insurancePolicyService.ValidateInsurancePolicy(InsurancePolicy, riskType));
            }
            catch (Exception e)
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
