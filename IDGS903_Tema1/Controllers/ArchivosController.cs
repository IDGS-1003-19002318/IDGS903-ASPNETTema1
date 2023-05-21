using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDGS903_Tema1.Services;

namespace IDGS903_Tema1.Controllers
{
    public class ArchivosController : Controller
    {
        // GET: Archivos
        public ActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(Maestros maestros)
        {
            var op = new GuardaService();
            op.GuardaArchivo(maestros);
            return View();
        }
        [HttpGet]
        public ActionResult LeerDatos()
        {            
            var maes = new LeerService();
            ViewBag.Maestros = maes.LeerArchivo();
            return View();
        }
    }
}