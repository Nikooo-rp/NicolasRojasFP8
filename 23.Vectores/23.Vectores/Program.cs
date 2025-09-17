namespace _23.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos unidimensionales

            int[] numeros = new int[5];
            string[] nombres = new string[4];

            // Asogmar vañpres a las posiciones
            numeros[0] = 20;
            numeros[1] = 15;
            numeros[2] = 5;
            numeros[3] = 30;
            numeros[4] = 45;

            int[] numeros1 = new int[] { 5, 12, 4, 7, 9, 21 };
            int[] numeros2 = { 5, 12, 4, 7, 9 };
            // Puedo recorrer el vector para llenarlo  de datos o para recuperar datos

            char[] caracter = new char[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ingrese el caracter para la posición {i + 1} con índice {i}");
                caracter[i] = Convert.ToChar(Console.ReadLine());
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"El vector caracter, en la posición {i+1}, tiene almacenado el dato: {caracter[i]}");
            }

            for (int i = 0; i < caracter.Length; i++)
            {
                Console.Write($"{caracter[i]} | ");
            }

            //Un algoritmo que guarde nombres y los muestre

            for (int i = 0; i < nombres.Length; i++) //Obtenemos los nombres
            {
                Console.WriteLine("\nIngrese el nombre para la posición " + (i + 1));
                nombres[i] = Console.ReadLine();
            }

            for (int i = 0; i < nombres.Length; i++) //Mostramos los nombres
            {
                Console.Write($"{nombres[i]} | ");
            }
        }
    }
}
