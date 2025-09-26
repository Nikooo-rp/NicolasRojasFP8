namespace _28.Matrices3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Clasificación de números en una matriz 
            * Desarrolla una aplicación que realice las siguientes tareas: 
            * Solicita al usuario que ingrese las dimensiones de una matriz (número de filas y columnas). 
            * Recorre la matriz y permite al usuario ingresar un número entero en cada posición. 
            * Una vez cargada la matriz, el programa debe contar cuántos de los números ingresados son positivos, 
            * cuántos son negativos y cuántos son ceros. 
            * Finalmente, muestra por pantalla los totales obtenidos para cada categoría (positivos, negativos y ceros)*/

            int positivos = 0;
            int negativos = 0;
            int ceros = 0;

            Console.WriteLine("Indica el número de filas de la matriz");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ahora indica el número de columnas de la matriz");
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] ints = new int[a, b];

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingresa un numero entero para la casilla de posición {i + 1}, {j + 1}");
                    ints[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    switch (ints[i, j])
                    {
                        case > 0:
                            positivos++;
                            break;
                        case < 0:
                            negativos++;
                            break;
                        case 0:
                            ceros++; 
                            break;
                    }
                }
            }

            Console.WriteLine($"En la matriz hay:");
            Console.WriteLine($"{positivos} numero(s) positivo(s)");
            Console.WriteLine($"{negativos} numero(s) negativo(s)");
            Console.WriteLine($"y {ceros} numero(s) igual(es) a 0");
        }
    }
}
