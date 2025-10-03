namespace _31.Modular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplosDeCinco = new int[CapturarFilas(), CapturarColumnas()];
        }

        static int[,] LlenarMatriz(int[,] matriz)
        {
            return matriz;
        }
        static int CapturarFilas()
        {
            Console.WriteLine("Ingrese el número de filas para la matriz");
            int filas = Convert.ToInt32(Console.ReadLine());
            return filas;
        }

        static int CapturarColumnas()
        {
            Console.WriteLine("Ingrese el número de columnas para la matriz");
            int columnas = Convert.ToInt32(Console.ReadLine());
            return columnas;
        }

        static void BorrarPantalla()
        {
            Console.Clear();
        }
    }
}
