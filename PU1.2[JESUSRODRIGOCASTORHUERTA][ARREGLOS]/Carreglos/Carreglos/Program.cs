using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string rep;
           do
           {
            Console.WriteLine("Inserta el numero de renglones");

            Console.Write("->"); int reng = Convert.ToInt32(Console.ReadLine());

            carreglos carreglos = new carreglos(reng);

            carreglos.generarDatos();

            Console.WriteLine("--------------------------------------------------------------------------------");
            carreglos.mostrarInfoMatriz();
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("El promedio de la matriz es: {0}", carreglos.promedio());

            Console.WriteLine();
            Console.WriteLine("Quieres hacer otro arreglo s = si y presione alguna otra tecla para no");

            Console.Write("->"); rep = Console.ReadLine();

             
           }while(rep=="s");
           
        }
    }
}
