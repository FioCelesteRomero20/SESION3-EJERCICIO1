using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SESION3_EJERCICIO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipo de fruta");
            Console.WriteLine("0: Naranja");
            Console.WriteLine("1: Fresa");
            Console.WriteLine("2: Mango");
            string tipoTexto = Console.ReadLine();

            Console.WriteLine("Ingrese la distancia");
            string distanciaTexto = Console.ReadLine();

            float distancia = float.Parse(distanciaTexto);
            int tipoFruta = int.Parse(tipoTexto);
            float pago = 0f;

            switch (pago)
            {
                case 0:
                    if (distancia < 30)
                    {
                        pago = 2;
                    }
                    else
                    {
                        pago = 4;
                    }
                    break;
                case 1:
                    if (distancia < 30)
                    {
                        pago = 6;
                    }
                    else
                    {
                        pago = 9;
                    }
                    break;
                case 2:
                    if (distancia < 30)
                    {
                        pago = 3;
                    }
                    else
                    {
                        pago = 5;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("El pago es: " + pago);
            Console.ReadLine();
        }
    }
}
