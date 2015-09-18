using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de espacio a almacenar");

            int[] array;

            int renglones = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            
 
           array = new int[renglones];

            for (int i=0; i < array.Length; i++) {

                //Console.WriteLine("Proporciona el dato");

                array[i] = r.Next(60);//Convert.ToInt32(Console.ReadLine()); 
                
            }
            foreach(int re in array){
                Console.Write("{0},",re);
            }
            



                Console.ReadKey();
        }
    }
}
