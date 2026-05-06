using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Elige ejercicio (1-4):");
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
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }

    // ---------------- EJERCICIO 1 ----------------
    static void Ejercicio1()
    {
        int[] llistaC = new int[55];
        Random rnd = new Random();

        for (int i = 0; i < 55; i++)
        {
            llistaC[i] = rnd.Next(22, 1560);
        }

        int min = llistaC[0];
        int max = llistaC[0];

        for (int i = 1; i < llistaC.Length; i++)
        {
            if (llistaC[i] < min) // mínimo
            {
                min = llistaC[i];
            }

            if (llistaC[i] > max) // máximo
            {
                max = llistaC[i];
            }
        }

        Console.WriteLine("Mínimo: " + min);
        Console.WriteLine("Máximo: " + max);
    }

    // ---------------- EJERCICIO 2 ----------------
    static void Ejercicio2()
    {
        int[] llistaC = new int[333];
        Random rnd = new Random();

        for (int i = 0; i < 333; i++)
        {
            llistaC[i] = rnd.Next(1, 1000);
        }

        int suma = 0;
        int mult4 = 0;

        for (int i = 0; i < llistaC.Length; i++)
        {
            suma += llistaC[i];

            if (llistaC[i] % 4 == 0) // múltiplos de 4
            {
                mult4++;
            }
        }

        double media = (double)suma / llistaC.Length;

        int mayores = 0;

        for (int i = 0; i < llistaC.Length; i++)
        {
            if (llistaC[i] > media) // mayores que la media
            {
                mayores++;
            }
        }

        Console.WriteLine("Media: " + media);
        Console.WriteLine("Múltiplos de 4: " + mult4);
        Console.WriteLine("Mayores que la media: " + mayores);
    }

    // ---------------- EJERCICIO 3 ----------------
    static void Ejercicio3()
    {
        Console.WriteLine("Introduce una frase:");
        string cop = Console.ReadLine().ToLower();

        int a = 0, e = 0, i = 0, o = 0, u = 0;

        for (int x = 0; x < cop.Length; x++)
        {
            char c = cop[x];

            // comprobar vocal
            if (c == 'a') a++;
            else if (c == 'e') e++;
            else if (c == 'i') i++;
            else if (c == 'o') o++;
            else if (c == 'u') u++;
        }

        Console.WriteLine("a: " + a);
        Console.WriteLine("e: " + e);
        Console.WriteLine("i: " + i);
        Console.WriteLine("o: " + o);
        Console.WriteLine("u: " + u);
    }

    // ---------------- EJERCICIO 4 ----------------
    static void Ejercicio4()
    {
        double saldo = 1000;
        int opcion;

        do
        {
            Console.WriteLine("\n1. Mirar saldo");
            Console.WriteLine("2. Treure diners");
            Console.WriteLine("3. Afegir diners");
            Console.WriteLine("0. Sortir");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    MirarSaldo(saldo);
                    break;
                case 2:
                    saldo = TreureSaldo(saldo);
                    break;
                case 3:
                    saldo = AfegirSaldo(saldo);
                    break;
            }

        } while (opcion != 0);
    }

    // ---- FUNCIONES ----

    static void MirarSaldo(double saldo)
    {
        Console.WriteLine("Saldo actual: " + saldo);
    }

    static double TreureSaldo(double saldo)
    {
        Console.WriteLine("Quant vols retirar?");
        double cantidad = Convert.ToDouble(Console.ReadLine());

        if (cantidad <= saldo)
        {
            saldo -= cantidad;
            Console.WriteLine("Retirada correcta");
        }
        else
        {
            Console.WriteLine("Saldo insuficient");
        }

        return saldo;
    }

    static double AfegirSaldo(double saldo)
    {
        Console.WriteLine("Quant vols afegir?");
        double cantidad = Convert.ToDouble(Console.ReadLine());

        saldo += cantidad;
        Console.WriteLine("Dipòsit correcte");

        return saldo;
    }
}