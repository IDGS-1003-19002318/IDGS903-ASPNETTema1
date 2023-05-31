using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Net.NetworkInformation;

namespace IDGS903_Tema1.Services
{
    public class TraductorService
    {
        //public static T GetTranslation<T>(string word)
        //{
        //    var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl=en&tl=es&dt=t&q={word}";
        //    var result = new System.Net.WebClient().DownloadString(url);
        //    var traduccion = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
        //    return (T)Convert.ChangeType(traduccion, typeof(T));
        //}
        public void GuardarPalabra(Translator traductor)
        {
            var esp = traductor.ingles.ToLower().Trim();
            var ing = traductor.espanol.ToLower().Trim();
            var datos = esp + "," + ing + Environment.NewLine;

            var ruta = HttpContext.Current.Server.MapPath("~/App_Data/traducciones.txt");
            File.AppendAllText(ruta, datos);
        }

        public string BuscarPalabra(Buscada buscadas)
        {
            var palabra = buscadas.Palabra.ToLower().Trim();
            var idioma = buscadas.Idioma;
            string traduccion = "";
            try
            {
                //Tip uno es para ingles a esp
                if (idioma == 0)
                {
                    var arr = LeerArchivo();
                    foreach (string item in arr)
                    {
                        string[] element = item.Split(',');
                        string comparar = element[1].ToString().Trim();
                        if (comparar == palabra)
                        {
                            traduccion = element[0].ToString().Trim().ToUpperInvariant();
                        }
                    }
                }
                else if (idioma == 1)
                {
                    var arr = LeerArchivo();
                    foreach (string item in arr)
                    {
                        string[] element = item.Split(',');
                        string comparar = element[0].ToString().Trim();
                        if (comparar == palabra)
                        {
                            traduccion = element[1].ToString().Trim().ToUpperInvariant();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hubo un error " + e.Message);
            }
            finally
            {

            }
            return traduccion;
        }

        public Array LeerArchivo()
        {
            Array traducciones = null;
            var file = HttpContext.Current.Server.MapPath("~/App_Data/traducciones.txt");
            if (File.Exists(file))
            {
                traducciones = File.ReadAllLines(file);
            }
            return traducciones;
        }
    }
}