using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hererncia
{
    class Padre
    {
        public Padre()
        {
            Console.WriteLine("Invocando al constructor padre");
        }
        ~Padre()
        {
            Console.WriteLine("Invoca al destructor de la clase");
            Console.ReadLine();
        }
    }
}
