namespace _20.Dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*20. Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:   
                    El número de partidos perdidos  
                    El número de partidos empatados  
                    El número de partidos ganados  
                    El porcentaje de partidos perdidos  
                    El porcentaje de partidos empatados  
                    El porcentaje de partidos ganados*/

            int i = 1, ganados = 0, perdidos = 0, empatados = 0;
            double porGanados = 0, porPerdidos = 0, porEmpatados = 0, partidos = 30;

            do
            {
                Console.WriteLine($"Partido número {i}, ¿se ganó, se perdió, o se empató?");
                Console.WriteLine("1. Ganado     2. Perdido     3. Empatado");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        ganados++;
                        break;
                    case 2:
                        perdidos++;
                        break;
                    case 3:
                        empatados++;
                        break;
                    default:
                        Console.WriteLine("Número introducido inválido");
                        break;
                }

                i++;
            } while (i <= partidos);

            porGanados = (ganados / partidos) * 100;
            porPerdidos = (perdidos / partidos) * 100;
            porEmpatados = (empatados / partidos) * 100;

            Console.WriteLine($"De los {partidos} partidos, {ganados} se ganaron, {perdidos} se perdieron y {empatados} acabaron en empate");
            Console.WriteLine($"El porcentaje de partidos ganados es {porGanados}%");
            Console.WriteLine($"El porcentaje de partidos perdidos es {porPerdidos}%");
            Console.WriteLine($"El porcentaje de partidos empatados es {porEmpatados}%");
        }
    }
}
