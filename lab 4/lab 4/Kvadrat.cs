using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Kvadrat
    {
        private int c;
        
      public void Vuvedi() {
            Console.Write("c =");
            c = int.Parse(Console.ReadLine());

        }

        public int Area()
        {
            return c*c;
        }
    }
    


}
