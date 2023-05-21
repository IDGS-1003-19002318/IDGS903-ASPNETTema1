using IDGS903_Tema1.Models;
using IDGS903_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class TraductorController : Controller
    {
        //[HttpPost]
        public ActionResult Index(Translator translator)
        {
            return View(translator);
        }
        [HttpPost]
        public ActionResult GuardarTraduccion(Translator translator)
        {
            var trad = new TraductorService();
            trad.GuardarPalabra(translator);
            return View("Index");
        }

        [HttpPost]
        public ActionResult MostrarTraducciones(Translator translator)
        {
            var trad = new TraductorService();
            ViewBag.Traducciones = trad.LeerArchivo();
            return View("Index");
        }

        public ActionResult Traductor(Buscada buscada)
        {
            return View(buscada);
        }

        [HttpPost]
        public ActionResult BuscarPalabra(Buscada buscada)
        {
            var traductorSvc = new TraductorService();
            ViewBag.Traduccion = traductorSvc.BuscarPalabra(buscada);
            ViewBag.Palabra = buscada.Palabra;

            return View("Traductor");
        }
    }
}