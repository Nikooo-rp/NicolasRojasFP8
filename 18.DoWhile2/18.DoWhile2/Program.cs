using System.Diagnostics.CodeAnalysis;

namespace _18.DoWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que le pida a un grupo de usuarios su nombre, 
             número de cuenta y saldo; para cada usuario se debe hacer lo siguiente: 

                - Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, 
                  el número de cuenta, el saldo y “Es apto para el crédito” 
                - Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, 
                  el número de cuenta, el saldo y “No es apto para el crédito” 

              El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique 
              que ya no se desea preguntar más. 
              Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto 
              por la información, y debe mostrar el promedio de los saldos. */

            int numUsuarios = 0;
            string nombre = "";
            int numCuenta = 0;
            int saldo = 0;
            string bandera = "y";
            double sumaSaldos = 0;

            do
            {
                nombre = "";
                numCuenta = 0;
                saldo = 0;
                numUsuarios++;
                Console.WriteLine("Ingresa tu nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresa tu número de cuenta (Sin puntos ni espacios)");
                numCuenta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa tu saldo");
                saldo = Convert.ToInt32(Console.ReadLine());

                switch (saldo)
                {
                    case > 3000000:
                        Console.WriteLine($"Nombre: {nombre}; Número de cuenta: {numCuenta}; Saldo: {saldo}.");
                        Console.WriteLine("Es apto para el crédito");
                        sumaSaldos += saldo;
                        break;
                    case < 3000000:
                        Console.WriteLine($"Nombre: {nombre}; Número de cuenta: {numCuenta}; Saldo: {saldo}.");
                        Console.WriteLine("No es apto para el crédito");
                        sumaSaldos += saldo;
                        break;
                    default:
                        Console.WriteLine("Valor no válido");
                        break;
                }

                Console.WriteLine("Desea ingresar un nuevo usuario? y/n");
                bandera = Console.ReadLine().ToLower();
            } while (bandera == "y");

            Console.WriteLine($"Se atendieron {numUsuarios} usuarios");
            Console.WriteLine($"El promedio de los saldos ingresados fue {sumaSaldos / numUsuarios}");
        }
    }
}
