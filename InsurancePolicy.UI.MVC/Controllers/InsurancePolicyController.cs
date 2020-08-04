namespace InsurancePolicy.UI.MVC.Controllers
{
    using Application.ViewModels;
    using Client.Api;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;

    public class InsurancePolicyController : Controller
    {
        private readonly InsurancePolicyClient<CoverageTypeViewModel> _coverageTypeClient;
        private readonly InsurancePolicyClient<RiskTypeViewModel> _riskTypeClient;
        private readonly InsurancePolicyClient<StatusTypeViewModel> _statusTypeClient;
        private readonly InsurancePolicyClient<InsurancePolicyViewModel> _insurancePolicyClient;
        public InsurancePolicyController(InsurancePolicyClient<CoverageTypeViewModel> coverageTypeClient, 
                InsurancePolicyClient<RiskTypeViewModel> riskTypeClient,
                InsurancePolicyClient<StatusTypeViewModel> statusTypeClient,
                InsurancePolicyClient<InsurancePolicyViewModel> insurancePolicyClient)
        {
            _coverageTypeClient = coverageTypeClient;
            _riskTypeClient = riskTypeClient;
            _statusTypeClient = statusTypeClient;
            _insurancePolicyClient = insurancePolicyClient;
        }
        
        [Authorize]
        public IActionResult Index()
        {
            try
            {
                var coverageType = _coverageTypeClient.ExecuteGet();
                var riskType = _riskTypeClient.ExecuteGet();
                var statusType = _statusTypeClient.ExecuteGet();

                ViewBag.CoverageType = new SelectList(coverageType, "CoverageTypeID", "CoverageTypeName");
                ViewBag.RiskType = new SelectList(riskType, "RiskTypeID", "RiskTypeName");
                ViewBag.StatusType = new SelectList(statusType, "StatusTypeID", "StatusTypeName");

                var model = _insurancePolicyClient.ExecuteGet();
                return View(model);
            }
            catch (Exception e)
            {
                return this.BadRequest("ocurrió un error consultando los registros: " + e.Message);
            }
        }

        [HttpPost]
        public ActionResult CreateInsurancePolicy(InsurancePolicyViewModel InsurancePolicy)
        {
            try
            {
                _insurancePolicyClient.ExecutePost(InsurancePolicy);
                return this.Ok("Proceso exisoto: Registro creado");
            }
            catch (Exception e)
            {
                return this.BadRequest("ocurrió un error creando el registro: " + e.Message);
            }
        }

        [HttpPost]
        public ActionResult UpdateInsurancePolicy(InsurancePolicyViewModel InsurancePolicy)
        {
            try
            {
                _insurancePolicyClient.ExecutePut(InsurancePolicy);
                return this.Ok("Proceso exisoto: Registro actualizado");
            }
            catch (Exception e)
            {
                return this.BadRequest("ocurrió un error actualizando el registro: " + e.Message);
            }
        }

        [HttpPost]
        public ActionResult DeleteInsurancePolicy(InsurancePolicyViewModel InsurancePolicy)
        {
            try
            {
                _insurancePolicyClient.ExecuteDelete(InsurancePolicy);
                return this.Ok("Proceso exisoto: Registro eliminado");
            }
            catch (Exception e)
            {
                return this.BadRequest("ocurrió un error eliminando el registro: " + e.Message);
            }
        }
    }
}