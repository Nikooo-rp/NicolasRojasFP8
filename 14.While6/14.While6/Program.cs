namespace _14.While6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*14. Escribir un algoritmo que cuente cuántos números pares hay en un rango 
              de números del 1 al número n.*/

            Console.WriteLine("Escriba hasta qué numero quiere contar los numeros pares");
            int max = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            int num = 0;

            while (i <= max)
            {
                i += 2;
                num += i;
                Console.WriteLine(num);
            }
        }
    }
}
