using System;
using System.Reflection.Emit;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
              numero2, numero3 respectivamente.El algoritmo debe comprobar si los números son
              diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
              pantalla los números de menor a mayor.*/

            int numero1, numero2, numero3;

            Console.WriteLine("Ingrese el primer número:");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            numero3 = Convert.ToInt32(Console.ReadLine());

            if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3)
            {
                if (numero1 > numero2 && numero1 > numero3)
                {
                    if (numero2 > numero3)
                    {
                        Console.WriteLine($"El número mayor es {numero1}. De menor a mayor: {numero3}, {numero2}, {numero1}");
                    }
                    else
                    {
                        Console.WriteLine($"El número mayor es {numero1}. De menor a mayor: {numero2}, {numero3}, {numero1}");
                    }
                }
                else if (numero2 > numero1 && numero2 > numero3)
                {
                    if (numero1 > numero3)
                    {
                        Console.WriteLine($"El número mayor es {numero2}. De menor a mayor: {numero3}, {numero1}, {numero2}");
                    }
                    else
                    {
                        Console.WriteLine($"El número mayor es {numero2}. De menor a mayor: {numero1}, {numero3}, {numero2}");
                    }
                }
                else // numero3 es el mayor
                {
                    if (numero1 > numero2)
                    {
                        Console.WriteLine($"El número mayor es {numero3}. De menor a mayor: {numero2}, {numero1}, {numero3}");
                    }
                    else
                    {
                        Console.WriteLine($"El número mayor es {numero3}. De menor a mayor: {numero1}, {numero2}, {numero3}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Los números no son diferentes.");
            }

            /* El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si
             cuenta con munición y si se encuentra en estado invencible, crear un programa que:
             a.Permita ingresar por teclado si el personaje está en estado invencible(True).
             b.La cantidad de munición que tiene el personaje en el momento será calculada por el
                sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#.
             c.Si el estado del personaje es invencible(true) y su cantidad de munición está entre 1 y
                10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario
                no hacer nada.*/

            bool invencible = false;
            int municion;
            Random rand = new Random();
            municion = rand.Next(0, 11); // Genera un numero aleatorio entre 0 y 10

            Console.WriteLine("¿El personaje está en estado invencible? (Verdadero(V) o Falso(F)) ");
            if (Console.ReadLine().ToUpper() == "V")
            {
                invencible = true;
            }
            else if (Console.ReadLine().ToUpper() == "F")
            {
                invencible = false;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Asumiendo que el personaje no está invencible.");
            }

            Console.WriteLine(invencible && municion > 0 && municion <= 10 ? "El personaje está disparando" : "");

            /*Crear un algoritmo que permita ingresar las coordenadas x,y, para tres puntos: P1(x1, y1),
            P2(x2, y2), P3(x3, y3).Luego calcular la distancia entre los puntos P1  P2, P2  P3, P 1
            P3.La distancia entre dos puntos está dada por la siguiente formula:
                        d = √((x2 - x1)² +(y2 - y1)²)
            Después de haber calculado la distancia entre los puntos, el algoritmo debe decir si con
            dichas distancias se puede construir un triángulo, consultar las condiciones que se deben
            cumplir para realizar dicha construcción.En caso contrario, decir cuál o cuáles de las
            condiciones no se cumplen. */

            double x1, y1, x2, y2, x3, y3;
            double d1, d2, d3;

            Console.WriteLine("Ingrese la coordenada x del punto P1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y del punto P1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada x del punto P2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y del punto P2:");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada x del punto P3:");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y del punto P3:");
            y3 = Convert.ToDouble(Console.ReadLine());

            d1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); // Distancia P1 a P2
            d2 = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2)); // Distancia P2 a P3
            d3 = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2)); // Distancia P1 a P3

            /* Para que se pueda formar un triángulo con estos puntos deben cumplirse las siguientes condiciones:
               1. La longitud de los lados debe ser mayor que cero
               2. Los tres puntos no pueden ser colineales */

            // Revisamos si son colineales
            if (d1 == 0 || d2 == 0 || d3 == 0) // Revisamos que las distancias sean mayores a 0
            {
                Console.WriteLine("No se puede formar un triángulo, la longitud de todos los lados debe ser mayor que cero.");
            }
            else if (Math.Abs(d1 + d2 - d3) < 0.0001 || Math.Abs(d1 + d3 - d2) < 0.0001 || Math.Abs(d2 + d3 - d1) < 0.0001)
            {
                Console.WriteLine("Se puede formar un triángulo con los puntos dados.");
            }
            else
            {
                Console.WriteLine("Los puntos son colineales, no se puede formar un triángulo.");
            }

            /*El personaje de un juego, solo se puede mover en forma horizontal(Izquierda o Derecha),
            crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve
            hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado.
             Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la
            derecha
             Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la derecha
             En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra
            dirección”*/

            Console.WriteLine("Presione 'd' para mover a la derecha o 'i' para mover a la izquierda:");
            switch (Console.ReadKey(true).KeyChar)
            {
                case 'd':
                    Console.WriteLine("El personaje se mueve hacia la derecha.");
                    break;
                case 'i':
                    Console.WriteLine("El personaje se mueve hacia la izquierda.");
                    break;
                default:
                    Console.WriteLine("No me puedo mover en otra dirección.");
                    break;

            }

            /*El personaje de un juego, puede realizar diferentes acciones dependiendo del carácter que
            el usuario ingrese, y de la cantidad de vidas que posee. Crear un programa que permita:
             Generar un número aleatorio entre 0 y 5 para simular el número de vidas del personaje.
            (Función Random)
             Si el número de vidas es mayor a 0, el personaje puede realizar acciones en el juego. En
            caso contrario escribir el mensaje “el personaje no posee vidas, y no puede realizar
            ninguna acción”.
             Si el personaje puede realizar acciones, escribir los siguientes mensajes de acuerdo al
            carácter que se ingrese:
            o Si se ingresa ‘c’, mostrar en consola “el personaje está disparando”
            o Si se ingresa ‘x’, mostrar en consola “el personaje está hablando con la Rana”
            o Si se ingresa ‘t’, mostrar en consola “el personaje está en modo Turbo”
            o Si se presiona ‘i’, mostrar en consola “el personaje es Invencible” */

            Random rand1 = new Random();
            int vidas = rand1.Next(0, 6); // Genera un numero aleatorio entre 0 y 5
            Console.WriteLine($"El personaje tiene {vidas} vidas.");

            switch (vidas > 0)
                            {
                case true:
                    Console.WriteLine("Ingrese una acción para el personaje: 'c' para disparar, 'x' para hablar con la Rana, 't' para modo Turbo, 'i' para Invencible:");
                    char accion = Console.ReadKey(true).KeyChar;
                    switch (accion)
                    {
                        case 'c':
                            Console.WriteLine("El personaje está disparando.");
                            break;
                        case 'x':
                            Console.WriteLine("El personaje está hablando con la Rana.");
                            break;
                        case 't':
                            Console.WriteLine("El personaje está en modo Turbo.");
                            break;
                        case 'i':
                            Console.WriteLine("El personaje es invencible.");
                            break;
                        default:
                            Console.WriteLine("Acción no reconocida.");
                            break;
                    }
                    break;
                case false:
                    Console.WriteLine("El personaje no posee vidas, y no puede realizar ninguna acción.");
                    break;
            }

        }
    }
}
