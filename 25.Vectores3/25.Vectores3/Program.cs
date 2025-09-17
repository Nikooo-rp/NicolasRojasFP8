namespace _25.Vectores3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que permita solicitar 10 números, los cuales 
             *serán almacenados en un arreglo unidimensional, al final, 
             *debe visualizar el promedio de esos números.*/

            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Ingresa el número para la posición " + (i + 1));
                num[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine($"El promedio de los numeros es {num.Average()}");
        }
    }
}
