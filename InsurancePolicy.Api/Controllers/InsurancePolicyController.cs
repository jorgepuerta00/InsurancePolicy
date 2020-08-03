namespace InsurancePolicy.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using InsurancePolicy.Application.Interfaces;
    using InsurancePolicy.Application.ViewModels;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [ApiController]
    [Route("api/[controller]")]
    public class InsurancePolicyController : ControllerBase
    {
        private readonly IInsurancePolicyService _insurancePolicyService;

        public InsurancePolicyController(IInsurancePolicyService insuranceService)
        {
            _insurancePolicyService = insuranceService;
        }

        [HttpGet]
        public IActionResult GetInsurancePolicies()
        {
            try
            {
                return this.Ok(_insurancePolicyService.GetInsurancePolicies().InsurancePolicies);
            }
            catch
            {
                return this.BadRequest();
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
            catch
            {
                return this.BadRequest();
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
            catch
            {
                return this.BadRequest();
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
            catch
            {
                return this.BadRequest();
            }
        }
    }
}
