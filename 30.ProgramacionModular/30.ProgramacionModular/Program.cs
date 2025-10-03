namespace _30.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensajes("Mi nombre es Nicolás");
            MostrarMensajes($"Tengo {CalcularEdad(2025, 2007)} años");
        }

        static void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido a la clase de programación modular");
        }

        static void MostrarMensajes(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        int CalcularEdad()
        {
            int edad;
            edad = 2025 - 2007;
            return edad;
        }

        static int CalcularEdad(int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }
    }
}
