namespace ParcialCiclos_NicolasRojasPadilla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Un profesor tiene las calificaciones de 14 alumnos y necesita procesar 
                la información para obtener un análisis general del curso. 
                Las notas se encuentran en un rango de 0 a 10.

                El programa debe realizar las siguientes operaciones:
                    - Leer por teclado la nota de cada uno de los 14 estudiantes.
                    - Calcular el promedio de todas las notas.
                    - Identificar y mostrar cuál fue la nota mayor y la nota menor entre las ingresadas.
                    - Contar cuántos estudiantes aprobaron la asignatura (nota mayor o igual a 6.0).
                    - Mostrar por pantalla:
                        El promedio general.
                        La nota más alta.
                        La nota más baja.
                        La cantidad de aprobados en el curso.*/

            double nota = 0, suma = 0, notaMayor = 0, notaMenor = 0, aprobados = 0;
            bool menorAsignada = false;

            for (int i = 1; i <= 14; i++)
            {
                Console.WriteLine("Ingresa la nota del estudiante " + i + " (0-10)");
                nota = Convert.ToInt32(Console.ReadLine());
                if (menorAsignada == false)
                {
                    notaMenor = nota;
                    menorAsignada = true;
                }

                if (nota > 10 || nota < 0)
                {
                    Console.WriteLine("Nota no válida, se tomará como 0 por defecto");
                    nota = 0;
                }

                suma += nota;
                if (nota > notaMayor)
                    notaMayor = nota;
                else if (nota < notaMenor)
                    notaMenor = nota;

                Console.WriteLine($"La nota menor actual es {notaMenor} y la nota mayor actual es {notaMayor}");

                if (nota >= 6.0)
                {
                    aprobados++;
                }
            }

            Console.WriteLine(" - - - - RESULTADOS - - - - ");
            Console.WriteLine($"El promedio de las notas es {suma / 14}");
            Console.WriteLine($"La nota más alta es {notaMayor} y las más baja es {notaMenor}");
            Console.WriteLine($"La cantidad de estudiantes aprobados es {aprobados}");
        }
    }
}
