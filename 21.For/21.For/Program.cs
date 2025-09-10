namespace _21.For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que genera y suma los primeros 5 numeros enteros.

            int num = 0;

            for (int i = 0; i <= 5; i++)
            {
                num += i;
            }
            
            Console.WriteLine($"La suma de los primeros 5 numeros enteros es {num}");
        }
    }
}
