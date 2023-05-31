using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
    public class Triangulo
    {
        public double x1 { get; set;}
        public double x2 { get; set;}
        public double x3 { get; set;}
        public double y1 { get; set;}
        public double y2 { get; set;}
        public double y3 { get; set;}

        public double DistanciaPunto1A2()
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        public double DistanciaPunto2A3()
        {
            return Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
        }

        public double DistanciaPunto3A1()
        {
            return Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
        }

        private bool IsTriangulo()
        {
            double pend1 = (y2 - y1)/(x2 - x1);
            double pend2 = (y3 - y1) / (x3 - x1);

            if (pend1 != pend2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string TipoTriangulo()
        {
            double lado1 = Math.Round(DistanciaPunto1A2());
            double lado2 = Math.Round(DistanciaPunto2A3());
            double lado3 = Math.Round(DistanciaPunto3A1());


            string tipo;
            if (ValidarTriangulo())
            {
                tipo = "No es triangulo";

            }else if (lado1 == lado2 && lado2 == lado3)
            {
                tipo = "Equilatero";
            }else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                tipo = "Isoceles";
            }else
            {
                tipo = "Escaleno";
            }
            return tipo;
        }

        public bool ValidarTriangulo()
        {
            double lado1 = Math.Round(DistanciaPunto1A2());
            double lado2 = Math.Round(DistanciaPunto2A3());
            double lado3 = Math.Round(DistanciaPunto3A1());            

            double mayor = 0;
            int caso = 0;
            bool valido = false;
            if (lado1 < (lado2 + lado3) && lado2 < (lado1 + lado3) && lado3 < (lado1 + lado2 ))
            {
                caso = 0;
            }
            else if (lado1 > lado2 && lado1 > lado3)
            {
                mayor = lado1;
                caso = 1;
            }
            else if (lado2 > lado3)
            {
                mayor = lado2;
                caso = 2;
            }
            else if (lado3 > lado1)
            {
                mayor = lado3;
                caso = 3;
            }
            else if(lado1 == lado2 && lado2 == lado3)
            {
                caso = 4;
            }
            else if(lado1 == lado2  || lado2 == lado3 || lado1 == lado3)
            {
                caso = 5;
            }

            switch (caso)
            {
                case 1:
                    if (mayor < (lado2 + lado3))
                    {
                        valido = true;
                    }
                    break;
                case 2:
                    if (mayor < (lado1 + lado3))
                    {
                        valido = true;
                    }
                    break;
                case 3:
                    if (mayor < (lado1 + lado2))
                    {
                        valido = true;
                    }
                    break;
                case 4:
                    valido = true;
                    break;
                case 5: 
                    valido = true;
                    break;
                default:
                    return false;
            }

            return valido;
        }

        public double AreaTriangulo()
        {
            double area = 0;
            string tipo;
            double lado1 = Math.Round(DistanciaPunto1A2());
            double lado2 = Math.Round(DistanciaPunto2A3());
            double lado3 = Math.Round(DistanciaPunto3A1());

            if (ValidarTriangulo())
            {
                tipo = TipoTriangulo();
                var s = (lado1 + lado2 + lado3)/ 2;
                switch (tipo)
                {
                    case "Equilatero":
                            area = Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
                        break;
                    case "Isoceles":
                            area = Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
                        break;
                    case "Escaleno":
                            area = Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
                        break;
                }
            }
            return area;
        }   

        public double Perimetro()
        {
            double perimetro = 0;

            double lado1 = Math.Round(DistanciaPunto1A2());
            double lado2 = Math.Round(DistanciaPunto2A3());
            double lado3 = Math.Round(DistanciaPunto3A1());

            if (ValidarTriangulo())
            {
                perimetro = lado1 + lado2 + lado3;
            }
            return perimetro;
        }
    }
} 