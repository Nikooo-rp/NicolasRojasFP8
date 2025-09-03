namespace _11.While3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese
            un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados.*/

            int suma = 0;
            int num = 0;

            while (num >= 0)
            {
                Console.WriteLine("Ingresa un número entero positivo (o un número negativo para terminar):");
                num = int.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    suma += num;
                }
            }

            Console.WriteLine($"La suma total es: {suma}");
        }
    }
}
