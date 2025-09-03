namespace _12.While4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar algoritmo que permita obtener la suma de todos los números impares hasta el 99.*/

            int numim = 0;
            int i2 = 1;

            while (i2 < 100)
            {
                numim = numim + i2;
                Console.WriteLine($"Num: {numim}");
                i2 = i2 + 2;
            }

            Console.WriteLine($"La suma de los numeros impares hasta el 99 es {numim}");
        }
    }
}
