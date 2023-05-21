using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;

namespace IDGS903_Tema1.Services
{
    public class GuardaService
    {
        public void GuardaArchivo(Maestros maestros) {
            var mat = maestros.Matricula;
            var nom = maestros.Nombre;
            var apa = maestros.Apaterno;
            var ama = maestros.Amaterno;
            var email = maestros.Email;
            var datos = mat + " , " + nom + " , " + apa + " , " + ama + " , " + email + Environment.NewLine ;

            var ruta = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            File.WriteAllText(ruta, datos);
        }
    }
}