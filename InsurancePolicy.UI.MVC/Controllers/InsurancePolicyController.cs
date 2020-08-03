namespace InsurancePolicy.UI.MVC.Controllers
{
    using Application.ViewModels;
    using Client.Api;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;

    public class InsurancePolicyController : Controller
    {
        private readonly InsurancePolicyClient _insurancePolicyClient;
        public InsurancePolicyController(InsurancePolicyClient insurancePolicyClient)
        {
            _insurancePolicyClient = insurancePolicyClient;
        }
        
        [Authorize]
        public IActionResult Index()
        {
            try
            {
                var model = _insurancePolicyClient.ExecuteGet<IEnumerable<InsurancePolicyViewModel>>();
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
                _insurancePolicyClient.ExecutePost<InsurancePolicyViewModel>(InsurancePolicy);
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
                _insurancePolicyClient.ExecutePut<InsurancePolicyViewModel>(InsurancePolicy);
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
                _insurancePolicyClient.ExecuteDelete<InsurancePolicyViewModel>(InsurancePolicy);
                return this.Ok("Proceso exisoto: Registro eliminado");
            }
            catch (Exception e)
            {
                return this.BadRequest("ocurrió un error eliminando el registro: " + e.Message);
            }
        }
    }
}