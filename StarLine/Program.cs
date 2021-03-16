using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLine
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Să se scrie un program orientat pe obiect care să afișeze următoarele linii:
            *
            **
            ***
            ****
            Numărul de linii va fi dat ca parametru al constructorului clasei, clasa va conține și un
            destructor care va afișa un mesaj corespunzător, iar afișarea se va face într-o metodă.*/
            int nrLinii;
            Console.Write("Dati numarul de linii: ");
            nrLinii = int.Parse(Console.ReadLine());
            Star s = new Star(nrLinii);
            s.afisare(nrLinii);
        }
    }

    internal class Star
    {
        private int nrLinii;

        public Star(int nrLinii)
        {
            this.nrLinii = nrLinii;
        }

        internal void afisare(int nrLinii)
        {
            for (int row = 1; row <= nrLinii; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        ~Star()
        {
            Console.WriteLine("Destructor");
        }
    }
}