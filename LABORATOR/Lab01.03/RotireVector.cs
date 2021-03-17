using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01._03
{
    class RotireVector
    {
        static void Main(string[] args)
        {
            //Rotirea elementelor unui vector

            Console.Write("Dati numarul de elemente al vectorului: ");
            int lungimeVector = int.Parse(Console.ReadLine());
            int[] vector = new int[lungimeVector];
            for (int i = 0; i < lungimeVector; i++)
            {
                vector[i] = i + 1;
            }
            Console.Write("Vectorul initial este: ");
            afisareVector(vector);
            Console.Write("Dati numarul de rotatii: ");
            int nrRotatii = int.Parse(Console.ReadLine());
            int[] vectorFinal = VectorRotit(vector,nrRotatii);
            Console.Write("Vectorul final este: ");
            afisareVector(vectorFinal);
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
        static int[] VectorRotit(int [] vector, int nrRotatii)
        {
            if (nrRotatii==0)
            {
                return vector;
            }
            int[] aux = new int[vector.Length];
            int j = 0;
            for (int i = nrRotatii; i < vector.Length; i++)
            {
                aux[j] = vector[i];
                j++;
            }
            for (int i = 0; i < nrRotatii; i++)
            {
                aux[j] = vector[i];
                j++;
            }
            return aux;
        }
    }
}
