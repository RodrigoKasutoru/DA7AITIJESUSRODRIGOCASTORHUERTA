using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
   public  class Poligono
    {
       //matris para almasenar la cantidad de lineas a crear
       Linea[] matrisLinea;

       //atributo y propiedad para asignar el numero de lados del poligono
       private int _numeroLados;

       public int  NumeroLados
       {
           get { return _numeroLados; }
           set { _numeroLados = value; }
       }
       //atributo y propiedad para asignar el nombre del poligono a crear
       private string _nombrePoligono;

       public string NombrePoligono
       {
           get { return _nombrePoligono; }
           set { _nombrePoligono = value; }
       }

       //constructor del poligono

       public Poligono(int numeroLados)
       {
           //se inicia el nombre de poligono en blanco
           _nombrePoligono = "";
           // se le asigna a la propiedad de numero de lados el valor pasado por el parametro
           NumeroLados = numeroLados;

           //creamos el arreglo con el tamaño por el parametro pasado
            matrisLinea = new Linea[numeroLados];
           //creamos valores aleatorios para crear las lineas del poligono
            Random aleatorio = new Random();
                   
           //creamos un bucle para recorrel el arreglo y crear las lineas
            for (int i = 0; i < matrisLinea.Length; i++)
            {
                //como es un poligono regular todos sus lados son iguales
                //creamos el primer lado del poligono
                if (i == 0)
                {
                    matrisLinea[i] = new Linea();
                    matrisLinea[i].X1 = aleatorio.Next(1, 60);
                    matrisLinea[i].X2 = aleatorio.Next(1, 40);
                    matrisLinea[i].Y1 = aleatorio.Next(1, 80);
                    matrisLinea[i].Y2 = aleatorio.Next(1, 30);
                }
                //creamos los demas lodos establesiendo los valores del primer lado
                //devido que es un poligono regular
                else {
                    matrisLinea[i] = new Linea();
                    matrisLinea[i].X1 = matrisLinea[0].X1;
                    matrisLinea[i].X2 = matrisLinea[0].X2;
                    matrisLinea[i].Y1 = matrisLinea[0].Y1;
                    matrisLinea[i].Y2 = matrisLinea[0].Y2;
                    }
            
                }
       }

        #region Calcular Area
       //Metodo para calcular el area del poligono
       public double calcularArea()
       {
           double operacion = calcularPerimetro() * calcularApotema();
           return operacion/2;
       }
       
        #endregion

        #region Calcular Apotema
       //metodo para calcular la apotema del poligono
       private double calcularApotema()
       {
           double operacion = 2 * Math.Tan(36);
           double resultado = _numeroLados / operacion;
           return resultado;
       }
        #endregion

        #region CalcularPerimetro
       //metodo para calcular el perimetro del poligono
       public double calcularPerimetro()
       {
           double suma =0;
           for (int i = 0; i < matrisLinea.Length; i++)
           {
               suma += matrisLinea[i].calcularLinea();


               
           }
           return suma;
       }
        #endregion

        #region nombre poligono
       //metodo para obtener el nombre del poligono
       public string ObtenerNombrePoligono()
       {
            string numero = Convert.ToString(_numeroLados);
           switch (numero)
           {
               case "5":
                   NombrePoligono = "Pentagono";
               break;
               case "6":
                    NombrePoligono = "Hexagono";
               break;
               case "7":
                    NombrePoligono ="Heptagono";
               break;
               case "8":
                     NombrePoligono ="Octagono";
               break;
               case "9":
                      NombrePoligono ="Nonagono";
               break;
               case "10":
                      NombrePoligono = "Decagono";
               break;
               case "11":
                      NombrePoligono ="Endenagono";
               break;
               case "12":
                     NombrePoligono = "Dodecagono";
               break;
              
           }
           return NombrePoligono;
           
       }
            
        #endregion

    }
}

