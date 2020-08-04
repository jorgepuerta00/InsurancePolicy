namespace InsurancePolicy.Api.Controllers
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;

    [ApiController]
    [Route("api/[controller]")]
    public class CoverageTypeController : ControllerBase
    {
        private readonly ICoverageTypeService _insurancePolicyService;
        private readonly ILogger<CoverageTypeController> _logger;

        public CoverageTypeController(ILogger<CoverageTypeController> logger, ICoverageTypeService insuranceService)
        {
            _logger = logger;
            _insurancePolicyService = insuranceService;
        }

        [HttpGet]
        public IActionResult GetCoverageTypes()
        {
            try
            {
                return this.Ok(_insurancePolicyService.GetCoverageTypes());
            }
            catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateCoverageType([FromBody]CoverageTypeViewModel CoverageType)
        {
            try
            {
                _insurancePolicyService.CreateCoverageType(CoverageType);
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateCoverageType([FromBody]CoverageTypeViewModel CoverageType)
        {
            try
            {
                _insurancePolicyService.UpdateCoverageType(CoverageType);
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteCoverageType([FromBody]CoverageTypeViewModel CoverageType)
        {
            try
            {
                _insurancePolicyService.DeleteCoverageType(CoverageType);
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}
