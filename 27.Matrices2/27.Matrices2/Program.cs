namespace _27.Matrices2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] nums1 = new int[2, 3];
            int[,] nums2 = new int[2, 3];
            int[,] suma = new int[2, 3];

            for (int i = 0; i < nums1.GetLength(0); i++)
            {
                for (int j = 0; j < nums1.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingresa el número para la posición {i}, {j} de la primera matriz");
                    nums1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < nums2.GetLength(0); i++)
            {
                for (int j = 0; j < nums2.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingresa el número para la posición {i}, {j} de la segunda matriz");
                    nums2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < suma.GetLength(0); i++)
            {
                for (int j = 0; j < suma.GetLength(1); j++)
                {
                    suma[i, j] = nums1[i, j] + nums2[i, j];
                }
            }

            Console.WriteLine("La suma de las matrices es: ");

            for (int i = 0; i < suma.GetLength(0); i++)
            {
                for (int j = 0; j < suma.GetLength(1); j++)
                {
                    Console.Write(suma[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
