using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreglos
{
    class carreglos
    {
        private double[] arreglo, arreglo2, multiplicacionArreglos;


        public carreglos(int renglones)
        {
            this.arreglo = new double[renglones];
            this.arreglo2 = new double[renglones];
            this.multiplicacionArreglos = new double[renglones];
        }


        public double promedioArregloSimple()
        {
            double sumatoria = 0;
            double res;
            for (int i = 0; i < arreglo.Length; i++)
            {
                sumatoria += arreglo[i];
            }
            return res = sumatoria / arreglo.Length;

        }
        public void mostrarInfoMatrizSimple()
        {
            foreach (var recorrer in arreglo)
            {
                
                Console.Write("{0},", recorrer);


            }
            Console.WriteLine();
        }
        public void generarDatosArregloSimple()
        {
            Random aleatorio = new Random();

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = aleatorio.Next(10);

            }
        }
        public void generarDatosMultiplicacionArreglos()
        {
            Random aleatorio = new Random();

            for (int i = 0; i < multiplicacionArreglos.Length; i++)
            {
                arreglo[i] = aleatorio.Next(10);
                arreglo2[i] = aleatorio.Next(10);

            }
        }
        public void mostrarMultiplicacionArreglos()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (int recorrer = 0; recorrer < multiplicacionArreglos.Length; recorrer++)
            {
                int num = recorrer + 1;

                Console.WriteLine("                               {0}>  {1} * {2} = {3}                                          ",num,arreglo[recorrer], arreglo2[recorrer], multiplicacionArreglos[recorrer]);


            }
                Console.WriteLine("--------------------------------------------------------------------------------");

        }
        public void multiplicarArreglos() {
            for (int i = 0; i < multiplicacionArreglos.Length; i++)
            {
                multiplicacionArreglos[i] = arreglo[i] * arreglo2[i];
                
            }        
        }
    }
}
