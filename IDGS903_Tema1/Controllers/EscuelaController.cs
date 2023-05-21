using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {
            var alumno1 = new Alumno()
            {
                Nombre = "Joshua",
                Edad = 21,
                Activo = false,
                Inscrito = DateTime.Now,
            };
            
            return View(alumno1);
        }

        public ActionResult Registrar(Alumno alumno)
        {
            var alumno1 = new Alumno()
            {
                Nombre = "Joshua xd",
                Edad = alumno.Edad,
                Activo = false,
                Inscrito = DateTime.Now,
            };

            alumno = alumno1;

            return View(alumno);
        }

        public ActionResult Lancamento()
        {
            return View();
        }

    }
}