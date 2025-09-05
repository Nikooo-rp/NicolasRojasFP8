using System.Reflection.Metadata.Ecma335;

namespace _17.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, num = 0;

            do
            {
                i++;
                num += i;
            }
            while (i < 5);

            Console.WriteLine($"La suma de los primeros cinco números enteros es {num}");

            /*17. Algoritmo que solicita un número y genere su correspondiente tabla de 
              multiplicar desde el 1 hasta el 10. Y así sucesivamente hasta que el 
              usuario ya no desee continuar generando tablas de multiplicar. */

            bool gen = true;
            i = 0;
            int num1 = 0;
            int resultado = 0;

            do
            {
                i = 0;
                num1 = 0;
                resultado = 0;
                string rta = "";
                Console.WriteLine("Ingrese un número para sacar su tabla de multiplicar");
                num1 = Convert.ToInt32(Console.ReadLine());

                while(i < 10)
                {
                    i++;
                    resultado = num1 * i;
                    Console.WriteLine($"{num1} * {i} = {resultado}");
                }

                Console.WriteLine("¿Quieres Continuar? y/n");
                rta = Console.ReadLine().ToLower();
                switch (rta)
                {
                    case "y":
                        break;
                    case "n":
                        gen = false;
                        break;
                    default:
                        gen = false;
                        Console.WriteLine("Respuesta inválida, se asumirá que no");
                        break;
                }

            }
            while (gen);
        }
    }
}
