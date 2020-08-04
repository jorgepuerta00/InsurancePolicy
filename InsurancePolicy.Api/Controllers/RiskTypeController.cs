namespace InsurancePolicy.Api.Controllers
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;

    [ApiController]
    [Route("api/[controller]")]
    public class RiskTypeController : ControllerBase
    {
        private readonly IRiskTypeService _insurancePolicyService;
        private readonly ILogger<RiskTypeController> _logger;

        public RiskTypeController(ILogger<RiskTypeController> logger, IRiskTypeService insuranceService)
        {
            _logger = logger;
            _insurancePolicyService = insuranceService;
        }

        [HttpGet]
        public IActionResult GetRiskTypes()
        {
            try
            {
                return this.Ok(_insurancePolicyService.GetRiskTypes());
            }
            catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateRiskType([FromBody]RiskTypeViewModel RiskType)
        {
            try
            {
                _insurancePolicyService.CreateRiskType(RiskType);
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateRiskType([FromBody]RiskTypeViewModel RiskType)
        {
            try
            {
                _insurancePolicyService.UpdateRiskType(RiskType);
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteRiskType([FromBody]RiskTypeViewModel RiskType)
        {
            try
            {
                _insurancePolicyService.DeleteRiskType(RiskType);
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}
