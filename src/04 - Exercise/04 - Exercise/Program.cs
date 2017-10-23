using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen kalkulaatori programm. Ütle mulle 2 numbrit ja ma ütlen Sulle nende summa");
            Console.WriteLine();
            Console.WriteLine();

            int arv   = int.Parse(Console.ReadLine());
            int arvb  = int.Parse(Console.ReadLine());



            Console.WriteLine("Esimene number:" + arv);
            Console.WriteLine("Teine number:" +  arvb);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Tulemuseks on:" + (arv + arvb));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();


        }
    }
}
