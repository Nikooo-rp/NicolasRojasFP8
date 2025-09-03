namespace _10.While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita calcular la factorial de un número dado 
             por el usuario. (5! = 1 * 2 * 3 * 4 * 5)*/

            Console.WriteLine("Ingresa un número para calcular su factorial:");
            int numero = int.Parse(Console.ReadLine());
            int fact = 1; 
            int i = 1;

            while (i <= numero)
            {
                fact = fact * i;
                i++;
            }

            Console.WriteLine($"El factorial es {fact}");
        }

    }
}
