using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Krug
    {
        private int r;
        public void Vuved()
        {
            Console.WriteLine("vuvedi Radiusa = ");
            r=int.Parse(Console.ReadLine());
        }
        public double Area ()
        {
         double S =Math.PI * Math.Pow(r,2);
            Console.WriteLine($"S ={S:f2}");
            return S;
        }
    }
}
