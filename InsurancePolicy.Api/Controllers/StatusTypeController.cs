namespace InsurancePolicy.Api.Controllers
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;

    [ApiController]
    [Route("api/[controller]")]
    public class StatusTypeController : ControllerBase
    {
        private readonly IStatusTypeService _insurancePolicyService;
        private readonly ILogger<StatusTypeController> _logger;

        public StatusTypeController(ILogger<StatusTypeController> logger, IStatusTypeService insuranceService)
        {
            _logger = logger;
            _insurancePolicyService = insuranceService;
        }

        [HttpGet]
        public IActionResult GetStatusTypes()
        {
            try
            {
                return this.Ok(_insurancePolicyService.GetStatusTypes());
            }
            catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateStatusType([FromBody]StatusTypeViewModel StatusType)
        {
            try
            {
                _insurancePolicyService.CreateStatusType(StatusType);
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateStatusType([FromBody]StatusTypeViewModel StatusType)
        {
            try
            {
                _insurancePolicyService.UpdateStatusType(StatusType);
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteStatusType([FromBody]StatusTypeViewModel StatusType)
        {
            try
            {
                _insurancePolicyService.DeleteStatusType(StatusType);
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}
