using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración e inicialización de variables
            string nombre = "Nicolás";
            const string iva = "19%";
            string apellidos = "Rojas Padilla";
            Console.Write("Bienvenido al curso de Fundamentos de Programación\n");
            //iva = "20%"; No puedo cambiar el valor de 'iva' porque es una constante
            Console.Write("\t" + nombre + " " + apellidos + " " + iva);
            Console.ReadKey();
        }
    }
}
