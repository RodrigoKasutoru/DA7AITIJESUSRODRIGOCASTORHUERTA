using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace herenciaLinea
{
    class Program
    {
        static void Main(string[] args)
        {
            #region practica de linea comentada
            /*
            //Solo calcula la distancia
            Linea lin1 = new Linea();
            lin1.X1 = 178;
            lin1.X2 = 92;
            lin1.Y1 = 80;
            lin1.Y2 = 192;

            double resLinea = lin1.calcularLinea();
            Console.WriteLine(resLinea);

            //Solo calcula la distancia
            Linea lin2 = new Linea();
            lin2.X1 = 237;
            lin2.X2 = 178;
            lin2.Y1 = 192;
            lin2.Y2 = 80;

            double resLinea2 = lin2.calcularLinea();
            Console.WriteLine(resLinea2);

            //Solo calcula la distancia
            Linea lin3 = new Linea();
            lin3.X1 = 237;
            lin3.X2 = 178;
            lin3.Y1 = 192;
            lin3.Y2 = 80;

            double resLinea3 = lin3.calcularLinea();
            Console.WriteLine(resLinea3);

            Console.WriteLine("El perimetro es {0}",(resLinea+resLinea2+resLinea3));
           */
            #endregion

            #region Triangulo
            
            string operacion;
            do
            {
            Ctriangulo triangulo = new Ctriangulo();

                string repetir;
                do
                {
                    
                 
            Console.WriteLine("Selecciona la operacion del triangulo 1- perimetro, 2-area");
            string leer = Console.ReadLine();

             switch (leer)
            {
                case "1":
                   Console.WriteLine("El perimetro del triangulo  {0} es {1}",triangulo.NombreTriangulo, triangulo.PerimetroTriangulo());
                    break;
                case "2":
                    Console.WriteLine("El area del triangulo es {0} es {1}",triangulo.NombreTriangulo, triangulo.CalcularAreaTriangulo());
                    break;
                default:
                    Console.WriteLine("seleccion invalida");
                    break;

                     
                     
            }
             Console.WriteLine("Quieres realisar otra operacion s = si o presione otra tecla para destruir el triangulo");
             repetir = Console.ReadLine();

                }while(repetir == "s");
             triangulo = null;

             Console.WriteLine("Quieres realisar Crear otro triangulo s = si o presione otra tecla para salir");
             operacion = Console.ReadLine();
             
               
           }while(operacion == "s");
            #endregion
            
        }
    }
}
