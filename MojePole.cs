using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SouctyNminus1
{
    internal class MojePole
    {
        int velikostPole;
        int[] hodnoty;
        public MojePole() {
            Console.WriteLine("Jak dlouhé pole chceš vytvořit?");
            while (!int.TryParse(Console.ReadLine(), out velikostPole) || (velikostPole < 0)) { Console.WriteLine("Napiš celé kladné číslo."); }
            hodnoty = new int[velikostPole];
            Console.WriteLine("Zadej hodnoty do pole:");
            for (int i = 0; i < velikostPole; i++)
            {
                Console.Write($"Hodnota {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out hodnoty[i])) { Console.WriteLine($"Hodnota {i + 1}:"); }
            }
            Console.Write("Zadané hodnoty: ");
            foreach (int i in hodnoty) { Console.Write(i+", "); }
            Console.WriteLine();
        }
        public int maximalniSoucet()
        {
            int index = 0;
            int minimalni = hodnoty[index];
            for (int i = 0; i < hodnoty.Length; i++)
            {
                if (hodnoty[i] < minimalni)
                {
                    minimalni = hodnoty[i];
                    index = i;
                }
            }
            return sectiPoleBez(index); }
        public int minimalniSoucet()
        {
            int index = 0;
            int maximalni = hodnoty[index];
            for (int i = 0; i < hodnoty.Length; i++)
            {
                if (hodnoty[i] > maximalni)
                {
                    maximalni = hodnoty[i];
                    index = i;
                }
            }
            return sectiPoleBez(index);
        }
        int sectiPoleBez(int index)
        {
            int soucet = 0;
            foreach (int i in hodnoty) { soucet = soucet + i; }
            return soucet-hodnoty[index];
        }
    }
}
