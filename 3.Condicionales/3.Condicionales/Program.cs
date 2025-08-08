namespace _3.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Debe una persona pagar impuestos si su ingreso es mayor a $3000
            int sueldo = 0;
            string nombre = "";
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo: ");
            sueldo = Convert.ToInt32(Console.ReadLine());
            if (sueldo > 3000)
            {
                Console.WriteLine($"{nombre}, usted debe pagar impuestos.");
            }
            else
            {
                Console.WriteLine($"{nombre}, usted no debe pagar impuestos.");
            }

            /*Crea un algoritmo que lea la edad de un usuario, 
             * si el usuario es mayor de 18, se debe mostrar el 
             * siguiente mensaje: “Bienvenido a mi sitio web”. */
            int edad = 0;
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine("Debes ser mayor de 18 años para entrar al sitio web");
            }
        }
    }
}
