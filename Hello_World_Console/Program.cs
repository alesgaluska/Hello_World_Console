using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace HelloWord_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hello World";

            String cislo1_text;  // standardni vstup cte pouze string
            String cislo2_text;

            Console.Out.WriteLine("Ahoj zadej prvni cislo");
            cislo1_text = Console.ReadLine();

            Console.Out.WriteLine("Ahoj zadej druhe cislo");
            cislo2_text = Console.ReadLine();

            int cislo1 = int.Parse(cislo1_text);
            int cislo2 = int.Parse(cislo2_text);

            int soucet = cislo1 + cislo2;
            int rozdil = cislo1 - cislo2;

            Console.Out.WriteLine("Soucet");
            Console.Out.WriteLine(soucet);
            Console.Out.WriteLine("Rozdil");
            Console.Out.WriteLine(rozdil);

            Console.ReadLine();
        }
    }
}