using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[10, 20];

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingresa el valor para la posición {i}, {j}");
                    numeros[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine($"El valor de la posición {i}, {j} es {numeros[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
