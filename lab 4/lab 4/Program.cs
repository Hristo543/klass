using System;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lice pravougulnik");
            Pravougulnik figura1 = new Pravougulnik();//suzdavane na obekt ime pravougulnik 
            figura1.Value();//dostup do metodite pravougulnik chrez obekt (instanciq)
            Console.WriteLine($"S ={figura1.Area()} ");//izvikvane na metod za namirane na lice na figurata
                                                   //postaven v metod za zveshdane na rezultata

            Console.WriteLine("Lice kvadrat");
            Kvadrat figura2 = new Kvadrat();
            figura2.Vuvedi();
            Console.WriteLine($"S ={figura2.Area()} ");

            Console.WriteLine("krug");
            Krug figura3 = new Krug();
            figura3.Vuved();
            figura3.Area();


        }
    }
    class Pravougulnik 
    {
        private int a;  //pole
        private int b;  //pole 
        public void Value() {//metod za vuveshdane 
            Console.WriteLine("a =") ;
             a =int.Parse(Console.ReadLine());

            Console.WriteLine("b =");
            b =int.Parse(Console.ReadLine());

         }
        public int Area()
        {
            
            return a*b;
        }

    }

}
