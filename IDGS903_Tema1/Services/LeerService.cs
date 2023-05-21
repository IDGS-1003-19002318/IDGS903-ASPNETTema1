using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace IDGS903_Tema1.Services
{
    public class LeerService
    {
        public Array LeerArchivo()
        {
            Array maestData = null;
            var file = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            if (File.Exists(file))
            {
                maestData = File.ReadAllLines(file);
            }
            return maestData;
        }
    }
}