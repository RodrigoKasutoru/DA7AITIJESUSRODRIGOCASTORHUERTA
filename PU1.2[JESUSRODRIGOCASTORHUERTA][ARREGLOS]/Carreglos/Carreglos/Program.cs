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
            string repeticion;
            do
            {
            
            Menu.VentanaPrinsipal();
            

            Console.Write(">"); string seleccion = Console.ReadLine();
            
            switch(seleccion)
            {
                case "1":
                   
                    {
                        string rep;

                        do
                        {
                            Console.WriteLine("Inserta el numero de casillas para el arreglo");

                            Console.Write("->"); int reng = Convert.ToInt32(Console.ReadLine());

                            carreglos carreglos = new carreglos(reng);

                            carreglos.generarDatosArregloSimple();

                            Console.WriteLine("--------------------------------------------------------------------------------");
                            carreglos.mostrarInfoMatrizSimple();
                            Console.WriteLine("--------------------------------------------------------------------------------");

                            Console.WriteLine("El promedio de la matriz es: {0}", carreglos.promedioArregloSimple());

                            Console.WriteLine();

                            Console.WriteLine("Quieres hacer otro arreglo s = si y presione alguna otra tecla para no");

                            Console.Write("->"); rep = Console.ReadLine();


                        } while (rep == "s");

                       
                    }break;

                case "2":
                    {
                        string rep;
                        do
                        {
                            Console.WriteLine("Inserta el numero de casillas para los arreglos");

                            Console.Write("->"); int reng = Convert.ToInt32(Console.ReadLine());

                            carreglos carreglos = new carreglos(reng);

                            carreglos.generarDatosMultiplicacionArreglos();

                            carreglos.multiplicarArreglos();

                            carreglos.mostrarMultiplicacionArreglos();
                            
                            Console.WriteLine();

                            Console.WriteLine("Quieres hacer otro arreglo s = si y presione alguna otra tecla para no");

                            Console.Write("->"); rep = Console.ReadLine();


                            
                        } while (rep == "s");

                        
                    }break;

                default:
                    Console.WriteLine("No escogiste ninguna opcion");
                    break;

                  


            }
                Console.WriteLine("Quieres ejecutar otro programa s = si o presione cualquier otra tecla para salir");
                Console.Write(">"); repeticion = Console.ReadLine();


            }while(repeticion == "s");
           
        }
    }
}
