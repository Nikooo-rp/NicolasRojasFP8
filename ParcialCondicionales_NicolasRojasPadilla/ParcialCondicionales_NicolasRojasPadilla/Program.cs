namespace ParcialCondicionales_NicolasRojasPadilla;

class Program
{
    static void Main(string[] args)
    {
        int edad;
        bool s1, s2, s3, s4, s5; // Para manejar el acceso a cada sala
        string salaElegida; // Sala elegida
        string juego; // Juego elegido
        double precio; // Precio del juego
        bool error; // Variable para manejar errores
        Console.WriteLine("Ingrese su edad:");
        edad = Convert.ToInt32(Console.ReadLine());

        switch (edad) // Determina a qué sala puede acceder según su edad
        {
            case > 1 && <= 5:
                Console.WriteLine("Puede acceder a la sala 1");
                s1 = true;
                break;
            case >= 6 && <= 16:
                Console.WriteLine("Puede acceder a la sala 2");
                s2 = true;
                break
            case >= 17 <= 25:
                Console.WriteLine("Puede acceder a las salas 3 y 4");
                s3 = true;
                s4 = true;
                break;
            case >= 26:
                Console.WriteLine("Puede acceder a la sala 5");
                s5 = true;
                break;
            default:
                Console.WriteLine("No puede acceder a ninguna sala (Verifique que haya ingresado su edad correctamente)");
                error = true;
                break;
        }

        Console.WriteLine("Seleccione la sala a la que desea ingresar (1-5):");
        int sala = Convert.ToInt32(Console.ReadLine());

        switch (sala)
            {
            case 1 && s1:
                salaElegida = "Sala 1";
                Console.WriteLine("Acceso permitido a la sala 1, ¿a qué juego quieres jugar?");
                Console.WriteLine("Juegos disponibles: Juego 1, Juego 5");
                Console.WriteLine("Escriba el número del juego al que desea acceder:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        juego = "Juego 1";
                        precio = 3000;
                        break;
                    case 5:
                        juego = "Juego 5";
                        precio = 7000;
                        break;
                    default:
                        Console.WriteLine("Juego no disponible en esta sala");
                        error = true;
                        break;
                }
            break;

            case 2 && s2:
                salaElegida = "Sala 2";
                Console.WriteLine("Acceso permitido a la sala 2, ¿a qué juego quieres jugar?");
                Console.WriteLine("Juegos disponibles: Juego 3, Juego 6");
                Console.WriteLine("Escriba el número del juego al que desea acceder:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 3:
                        juego = "Juego 3";
                        precio = 7000;
                        break;
                    case 6:
                        juego = "Juego 6";
                        precio = 9000;
                        break;
                    default:
                        Console.WriteLine("Juego no disponible en esta sala");
                        error = true;
                        break;
                }
            break;

            case 3 && s3:
                salaElegida = "Sala 3";
                Console.WriteLine("Acceso permitido a la sala 3, ¿a qué juego quieres jugar?");
                Console.WriteLine("Juegos disponibles: Juego 2, Juego 7");
                Console.WriteLine("Escriba el número del juego al que desea acceder:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 6:
                        juego = "Juego 2";
                        precio = 5000;
                        break;
                    case 7:
                        juego = "Juego 7";
                        precio = 10000;
                        break;
                    default:
                        Console.WriteLine("Juego no disponible en esta sala");
                        error = true;
                        break;
                }
            break;
            case 4 && s4:
                salaElegida = "Sala4";
                Console.WriteLine("Acceso permitido a la sala 4, ¿a qué juego quieres jugar?");
                Console.WriteLine("Juegos disponibles: Juego 4, Juego 8");
                Console.WriteLine("Escriba el número del juego al que desea acceder:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 4:
                        juego = "Juego 4";
                        precio = 9000;
                        break;
                    case 8:
                        juego = "Juego 8";
                        precio = 7000;
                        break;
                }
            break;

            case 5 && s5:
                salaElegida = "Sala 5";
                Console.WriteLine("Acceso permitido a la sala 5, ¿a qué juego quieres jugar?");
                Console.WriteLine("Juegos disponibles: Juego 9, Juego 10");
                Console.WriteLine("Escriba el número del juego al que desea acceder:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 9:
                        juego = "Juego 9";
                        precio = 5000;
                        break;
                    case 10:
                        juego = "Juego 10";
                        precio = 3000;
                        break;
                }
            break;

            default:
                Console.WriteLine("Sala no disponible o no tiene acceso a la sala seleccionada");
                error = true;
                break;
        }

        if (error = true)
        {
            Console.WriteLine("Ha ocurrido un error, por favor verifique que los datos ingresados sean correctos");
        }
        else
        {
            Console.WriteLine($"Usted tiene {edad} años.");
            Console.WriteLine("Sala seleccionada: " + salaElegida);
            Console.WriteLine("Juego seleccionado: " + juego);
            Console.WriteLine($"Precio: ${precio}");
            Console.WriteLine("¡Disfrute su juego!");
        }
    }
}
