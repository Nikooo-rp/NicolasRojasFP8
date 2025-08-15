using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _4.CondicionalesCompuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Condicionales compuestos
            /*Crear un algoritmo que permita ingresar el nombre y el 
            * sueldo de una persona, si el sueldo supera los 3000 pesos 
            * mostrar el mensaje en pantalla con el nombre de la persona, 
            * indicando que debe abonar impuestos. De lo contrario 
            * mostrar el mensaje “Persona exenta de impuestos”. */

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
                Console.WriteLine($"{nombre}, persona exenta de impuestos.");
            }
            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, 
            se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”. 
            De lo contrario, mostrar el mensaje “No es apto para el contenido de este 
            sitio web”.*/
            int edad = 0;
            Console.WriteLine("Ingresa tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web.");
            }
            else
            {
                Console.WriteLine("No es apto para el contenido de este sitio web.");
            }

            /*Crear un algoritmo que permita ingresar dos números, 
             si el primer número es mayor al segundo número informar 
             su suma y diferencia, en caso contrario informar el producto 
             y la división del primer número respecto al segundo número. */
            int num1 = 0, num2 = 0;
            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine($"La suma de los numeros es: {num1 + num2}");
                Console.WriteLine($"La diferencia de los numeros es: {num1 - num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"El producto de los numeros es: {num1 * num2}");
                Console.WriteLine($"La división de los numeros es: {num1 / num2}");
            }

            // TAREA
            /*Un cliente se hospeda varias noches en una hostería, 
             el precio por noche es de 200 dólares. Si el usuario se 
             queda más de 3 noches se le aplica un porcentaje de descuento 
             del 17% y si no se aplica un porcentaje de descuento del 2%. 
             Mostrar un mensaje con el monto total que debe pagar el cliente, 
             sabiendo que el usuario indica cuántas noches se va a quedar en 
             la hostería. */
            int noches = 0, costo = 0;
            int precio = 200;

            Console.WriteLine("Ingresa el número de noches que te vas a quedar:");
            noches = Convert.ToInt32(Console.ReadLine());

            if (noches > 3)
            {
                costo = precio * noches;
                costo = costo - costo * 17 / 100; // Aplicar descuento del 17%
            }
            else
            {
                costo = precio * noches;
                costo = costo - costo * 2 / 100; // Aplicar descuento del 2%
            }

            Console.WriteLine($"Debes pagar {costo} por tu estadía");
        }
    }
}
