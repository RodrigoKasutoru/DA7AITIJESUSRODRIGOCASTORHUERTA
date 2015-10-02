using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hererncia
{
    class Hijo:Padre
    {
        public Hijo() {
            Console.WriteLine("Invocando el constructor hijo");
        }
        ~Hijo() {
            Console.WriteLine("Invocando el destructor del hijo");
            Console.ReadLine();
        }
    }
}
