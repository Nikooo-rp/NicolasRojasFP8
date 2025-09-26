namespace _26.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[2,2]; // rango = 4
            string[,] nombres = new string[2,3]; // rango = 6

            // Asignación de datos
            numeros[0, 0] = 25;
            numeros[0, 1] = 46;
            numeros[1, 0] = 42;
            numeros[1, 1] = 78;
            // numeros[1, 2] = 2; Error índice fuera del rango.

            // Otra forma de declarar e inicializar matrices
            string[,] apellidos ={ {"Chica", "Álvarez"}, {"Cardona","Ríos"},{"López","Mejía"}};

            // Recuperar datos de la matriz
            Console.WriteLine(apellidos[1, 1]);

            // Recorrer matrices - Almacenar datos
            char[,] caracteres = new char[3, 2]; // rango = 6
            for (int i = 0; i < 3; i++) // Filas
            {
                for (int j = 0; j < 2; j++) // Columnas
                {
                    Console.WriteLine($"Ingrese el caracter para la posición {i}, {j}");
                    caracteres[i,j] = Convert.ToChar(Console.ReadLine());
                }
            }

            // Recorrer matrices - Almacenar datos
            for (int i = 0; i < caracteres.GetLength(0); i++) // GetLength(0) Devuelve el número de filas
            {
                for (int j = 0; j < caracteres.GetLength(1); j++) // GetLength(1) Devuelve el numero de columnas
                {
                    Console.Write(caracteres[i,j] + " ");
                    Console.WriteLine();
                }
            }

            // Rango de la matriz
            Console.WriteLine(caracteres.Length);

            int[,] dieces = new int[4, 4];
            for (int i = 0; i < dieces.GetLength(0); i++)
            {
                for (int j = 0; j < dieces.GetLength(1); j++)
                {
                    dieces[i, j] = 10;
                }
            }
            for (int i = 0; i < dieces.GetLength(0); i++)
            {
                for (int j = 0; j < dieces.GetLength(1); j++)
                {
                    Console.Write(dieces[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
