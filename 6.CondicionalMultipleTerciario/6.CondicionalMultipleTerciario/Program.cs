using System.Net.NetworkInformation;

namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float monto = 0;
            float descuento = 0;
            char dia = ' ';
            int dtoDía = 0;
            string Dia = "";
            bool esValido = true;

            Console.WriteLine("Ingrese el monto de la compra:");
            monto = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dia de la semana (L, M, X, J, V, S, D):");
            dia = Convert.ToChar(Console.ReadLine());
            dia = char.ToUpper(dia); // Aseguramos que el día esté en mayúscula

            switch (dia)
            {
                case 'L':
                    descuento = monto * 0.1f;
                    dtoDía = 10;
                    Dia = "Lunes";
                    break;
                case 'M':
                    descuento = monto * 0.15f;
                    dtoDía = 15;
                    Dia = "Martes";
                    break;
                case 'X':
                    descuento = monto * 0.1f;
                    dtoDía = 10;
                    Dia = "Miercoles";
                    break;
                case 'J':
                    descuento = monto * 0.15f;
                    dtoDía = 15;
                    Dia = "Jueves";
                    break;
                case 'V':
                    descuento = monto * 0.2f;
                    dtoDía = 20;
                    Dia = "Viernes";
                    break;
                case 'S':
                    descuento = monto * 0.2f;
                    dtoDía = 20;
                    Dia = "Sabado";
                    break;
                case 'D':
                    descuento = monto * 0f;
                    dtoDía = 0;
                    Dia = "Domingo";
                    break;
                default:
                    Console.WriteLine("ingresa un día válido (L, M, X, J, V, S, D)");
                    esValido = false;
                    break;
            }

            if (esValido)
            {
                Console.WriteLine($"Hoy es {Dia}, el descuento es del {dtoDía}%, por lo que debes pagar {monto - descuento}");
            }

            /*Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas 
            entre dos números ingresados por el usuario. Las operaciones disponibles serán: suma, resta, multiplicación 
            y división, las cuales se ejecutarán según la opción seleccionada por el usuario.*/

            int num1, num2;
            char op;
            double resultado = 0;

            Console.WriteLine("Ingrese el primer número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la operación a realizar (+, -, *, /):");
            op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine($"La suma de {num1} y {num2} es: {resultado}");
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine($"La resta de {num1} y {num2} es: {resultado}");
                    break;
                case '*':
                    resultado = num1 * num2;
                    Console.WriteLine($"La multiplicación de {num1} y {num2} es: {resultado}");
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        resultado = (double)num1 / num2;
                        Console.WriteLine($"La división de {num1} entre {num2} es: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: División por cero no permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Operación no válida. Por favor, ingrese una operación válida (+, -, *, /).");
                    break;
            }

            /*Diseñar un algoritmo que solicite al usuario un número del 1 al 12, correspondiente a un mes del año 
            (1 para enero, 2 para febrero, etc.). El algoritmo debe mostrar en pantalla el nombre del mes 
            seleccionado y la cantidad de días que contiene. */

            int mes = 0;
            int dias = 0;
            string nombreMes = "";
            esValido = true;

            Console.WriteLine("Ingrese un número del 1 al 12 para seleccionar un mes:");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    nombreMes = "Enero";
                    dias = 31;
                    break;
                case 2:
                    nombreMes = "Febrero";
                    dias = 28; // Considerando un año no bisiesto
                    break;
                case 3:
                    nombreMes = "Marzo";
                    dias = 31;
                    break;
                case 4:
                    nombreMes = "Abril";
                    dias = 30;
                    break;
                case 5:
                    nombreMes = "Mayo";
                    dias = 31;
                    break;
                case 6:
                    nombreMes = "Junio";
                    dias = 30;
                    break;
                case 7:
                    nombreMes = "Julio";
                    dias = 31;
                    break;
                case 8:
                    nombreMes = "Agosto";
                    dias = 31;
                    break;
                case 9:
                    nombreMes = "Septiembre";
                    dias = 30;
                    break;
                case 10:
                    nombreMes = "Octubre";
                    dias = 31;
                    break;
                case 11:
                    nombreMes = "Noviembre";
                    dias = 30;
                    break;
                case 12:
                    nombreMes = "Diciembre";
                    dias = 31;
                    break;
                default:
                    Console.WriteLine("Número no válido. Por favor, ingrese un número del 1 al 12.");
                    break;
            }
            if (esValido)
            {
                Console.WriteLine($"El mes seleccionado es {nombreMes} y tiene {dias} días.");
            }
        }
    }
}
