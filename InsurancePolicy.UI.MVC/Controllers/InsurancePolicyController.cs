namespace InsurancePolicy.UI.MVC.Controllers
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    public class InsurancePolicyController : Controller
    {
        private IInsurancePolicyService _insurancePolicyService;

        public InsurancePolicyController(IInsurancePolicyService insuranceService)
        {
            _insurancePolicyService = insuranceService;
        }
        
        [Authorize]
        public IActionResult Index()
        {
            IEnumerable<InsurancePolicyViewModel> model = _insurancePolicyService.GetInsurancePolicies();
            return View(model);
        }

        [HttpPost]
        public JsonResult CreateInsurancePolicy(InsurancePolicyViewModel InsurancePolicy)
        {
            _insurancePolicyService.CreateInsurancePolicy(InsurancePolicy);
            return Json(InsurancePolicy);
        }

        [HttpPost]
        public ActionResult UpdateInsurancePolicy(InsurancePolicyViewModel InsurancePolicy)
        {
            _insurancePolicyService.UpdateInsurancePolicy(InsurancePolicy);
            return new EmptyResult();
        }

        [HttpPost]
        public ActionResult DeleteInsurancePolicy(InsurancePolicyViewModel InsurancePolicy)
        {
            _insurancePolicyService.DeleteInsurancePolicy(InsurancePolicy);
            return new EmptyResult();
        }
    }
}