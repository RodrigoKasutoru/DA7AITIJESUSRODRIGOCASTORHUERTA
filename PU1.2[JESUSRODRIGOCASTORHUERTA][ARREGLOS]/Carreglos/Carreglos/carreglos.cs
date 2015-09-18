using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreglos
{
    class carreglos
    {
        private double[] renglones;
        
        public carreglos(int renglones)
        {
            this.renglones = new double[renglones];
        }

        public double promedio() {
            double sumatoria = 0;
            double res;
            for (int i = 0; i < renglones.Length; i++)
            {
                sumatoria += renglones[i];
            }
            return res = sumatoria / renglones.Length;
        
        }
        public void mostrarInfoMatriz() {
            foreach (var recorrer in renglones)
            {
                Console.Write("{0},", recorrer);
               
                
            }
            Console.WriteLine();
        }
        public void generarDatos() {
            Random aleatorio = new Random();

            for (int i = 0; i < renglones.Length; i++)
            {
                renglones[i] = aleatorio.Next(10);
                
            }
        }
    }
}
