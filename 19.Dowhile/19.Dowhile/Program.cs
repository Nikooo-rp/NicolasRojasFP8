namespace _19.Dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*19. En un grupo de 100 alumnos, se desea saber cuántos de los estudiantes son hombres
            y cuántos son mujeres, además se desea saber cuántos son mayores de edad y cuántos no.*/ 

            int edad = 0, menorEdad = 0, mayorEdad = 0, hombres = 0, mujeres = 0, numeroEstudiantes = 0, genero = 0;
            int cantidad = 5;
            do
            {
                Console.WriteLine("Por favor ingrese su edad");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("¿Cuál es su género?");
                Console.WriteLine("1. Hombre    2. Mujer");
                genero = Convert.ToInt32(Console.ReadLine());

                if (edad >= 18)
                {
                    mayorEdad++;
                }
                else
                {
                    menorEdad++;
                }

                if (genero == 1)
                {
                    hombres++;
                }
                else if (genero == 2)
                {
                    mujeres++;
                }
                else
                {
                    Console.WriteLine("Genero introducido incorrecto, se descartará del resultado final");
                }
                numeroEstudiantes++;
            } while (numeroEstudiantes < cantidad);

            Console.WriteLine($"De los {cantidad} estudiantes, {mayorEdad} son mayores de edad, {menorEdad} son menores de edad, {hombres} son hombres y {mujeres} son mujeres");
        }
    }
}
