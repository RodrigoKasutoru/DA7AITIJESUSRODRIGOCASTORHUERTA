using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Linea:Punto
    {
        private int x1, x2, y1, y2;
        public int X1
        {
            get
            {
                return x1;
            }
            set
            {

                x1 = value;

            }
        }
        public int X2
        {
            get
            {
                return x2;
            }
            set
            {

                x2 = value;

            }
        }
        public int Y1
        {
            get
            {
                return y1;
            }
            set
            {

                y1 = value;

            }
        }
        public int Y2
        {
            get
            {
                return y2;
            }
            set
            {

                y2 = value;

            }
        }
        //constructor
        public Linea()
            : base(0, 0)
        {
            x1 = 0;
            x2 = 0;
            y1 = 0;
            y2 = 0;
        }
        //calcula distancia
        public double calcularLinea()
        {
            double distancia = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            return distancia;

        }
    }
}
