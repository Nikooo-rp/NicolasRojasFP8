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
