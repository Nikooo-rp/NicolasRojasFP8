namespace _13.While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*13. Realizar un algoritmo que le pida al usuario ingresar por teclado números 
             * enteros al azar. Al usuario le corresponde ingresar la cantidad de números 
             * que va a introducir.  
                    El algoritmo debe escribir en pantalla: 
                    La cantidad de números introducidos que son mayores que 0 
                    La cantidad de números introducidos menores que 0  
                    La cantidad de números iguales a 0. */

            int i = 0;
            int mayorCero = 0;
            int menorCero = 0;
            int igualCero = 0;

            Console.WriteLine("Escriba cuántos números quiere ingresar");
            int totalnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ahora ingrese los números");

            while (i < totalnum)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case > 0:
                        mayorCero++;
                        i++;
                        break;
                    case < 0:
                        menorCero++;
                        i++;
                        break;
                    case 0:
                        igualCero++;
                        i++;
                        break;
                }
            }

            Console.WriteLine($"Cantidad de numeros mayores a cero ingresados: {mayorCero}");
            Console.WriteLine($"Cantidad de numeros menores a cero ingresados: {menorCero}");
            Console.WriteLine($"Cantidad de numeros iguales a cero ingresados: {igualCero}");
        }
    }
}
