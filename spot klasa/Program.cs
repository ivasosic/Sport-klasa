
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spot_klasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sport Nogomet = new sport("Nogomet", true, 22 );
            sport Curling = new sport("Curling", true, 4);
            sport Vaterpolo = new sport("Vaterpolo", false, 14);

            Console.WriteLine(Nogomet.ToString());
            Console.WriteLine(Curling.ToString());
            Console.WriteLine(Vaterpolo.ToString());
            Console.ReadKey();

        }
    }
}
