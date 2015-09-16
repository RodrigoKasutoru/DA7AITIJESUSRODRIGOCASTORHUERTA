using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
           do
           {
            Console.WriteLine("Proporciona el primer valor");
            
            int inum1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ingresa el segundo valor");
            
            int inum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Que tipo de operacion quieres 1 = + ,2 = - , 3 = * , 4 = /");

            string operacion = Console.ReadLine();

            Sumar su = new Sumar(inum1, inum2);

            switch (operacion)
            
            {
            
                case "1":
            
                    Console.WriteLine("El resultado de la suma es {0}", su.suma());
               
                break;
            
                
                case "2":

                     Console.WriteLine("El resultado de la resta es {0}", su.restar());
                
                break;
                
                case "3":

                    Console.WriteLine("El resultado de la multiplicacion es {0}", su.multiplicar());
                
                break;
                
                case "4":
                
                    Console.WriteLine("El resultado de la divicion es {0}", su.dividir());

                break;
                
                default:

                    Console.WriteLine("Operacion no valida");

                 break;
            }
               Console.WriteLine("Quieres hacer otra operación presione s = si y cualquier otra tecla para no");
               
               op = Console.ReadLine();

               op = (op == "s")? op:op = "n";


           }while(op=="s");
            
            
            

          
            
        }
    }
}
