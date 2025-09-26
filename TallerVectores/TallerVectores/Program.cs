namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1:
            /*int[] numeros = new int[15];

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese el número entero para la posición {i + 1}");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            for (int i = 0; i < numeros.Length ; i++)
            {
                Console.Write(numeros[i] + ", ");
            }
            Console.WriteLine($"\nEl valor más alto de los números ingresados es {numeros.Max()}");
            Console.WriteLine($"El valor más bajo de los números ingresados es {numeros.Min()}");

            // Ejercicio 2:

            char[] caracteres = new char[5];

            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.WriteLine($"Ingresa un caracter para la posición {i + 1}");
                caracteres[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine($"Los caracteres ingresados, escritos en secuencia contraria, son");
            for (int i = caracteres.Length - 1; i >= 0; i--)
            {
                Console.Write(caracteres[i] + ", ");
            }*/

            // Ejercicio 3:

            Random ran = new Random();
            int[] numsAleatorios = new int[20];
            int[] posiciones = new int[20];
            int numUsuario = 0, j = 0;
            bool numEncontrado = false;

            for (int i = 0; i < numsAleatorios.Length; i++)
            {
                numsAleatorios[i] = ran.Next(0,50);
            }

            Console.WriteLine("Ingrese un número entre 1 y 50 para buscarlo en el vector");
            numUsuario = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numsAleatorios.Length; i++)
            {
                if (numsAleatorios[i] == numUsuario)
                {
                    posiciones[j] = i + 1;
                    j++;
                    numEncontrado = true;
                }
                else if (i == numsAleatorios.Length && numEncontrado == false)
                {
                    Console.WriteLine("El número no fue encontrado");
                }
            }

            if (numEncontrado == true)
            {
                Console.WriteLine("El número fue encontrado en la(s) posicion(es):");
                for (int i = 0; i < j; i++)
                {
                    Console.Write($"{posiciones[i]}, ");
                }
                Console.WriteLine();
                for (int i = 0; i < numsAleatorios.Length; i++)
                {
                    if (numsAleatorios[i] == numUsuario)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.White;

                    Console.Write(numsAleatorios[i] + ", ");
                }
            }
            else
                Console.WriteLine("\n" + -1);
        }
    }
}
