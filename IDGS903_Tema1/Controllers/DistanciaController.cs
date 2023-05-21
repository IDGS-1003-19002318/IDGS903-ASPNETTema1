using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class DistanciaController : Controller
    {
        // GET: Distancia
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculo(Distancia distancia)
        {
            var res = distancia.Calculo();
            ViewBag.Distancia = res;
            return View(distancia);
        }
    }
}