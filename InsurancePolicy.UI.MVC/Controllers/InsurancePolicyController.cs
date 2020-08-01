namespace InsurancePolicy.UI.MVC.Controllers
{
    using Application.Interfaces;
    using Application.ViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

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
            InsurancePolicyViewModel model = _insurancePolicyService.GetInsurancePolicies();
            return View(model);
        }
    }
}