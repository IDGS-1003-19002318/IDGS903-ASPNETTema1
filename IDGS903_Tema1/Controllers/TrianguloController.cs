using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class TrianguloController : Controller
    {        
        public ActionResult Index(Triangulo triangulo)
        {
            TempData["area"] = triangulo.AreaTriangulo().ToString();
            TempData["tipo"] = triangulo.TipoTriangulo();
            TempData["perimetro"] = triangulo.Perimetro().ToString();
            return View(triangulo);
        }
    }
}