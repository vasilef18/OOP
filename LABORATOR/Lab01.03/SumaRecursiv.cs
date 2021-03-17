using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01._03
{
    class SumaRecursiv
    {
        static void Main(string[] args)
        {
            //Suma elementelor unui vector
            int[] vector = new int[] { 1, 2, 3, 4, 5,};
            //int rezultat = sumaBasic(vector);
            int rezultat = sumaRecursiv(vector,0);
            Console.Write("Elementele vectorului sunt: ");
            afisareVector(vector);
            Console.Write("Suma elementelor vectorului este: ");
            Console.WriteLine(rezultat);
        }
        static int sumaBasic(int[] vector)
        {
            int suma = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i];
            }
            return suma;
        }
        static void afisareVector(int[] vector)
        {
            int lungimeVector = vector.Length;
            for (int i = 0; i < lungimeVector; i++)
            {
                Console.Write($"{vector[i]} ");
            }
            Console.WriteLine();
        }
        static int sumaRecursiv(int[] vector, int index)
        {
            if (index==vector.Length)
            {
                return 0;
            }
            return vector[index] + sumaRecursiv(vector, index + 1);
        }
    }
}
