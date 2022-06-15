using Microsoft.AspNetCore.Mvc;
using ResCliCore.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResCliCore.Controllers
{
    public class ResiduosController : Controller
    {
        private readonly IManejoResiduosServiceInt _serviceAPI;

        public ResiduosController(IManejoResiduosServiceInt servicioAPI)
        {
            _serviceAPI = servicioAPI;
        }
        public IActionResult Index()
        {
            //pruebajson();
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Graficaresiduos()
        {
            try
            {
                var result = await _serviceAPI.ObtenerResiduos();
                return Json(result);
            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
                //return (ex.ToString());

            }

            
        }

        private async void pruebajson()
        {

        }
    }
}
