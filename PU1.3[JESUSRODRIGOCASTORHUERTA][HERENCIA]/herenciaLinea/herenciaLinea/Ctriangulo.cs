using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace herenciaLinea
{
    class Ctriangulo
    {
        private string _nomTriangulo;
        private int _numLinea;
        private Linea[] lin;

        public string NombreTriangulo { get { return _nomTriangulo; } set { _nomTriangulo = value; } }

        #region Constructor
        public Ctriangulo()
        {
            _nomTriangulo = " ";
            _numLinea = 3;
            lin = new Linea[_numLinea];
            Random ale = new Random();

            for (int i = 0; i < lin.Length; i++)
            {
                lin[i] = new Linea();
                lin[i].X1 = ale.Next(1,50);
                lin[i].X2 = ale.Next(40,60);
                lin[i].Y1 = ale.Next(4,40);
                lin[i].Y2 = ale.Next(5,10);
                
            }
        }
      #endregion 
        
        #region Metodo de calcular el perimetro
        public double PerimetroTriangulo()
        {
            double sumaPerimetro = 0;
            for (int i = 0; i < _numLinea; i++)
            {
                sumaPerimetro = lin[i].calcularLinea();
                
            }
            return sumaPerimetro;
           
        }
        #endregion

        #region Obtener altura
        public double ObtenerAltura()
        {
            double numerador = 3 * lin[0].calcularLinea();
            double numeradorRaiz = Math.Sqrt(numerador);
            double total = numeradorRaiz / 2;
            return total;
        }
        #endregion

        #region Area triangulo
        public double CalcularAreaTriangulo()
        {
            return (lin[0].calcularLinea() * ObtenerAltura())/2;
        }
        #endregion

        #region Buscar Nombre Triangulo

        public void nombreTriangulo()
        {
            for (int i = 0; i < lin.Length; i++)
            {
               
                
            }
        }
        #endregion
    }
}



        


       



    