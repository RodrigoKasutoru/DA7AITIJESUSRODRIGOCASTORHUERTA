using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Sumar
    {
        private int inum1, inum2;

            public Sumar(int inum1,int inum2) {
            
                this.inum1 = inum1;
            
                this.inum2 = inum2;
        
            }      
        
            public int suma() {
        
                return inum1 + inum2;
        
            }

            public int restar()
            {

                return inum1 - inum2;

            }

            public int multiplicar() {

                return inum1 * inum2;
            }

            public int dividir() {

                return inum1 / inum2;
            }

    }
}
