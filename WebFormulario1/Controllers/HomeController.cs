using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFormulario1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Inicio");
        }

        public ActionResult Vista2()
        {
            return View("Vista2");
        }
        public ActionResult RecibirDatosFormulario(string dia, string mes, int anio)
        {
            // La fecha es: Viernes del mes Junio del año 2024
            // Concatenar con el operador +
            string resultado = "La fechas es: " + dia + " del mes " + mes + " del año: " + anio;

            //Concatenar con el operador de pesos
            string resultado2 = $"La fechas es: {dia} del mes {mes} del año {anio}";
            // Creamos un TempData para enviar informacion del controlador a la vista
            TempData["mensaje1"] = resultado;

            TempData["mensaje2"] = resultado2;

            return View("Inicio");
        }

    }
}