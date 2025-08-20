using System.Security.Cryptography;

namespace _5.CondicionalAnidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1= 0, num2=0, num3=0;

            Console.WriteLine("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1> num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1 + " Es el número mayor");
                }
                else
                {
                    Console.WriteLine(num3 + " Es el número mayor");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num2 + " Es el número mayor");
                }
                else
                {
                    Console.WriteLine(num3 + " Es el número mayor");
                }
            }
        }
    }
}
