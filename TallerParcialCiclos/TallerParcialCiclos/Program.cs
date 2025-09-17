using System;

namespace TallerParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que permita calcular el promedio de calificaciones, el algoritmo
                le permitirá al usuario, introducir tantas calificaciones como así desee,
                en el momento en que seleccione que no desea continuar capturando
                calificaciones, el algoritmo debe presentar el promedio de las
                calificaciones capturadas previamente. */

            double numNotas = 0; // Contador
            double total = 0; // Acumulador
            bool ibool = true; // Esta será la bandera del condicional (bool)

            while (ibool == true)
            {
                Console.WriteLine("Ingresa una calificación");
                total += Convert.ToDouble(Console.ReadLine());
                numNotas++;

                Console.WriteLine("Deseas continuar añadiendo calificaciones? 1. SI    2. NO");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        ibool = true;
                        break;
                    case 2:
                        ibool = false;
                        break;
                    default:
                        Console.WriteLine("Respuesta inválida, se detendrá el proceso");
                        break;
                }
            }

            Console.WriteLine($"El promedio de las calificaciones ingresadas es: {total / numNotas}");

            /*Se requiere un algoritmo para mostrar por pantalla los divisores de un
                número ingresado por teclado.
                Tener en cuenta que dados dos números enteros a y b, se dice que b es
                divisor de a si se cumple que al efectuar una división entera a/b el
                residuo es 0, en C# utilizar el operador Mod para obtener el residuo de
                una división de dos números. */

            int num = 0; // Aquí se almacena el número para hallar sus divisores
            int inum = 1; // Contador del dividendo

            Console.WriteLine("Ingresa un número entero para encontrar sus divisores");
            num = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (num % inum == 0)
                {
                    Console.WriteLine($"{inum} es un divisor de {num}");
                }
                inum++;
            } while (inum <= num);

            /*Dados dos números enteros ingresados por teclado: b que es la base y
              e que es el exponente, se requiere calcular el resultado de la
              potenciación.
            
              Mostrar por pantalla el resultado de la potenciación.
              Seguir pidiendo por teclado la base y el exponente y realizar la
              potenciación correspondiente, hasta que el usuario ingrese por teclado
              el carácter de escape ‘n’*/

            int b = 0;
            int e = 0;
            ibool = true;

            while (ibool == true)
            {
                Console.WriteLine("Ingresa la base para la potencia");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa el exponente para la potencia");
                e = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"La potencia de los números es {Math.Pow(b, e)}");
                Console.WriteLine("Ingresa n para salir, cualquier otra tecla para continuar");

                switch (Console.ReadKey().KeyChar)
                {
                    case 'n':
                        ibool = false;
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }

            /*Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco
              kilómetros durante 10 días, para determinar si es apto para la prueba de
              5 kilómetros. Para considerarlo apto debe cumplir las siguientes
              condiciones:
                 Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos.
                 Que al menos en una de las pruebas realice un tiempo menor de 15
                minutos.
                 Que su promedio sea menor o igual a 18 minutos.
              Diseñar un algoritmo para registrar los datos y decidir si es apto para la
              competencia.*/

            bool c1 = true, c2 = false, c3 = false; // Las condiciones que se deben cumplir
            total = 0; // Para el promedio
            int tiempo = 0;

            for (inum = 1; inum <= 10; inum++)
            {
                Console.WriteLine($"Ingresa el tiempo del día {inum} en minutos");
                tiempo = Convert.ToInt32(Console.ReadLine());

                if (tiempo > 20) // Si se superan los 20 minutos UNA vez, la condición deja de cumplirse
                    c1 = false;
                if (tiempo < 15 && c2 == false) // Esta condición se deja de cambiar una vez es verdadera
                    c2 = true;

                total += tiempo;
            }

            if ((total / inum) < 18) // Se revisa el promedio de los tiempos
                c3 = true;

            Console.WriteLine("El promedio de los tiempos fue: " + (total / inum));

            // Se informa al usuario de las condiciones cumplidas
            if (c1 == true)
                Console.WriteLine("El tiempo todos los días fue menor a 20 minutos");
            else
                Console.WriteLine("El tiempo no fue menor a 20 minutos todos los días");

            if (c2 == true)
                Console.WriteLine("Se consiguió un tiempo menor a 15 minutos al menos una vez");
            else
                Console.WriteLine("No se consiguió un tiempo menor a 15 minutos ni una vez");

            if (c3 == true)
                Console.WriteLine("El promedio de los tiempos fue menor a 18 minutos");
            else
                Console.WriteLine("El promedio de los tiempos fue mayor a 18 minutos");
            // Fin del informe

            if (c1 && c2 && c3) // Se revisa que se cumplan todas las condiciones
                Console.WriteLine("El atleta es apto para la prueba de 5 kilómetros");
            else
                Console.WriteLine("El atleta no es apto para la prueba de 5 kilómetros");

            /*Se aplicó una encuesta a n personas solicitando su opinión sobre el
              tema del servicio militar obligatorio para las mujeres. Las opciones de
              respuesta fueron: a favor, en contra y no responde. Se solicita un
              algoritmo que calcule qué porcentaje de los encuestados marcó cada
              una de las respuestas. */

            double n = 0; // Numero de personas
            double aFavor = 0, enContra = 0, noResponde = 0; // Numero de respuestas
            inum = 1; // Reutilizamos inum como contador

            Console.WriteLine("Ingresa el número de personas encuestadas");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Se encuestaron a " + n + " personas");

            while (inum <= n)
            {
                Console.WriteLine("Ingresa la respuesta de la persona #" + inum);
                Console.WriteLine("1. A favor    2. En contra    3. No responde");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        aFavor++;
                        break;
                    case 2:
                        enContra++;
                        break;
                    case 3:
                        noResponde++; 
                        break;
                }
                inum++;
            }

            // Se sacan e informan los porcentajes
            Console.WriteLine($"El porcentaje de personas que marcó a favor es {aFavor / n * 100}%");
            Console.WriteLine($"El porcentaje de personas que marcó en contra es {enContra / n * 100}%");
            Console.WriteLine($"El porcentaje de personas que no respondió es {noResponde / n * 100}%");

            /*Realizar un algoritmo que lea 40 números e imprima en pantalla cuántos
              de esos números son positivos, cuántos negativos, cuántos son neutros
              (0); además que imprima por pantalla la sumatoria de los números
              positivos y la de los negativos. */

            inum = 0;
            num = 0;
            int positivos = 0, negativos = 0, neutros = 0;
            total = 0;

            for (inum = 1; inum <= 40; inum++)
            {
                Console.WriteLine($"Ingresa un número ({inum}/40)");
                num = Convert.ToInt32(Console.ReadLine());
                total += num;

                switch (num)
                {
                    case > 0:
                        positivos++;
                        break;
                    case < 0:
                        negativos++;
                        break;
                    case 0:
                        neutros++;
                        break;
                }
            }

            Console.WriteLine("La cantidad de números positivos ingresada es: " + positivos);
            Console.WriteLine("La cantidad de números negativos ingresada es: " + negativos);
            Console.WriteLine("La cantidad de números neutros (0) ingresada es: " + neutros);
            Console.WriteLine("La sumatoria de los números positivos y negativos es: " + total);

            /*Una persona desea realizar un muestreo con 70 personas para
              determinar el promedio de peso de los niños, jóvenes, adultos y viejos
              que existen en su zona y cuántos son de cada una de las categorías. */

            // Entonces haremos un algoritmo que permita ingresar los 70 datos, los promedie y clasifique

            int niños = 0, jovenes = 0, adultos = 0, viejos = 0, edad = 0;
            double promTotal = 0;

            for (inum = 1; inum <= 70; inum++)
            {
                Console.WriteLine("Ingresa tu edad");
                edad = Convert.ToInt32(Console.ReadLine());

                if (edad > 0 && edad <= 13)
                    niños++;
                else if (edad <= 30)
                    jovenes++;
                else if (edad <= 60)
                    adultos++;
                else if (edad > 60)
                    viejos++;

                Console.WriteLine("Ingresa tu peso");
                promTotal += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"El número de niños es: {niños}");
            Console.WriteLine($"El número de jóvenes es: {jovenes}");
            Console.WriteLine($"El número de adultos es: {adultos}");
            Console.WriteLine($"El número de viejos es: {viejos}");

            Console.WriteLine($"El promedio de los pesos es {promTotal/inum}");
        }
    }
}
