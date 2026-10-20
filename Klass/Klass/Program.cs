using System;

namespace Klass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi usporednik"); 
            Usporednik figura = new Usporednik();
            figura.Vuvedi();
            Console.WriteLine($"S ={figura.Area()} ");
            
            Console.WriteLine("Vuvedi strani na petougulnik");
            Petougulnik figura2 = new Petougulnik();
            figura2.Vuvedi();
            figura2.Area();
        }
    }
    class Usporednik
    {
        private int a;
        private int ha;
        public void Vuvedi()
        {
            Console.WriteLine("a=");
            a =int.Parse(Console.ReadLine());
            Console.WriteLine("ha =");
            ha =int.Parse(Console.ReadLine());
        }
        public int Area()
        {
            return a*ha;   
        }



    }




}
