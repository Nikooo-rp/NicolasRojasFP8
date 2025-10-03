namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Punto 1
            int[,] numeros = new int[10, 20];
            int[] suma = new int[20];

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingresa el valor para la posición {i}, {j}");
                    numeros[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < numeros.GetLength(1); i++)
            {
                for (int j = 0; j < numeros.GetLength(0); j++)
                {
                    suma[i] += numeros[j, i];
                }
            }

            Console.WriteLine("La suma de los valores de cada columna del arreglo es: ");
            for (int i = 0; i < suma.Length; i++)
            {
                Console.Write($"{suma[i]}, ");
            }

            //Punto 2.
            Console.WriteLine("Ingresa el número de filas del arreglo");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el número de columnas del arreglo");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] ints = new int[m, n];
            int[] savedRow = new int[n]; // Una fila tiene n número de posiciones.

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingresa el valor para la posición {i}, {j}");
                    ints[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("El arreglo quedó así: ");
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.Write(ints[i, j] + " | ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < savedRow.Length; i++)
            {
                savedRow[i] = ints[n - 1, i];
            }

            for (int i = 0; i < ints.GetLength(1); i++)
            {
                ints[n - 1, i] = ints[0, i];
                ints[0, i] = savedRow[i];
            }

            Console.WriteLine("El arreglo con la primera y última fila intercambiadas quedaría así: ");
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.Write(ints[i, j] + " | ");
                }
                Console.WriteLine();
            }

            // Punto 3
            Random ran = new Random();
            int[,] randomInts = new int[5, 5];
            int[] frequency = new int[10];

            for (int i = 0; i < randomInts.GetLength(0); i++)
            {
                for (int j = 0; j < randomInts.GetLength(1); j++)
                {
                    randomInts[i, j] = ran.Next(0, 11);
                    switch (randomInts[i, j])
                    {
                        case 1: frequency[0]++; break;
                        case 2: frequency[1]++; break;
                        case 3: frequency[2]++; break;
                        case 4: frequency[3]++; break;
                        case 5: frequency[4]++; break;
                        case 6: frequency[5]++; break;
                        case 7: frequency[6]++; break;
                        case 8: frequency[7]++; break;
                        case 9: frequency[8]++; break;
                        case 10: frequency[9]++; break;
                    }
                }
            }

            for (int i = 0; i < randomInts.GetLength(0); i++)
            {
                for (int j = 0; j < randomInts.GetLength(1); j++)
                {
                    Console.Write(randomInts[i, j] + " | ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"La frecuencia de los números del 1 al 10 en la matriz es, en orden 1-10: ");
            Console.WriteLine();
            for (int i = 0; i < frequency.Length; i++)
            {
                Console.Write($"{i + 1}: {frequency[i]} | ");
            }

            // Punto 4
            Random ranX = new Random();
            char[,] board = new char[5, 5];
            int[,] xCoords = new int[3, 2];
            int[] guess = new int[2];
            int attempts = 3;

            bool foundx1 = false, foundx2 = false, foundx3 = false;

            xCoords[0, 0] = ranX.Next(1, 6);
            xCoords[0, 1] = ranX.Next(1, 6);

            xCoords[1, 0] = ranX.Next(1, 6);
            xCoords[1, 1] = ranX.Next(1, 6);

            xCoords[2, 0] = ranX.Next(1, 6);
            xCoords[2, 1] = ranX.Next(1, 6);

            Console.WriteLine($"{xCoords[0, 0]}, {xCoords[0, 1]}");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = 'O';
                }
            }

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + " | ");
                }
                Console.WriteLine();
            }

            while (attempts > 0)
            {
                Console.WriteLine("Ingresa las coordenadas de un punto de la matriz (1,1 - 5,5)");

                Console.WriteLine("Primero la coordenada x: ");
                guess[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ahora la coordenada y: ");
                guess[1] = Convert.ToInt32(Console.ReadLine());

                if (guess[0] == xCoords[0, 0] && guess[1] == xCoords[0, 1])
                {
                    board[guess[0] - 1, guess[1] - 1] = 'X';
                    for (int i = 0; i < board.GetLength(0); i++)
                    {
                        for (int j = 0; j < board.GetLength(1); j++)
                        {
                            Console.Write(board[i, j] + " | ");
                        }
                        Console.WriteLine();
                    }
                    foundx1 = true;
                }
                else if (guess[0] == xCoords[1, 0] && guess[1] == xCoords[1, 1])
                {
                    board[guess[0] - 1, guess[1] - 1] = 'X';
                    for (int i = 0; i < board.GetLength(0); i++)
                    {
                        for (int j = 0; j < board.GetLength(1); j++)
                        {
                            Console.Write(board[i, j] + " | ");
                        }
                        Console.WriteLine();
                    }
                    foundx2 = true;
                }
                else if (guess[0] == xCoords[2, 0] && guess[1] == xCoords[2, 1])
                {
                    board[guess[0] - 1, guess[1] - 1] = 'X';
                    for (int i = 0; i < board.GetLength(0); i++)
                    {
                        for (int j = 0; j < board.GetLength(1); j++)
                        {
                            Console.Write(board[i, j] + " | ");
                        }
                        Console.WriteLine();
                    }
                    foundx3 = true;
                }
                else
                {
                    for (int i = 0; i < board.GetLength(0); i++)
                    {
                        for (int j = 0; j < board.GetLength(1); j++)
                        {
                            Console.Write(board[i, j] + " | ");
                        }
                        Console.WriteLine();
                    }
                }

                attempts--;
            }

            if (attempts <= 0)
            {
                if (foundx1 && foundx2 && foundx3)
                    Console.WriteLine("Felicidades, encontraste todas las X!");
                else if (foundx1 == false && foundx2 == false && foundx3 == false)
                    Console.WriteLine("Mejor suerte para la próxima");
                else
                    Console.WriteLine("Encontraste algunas, bien hecho!");
            }

            // Punto 5
            Console.WriteLine("Ingresa el número de filas de la matriz");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el número de columnas de la matriz");
            int n1 = Convert.ToInt32(Console.ReadLine());

            int[,] ints1 = new int[m1, n1];

            for (int i = 0; i < ints1.GetLength(0); i++)
            {
                for (int j = 0; j < ints1.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingresa el valor para la posición {i}, {j} de la matriz");
                    ints1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < ints1.GetLength(0); i++)
            {
                for (int j = 0; j < ints1.GetLength(1); j++)
                {
                    Console.Write(ints1[i, j] + " | ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Al intercambiar filas y columnas...");
            for (int i = 0; i < ints1.GetLength(0); i++)
            {
                for (int j = 0; j < ints1.GetLength(1); j++)
                {
                    Console.Write(ints1[j, i] + " | ");
                }
                Console.WriteLine();
            }

            // Punto 6
            Console.WriteLine("Ingresa el número de filas de la matriz");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el número de columnas de la matriz");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int[,] ints2 = new int[m2, n2];
            Random ran1to3 = new Random();

            int uno = 0, dos = 0, tres = 0;

            for (int i = 0; i < ints2.GetLength(0); i++)
            {
                for (int j = 0; j < ints2.GetLength(1); j++)
                {
                    ints2[i, j] = ran1to3.Next(1, 4);
                    switch (ints2[i, j])
                    {
                        case 1: uno++; break;
                        case 2: dos++; break;
                        case 3: tres++; break;
                    }
                }
            }

            for (int i = 0; i < ints2.GetLength(0); i++)
            {
                for (int j = 0; j < ints2.GetLength(1); j++)
                {
                    Console.Write(ints2[j, i] + " | ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("La repetición de los números es:");
            Console.WriteLine($" 1: {uno} | 2: {dos} | 3: {tres}");

            if (uno > dos)
                if (uno > tres)
                    Console.WriteLine("El número más repetido es el 1");
                else
                    Console.WriteLine("El número más repetido es el 3");
            else if (dos > tres)
                Console.WriteLine("El número más repetido es el 2");
            else
                Console.WriteLine("El número más repetido es el 3");
        }
    }
}
