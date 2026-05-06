using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Elige ejercicio (1-5):");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Ejercicio1();
                break;
            case 2:
                Ejercicio2();
                break;
            case 3:
                Ejercicio3();
                break;
            case 4:
                Ejercicio4();
                break;
            case 5:
                Ejercicio5();
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }

    // EJERCICIO 1 (WHILE)
    static void Ejercicio1()
    {
        Console.WriteLine("Introduce un número:");
        int num = Convert.ToInt32(Console.ReadLine());

        int i = 13;
        int suma = 0;

        while (i <= num)
        {
            suma += i;
            i++;
        }

        Console.WriteLine("La suma es: " + suma);
    }

    // EJERCICIO 2
    static void Ejercicio2()
    {
        Console.WriteLine("Introduce un número:");
        int num = Convert.ToInt32(Console.ReadLine());

        int pares = 0, impares = 0;
        int sumaPares = 0, sumaImpares = 0;
        int mult13 = 0;

        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                pares++;
                sumaPares += i;
            }
            else
            {
                impares++;
                sumaImpares += i;
            }

            if (i % 13 == 0)
            {
                mult13++;
            }
        }

        Console.WriteLine("Pares: " + pares);
        Console.WriteLine("Impares: " + impares);
        Console.WriteLine("Suma pares: " + sumaPares);
        Console.WriteLine("Suma impares: " + sumaImpares);
        Console.WriteLine("Múltiplos de 13: " + mult13);
    }

    // EJERCICIO 3 (Piedra, papel o tijera)
    static void Ejercicio3()
    {
        Random rnd = new Random();

        int j1 = rnd.Next(0, 3);
        int j2 = rnd.Next(0, 3);

        string[] opciones = { "Piedra", "Papel", "Tijera" };

        Console.WriteLine("Jugador 1: " + opciones[j1]);
        Console.WriteLine("Jugador 2: " + opciones[j2]);

        if (j1 == j2)
        {
            Console.WriteLine("Empate");
        }
        else if ((j1 == 0 && j2 == 2) ||
                 (j1 == 1 && j2 == 0) ||
                 (j1 == 2 && j2 == 1))
        {
            Console.WriteLine("Gana Jugador 1");
        }
        else
        {
            Console.WriteLine("Gana Jugador 2");
        }
    }

    // EJERCICIO 4 (Cajero automático)
    static void Ejercicio4()
    {
        double saldo = 1000;
        int opcion;

        do
        {
            Console.WriteLine("\n1. Consultar saldo");
            Console.WriteLine("2. Retirar dinero");
            Console.WriteLine("3. Depositar dinero");
            Console.WriteLine("0. Salir");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Saldo actual: " + saldo);
                    break;

                case 2:
                    Console.WriteLine("Cantidad a retirar:");
                    double retirar = Convert.ToDouble(Console.ReadLine());

                    if (retirar <= saldo)
                    {
                        saldo -= retirar;
                        Console.WriteLine("Retirada correcta");
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente");
                    }
                    break;

                case 3:
                    Console.WriteLine("Cantidad a depositar:");
                    double deposito = Convert.ToDouble(Console.ReadLine());

                    saldo += deposito;
                    Console.WriteLine("Depósito realizado");
                    break;
            }

        } while (opcion != 0);
    }

    // EJERCICIO 5 (Alquiler)
    static void Ejercicio5()
    {
        Console.WriteLine("Edad:");
        int edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresos mensuales:");
        double ingresos = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Referencia positiva (si/no):");
        string referencia = Console.ReadLine().ToLower();

        Console.WriteLine("Infracciones graves:");
        int infracciones = Convert.ToInt32(Console.ReadLine());

        if (edad > 21 && edad < 65 &&
            ingresos >= 2500 &&
            referencia == "si" &&
            infracciones <= 1)
        {
            Console.WriteLine("Cliente ACEPTADO");
        }
        else
        {
            Console.WriteLine("Cliente NO aceptado");
        }
    }
}