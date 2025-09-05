namespace _16.While8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*16. Escribe un algoritmo en el que el ordenador elija un 
             número aleatorio entre 1 y 100. El usuario debe adivinar 
             el número, y el programa debe decirle si su intento es 
             demasiado alto, demasiado bajo o correcto. Usa un ciclo 
             while para seguir pidiendo intentos hasta que el usuario 
             adivine el número. */

            Random rand = new Random();
            int num = rand.Next(1,100);
            int intento = 0;
            int i = 0; // Extra: Para contar el número de intentos

            Console.WriteLine("He elegido un número entre 1 y 100, intenta adivinarlo");

            while (intento != num)
            {
                Console.WriteLine("Ingresa tu número"); 
                intento = Convert.ToInt32(Console.ReadLine());

                if (intento > num)
                {
                    Console.WriteLine("El número a adivinar es menor que eso");
                    i++;
                }
                else if (intento < num)
                {
                    Console.WriteLine("El número a adivinar es mayor que eso");
                    i++;
                }
                else if (intento == num)
                {
                    Console.WriteLine("Felicidades, ¡adivinaste! El número era " + num + ", adivinar te costó " + i + " intentos");
                }
            }
        }
    }
}
