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
           /* int[,] numeros = new int[10, 20];
            int[] sumaColumnas = new int[numeros.GetLength(1)];

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
                    sumaColumnas[i] = numeros[j, i];
                }
            }

            for (int i = 0;i < sumaColumnas.Length; i++)
            {
                Console.WriteLine(sumaColumnas[i] + " |");
            }*/

            // Punto 2
            Console.WriteLine("Ingresa el numero de filas");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el numero de columnas");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] ints = new int[m, n];
            int[] ultimaFila = new int[ints.GetLength(1)];
            int[,] intsIntercambiado = new int[m, n];

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0;j < ints.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingresa el valor para la posición {i}, {j}");
                    ints[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine(intsIntercambiado.GetUpperBound(0));
            Console.WriteLine(intsIntercambiado.GetUpperBound(1));

            /*for (int i = 0; i < ints.GetLength(1); i++)
            {
                ultimaFila[i] = ints[ints.GetUpperBound(0), i];
            }

            for (int j = 0; j < intsIntercambiado.GetLength(1); j++)
            {
                intsIntercambiado[intsIntercambiado.GetUpperBound(0), j] = ints[ints.GetLowerBound(0), j];
                intsIntercambiado[intsIntercambiado.GetLowerBound(0), j] = ultimaFila[j];
            }

            for (int i = 0; i < ints.GetLength(1); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.Write($"{ints[i, j]} |");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matriz con la primera y última fila intercambiadas");
            for (int i = 0; i < ints.GetLength(1); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.Write($"{intsIntercambiado[i, j]} |");
                }
                Console.WriteLine();
            }*/
        }
    }
}
