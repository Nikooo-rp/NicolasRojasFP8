namespace _15.While7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, 
             si al final de cada mes deposita cantidades variables de dinero; además, 
             se quiere saber cuánto lleva ahorrado cada mes. */

            double total = 0;
            double mensual = 0;
            int i = 1;

            while (i <= 12)
            {
                Console.WriteLine("Ingresa tu depósito del mes " + i);

                mensual = Convert.ToDouble(Console.ReadLine());
                total += mensual;

                Console.WriteLine("Llevas un total de " +  total);

                i++;
            }

            Console.WriteLine("Tu ahorro final de este año es: " + total);
        }
    }
}
