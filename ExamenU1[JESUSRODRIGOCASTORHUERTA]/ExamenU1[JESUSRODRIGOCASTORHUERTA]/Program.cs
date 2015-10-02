using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;
namespace ExamenU1_JESUSRODRIGOCASTORHUERTA_
{
    class Program
    {
        static void Main(string[] args)
        {
            string operacion,salir;
          do
          {
            Console.WriteLine("Ingresa el numero de lados mayor a 5 y menor a 12 para el poligono");
            int lados = Convert.ToInt32(Console.ReadLine());
            if (lados >= 5 & lados <= 12)
            {
                Poligono poligo = new Poligono(lados);
                do
                {
                    Console.WriteLine("Ingrese la operacion a realizar del {0} 1 = area 2 = perimetro 3 = perimetro y area",poligo.ObtenerNombrePoligono());
                    string opcion = Console.ReadLine();
                    switch (opcion)
                    {
                        case "1":
                           
                            Console.WriteLine("El area del {0}  es {1}",poligo.ObtenerNombrePoligono(), poligo.calcularArea());
                            break;
                        case "2":
                            Console.WriteLine("El perimetro del {0}  es {1}",poligo.ObtenerNombrePoligono(), poligo.calcularPerimetro());
                            break;
                        case "3":
                             Console.WriteLine("El perimetro del {0}  es {1} y el area es {2}",poligo.ObtenerNombrePoligono(), poligo.calcularPerimetro(),poligo.calcularArea());
                            break;

                        default:
                            Console.WriteLine("Seleccion no valida");
                            break;
                    }


                    Console.WriteLine("Quires realisar otra operacion s = si o presiona una tecla para terminar");
                    operacion = Console.ReadLine();
                } while (operacion == "s");
                poligo = null;
            }
            else
            {
                Console.WriteLine("Operaccion no valida");
            }
            Console.WriteLine("Quieres crear otro poligono s = si o presiona una tecla para salir del programa");
            salir = Console.ReadLine();
          }while(salir == "s");

        }
    }
}
