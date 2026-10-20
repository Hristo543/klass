using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klass
{
    internal class Petougulnik
    {
        private double g;
       
        private double r;  
        public void Vuvedi()
        {
           Console.WriteLine("strana g =");
            g =int.Parse(Console.ReadLine());

            Console.WriteLine("vuvedi visochina r");
            r =int.Parse(Console.ReadLine());

            
        }
        public double Area()
        {
            double s = (5 * g * r) / 2;
            Console.WriteLine($"S ={s}");
            return s;

        }
    }
}
