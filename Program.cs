using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouctyNminus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MojePole mojePole = new MojePole();
            Console.WriteLine("Maximální součet: " + mojePole.maximalniSoucet());
            Console.WriteLine("Minimální součet: " + mojePole.minimalniSoucet());

        }
    }
}
